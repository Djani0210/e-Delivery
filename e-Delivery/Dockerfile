FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 44395
ENV ASPNETCORE_URLS=http://+:44395

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .



FROM build AS publish
RUN dotnet publish "e-Delivery/e-Delivery.csproj" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
COPY ./e-Delivery/Uploads/Images ./Uploads/Images

ENTRYPOINT ["dotnet", "e-Delivery.dll"]