using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Helper
{
    public class Config
    {
        public static string AplikacijaURL = "https://localhost:7218/";

        public static string Slike => "FoodItem_images/";
        public static string SlikeURL => AplikacijaURL + Slike;
        public static string SlikeBazniFolder = "wwwroot/";
        public static string SlikeFolder => SlikeBazniFolder + Slike;
    }
}
