using System;
using System.Collections.Generic;
using Models.Entities;

namespace Repositories.Data
{
    public static class DataProvider
    {
        private static readonly string _adminName = "RentalAdmin";

        public static List<NewsItem> NewsItem = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Golden Globe Nominee Shawshank Redemption",
                ImgSource = "https://m.media-amazon.com/images/M/MV5BNjQ2NDA3MDcxMF5BMl5BanBnXkFtZTgwMjE5NTU0NzE@._V1_CR0,60,640,360_AL_UX477_CR0,0,477,268_AL_.jpg",
                ShortDescription = "Shawshank Redemptiongot many nominations",
                LongDescription = "Shawsh ",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 2,
                Title = "Golden Globe Award Shawshank Redemption",
                ImgSource = "https://m.media-amazon.com/images/M/MV5BNjQ2NDA3MDcxMF5BMl5BanBnXkFtZTgwMjE5NTU0NzE@._V1_CR0,60,640,360_AL_UX477_CR0,0,477,268_AL_.jpg",
                ShortDescription = "Shawshank Redemption got many awards",
                LongDescription = "Shawshank Redemption got many awards at the Golden Globes",
                PublishDate = DateTime.Now,
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 3,
                Title = "Harry leaves Sally",
                ImgSource = "https://images2.minutemediacdn.com/image/upload/c_crop,h_1171,w_2085,x_27,y_0/f_auto,q_auto,w_1100/v1554991835/shape/mentalfloss/57846-when_harry-mgm.jpg",
                ShortDescription = "Harry has decided to leave Sally",
                LongDescription = "arry has decided to leave Sally. arry has decided to leave Sally. ",
                PublishDate = new DateTime(2012, 12, 31, 16, 45, 0),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 4,
                Title = "Golden Globes Tonight",
                ImgSource = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Golden_Globe_Trophy.jpg/220px-Golden_Globe_Trophy.jpg",
                ShortDescription = "The Golden Globe will be held tonight",
                LongDescription = "The 2007 Golden globe awards will be held tonight for the Xth time.",
                PublishDate = new DateTime(2007, 12, 31, 13, 00, 0),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
                        new NewsItem
            {
                Id = 5,
                Title = "Future Golden Globes",
                ImgSource = "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Golden_Globe_Trophy.jpg/220px-Golden_Globe_Trophy.jpg",
                ShortDescription = "What will they be like",
                LongDescription = "Golden globe  blah blah blah blah blah.",
                PublishDate = new DateTime(2007, 12, 31, 13, 30, 0),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
    };/*
            },
            new Owner
            {
                Id = 2,
                Name = "Hill Haney",
                RentalId = 2
            },
            new Owner
            {
                Id = 3,
                Name = "Stout Craft",
                RentalId = 3
            },
            new Owner
            {
                Id = 4,
                Name = "Shelly Banks",
                RentalId = 4
            },
            new Owner
            {
                Id = 5,
                Name = "Arlene Melendez",
                RentalId = 5
            },
            new Owner
            {
                Id = 6,
                Name = "Estela Rios",
                RentalId = 6
            },
            new Owner
            {
                Id = 7,
                Name = "Mack Mcknight",
                RentalId = 7
            },
            new Owner
            {
                Id = 8,
                Name = "Mamie Shepard",
                RentalId = 8
            }
        };
        public static List<Rental> Rentals = new List<Rental> 
        {
            new Rental
            {
                Id = 1,
                Title = "Great family home in Malibu, LA, California",
                Description = "Great comfortable family home. It has everything you could need. Located in central Malibu next to Pepperdine University and near all the great Malibu beaches. Lots of things to do. Tennis courts within walking distance, great parks for hiking and many great restaurants. It is also a good spot to visit other areas. You cannot but enjoy yourselves.",
                AskingPrice = 2000,
                Available = true,
                Address = "Central Malibu",
                City = "Los Angeles, California",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 2,
                Title = "Cape May beach house NJ USA",
                Description = "Visit historic Cape May by the shore in New Jersey. Private home by the bay, walk to beach ! Perfect for families or couples . Numerous one of a kind attractions, festivals, flea markets, theater, concerts. Home includes: Fenced in yard, deck, patio, fire pit, BBQ, outdoor shower, ping pong, lawn games, movies, music, cable, internet& 1 bicycle. 6 Beach passes included& everything you need for the beach. All in a quiet neighborhood 5 minutes from town. Walk to best restaurant in town & convenience store. 2 Queen beds, 2 twin beds & new queen pull out sofa.",
                AskingPrice = 1500,
                Available = true,
                Address = "Cape May",
                City = "New Jersey, New Jersey",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 3,
                Title = "Well decorated, equipped and bright apartment",
                Description = "Located in a very chic neighborhood called Las Cañitas, beside Palermo. The apartment is very well cared, fully equipped, super comfortable, nicely decorated, very bright, and has a large balcony with a ¨parrilla¨. The building has security 24 hours, gym and pool.",
                AskingPrice = 600,
                Available = false,
                Address = "Palermo",
                City = "Buenos Aires, Argentina",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 4,
                Title = "Beautiful coastal villa",
                Description = "On the stunning Otago Peninsula - an area of outstanding natural beauty with penguins, seals and amazing native birdlife - Pudding island is walkable at low tide from the house to enjoy the bird sanctuary and explore its coast",
                AskingPrice = 1200,
                Available = true,
                Address = "Portobello, Dunedin",
                City = "Otago, New Zealand",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 5,
                Title = "Best view in Copenhagen",
                Description = "Our appartient probably has the best view of the lakes and the city of Copenhagen. It's right in the middle of everything, and restaurants and theaters are right at the doorstep. The appartient is at the 5th floor (no elevator)and you will enjoy 175 squaremeters luxury and your own roof terrace. There are two bedrooms, 2 large livingrooms and a new moderniced kitchen with everything you need. Also a new bathroom and a small second toilet. We are open to swaps globally and in general flexible could be both points or snaps (dosen't have to be direct). Get in contact and let's discuss the possibilities",
                AskingPrice = 950,
                Available = true,
                Address = "Copenhagen N",
                City = "Copenhagen, Denmark",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 6,
                Title = "Sunrise",
                Description = "Penthouse gifted with unrivalled waterfront views from the living room & master bedroom window - Sunrise really lives up to its name. The large balcony is the perfect place to take in the views, including gorgeous sunrises and sunsets, and really make the most of the Mediterranean climate.",
                AskingPrice = 1300,
                Available = true,
                Address = "Avenue de la California",
                City = "Nice, France",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 7,
                Title = "Diano Castello, Liguria, Italia",
                Description = "Our summer apartment is located on a little quite hill in the italian Riviera and features 2 bedrooms 1 bathroom 1 livingroom and 1 terrace. Not so large (65mq), is located at 800m far the seaside, 40 km from Sanremo, 90 km from Nice airport. Under house you can find a market and a farmacy, at 300m a swimming pool and train station. For a family or group max 5 sleeps. 15 minutes from the city center in tourist area. In the nearby you can find many activities to do like relaxing in many sea villages counting on more then 300km of coast, visiting the countryside rich of history, practicing diving sailing and many other sport, visiting the largest aquarium in Europe (Genova).",
                AskingPrice = 1190,
                Available = false,
                Address = "Strada Provinciale 36",
                City = "Diano Castello, Liguria, Italia",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            },
            new Rental
            {
                Id = 8,
                Title = "Cosy apartment in a quiet area",
                Description = "A small apartment in a block of flats (5th floor/lift), next to a tiny river, in the southern part of Kraków. It's a quiet area, thus a perfect place to sleep well after a tiring day of sightseeing. Only 3-4 km from the main city's attractions: the historic old town, the Wawel Castle and the Jewish district, Kazimierz. Very good public transport to the city center (10-15min, tram/bus-stops 2 minutes away. If u run it's about 15 sec.). All necessary shops & a few restaurants, nearby, within walking distance. BAKERY on the ground floor of the block.",
                AskingPrice = 400,
                Available = true,
                Address = "Jana Brozka 10",
                City = "Krakow, Poland",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                ModifiedBy = _adminName
            }
        };*/
    }
}