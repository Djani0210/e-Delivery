using e_Delivery.Entities;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultFoodItemPicturesData
    {
        public static IEnumerable<FoodItemPictures> FoodItemPictures
        {
            get => new List<FoodItemPictures>()
        {
            new FoodItemPictures
            {
                Id = 1,
                FileName = "https://localhost:44395/FoodItem_images/hamburger.jpg",
                FileSize = 135168,
                FoodItemId = 1
            },
            new FoodItemPictures
            {
                Id = 2,
                FileName = "https://localhost:44395/FoodItem_images/cheeseburger.jpg",
                FileSize = 57306,
                FoodItemId = 2
            },
            new FoodItemPictures
            {
                Id = 3,
                FileName = "https://localhost:44395/FoodItem_images/margarita.jpg",
                FileSize = 85319,
                FoodItemId = 3
            },
            new FoodItemPictures
            {
                Id = 4,
                FileName = "https://localhost:44395/FoodItem_images/capricoza.jpg",
                FileSize = 69759,
                FoodItemId = 4
            },
            new FoodItemPictures
            {
                Id = 5,
                FileName = "https://localhost:44395/FoodItem_images/funghi.jpg",
                FileSize = 308224,
                FoodItemId = 5
            },
            new FoodItemPictures
            {
                Id = 6,
                FileName = "https://localhost:44395/FoodItem_images/fileti.jpg",
                FileSize = 59801,
                FoodItemId = 6
            },
            new FoodItemPictures
            {
                Id = 7,
                FileName = "https://localhost:44395/FoodItem_images/sausage.jpg",
                FileSize = 10547,
                FoodItemId = 7
            },
            new FoodItemPictures
            {
                Id = 8,
                FileName = "https://localhost:44395/FoodItem_images/sendvicklasik.jpg",
                FileSize = 197632,
                FoodItemId = 8
            },
             new FoodItemPictures
            {
                Id = 9,
                FileName = "https://localhost:44395/FoodItem_images/chickensendvic.jpg",
                FileSize = 238592,
                FoodItemId = 9
            },
            new FoodItemPictures
            {
                Id = 10,
                FileName = "https://localhost:44395/FoodItem_images/pepperoni.jpg",
                FileSize = 52838,
                FoodItemId = 10
            },
            new FoodItemPictures
            {
                Id = 11,
                FileName = "https://localhost:44395/FoodItem_images/sacher.jpg",
                FileSize = 147456,
                FoodItemId = 11
            },
            new FoodItemPictures
            {
                Id = 12,
                FileName = "https://localhost:44395/FoodItem_images/baklava.jpg",
                FileSize = 64307,
                FoodItemId = 12
            },
            new FoodItemPictures
            {
                Id = 13,
                FileName = "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg",
                FileSize = 103424,
                FoodItemId = 13
            },
            new FoodItemPictures
            {
                Id = 14,
                FileName = "https://localhost:44395/FoodItem_images/dzempalacinke.jpg",
                FileSize = 11366,
                FoodItemId = 14
            },
            new FoodItemPictures
            {
                Id = 15,
                FileName = "https://localhost:44395/FoodItem_images/margarita.jpg",
                FileSize = 85319,
                FoodItemId = 15
            },
            new FoodItemPictures
            {
                Id = 16,
                FileName = "https://localhost:44395/FoodItem_images/capricoza.jpg",
                FileSize = 69759,
                FoodItemId = 16
            },
            new FoodItemPictures
            {
                Id = 17,
                FileName = "https://localhost:44395/FoodItem_images/funghi.jpg",
                FileSize = 308224,
                FoodItemId = 17
            },
            new FoodItemPictures
            {
                Id = 18,
                FileName = "https://localhost:44395/FoodItem_images/pepperonipizza.jpg",
                FileSize = 278528,
                FoodItemId = 18
            },
            new FoodItemPictures
            {
                Id = 19,
                FileName = "https://localhost:44395/FoodItem_images/fileti.jpg",
                FileSize = 59801,
                FoodItemId = 19
            },
            new FoodItemPictures
            {
                Id = 20,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 20
            },
            new FoodItemPictures
            {
                Id = 21,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 21
            },
            new FoodItemPictures
            {
                Id = 22,
                FileName = "https://localhost:44395/FoodItem_images/greeksalad.jpg",
                FileSize = 212992,
                FoodItemId = 22
            },
            new FoodItemPictures
            {
                Id = 23,
                FileName = "https://localhost:44395/FoodItem_images/tomatosalad.jpg",
                FileSize = 320512,
                FoodItemId = 23
            },
            new FoodItemPictures
            {
                Id = 24,
                FileName = "https://localhost:44395/FoodItem_images/regularsalad.jpg",
                FileSize = 253952,
                FoodItemId = 24
            },
             new FoodItemPictures
            {
                Id = 25,
                FileName = "https://localhost:44395/FoodItem_images/sendvicklasik.jpg",
                FileSize = 197632,
                FoodItemId = 25
            },
            new FoodItemPictures
            {
                Id = 26,
                FileName = "https://localhost:44395/FoodItem_images/chickensendvic.jpg",
                FileSize = 238592,
                FoodItemId = 26
            },
            new FoodItemPictures
            {
                Id = 27,
                FileName = "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg",
                FileSize = 103424,
                FoodItemId = 27
            },
            new FoodItemPictures
            {
                Id = 28,
                FileName = "https://localhost:44395/FoodItem_images/friedsquid.jpg",
                FileSize = 354304,
                FoodItemId = 28
            },
            new FoodItemPictures
            {
                Id = 29,
                FileName = "https://localhost:44395/FoodItem_images/friedsquid.jpg",
                FileSize = 354304,
                FoodItemId = 29
            },
            new FoodItemPictures
            {
                Id = 30,
                FileName = "https://localhost:44395/FoodItem_images/pastrmka.jpg",
                FileSize = 11572,
                FoodItemId = 30
            },
            new FoodItemPictures
            {
                Id = 31,
                FileName = "https://localhost:44395/FoodItem_images/pastrmka.jpg",
                FileSize = 11572,
                FoodItemId = 31
            },
            new FoodItemPictures
            {
                Id = 32,
                FileName = "https://localhost:44395/FoodItem_images/beefsteak.jpg",
                FileSize = 138240,
                FoodItemId = 32
            },
            new FoodItemPictures
            {
                Id = 33,
                FileName = "https://localhost:44395/FoodItem_images/chickenskewers.jpg",
                FileSize = 149504,
                FoodItemId = 33
            },
            new FoodItemPictures
            {
                Id = 34,
                FileName = "https://localhost:44395/FoodItem_images/chickenskewers.jpg",
                FileSize = 149504,
                FoodItemId = 34
            },
            new FoodItemPictures
            {
                Id = 35,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 35
            },
            new FoodItemPictures
            {
                Id = 36,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 36
            },
            new FoodItemPictures
            {
                Id = 37,
                FileName = "https://localhost:44395/FoodItem_images/regularsalad.jpg",
                FileSize = 253952,
                FoodItemId = 37
            },
            new FoodItemPictures
            {
                Id = 38,
                FileName = "https://localhost:44395/FoodItem_images/tomatosalad.jpg",
                FileSize = 320512,
                FoodItemId = 38
            },
            new FoodItemPictures
            {
                Id = 39,
                FileName = "https://localhost:44395/FoodItem_images/greeksalad.jpg",
                FileSize = 212992,
                FoodItemId = 39
            },
            new FoodItemPictures
            {
                Id = 40,
                FileName = "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg",
                FileSize = 103424,
                FoodItemId = 40
            },
             new FoodItemPictures
            {
                Id = 41,
                FileName = "https://localhost:44395/FoodItem_images/baklava.jpg",
                FileSize = 64307,
                FoodItemId = 41
            },
            new FoodItemPictures
            {
                Id = 42,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 42
            },
            new FoodItemPictures
            {
                Id = 43,
                FileName = "https://localhost:44395/FoodItem_images/cevapi.jpg",
                FileSize = 7469,
                FoodItemId = 43
            },
            new FoodItemPictures
            {
                Id = 44,
                FileName = "https://localhost:44395/FoodItem_images/fileti.jpg",
                FileSize = 59801,
                FoodItemId = 44
            },
            new FoodItemPictures
            {
                Id = 45,
                FileName = "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg",
                FileSize = 103424,
                FoodItemId = 45
            },
            new FoodItemPictures
            {
                Id = 46,
                FileName = "https://localhost:44395/FoodItem_images/baklava.jpg",
                FileSize = 64307,
                FoodItemId = 46
            },
            new FoodItemPictures
            {
                Id = 47,
                FileName = "https://localhost:44395/FoodItem_images/dolma.jpg",
                FileSize = 115712,
                FoodItemId = 47
            },
            new FoodItemPictures
            {
                Id = 48,
                FileName = "https://localhost:44395/FoodItem_images/japrak.jpg",
                FileSize = 83251,
                FoodItemId = 48
            },
            new FoodItemPictures
            {
                Id = 49,
                FileName = "https://localhost:44395/FoodItem_images/bibermeso.jpg",
                FileSize = 9011,
                FoodItemId = 49
            },
            new FoodItemPictures
            {
                Id = 50,
                FileName = "https://localhost:44395/FoodItem_images/bosanskilonac.jpg",
                FileSize = 224256,
                FoodItemId = 50
            },
            new FoodItemPictures
            {
                Id = 51,
                FileName = "https://localhost:44395/FoodItem_images/hamburger.jpg",
                FileSize = 135168,
                FoodItemId = 51
            },
            new FoodItemPictures
            {
                Id = 52,
                FileName = "https://localhost:44395/FoodItem_images/cheeseburger.jpg",
                FileSize = 57306,
                FoodItemId = 52
            },
            new FoodItemPictures
            {
                Id = 53,
                FileName = "https://localhost:44395/FoodItem_images/margarita.jpg",
                FileSize = 85319,
                FoodItemId = 53
            },
            new FoodItemPictures
            {
                Id = 54,
                FileName = "https://localhost:44395/FoodItem_images/capricoza.jpg",
                FileSize = 69759,
                FoodItemId = 54
            },
            new FoodItemPictures
            {
                Id = 55,
                FileName = "https://localhost:44395/FoodItem_images/greeksalad.jpg",
                FileSize = 212992,
                FoodItemId = 55
            },
            new FoodItemPictures
            {
                Id = 56,
                FileName = "https://localhost:44395/FoodItem_images/fileti.jpg",
                FileSize = 59801,
                FoodItemId = 56
            },
             new FoodItemPictures
            {
                Id = 57,
                FileName = "https://localhost:44395/FoodItem_images/sendvicklasik.jpg",
                FileSize = 197632,
                FoodItemId = 57
            },
            new FoodItemPictures
            {
                Id = 58,
                FileName = "https://localhost:44395/FoodItem_images/chickensendvic.jpg",
                FileSize = 238592,
                FoodItemId = 58
            },
            new FoodItemPictures
            {
                Id = 59,
                FileName = "https://localhost:44395/FoodItem_images/baklava.jpg",
                FileSize = 64307,
                FoodItemId = 59
            },
            new FoodItemPictures
            {
                Id = 60,
                FileName = "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg",
                FileSize = 103424,
                FoodItemId = 60
            },
            new FoodItemPictures
            {
                Id = 61,
                FileName = "https://localhost:44395/FoodItem_images/dzempalacinke.jpg",
                FileSize = 11366,
                FoodItemId = 61
            },
            new FoodItemPictures
            {
                Id = 62,
                FileName = "https://localhost:44395/FoodItem_images/margarita.jpg",
                FileSize = 85319,
                FoodItemId = 62
            },
            new FoodItemPictures
            {
                Id = 63,
                FileName = "https://localhost:44395/FoodItem_images/capricoza.jpg",
                FileSize = 69759,
                FoodItemId = 63
            },
            new FoodItemPictures
            {
                Id = 64,
                FileName = "https://localhost:44395/FoodItem_images/carbonara.jpg",
                FileSize = 129024,
                FoodItemId = 64
            },
             new FoodItemPictures
            {
                Id = 65,
                FileName = "https://localhost:44395/FoodItem_images/bolognese.jpg",
                FileSize = 70144,
                FoodItemId = 65
            },
            new FoodItemPictures
            {
                Id = 66,
                FileName = "https://localhost:44395/FoodItem_images/pesto.jpg",
                FileSize = 53760,
                FoodItemId = 66
            },
            new FoodItemPictures
            {
                Id = 67,
                FileName = "https://localhost:44395/FoodItem_images/lasagne.jpg",
                FileSize = 62976,
                FoodItemId = 67
            },
            new FoodItemPictures
            {
                Id = 68,
                FileName = "https://localhost:44395/FoodItem_images/baklava.jpg",
                FileSize = 64307,
                FoodItemId = 68
            },
            new FoodItemPictures
            {
                Id = 69,
                FileName = "https://localhost:44395/FoodItem_images/dzempalacinke.jpg",
                FileSize = 11366,
                FoodItemId = 69
            },
        };
        }
    }

}
