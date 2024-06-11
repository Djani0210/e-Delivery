using e_Delivery;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Services.CreateRoles;
using e_Delivery.Services.Helper;

using e_Delivery.Services.Hubs;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.JwtConfiguration;
using e_Delivery.Services.Services;
using EasyNetQ;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Stripe;
using System.Text;
using System.Text.Json;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Token",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
builder.Services.AddSwaggerGen(c => c.MapType<TimeSpan?>(() => new OpenApiSchema { Type = "string", Example = new OpenApiString("00:00:00") }));

var jwtConfig = builder.Configuration.GetSection("Jwt").Get<JwtConfiguration>();
builder.Services.AddSingleton(jwtConfig);


builder.Services.AddSignalR(opt =>
{
    opt.EnableDetailedErrors = true;
}).AddMessagePackProtocol();

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequiredLength = 4;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<eDeliveryDBContext>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = jwtConfig.Issuer,
                        ValidAudience = jwtConfig.Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Secret)),
                        ClockSkew = TimeSpan.Zero
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnMessageReceived = context =>
                        {
                            var accessToken = context.Request.Query["access_token"];
                            if (!string.IsNullOrEmpty(accessToken))
                            {
                                context.Token = accessToken;
                            }
                            return Task.CompletedTask;
                        }
                    };
                }

                ) ;

builder.Services.AddLogging();
builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAuthContext, AuthContextService>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IFileService, e_Delivery.Services.Services.FileService>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<IFoodItemPicturesService, FoodItemPicturesService>();
builder.Services.AddTransient<ISideDishService, SideDishService>();
builder.Services.AddTransient<IFoodItemService, FoodItemService>();
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IReviewService, e_Delivery.Services.Services.ReviewService>();
builder.Services.AddTransient<IOrderReportService, OrderReportService>();
builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddTransient<IChatService, ChatService>();
builder.Services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();


builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});


builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                })
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase)
                .AddFluentValidation();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<eDeliveryDBContext>(options =>
options.UseSqlServer(connectionString).EnableSensitiveDataLogging(), ServiceLifetime.Scoped);



builder.Services.AddSingleton(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var rabbitMqSettings = new RabbitMqSettings
    {
        HostName = configuration["RABBITMQ_HOST"],
        Port = int.Parse(configuration["RABBITMQ_PORT"] ?? "5672"),
        UserName = configuration["RABBITMQ_USERNAME"],
        Password = configuration["RABBITMQ_PASSWORD"],
        VirtualHost = configuration["RABBITMQ_VIRTUALHOST"] ?? "/"
    };

    if (rabbitMqSettings == null)
    {
        throw new InvalidOperationException("RabbitMQ settings are missing in the configuration.");
    }

    return RabbitHutch.CreateBus($"host={rabbitMqSettings.HostName};port={rabbitMqSettings.Port};username={rabbitMqSettings.UserName};password={rabbitMqSettings.Password}");
});




var app = builder.Build();

app.UseCors(builder => builder
    .WithOrigins("http://10.0.2.2", "https://10.0.2.2")
    .AllowAnyMethod()
    .AllowAnyHeader());


app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                           Path.Combine(Directory.GetCurrentDirectory(), "Uploads/Images")),
    RequestPath = "/Uploads/Images"
});

app.UseDirectoryBrowser(new DirectoryBrowserOptions
{
    FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "Uploads/Images")),
    RequestPath = "/Uploads/Images"
});


app.UseHttpsRedirection();

app.UseAuthentication();


app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<MyHub>("/toastr");
    endpoints.MapHub<ChatHub>("/chathub");
    endpoints.MapControllers();
});

app.MapControllers();
#region EnsureData

Task.Run(() =>
{
    IServiceProvider provider = app.Services
        .GetService<IServiceScopeFactory>()!
        .CreateScope()
        .ServiceProvider;


    eDeliveryDBContext context = provider.GetService<eDeliveryDBContext>()!;
    context.Database.Migrate();
})
    .Wait();

//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = (RoleManager<Role>)scope.ServiceProvider.GetService(typeof(RoleManager<Role>));
//    CreateRolesHelper.CreateRoles(roleManager).Wait();
//}


#endregion
app.Run();
