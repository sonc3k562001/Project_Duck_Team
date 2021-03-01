using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            JwelleryContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<JwelleryContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


            if (!context.Color.Any())
            {
                context.Color.AddRange(
                      new Color
                      {
                          ColorId = "Gold",
                          Name = "Gold",
                      },

                    new Color
                    {
                        ColorId = "White",
                        Name = "White",
                    },
                      new Color
                      {
                          ColorId = "Rose",
                          Name = "Rose",
                      },
                      new Color
                      {
                          ColorId = "Black",
                          Name = "Black",
                      },
                      new Color
                      {
                          ColorId = "Blue",
                          Name = "Blue",
                      },
                      new Color
                      {
                          ColorId = "Green",
                          Name = "Green",
                      },
                      new Color
                      {
                          ColorId = "Grey",
                          Name = "Grey",
                      },
                      new Color
                      {
                          ColorId = "Pink",
                          Name = "Pink",
                      },
                      new Color
                      {
                          ColorId = "Red",
                          Name = "Red",
                      },
                      new Color
                      {
                          ColorId = "Silver",
                          Name = "Silver",
                      },
                      new Color
                      {
                          ColorId = "Multi",
                          Name = "Multi",
                      },
                      new Color
                      {
                          ColorId = "Yellow",
                          Name = "Yellow",
                      }
                );
                context.SaveChanges();
            }
            if (!context.Category.Any())
            {
                context.Category.AddRange(
                      new Category
                      {
                          IdCategory = "Lockets",
                          TypeName = "Lockets",
                      },
                      new Category
                      {
                          IdCategory = "Bracelets",
                          TypeName = "Bracelets",
                      },
                      new Category
                      {
                          IdCategory = "Necklaces",
                          TypeName = "Necklaces",
                      },
                      new Category
                      {
                          IdCategory = "Earrings",
                          TypeName = "Earrings",
                      },
                      new Category
                      {
                          IdCategory = "Rings",
                          TypeName = "Rings",
                      }
                );
                context.SaveChanges();
            }
            if (!context.Brand.Any())
            {
                context.Brand.AddRange(
                      new Brand
                      {
                          BrandId = "AstleyClarke",
                          BrandName = "AstleyClarke",
                      }
                );
                context.SaveChanges();
            }
            if (!context.Dim.Any())
            {
                context.Dim.AddRange(
                      new Dim
                      {
                          DimId = "Diamond",
                          Name = "White Diamond",
                          DimSize = 2,
                          DimAmt = 10,
                          DimCrt = 14,
                          DimGm = 6,
                          DimPcs = 12,
                          DimRate = 4,
                          Certify = "GIA, AGS, IGI, EGL, GSI, and HRD",
                      },
                      new Dim
                      {
                          DimId = "BlackDiamond",
                          Name = "Black Diamond",
                          DimSize = 4,
                          DimAmt = 23,
                          DimCrt = 18,
                          DimGm = 8,
                          DimPcs = 11,
                          DimRate = 20,
                          Certify = "GIA, AGS, IGI, EGL, GSI, and HRD",
                      }
                );
                context.SaveChanges();
            }
            if (!context.Stone.Any())
            {
                context.Stone.AddRange(
                      new Stone
                      {
                          StoneId = "Diamond",
                          Name = "Diamond",
                          Description = "15 Carat White Diamond",
                          Price = 154,
                          StoneAmt = 13,
                          StoneCrt = 15,
                          StoneGm = 8,
                          StoneRate = 12,
                      },
                      new Stone
                      {
                          StoneId = "CulWhiteSapphireSpinel",
                          Name = "Cultured White Sapphire, Spinel",
                          Description = "10 Carat Cultured White Sapphire, Spinel",
                          Price = 45,
                          StoneAmt = 6,
                          StoneCrt = 10,
                          StoneGm = 9,
                          StoneRate = 7,
                      },
                      new Stone
                      {
                          StoneId = "CulWhiteSapphireEnamel",
                          Name = "Cultured White Sapphire, Enamel",
                          Description = "14 Carat Gold Plated Sterling Silver",
                          Price = 52,
                          StoneAmt = 9,
                          StoneCrt = 14,
                          StoneGm = 3,
                          StoneRate = 16,
                      },
                      new Stone
                      {
                          StoneId = "LapisLazuli",
                          Name = "Lapis Lazuli",
                          Description = "11 Carat Lapis Lazuli",
                          Price = 44,
                          StoneAmt = 8,
                          StoneCrt = 11,
                          StoneGm = 5,
                          StoneRate = 7,
                      },
                      new Stone
                      {
                          StoneId = "Emerald",
                          Name = "Emerald",
                          Description = "18 Carat Emerald",
                          Price = 37,
                          StoneAmt = 23,
                          StoneCrt = 18,
                          StoneGm = 6,
                          StoneRate = 21,
                      },
                      new Stone
                      {
                          StoneId = "RainbowMoonstone",
                          Name = "Rainbow Moonstone",
                          Description = "23 Carat  Rainbow Moonstone",
                          Price = 74,
                          StoneAmt = 34,
                          StoneCrt = 23,
                          StoneGm = 3,
                          StoneRate = 13,
                      },
                      new Stone
                      {
                          StoneId = "Pearl",
                          Name = "Pearl",
                          Description = "22 Carat Pearl",
                          Price = 37,
                          StoneAmt = 12,
                          StoneCrt = 22,
                          StoneGm = 15,
                          StoneRate = 23,
                      },
                      new Stone
                      {
                          StoneId = "Agate",
                          Name = "Agate",
                          Description = "17 Carat Agate",
                          Price = 52,
                          StoneAmt = 15,
                          StoneCrt = 17,
                          StoneGm = 8,
                          StoneRate = 14,
                      }
                );
                context.SaveChanges();
            }
            if (!context.Metal.Any())
            {
                context.Metal.AddRange(
                      new Metal
                      {
                          MetalId = "YellowGold",
                          Name = "Yellow Gold (Solid, 100% Recycled)",
                          MetalCrt = "14 carat Gold",
                      },
                      new Metal
                      {
                          MetalId = "YellowGoldVermeil",
                          Name = "Yellow Gold (Vermeil)",
                          MetalCrt = "14 carat Gold",
                      },

                    new Metal
                    {
                        MetalId = "WhiteGold",
                        Name = "White Gold (Solid, 100% Recycled)",
                        MetalCrt = "14 carat Gold",
                    },
                      new Metal
                      {
                          MetalId = "RoseGold",
                          Name = "Rose Gold (Solid, 100% Recycled)",
                          MetalCrt = "14 carat Gold",
                      },
                      new Metal
                      {
                          MetalId = "RoseGoldVermeil",
                          Name = "Rose Gold (Vermeil)",
                          MetalCrt = "14 carat Gold",
                      },
                      new Metal
                      {
                          MetalId = "SterlingSilver",
                          Name = "Sterling Silver",
                          MetalCrt = "14 carat Silver",
                      },
                      new Metal
                      {
                          MetalId = "YellowGoldSolid",
                          Name = "Yellow Gold Solid",
                          MetalCrt = "14 carat Silver",
                      }
                );
                context.SaveChanges();
            }
            if (!context.Category.Any())
            {
                context.Category.AddRange(
                     new Category
                     {
                         IdCategory = "Earrings",
                         TypeName = "Earrings,"
                     },
                     new Category
                     {
                         IdCategory = "Rings",
                         TypeName = "Rings,"
                     },
                     new Category
                     {
                         IdCategory = "Necklaces",
                         TypeName = "Necklaces,"
                     },
                     new Category
                     {
                         IdCategory = "Lockets",
                         TypeName = "Lockets,"
                     },
                     new Category
                     {
                         IdCategory = "Bracelets",
                         TypeName = "Bracelets,"
                     }



                );
                context.SaveChanges();
            }
            if (!context.Role.Any())
            {
                context.Role.AddRange(
                     new Role
                     {
                         IdRole= "1",
                         StringRole = "SuperAdmin"
                     },
                     new Role
                     {
                         IdRole = "2",
                         StringRole = "Admin"
                     },
                     new Role
                     {
                         IdRole = "3",
                         StringRole = "Employee"
                     },
                     new Role
                     {
                         IdRole = "4",
                         StringRole = "Customer"
                     }
                );
                context.SaveChanges();
            }
            if (!context.User.Any())
            {
                context.User.AddRange(
                     new User
                     {
                         Email = "sonngth1908031@fpt.edu.vn",
                         Fname = "Nguyễn",
                         Lname = "Giang Sơn",
                         Bdate = "2001-07-25",
                         Gender = "Man",
                         Address = "8A Tôn Thất Thuyết, Mĩ Đình ,Cầu Giấy,Hà Nội",
                         Phone = "0966803014",
                         Avatar = "Mai_Avatar.jpg",
                         Password = "$2a$04$QDNudgI.yeBrc85Kz2RoQOYGasoKfLfMY6I/0Rn1rFD9h6a0yd/xK",
                         ConfirmPassword = "$2a$04$QDNudgI.yeBrc85Kz2RoQOYGasoKfLfMY6I/0Rn1rFD9h6a0yd/xK",
                         ZipCode = "VN",
                         Eable = true,
                         IdRole = "1"
                     }, new User
                     {
                         Email = "son10c3k56@gmail.com",
                         Fname = "Nguyễn",
                         Lname = "Giang Sơn",
                         Bdate = "2001-07-25",
                         Gender = "Man",
                         Address = "8A Tôn Thất Thuyết, Mĩ Đình ,Cầu Giấy,Hà Nội",
                         Phone = "0966803014",
                         Avatar = "Mai_Avatar.jpg",
                         Password = "$2a$04$QDNudgI.yeBrc85Kz2RoQOYGasoKfLfMY6I/0Rn1rFD9h6a0yd/xK",
                         ConfirmPassword = "$2a$04$QDNudgI.yeBrc85Kz2RoQOYGasoKfLfMY6I/0Rn1rFD9h6a0yd/xK",
                         ZipCode = "VN",
                         Eable = true,
                         IdRole = "4"
                     }
                );
                context.SaveChanges();
            }
            if (!context.Product.Any())
            {
                context.Product.AddRange(
                    new Product
                      {
                          PdId = "45058YNON",
                          Name = "Large Icon Diamond Gold Locket Necklace",
                          Price = 3985,
                          Description = "This large Icon locket is an engravable photo locket with a difference. Featuring gloriously encrusted circles of light grey diamonds pavé set in a 14 carat gold disc, the gold locket makes every day an occasion and can be personalised for free with an engraving and photograph. The engravable statement gold locket has a hinge opening to allow for a photograph or keepsake to be stored inside. Our engravable photo lockets are the perfect jewellery gifts, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable chain with three alternate lengths" +
                                            "Solid 14 carat gold, encrusted with diamonds" +
                                            "Produced using 100 % recycled gold" +
                                            "All of our diamonds are natural, conflict - free and ethically sourced",
                          Image = "/Images/Lockets/45058YNON.jpg",
                          Size = "16 - 18",
                          ColorId = "Gold",
                          IdCategory = "Lockets",
                          BrandId = "AstleyClarke",
                          DimId = "Diamond",
                          StoneId = "Diamond",
                          MetalId = "YellowGold",
                      },

            new Product
            {
                PdId = "45058WNON",
                Name = "Large Icon Diamond White Gold Locket Necklace",
                Price = 3985,
                Description = "This large Icon locket is an engravable photo locket with a difference. Featuring gloriously encrusted circles of light grey diamonds pavé set in a 14 carat white gold disc, the white gold locket makes every day an occasion and can be personalised for free with an engraving and photograph. The engravable statement white gold locket has a hinge opening to allow for a photograph or keepsake to be stored inside. Our engravable photo lockets are the perfect jewellery gifts, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable chain with three alternate lengths" +
                                            "Solid 14 carat white gold, encrusted with diamonds" +
                                            "Produced using 100% recycled gold" +
                                            "All of our diamonds are natural, conflict-free and ethically sourced",
                Image = "/Images/Lockets/45058WNON.jpg",
                Size = "16 - 18",
                ColorId = "White",
                IdCategory = "Lockets",
                BrandId = "AstleyClarke",
                DimId = "Diamond",
                StoneId = "Diamond",
                MetalId = "WhiteGold",
            },

            new Product
            {
                PdId = "45058RNON",
                Name = "Large Icon Diamond Rose Gold Locket Necklace",
                Price = 3985,
                Description = "This large Icon locket is an engravable photo locket with a difference. Featuring gloriously encrusted circles of light grey diamonds pavé set in a 14 carat rose gold disc, the rose gold locket makes every day an occasion and can be personalised for free with an engraving and photograph. The engravable statement rose gold locket has a hinge opening to allow for a photograph or keepsake to be stored inside. Our engravable photo lockets are the perfect jewellery gifts, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable chain with three alternate lengths" +
                                            "Solid 14 carat rose gold, encrusted with diamonds" +
                                            "Produced using 100% recycled gold" +
                                            "All of our diamonds are natural, conflict-free and ethically sourced",
                Image = "/Images/Lockets/45058RNON.jpg",
                Size = "16 - 18",
                ColorId = "Rose",
                IdCategory = "Lockets",
                BrandId = "AstleyClarke",
                DimId = "Diamond",
                StoneId = "Diamond",
                MetalId = "RoseGold",
            },

              new Product
              {
                  PdId = "45054RBKN",
                  Name = "Icon Black Diamond Rose Gold Locket Necklace",
                  Price = 2000,
                  Description = "This Icon locket is an engravable photo locket with a difference. Featuring gloriously encrusted circles of black diamonds pavé set in a 14 carat rose gold disc, the rose gold locket makes every day an occasion and can be personalised for free with an engraving and photograph. The engravable statement rose gold locket has a hinge opening to allow for a photograph or keepsake to be stored inside. Our engravable photo lockets are the perfect jewellery gifts, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable chain with three alternate lengths" +
                                            "Solid 14 carat rose gold, encrusted with black diamonds" +
                                            "Produced using 100% recycled gold" +
                                            "All of our diamonds are natural, conflict-free and ethically sourced",
                  Image = "/Images/Lockets/45054RBKN.jpg",
                  Size = "16 - 18",
                  ColorId = "Black",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "BlackDiamond",
                  StoneId = "Diamond",
                  MetalId = "RoseGold",
              },

              new Product
              {
                  PdId = "46048YGEN",
                  Name = "Celestial Green Enamel Constellation Locket Necklace",
                  Price = 300,
                  Description = "This photo locket necklace features a constellation motif inspired by the night sky. The three stars are set with white sapphires and embellished with enamel in a bold green tone, in a unique octagonal silhouette. This gold personalised necklace is perfect for layering and evokes the feeling of plotting a course with a little help from the stars. This statement locket has a hinge opening to allow for a photograph or keepsake to be stored inside - simply upload a cherished image and we'll take care of the rest. Our photo lockets are the perfect jewellery gifts, available with free personalisation." +
                                            "Upload an image and we will print and fit it into the locket for FREE" +
                                            "Adjustable chain with three alternate lengths" +
                                            "18 carat gold-plated sterling silver, finished with white sapphires" +
                                            "Embellished with enamel in a bold green tone",
                  Image = "/Images/Lockets/46048YGEN.jpg",
                  Size = "16 - 18",
                  ColorId = "Green",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireEnamel",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "39094YBEN",
                  Name = "Lapis Slice Stilla Locket Necklace",
                  Price = 400,
                  Description = "This gold locket necklace features a slice of dark blue Lapis Lazuli set in 18 carat yellow gold plated sterling silver.The statement lapis lazuli necklace can be engraved with a personal message, making for a special personalised jewellery gift.This locket can also hold a special photograph, which we print and insert into the photo locket for free.Our photo lockets are the perfect fit for any occasion, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "The perfect personalised jewellery gift" +
                                            "Gold locket necklace finished with our signature star-set white sapphire tag" +
                                            "Each gemstone has a unique appearance, therefore patterns may vary slightly" +
                                            "Also available in a larger size" +
                                            "Styled here with the Lapis Droplet Necklace and Celestial Compass Pendant" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Lockets/39094YBEN.jpg",
                  Size = "20 - 22",
                  ColorId = "Blue",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "LapisLazuli",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "39094RPKN",
                  Name = "Lace Agate Slice Stilla Locket Necklace",
                  Price = 400,
                  Description = "This rose gold locket necklace features a slice of blue lace agate, delicately streaked with lilac and pink tones, set in 18 carat rose gold-plated sterling silver. The rose gold statement necklace can be engraved with a personal message, making for a special personalised jewellery gift. This rose gold personalised locket can also hold a special photograph, which we print and insert into the photo locket for free. Our photo lockets are the perfect fit for any occasion, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable to give three alternative lengths" +
                                            "Rose gold locket finished with our signature star-set white sapphire tag" +
                                            "Styled here with the Beaded Moonstone Pendant and Cosmos Pendant" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Lockets/39094RPKN.jpg",
                  Size = "16 - 18",
                  ColorId = "Pink",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "RoseGoldVermeil",
              },

              new Product
              {
                  PdId = "41025SNON",
                  Name = "Mini Biography Locket Necklace",
                  Price = 115,
                  Description = "This meaningful sterling silver locket is a beautiful, personalised necklace that can hold treasured memories. A star-set locket crafted from solid sterling silver with a white sapphire gemstone, this easy-to-style engravable locket necklace makes for a meaningful personalised jewellery gift, with the option to add two special photographs, which we print and insert into the sterling silver photo locket for free. Our engravable lockets are the perfect fit for any occasion, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload two images and we will print and fit them into the locket for free" +
                                            "A timeless, sterling silver personalised necklace" +
                                            "Features our signature star-set cultured white sapphire tag" +
                                            "This photo locket would make the perfect personalised jewellery gift" +
                                            "Styled here with the White Pearl Choker and Sunrise Locket",
                  Image = "/Images/Lockets/41025SNON.jpg",
                  Size = "14 - 16",
                  ColorId = "Silver",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireSpinel",
                  MetalId = "SterlingSilver",
              },

              new Product
              {
                  PdId = "42064SNON",
                  Name = "Celestial Compass Locket Necklace",
                  Price = 265,
                  Description = "This engravable photo locket necklace features a compass motif inspired by navigational instruments used by explorers in the 14th and 15th centuries. Showcasing a white sapphire set at the centre, with rays of solid sterling silver stretching outwards, this silver personalised necklace is perfect for layering and evokes the feeling of plotting a course with a little help from the stars. The engravable statement silver locket has a hinge opening to allow for a photograph or keepsake to be stored inside - simply upload a cherished image, and we'll take care of the rest. Our engravable photo lockets are the perfect jewellery gifts, just upload a photo and a message and we will create your future heirloom." +
                                            "Personalised locket necklace with a FREE engraving and photo inside" +
                                            "Upload an image and we will print and fit it into the locket for free" +
                                            "Adjustable chain with three alternate lengths" +
                                            "Solid sterling silver, finished with a sapphire gemstone" +
                                            "As seen in Red Magazine" +
                                            "Styled here with the Compass Pendant and Large Mother of Pearl Locket",
                  Image = "/Images/Lockets/42064SNON.jpg",
                  Size = "16 - 18",
                  ColorId = "Silver",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireSpinel",
                  MetalId = "SterlingSilver",
              },

              new Product
              {
                  PdId = "46049YGYN",
                  Name = "Celestial Grey Enamel Dial Locket Necklace",
                  Price = 300,
                  Description = "This photo locket necklace features a star motif reminiscent of sundials. The central star is set with a white sapphire, while the surround is embellished with enamel in a chic grey tone, all in a unique octagonal silhouette. This gold personalised necklace is perfect for layering and evokes the feeling of plotting a course with a little help from the stars. This statement locket has a hinge opening to allow for a photograph or keepsake to be stored inside - simply upload a cherished image and we'll take care of the rest. Our photo lockets are the perfect jewellery gifts, available with free personalisation." +
                                            "Upload an image and we will print and fit it into the locket for FREE" +
                                            "Adjustable chain with three alternate lengths" +
                                            "18 carat gold-plated sterling silver, finished with white sapphires" +
                                            "Embellished with enamel in a chic grey tone",
                  Image = "/Images/Lockets/46049YGYN.jpg",
                  Size = "16 - 18",
                  ColorId = "Grey",
                  IdCategory = "Lockets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireEnamel",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "44038YBKB",
                  Name = "Black Onyx Biography Bracelet",
                  Price = 185,
                  Description = "Perfect for layering into your bracelet collection, this grown-up friendship bracelet design features hand-cut black onyx gemstones with a spectacle-set black onyx charm, set in 18 carat yellow gold plated sterling silver. Mesmerising black onyx is thought to eliminate negative energy." +
                                            "Finished by our signature cultured white star-set sapphire tag" +
                                            "Gemstone details are eye-catching and add a touch of luxury" +
                                            "Fixed length and securely fastened by a clasp" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Bracelets/44038YBKB.jpg",
                  Size = "16 - 18",
                  ColorId = "Black",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Pearl",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "46037YGEB",
                  Name = "Mini Icon Aura Emerald Bracelet",

                  Price = 800,
                  Description = "Featuring two concentric circles, one set with white diamond pavé and the other a beautifully vibrant emerald, this mini Icon Aura bracelet is set in solid 14 carat gold. We use a modern casting technique for our diamond pavé that allows for a stronger setting and more refined design. Adjustable to fit a variety of wrist sizes, this emerald bracelet with a diamond halo surround is finished with our signature Astley Clarke star-set diamond." +
                        "Solid 14ct gold bracelet" +
                        "Set with diamond pavé and an emerald" +
                        "Perfect for stacking" +
                        "Emerald is the birthstone of May" +
                        "All of our gemstones are cut and polished by hand" +
                        "Produced using 100% recycled gold",
                  Image = "/Images/Bracelets/46037YGEB.jpg",
                  Size = "14 - 16",
                  ColorId = "Green",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Emerald",
                  MetalId = "YellowGold",
              },

              new Product
              {
                  PdId = "44011YWTB",
                  Name = "Linia Rainbow Moonstone Bangle",
                  Price = 250,
                  Description = "Proving that it really is all in the detail, this Linia Bangle showcases a stunning row of faceted rainbow moonstones, held by unique structures that decorate the design. Featuring an easy sprung closure, this bangle is perfect for everyday wear and has a polished, elegant finish." +
                                            "Features a row of beautiful rainbow moonstones" +
                                            "Crafted from 18 carat gold plated sterling silver" +
                                            "Showcases unique structures that decorate the design" +
                                            "Also available as part of a bracelet stack" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Bracelets/44011YWTB.jpg",
                  Size = "16 - 18",
                  ColorId = "White",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "RainbowMoonstone",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "47044YWTB",
                  Name = "Pearls of Wisdom Bracelet Stack",
                  Price = 365,
                  Description = "Featuring a beautiful combination of pearl gemstones and white sapphires, this Pearls of Wisdom bracelet stack includes an adjustable pearl bracelet and an adjustable kula bracelet, finished with a chain bracelet inspired by the outline of an Evil Eye symbol – offering a beautifully relaxed look you can stack straight away." +
                                            "Curated selection of complementary bracelets" +
                                            "Features pearl and white sapphire gemstones" +
                                            "Crafted from gold plated sterling silver" +
                                            "As seen in Hello! Fashion",
                  Image = "/Images/Bracelets/47044YWTB.jpg",
                  Size = "16 - 18",
                  ColorId = "White",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Pearl",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "45023YMUB",
                  Name = "Rainbow Tree of Life Biography Bracelet",
                  Price = 185,
                  Description = "Perfect for layering into your bracelet collection, this grown-up friendship bracelet design features a spectrum of hand-cut gemstones and a meaningful ‘Tree of Life’ charm, set in 18 carat yellow gold plated sterling silver. This bracelet’s charm represents regeneration and makes a meaningful jewellery gift." +
                                            "Gold friendship bracelet with a ‘Tree of Life’ charm" +
                                            "Gemstone bracelet that makes a meaningful jewellery gift" +
                                            "Crafted with vibrant gemstones" +
                                            "Also available as part of a bracelet stack" +
                                            "Styled here with the hope skinny bracelet, and the compass kula",
                  Image = "/Images/Bracelets/45023YMUB.jpg",
                  Size = "16 - 18",
                  ColorId = "Multi",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "YellowGold",
              },

              new Product
              {
                  PdId = "48027YRDB",
                  Name = "Agate Hamsa Biography Bracelet",
                  Price = 185,
                  Description = "This demi-fine, gold bracelet features hand-cut red agate gemstones with a sapphire pavé and carnelian Hamsa charm set in 18 carat yellow gold plated sterling silver." +
                                            "Astley Clarke Hamsa charm symbolises Protection" +
                                            "Finished by our signature star-set lapis lazuli." +
                                            "As seen in Condé Nast Traveller" +
                                            "Also available as part of a bracelet stack" +
                                            "Styled here with the moonstone hamsa biography bracelet" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Bracelets/48027YRDB.jpg",
                  Size = "16 - 18",
                  ColorId = "Red",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Agate",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "40143SNOB",
                  Name = "Cylinder Cosmos Kula Bracelet Stack",
                  Price = 210,
                  Description = "This bracelet stack is a combination of two sterling silver Kula bracelets, one featuring a smooth rounded tube and the other, faceted silver beads. With a Cosmos disc charm symbolising ‘Infinity’ and adjustable nugget fastenings, these bracelets are also finished with our signature star-set white cultured sapphire.Our bracelet stacks have a saving of 10% as compared to buying the bracelets individually." +
                                            "Curated selection of complementary bracelets" +
                                            "Features charms that represent infinity" +
                                            "Adjustable friendship bracelets",
                  Image = "/Images/Bracelets/40143SNOB.jpg",
                  Size = "16 - 18",
                  ColorId = "Silver",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "SterlingSilver",
              },

              new Product
              {
                  PdId = "37081SNO",
                  Name = "Cosmos Kula Bracelet",
                  Price = 160,
                  Description = "This demi-fine, silver bracelet is a grown-up take on the traditional friendship bracelet style and features faceted nuggets alongside a cultured white sapphire Cosmos charm." +
                                            "Symbolic Cosmos charm representing Infinity" +
                                            "Adjustable fit from Kula nugget fastening" +
                                            "Finished by the Astley Clarke star-set lapis lazuli" +
                                            "Also available as part of a bracelet stack" +
                                            "Styled here with the cosmos kula bracelet, the rose gold cylinder kula bracelet and the silver cylinder kula bracelet",
                  Image = "/Images/Bracelets/37081SNO.jpg",
                  Size = "16 - 18",
                  ColorId = "Silver",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireEnamel",
                  MetalId = "SterlingSilver",
              },

              new Product
              {
                  PdId = "42035RWTB",
                  Name = "Large Icon Nova Opal Bracelet",
                  Price = 1550,
                  Description = "Showcased by two delicate chains and rose-cut diamonds, the central Icon Nova motif features colour-changing opal cabochons and diamonds arranged in concentric circles. This 14 carat rose gold bracelet is a captivating addition to any fine jewellery collection." +
                                            "Sliding ball and clasp fastening gives adjustable fit" +
                                            "Finished by our signature star-set diamond tag" +
                                            "Harmonious pastel colour combination" +
                                            "Produced using 100% recycled gold" +
                                            "All of our diamonds are natural and ethically sourced" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Bracelets/42035RWTB.jpg",
                  Size = "20-22",
                  ColorId = "Rose",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "RoseGold",
              },

              new Product
              {
                  PdId = "39063YBKB",
                  Name = "Black Spinel Evil Eye Biography Bracelet",
                  Price = 185,
                  Description = "This grown-up friendship bracelet features hand-cut black spinel gemstones with a cultured white sapphire Evil Eye charm set in 18 carat yellow gold plated silver. Inspired by treasured talismans, this fixed length Biography bracelet symbolises Protection and Wisdom." +
                                            "Evil Eye symbol is recognised and adored around the world" +
                                            "Semi-precious stones give a touch of everyday luxury" +
                                            "Highly stackable and can accessorise both casual and evening wear" +
                                            "Also available as part of a stack" +
                                            "As seen in Town & Country" +
                                            "Styled here with the cosmos biography bracelet",
                  Image = "/Images/Bracelets/39063YBKB.jpg",
                  Size = "16 - 18",
                  ColorId = "Black",
                  IdCategory = "Bracelets",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireSpinel",
                  MetalId = "YellowGold",
              },


              new Product
              {
                  PdId = "45059RNON",
                  Name = "Large Icon Rose Gold Diamond Pendant Necklace",
                  Price = 1905,
                  Description = "Featuring gloriously encrusted circles of light grey diamonds pavé set in a 14 carat rose gold disc, this Large Icon Pendant makes every day an occasion. An open back pavé setting allows the light to pass through the diamonds to enhance their natural magnificence. The diamond design can be layered luxuriously with other fine necklaces or worn alone for an opulent statement." +
                                            "As seen on Poppy Delevingne, Celia Imrie and Megan Fox" +
                                            "Adjustable to give length variation" +
                                            "Elegant chain is finished by our signature star-set diamond tag" +
                                            "Produced using 100% recycled gold" +
                                            "All of our diamonds are natural, conflict-free and ethically sourced",
                  Image = "/Images/Necklaces/45059RNON.PNG",
                  Size = "20-22",
                  ColorId = "Gold",
                  IdCategory = "Necklaces",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "RoseGold",
              },
              new Product
              {
                  PdId = "38032YGRN",
                  Name = "Round Stilla Pendant Necklace",
                  Price = 160,
                  Description = "A celebration of vibrancy, this demi-fine Stilla pendant features a captivating rose-cut green onyx gemstone, set in 18 carat yellow gold plated sterling silver, and uses a spectacle setting to display the entire gemstone and catch the light beautifully. This gemstone pendant is finished with a gold nugget detail and our signature Astley Clarke star-set white sapphire tag." +
                                            "Hand finished, polished and set" +
                                            "Captivating rose-cut green onyx gemstone" +
                                            "Spectacle set gemstone in 18 carat gold plated sterling silver" +
                                            "Easy to wear and catch the light beautifully" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Necklaces/38032YGRN.PNG",
                  Size = "16 - 18",
                  ColorId = "Gold",
                  IdCategory = "Necklaces",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "YellowGoldVermeil",
              },

              new Product
              {
                  PdId = "38032YGEN",
                  Name = "Round Stilla Amazonite Pendant Necklace",
                  Price = 160,
                  Description = "A celebration of vibrancy, this demi-fine Stilla gemstone pendant features a captivating table-cut amazonite gem, set in 18 carat yellow gold plated sterling silver, and uses a spectacle setting to display the entire green gemstone and show its complexities beautifully. This gemstone pendant is finished with a gold nugget detail and our signature Astley Clarke star-set lapis lazuli tag. This blue gemstone necklace would be perfect as a birthday gift or paired and stacked with our other gemstone jewellery for a playful contemporary look." +
                                            "Chain finished by our signature sapphire-set tag" +
                                            "Also available as part of a necklace stack" +
                                            "All of our gemstones are cut and polished by hand",
                  Image = "/Images/Necklaces/38032YGEN.PNG",
                  Size = "14 - 16",
                  ColorId = "Gold",
                  IdCategory = "Necklaces",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "LapisLazuli",
                  MetalId = "YellowGoldVermeil",
              },
              new Product
              {
                  PdId = "46043YNON",
                  Name = "Celestial Orbit Chain Necklace",
                  Price = 250,
                  Description = "The ultimate chain design, this unique Celestial Orbit chain necklace features interconnected components that alternate between links and oval discs, set with radiant white sapphires. Crafted from 18 carat gold plated sterling silver, this gold chain goes with absolutely everything and will bring a bright touch to your jewellery collection. Perfect for gifting, the Celestial Orbit chain necklace is adjustable to many lengths with a series of open links and secure jump ring closure." +
                                            "Stackable chain necklace" +
                                            "Crafted from 18 carat gold-plated sterling silver" +
                                            "Set with radiant white sapphires" +
                                            "Inspired by the night sky",
                  Image = "/Images/Necklaces/45059RNON.PNG",
                  Size = "12-14",
                  ColorId = "Gold",
                  IdCategory = "Necklaces",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "CulWhiteSapphireEnamel",
                  MetalId = "RoseGold",
              },
              new Product
              {
                  PdId = " 47000YNON",
                  Name = "Celestial Dial Multi-Way Lariat Necklace",
                  Price = 150,
                  Description = "This Celestial lariat is just the thing for refreshing your jewellery collection. Designed so that you can wear it either as a pendant or lariat, the necklace features an octagonal charm decorated with our signature Celestial star setting. Two white sapphire-encrusted hook clip fastenings join the chain to the charm, and can be securely clipped into the second jump ring higher up on the chain to switch up styles effortlessly. Crafted from 18 carat gold plated sterling silver, the charm can be engraved for free to create an even more meaningful piece." +
                                            "Features an octagonal charm finished with a star-set sapphire" +
                                            "Personalise for free with an engraving" +
                                            "Crafted from 18 carat gold plated sterling silver" +
                                            "Can be worn as either a pendant or lariat necklace",
                  Image = "/Images/Necklaces/47000YNON.PNG",
                  Size = "20-22",
                  ColorId = "Gold",
                  IdCategory = "Necklaces",
                  BrandId = "AstleyClarke",
                  DimId = "Diamond",
                  StoneId = "Diamond",
                  MetalId = "YellowGoldVermeil",
              },
                new Product
                {
                    PdId = "42019YWTN",
                    Name = "Peggy Pearl Necklace",
                    Price = 195,
                    Description = "The Pearl Peggy Necklace is a modern update to the traditional string of pearls around the neck. Featuring pearls in graduating sizes, each with a brilliant white lustre, this 18 carat yellow gold-plated sterling silver necklace is a standout, everyday stacking option." +
                                                            "A progressive addition to the pearl fashion trend" +
                                                            "Three length options with a secure clasp fastening" +
                                                            "Finished by our signature star-set cultured white sapphire tag" +
                                                            "All of our gemstones are cut and polished by hand",
                    Image = "/Images/Necklaces/42019YWTN.PNG",
                    Size = "16-18",
                    ColorId = "Gold",
                    IdCategory = "Necklaces",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "46012YBEN",
                    Name = "Stilla Droplet Lapis Pendant Necklace",
                    Price = 125,
                    Description = "Here to add a touch of vibrancy to your necklace layering, this beautiful station necklace is crafted from 18 carat gold-plated sterling silver, adorned with table-cut lapis lazuli ‘droplets’ with a larger gemstone taking centre stage. The deep blue gemstones are interspersed with our signature Stilla gold discs for an easy-to-wear, luxurious aesthetic – ideal for relaxed styling. Perfect for layering, this droplet design would effortlessly add colour and texture to a stack of necklaces." +
                                            "Crafted from 18 carat gold plated sterling silver" +
                                            "Featuring vibrant table-cut lapis lazuli gemstones" +
                                            "Adjustable to three lengths" +
                                            "Makes a meaningful jewellery gift",
                    Image = "/Images/Necklaces/46012YBEN.PNG",
                    Size = "13-15",
                    ColorId = "Gold",
                    IdCategory = "Necklaces",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "RoseGold",
                },
                new Product
                {
                    PdId = "46036YBEN",
                    Name = "Mini Icon Aura Blue Sapphire Pendant Necklace",
                    Price = 695,
                    Description = "Featuring two concentric circles, one set with white diamond pavé and the other a beautifully rich blue sapphire, this mini Icon Aura necklace is set in solid 14 carat gold. We use a modern casting technique for our diamond pavé that allows for a stronger setting and more refined design. Adjustable to three lengths, this blue sapphire necklace with a diamond halo surround is finished with our signature Astley Clarke star-set diamond." +
                                                            "Solid 14ct gold necklace" +
                                                            "Set with diamond pavé and a blue sapphire" +
                                                            "Perfect for stacking" +
                                                            "Sapphire is the birthstone of September" +
                                                            "All of our gemstones are cut and polished by hand" +
                                                            "Produced using 100% recycled gold",
                    Image = "/Images/Necklaces/46036YBEN.PNG",
                    Size = "16-18",
                    ColorId = "Gold",
                    IdCategory = "Necklaces",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGold",
                },
                new Product
                {
                    PdId = "46048YBEN",
                    Name = "Celestial Blue Enamel Constellation Locket Necklace",
                    Price = 225,
                    Description = "This photo locket necklace features a constellation motif inspired by the night sky. The three stars are set with white sapphires and embellished with enamel in a deep blue tone, in a unique octagonal silhouette. This gold necklace personalised is perfect for layering and evokes the feeling of plotting a course with a little help from the stars. This statement locket has a hinge opening to allow for a photograph or keepsake to be stored inside - simply upload a cherished image and we'll take care of the rest. Our photo lockets are the perfect jewellery gifts, available with free personalisation." +
                                                                        "Upload an image and we will print and fit it into the locket for FREE" +
                                                                        "Adjustable chain with three alternate length" +
                                                                        "18 carat gold-plated sterling silver, finished with white sapphires" +
                                                                        "Embellished with enamel in a deep blue tone",
                    Image = "/Images/Necklaces/46048YBEN.PNG",
                    Size = "20-22",
                    ColorId = "Gold",
                    IdCategory = "Necklaces",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "LapisLazuli",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "46052YWTN",
                    Name = "Celestial White Enamel Astra Pendant Necklace",
                    Price = 125,
                    Description = "This Celestial Astra pendant necklace features a navigational motif inspired by instruments used by explorers in the 14th and 15th centuries. Showcasing a sapphire set at its centre, surrounded by a halo of white sapphires and embellished with bright white enamel, this meaningful pendant is perfect for layering and evokes the feeling of plotting a course with a little help from the stars." +
                                            "As seen on Poppy Delevingne, Celia Imrie and Megan Fox" +
                                            "Adjustable pendant inspired by early voyages of discovery" +
                                            "Set with white sapphires" +
                                            "Embellished with enamel in a bright white tone",
                    Image = "/Images/Necklaces/46052YWTN.PNG",
                    Size = "16-18",
                    ColorId = "Gold",
                    IdCategory = "Necklaces",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },



                new Product
                {
                    PdId = "45060YBEE",
                    Name = "Mini Blue Sapphire Stud Earrings",
                    Price = 395,
                    Description = "Featuring two vibrant sapphires set in 14 carat gold, these mini solid gold stud earrings are the perfect enhancement to any ear stack. Timelessly refined, this seemingly simple design creates immediate impact with minimal effort and looks perfect stacked with fine hoops and drop earrings." +
                                                            "Beautifully set in 14 carat gold" +
                                                            "Designed as everyday stacking favourite" +
                                                            "Perfect for lobe and upper lobe piercings" +
                                                            "Set with beautifully vibrant sapphires" +
                                                            "Produced using 100% recycled gold",
                    Image = "/Images/Earrings/45060YBEE.PNG",
                    Size = "14 - 16",
                    ColorId = "Blue",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGold",
                },
                new Product
                {
                    PdId = "47018YNOE",
                    Name = "Celestial Astra Hoop Earrings",
                    Price = 150,
                    Description = "These sapphire encrusted Astra hoop earrings have major stack appeal. Each featuring two rows of cultured white sapphire pavé set into 18-carat gold plated sterling silver hoops, these Astra gold earrings evoke the collection’s theme of a starry night sky, reflecting light in all directions. Perfect for bringing a bright touch to your ear stacks, these hoops can be worn anywhere across the lobe and layer in perfectly with other studs and cuffs, making them meaningful gifts or a versatile addition to your own jewellery box." +
                                                            "Set with radiant white sapphire pavé" +
                                                            "Crafted from 18 carat gold-plated sterling silver" +
                                                            "A versatile addition to any jewellery collection",
                    Image = "/Images/Earrings/47018YNOE.PNG",
                    Size = "16-18",
                    ColorId = "Gold",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "47014YNOE",
                    Name = "Celestial Chain Earrings",
                    Price = 85,
                    Description = "Resembling radiant stars floating in space, these Celestial chain earrings are statements that look radiant stacked with studs and hoops, or equally bold when worn alone. Crafted from 18 carat gold plated sterling silver, the chain earrings are decorated with starburst motifs set with cultured white sapphires - the chain connects to the butterfly back for secure wear. Perfect for bringing a bright touch to your ear stacks, these chain earrings make a meaningful gift or a statement addition to your own jewellery box." +
                                                            "Chain earrings set with white sapphires." +
                                                            "Crafted from 18 carat gold-plated sterling silver" +
                                                            "Resemble stars floating in space" +
                                                            "A statement addition to any jewellery collection",
                    Image = "/Images/Earrings/47014YNOE.PNG",
                    Size = "14 - 16",
                    ColorId = "Gold",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "44002YLBE",
                    Name = "Linia London Blue Topaz Stud Earrings",
                    Price = 55,
                    Description = "The ultimate colour accent for your collection, these Linia stud earrings are crafted from 18 carat gold plated sterling silver prongs that hold beautifully rich London blue topaz gemstones. With a polished finish, these studs are perfect for adding to your ear stack, or wearing as subtle statements." +
                                                            "Crafted from 18 carat gold plated sterling silver" +
                                                            "Defined by unique structures that hold the stones" +
                                                            "Feature rich, jewel tone London blue topaz gemstones" +
                                                            "All of our gemstones are cut and polished by hand" +
                                                            "Styled here with the Linia London Blue Topaz Ear Cuff and the Disc Stilla Studs",
                    Image = "/Images/Earrings/44002YLBE.PNG",
                    Size = " 13 - 15",
                    ColorId = "Blue",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "44050SNOE",
                    Name = "Small Linia Hoop Earrings",
                    Price = 75,
                    Description = "Meet your new staples. These small Linia hoop earrings are lightweight without compromising on quality, crafted from solid sterling silver. With a secure click closure, the hoops feature a ridged textural detail that runs across the design, perfect for stacking and everyday wear." +
                                                            "Crafted from solid sterling silver" +
                                                            "Secure click closure" +
                                                            "Lightweight and luxurious" +
                                                            "Styled here with the Linia Ear Cuff and the Disc Stilla Studs" +
                                                            "Also available as medium hoops and large hoops",
                    Image = "/Images/Earrings/44050SNOE.PNG",
                    Size = "16-18",
                    ColorId = "White",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "38178RNOE",
                    Name = "Mini Stilla Hoop Earrings",
                    Price = 65,
                    Description = "No earring collection is complete without a pair of chic, minimalist hoops. These Mini Stilla Hoop Earrings are crafted from 18 carat rose gold plated silver and offer refined luxury to wear every day." +
                                                            "Hugs the earlobe elegantly" +
                                                            "Style alongside our other demi-fine earrings",
                    Image = "/Images/Earrings/38178RNOE.PNG",
                    Size = " 13 - 15",
                    ColorId = "Gold",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "RoseGold",
                },
                new Product
                {
                    PdId = "47011YNOE",
                    Name = "Mini Celestial Dial Stud Earrings",
                    Price = 60,
                    Description = "These mini Celestial Dial stud earrings are unique designs set to enliven your ear stacks, each crafted from 18 carat gold plated sterling silver and set with a white sapphire. Featuring octagonal surfaces decorated with the collection’s signature star motif, these mini Dial stud earrings will elevate your everyday staples. The meaningful Celestial collection draws inspiration from vintage metalwork, astronomical instruments used to track the night sky, and the sandblasted rays of sundials, to create extraordinary jewellery you’ll love wearing day in, day out." +
                                                            "Set with white sapphires and decorated with star motifs" +
                                                            "Crafted from 18 carat gold plated sterling silver" +
                                                            "Mix and match with gold hoops and ear cuffs" +
                                                            "Inspired by vintage metalwork",
                    Image = "/Images/Earrings/47011YNOE.PNG",
                    Size = "16-18",
                    ColorId = "Gold",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "RoseGold",
                },
                new Product
                {
                    PdId = "46013YGYE",
                    Name = "Stilla Labradorite Drop Hoop Earrings",
                    Price = 160,
                    Description = "Here to add a touch of iridescence to your ear party, these labradorite drop hoop earrings boast a specially designed ‘spectacle setting’, allowing the rose-cut gems to be viewed from both sides and creating maximum light reflection through the stones. Crafted from 18 carat gold plated sterling silver, these versatile hoops stack perfectly with gemstone studs and fit with a secure click closure." +
                                                            "Featuring iridescent rose-cut labradorite gemstones" +
                                                            "Crafted from 18 carat gold plated sterling silver" +
                                                            "Fits with a secure click closure" +
                                                            "Makes a meaningful jewellery gift",
                    Image = "/Images/Earrings/46013YGYE.PNG",
                    Size = "16-18",
                    ColorId = "White",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldVermeil",
                },
                new Product
                {
                    PdId = "38084WNOE",
                    Name = "Medium Halo Diamond Hoop Earrings",
                    Price = 1250,
                    Description = "Featuring brilliant-cut white diamonds set in solid 14 carat white gold, we have built on the popularity of our Mini Halo Hoop earrings to create these larger, equally covetable, essential diamond hoops." +
                                                            "Luxurious jewellery piece to be enjoyed at any occasion" +
                                                            "Crafted using a modern casting technique for a strong diamond setting" +
                                                            "As seen on Rosie Huntington-Whiteley" +
                                                            "Produced using 100% recycled gold" +
                                                            "All of our diamonds are natural, conflict - free and ethically sourced",
                    Image = "/Images/Earrings/38084WNOE.PNG",
                    Size = "16-18",
                    ColorId = "White",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "WhiteGold",
                },
                new Product
                {
                    PdId = "45034RBKE",
                    Name = "Medium Interstellar Black Diamond Hoop Earrings",
                    Price = 895,
                    Description = "These medium Interstellar black diamond hoop earrings are the ultimate fine earring you can style easily into your everyday look. Relaxed and opulent all at once, the stones have been set in a cluster formation; brilliant cut black diamonds are gloriously encrusted in solid 14 carat rose gold hoops for maximum impact and light reflection. Perfect for stacking with diamond studs, the medium Interstellar rose gold hoops are your new jewellery box staples." +
                                                            "Click closure for a secure easy fastening" +
                                                            "Cluster formation of brilliant cut black diamonds" +
                                                            "Set in solid 14 carat rose gold" +
                                                            "Everyday diamonds that are perfect for stacking" +
                                                            "Styled here with the Mini Interstellar Hoops" +
                                                            "All of our diamonds are natural, conflict - free and ethically sourced",
                    Image = "/Images/Earrings/45034RBKE.PNG",
                    Size = " 13 - 15",
                    ColorId = "Black",
                    IdCategory = "Earrings",
                    BrandId = "AstleyClarke",
                    DimId = "BlackDiamond",
                    StoneId = "Diamond",
                    MetalId = "RoseGold",
                },

                new Product
                {
                    PdId = "41024YNOR",
                    Name = "Interstellar Diamond Ring",
                    Price = 1087,
                    Description = "Exceptionally crafted from 14 carat gold and inspired by the star clusters of the cosmos, this diamond ring is part of the Interstellar fine jewellery collection and features light grey,meticulously pavé set diamonds on a highly polished band of yellow gold." +
                                                            "Alternately sized diamonds for an intricate pavé setting" +
                                                            "Beautiful wedding or eternity ring option" +
                                                            "Fine stacking ring to wear every day" +
                                                            "Produced using 100% recycled gold" +
                                                            "All of our diamonds are natural, conflict-free and ethically sourced",
                    Image = "/Images/Rings/41024YNOR.jpg",
                    Size = "16-18",
                    ColorId = "Yellow",
                    IdCategory = "Rings",
                    BrandId = "AstleyClarke",
                    DimId = "Diamond",
                    StoneId = "Diamond",
                    MetalId = "YellowGoldSolid",
                },
                new Product
                    {
                        PdId = "46038YBER",
                        Name = "Ruby Stacking Ring",
                        Price = 473,
                        Description = "Expensively crafted with an affordable price tag, this precious stacking ring is a solid 14ct gold band with a light-reflective setting of graduated vibrant rubies across the centre of its surface.Perfect for layering into your existing collection, this beautiful ruby stacking ring is a vibrant staple to wear every day." +
                                           "Solid 14ct gold ring with graduated precious stones" +
                                           "Set with rich red rubies across its centre" +
                                           "Perfect for stacking" +
                                           "All of our diamonds are natural, conflict - free and ethically sourced",
                        Image = "/Images/Rings/46038YBER.jpg",
                        Size = "16-18",
                        ColorId = "Yellow",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldSolid",
                    },
                    new Product
                    {
                        PdId = "38050YNOR",
                        Name = "Fusion Interstellar Diamond Ring",
                        Price = 1884,
                        Description = "Set in 14 carat yellow gold and inspired by the stars, the Fusion Interstellar Ring is crafted from two spectacular bands of light grey diamonds that come together to form an ‘X’ silhouette.This ring may be stacked with other rings to create a brilliant,multi - layered look or worn alone for a simple statement." +
                    "Crafted from solid 14ct gold" +
                    "Features graduating sizes of diamonds" +
                    "Designed to be worn with the Mini Interstellar ring" +
                    "Produced using 100% recycled gold" +
                    "All of our diamonds are natural, conflict - free and ethically sourced",
                        Image = "/Images/Rings/38050YNOR.jpg",
                        Size = "16-18",
                        ColorId = "Black",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldSolid",
                    },
                    new Product
                    {
                        PdId = "47005YNOR",
                        Name = "Celestial Astra Double Eternity Ring",
                        Price = 217,
                        Description = "This sapphire encrusted Astra double eternity ring has major stack appeal. Featuring two rows of cultured white sapphire pavé set into an 18 carat gold plated sterling silver eternity band, this Astra gold stacking ring evokes the collection’s theme of a starry night sky, reflecting light in all directions.Perfect for bringinga bright touch to your ring stacks, this eternity ring can be worn anywhere across the hand as a stacking ring and layers in perfectly with other rings, making it a meaningful gift or versatile addition to your own jewellery box." +
                                            "Stackable eternity ring design" +
                                            "Crafted from 18 carat gold-plated sterling silver" +
                                            ">Set with radiant white sapphire pavé" +
                                            "A versatile addition to any jewellery collection",
                        Image = "/Images/Rings/47005YNOR.jpg",
                        Size = "16-18",
                        ColorId = "Gold",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldVermeil",
                    },
                    new Product
                    {
                        PdId = "47004YNOR",
                        Name = "Celestial Astra Eternity Ring",
                        Price = 13799,
                        Description = "This sapphire encrusted Astra eternity ring has major stack appeal. Featuring a single row of cultured white sapphirepavé set into an 18 carat gold plated sterling silver eternity band, this Astra gold stacking ring evokes the collection’s theme of starry night sky, reflecting light in all directions. Perfect for bringing a bright touch to your ring stacks, this eternity ring can be worn anywhere across the hand as a stacking ring and layers in perfectly with other rings, making it a meaningful gift or versatile addition to your own jewellery box." +
                                            "Stackable eternity ring design" +
                                            "Crafted from 18 carat gold-plated sterling silver" +
                                            "Set with radiant white sapphire pavé" +
                                            "A versatile addition to any jewellery collection",
                        Image = "/Images/Rings/47004YNOR.jpg",
                        Size = " 13 - 15",
                        ColorId = "Gold",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldSolid",
                    },
                    new Product
                    {
                        PdId = "46045YNOR",
                        Name = "Celestial Astra Signet Ring",
                        Price = 181,
                        Description = "This stackable Celestial Astra Signet Ring features radiant white sapphire pavé at its centre, evoking the night sky. Perfect for bringing a bright touch to your ring stacks, this signet ring can be worn anywhere across the hand as a stacking ring and layers in perfectly with other rings, or looks bold and unique worn alone.This gold signet ring is crafted from 18 carat gold plated sterling silver and makes a meaningful gift." +
                                            "Stackable eternity ring design" +
                                            "Crafted from 18 carat gold-plated sterling silver" +
                                            "Set with radiant white sapphire pavé" +
                                            "Inspired by the night sky",
                        Image = "/Images/Rings/46045YNOR.jpg",
                        Size = "16-18",
                        ColorId = "Gold",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldVermeil",
                    },
                    new Product
                    {
                        PdId = "47009YNOR",
                        Name = "Celestial Ring",
                        Price = 211,
                        Description = "This Celestial ring is a statement design set to embolden your stacks, crafted from 18 carat gold plated sterling silver and set with white sapphires.Featuring a wide band composed of linked octagonal charms ensuring a bold silhouette and luxurious weight,the gold ring’s surfaces showcase the signature Celestial star and sunrise motifs and can be worn anywhere across the hand for radiant results.This meaningful collection draws inspiration from vintage metalwork, astronomical instruments used to track the night sky,and the sandblasted rays of sundials, to create extraordinary jewellery you’ll love wearing day in, day out." +
                                            "Statement signet ring with octagonal links" +
                                            "Wide tapered ring band for a bold silhouette" +
                                            "Crafted from 18 carat gold plated sterling silver" +
                                            "Wear anywhere across the hand for a statement look",
                        Image = "/Images/Rings/47009YNOR.jpg",
                        Size = "16-18",
                        ColorId = "Yellow",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldVermeil",
                    },
                    new Product
                    {
                        PdId = "46051YWTR",
                        Name = "Celestial White Enamel Astra Ring",
                        Price = 160,
                        Description = "his Celestial Astra ring features a navigational motif inspired by instruments used by explorers in the 14th and 15th centuries. Showcasing a sapphire set at its centre,surrounded by a halo of white sapphires and embellished with bright white enamel,this meaningful ring makes a luxurious statement and evokes the feeling of plotting a course with a little help from the stars." +
                                                                "Ring design inspired by early voyages of discovery" +
                                                                "Crafted from 18 carat gold-plated sterling silver" +
                                                                "Set with white sapphires" +
                                                                "Embellished with enamel in a bright white tone",
                        Image = "/Images/Rings/46051YWTR.jpg",
                        Size = "16-18",
                        ColorId = "White",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "YellowGoldVermeil",
                    },
                    new Product
                    {
                        PdId = "42021RWTR",
                        Name = "Mini Icon Nova Opal Ring",
                        Price = 590,
                        Description = "Stackable and refined, the Icon Nova Ring features four brilliant-cut diamonds in two alternate sizes surrounding an iridescent opal cabochon,offering easy - to - wear elegance.With a bezel gemstone setting in polished 14 carat rose gold, the ever - changing colours presented by this precious ring are to be admired every day." +
                                                                "Crafted from polished 14 carat rose gold" +
                                                                "Features four brilliant-cut diamonds" +
                                                                "Defined by a central iridescent opal cabochon" +
                                                                "All of our diamonds are natural and ethically sourced" +
                                                                "Also available as a diamond ring" +
                                                                "All of our diamonds are natural, conflict - free and ethically sourced",
                        Image = "/Images/Rings/42021RWTR.jpg",
                        Size = "16-18",
                        ColorId = "Gold",
                        IdCategory = "Rings",
                        BrandId = "AstleyClarke",
                        DimId = "Diamond",
                        StoneId = "Diamond",
                        MetalId = "RoseGold",
                    },


            new Product
            {
                PdId = "46022YNOR",
                Name = "Biography Evil Eye Stacking Ring",
                Price = 211,
                Description = "The ultimate stacking piece, this gold ring features mini links created from Evil Eye symbols; the unique links have been repeated to create a statement chain effect that will give your ring stacks the golden touch.Each Evil Eye link is crafted using white sapphire pavé with a turquoise pupil set in 18 carat gold plated sterling silver. With a relaxed, cool look, this meaningful gold stacking ring would stack with other gemstones and textures beautifully." +
                                                        "Crafted from 18 carat gold plated sterling silver" +
                                                        "Gold chain stacking ring made up of Evil Eye symbols" +
                                                        "The Evil Eye is an ancient talisman that represents ‘wisdom’ and ‘protection’" +
                                                        "Makes a meaningful jewellery gift" +
                                                        ">White sapphire pavé setting with a turquoise cabochon",
                Image = "/Images/Rings/46022YNOR.jpg",
                Size = "16-18",
                ColorId = "Green",
                IdCategory = "Rings",
                BrandId = "AstleyClarke",
                DimId = "Diamond",
                StoneId = "Diamond",
                MetalId = "YellowGoldVermeil",
            }
                );

                context.SaveChanges();
            }
            if (!context.Order.Any())
            {
                context.Order.AddRange(
                      new Order
                      {
                          Id = "1112A19",
                          CreateTime = new DateTime(2019, 05, 23, 08, 14, 40),
                          Status = true,
                          Name = "Nguyễn Văn Bình",
                          Birthday = "1995-04-17",
                          ZipCode = "BNT190IK",
                          Gender = "Man",
                          Address = "09 Đào Duy Anh, Đống Đa, Hà Nội",
                          Phone = "0360935271",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112B19",
                          CreateTime = new DateTime(2020, 08, 15, 11, 23, 14),
                          Status = true,
                          Name = "Đỗ Thị Lan",
                          Birthday = "2003-11-04",
                          ZipCode = "29OUYR4E",
                          Gender = "Woman",
                          Address = "392 Cầu Giấy, Cầu Giấy, Hà Nội",
                          Phone = "0934876132",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112C19",
                          CreateTime = new DateTime(2021, 12, 16, 11, 23, 14),
                          Status = true,
                          Name = "Nguyễn Văn Lộc",
                          Birthday = "1983-07-28",
                          ZipCode = "OI863FRE",
                          Gender = "Man",
                          Address = "26 Lâm Động, Thủy Nguyên, Hải Phòng",
                          Phone = "0907529131",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112A20",
                          CreateTime = new DateTime(2021, 11, 12, 09, 02, 00),
                          Status = true,
                          Name = "Đào Quỳnh Mai",
                          Birthday = "1973-12-09",
                          ZipCode = "T853EDRKI",
                          Gender = "Woman",
                          Address = "12 Thượng Đình, Thanh Xuân, Hà Nội",
                          Phone = "0397265320",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112B20",
                          CreateTime = new DateTime(2021, 10, 07, 10, 23, 15),
                          Status = false,
                          Name = "Nguyễn Thị Lệ Quyên",
                          Birthday = "1999-09-12",
                          ZipCode = "8OYTR42W",
                          Gender = "Woman",
                          Address = "25 Lê Lợi, Sơn Tây, Hà Nội",
                          Phone = "09036542186",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112C20",
                          CreateTime = new DateTime(2021, 9, 17, 05, 43, 10),
                          Status = false,
                          Name = "Phạm Lệ Trâm",
                          Birthday = "1998-11-21",
                          ZipCode = "85DCTSD5",
                          Gender = "Woman",
                          Address = "3C Thụy An, Ba Vì, Hà Nội",
                          Phone = "09309723246",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112D20",
                          CreateTime = new DateTime(2021, 8, 04, 03, 32, 56),
                          Status = false,
                          Name = "Trần Đắc Tiến",
                          Birthday = "1982-01-27",
                          ZipCode = "09OTDXE43",
                          Gender = "Man",
                          Address = "56 Thụy Khê, Tây Hồ, Hà Nội",
                          Phone = "0309265318",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112E20",
                          CreateTime = new DateTime(2021, 7, 03, 09, 54, 04),
                          Status = true,
                          Name = "Nguyễn Việt Dũng",
                          Birthday = "1989-09-05",
                          ZipCode = "UTD543SL",
                          Gender = "Man",
                          Address = "123 Lê Lợi,Bến Nghé, 1,Hồ Chí Minh",
                          Phone = "0907243862",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112A21",
                          CreateTime = new DateTime(2021, 6, 04, 08, 12, 34),
                          Status = true,
                          Name = "Trương Tuấn Đức",
                          Birthday = "1993-12-19",
                          ZipCode = "90OJGFD54",
                          Gender = "Man",
                          Address = "123/5B Lê Lợi, 6, Tuy Hòa, Phú Yên",
                          Phone = "0387508254",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112B21",
                          CreateTime = new DateTime(2021, 5, 14, 06, 30, 12),
                          Status = true,
                          Name = "Phạm Ngọc Dương",
                          Birthday = "2000-04-25",
                          ZipCode = "UTRD65I86",
                          Gender = "Woman",
                          Address = "49 Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội",
                          Phone = "0907353454",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112C21",
                          CreateTime = new DateTime(2021, 4, 28, 02, 11, 38),
                          Status = true,
                          Name = "Ngô Diên An",
                          Birthday = "1997-12-09",
                          ZipCode = "IYF9754WEE",
                          Gender = "Man",
                          Address = "164 Nguyễn Tuân, Thanh Xuân, Hà Nội",
                          Phone = "0909354572",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112D21",
                          CreateTime = new DateTime(2021, 3, 10, 10, 15, 13),
                          Status = true,
                          Name = "Ngô Lệ Á",
                          Birthday = "1984-07-11",
                          ZipCode = "UTDX7654D",
                          Gender = "Woman",
                          Address = "5 Đào Duy Anh, Đống Đa, Hà Nội",
                          Phone = "0309625484",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112E21",
                          CreateTime = new DateTime(2021, 2, 18, 07, 43, 09),
                          Status = true,
                          Name = "Trần Dụ Uyên",
                          Birthday = "1994-02-09",
                          ZipCode = "497TRSS754",
                          Gender = "Woman",
                          Address = "2B/107 Trần Duy Hưng,Trung Hoà,Cầu Giấy, Hà Nội",
                          Phone = "0375409524",
                          Email = "sonngth1908031@fpt.edu.vn"
                      },
                      new Order
                      {
                          Id = "1112F21",
                          CreateTime = new DateTime(2021, 1, 13, 06, 27, 14),
                          Status = true,
                          Name = "Mộc Minh Phong",
                          Birthday = "1996-08-03",
                          ZipCode = "8765YFDG43",
                          Gender = "Woman",
                          Address = " 43 Tú Mỡ, Yên Hoà,Cầu Giấy, Hà Nội",
                          Phone = "0904538325",
                          Email = "sonngth1908031@fpt.edu.vn"
                      }
                     
                );
                context.SaveChanges();
            }
            if (!context.OrderDetail.Any())
            {
                context.OrderDetail.AddRange(
                      new OrderDetail
                      {
                          OdId = "1112A19",
                          PdId = "45058YNON",
                          Size = "18",
                          Quantity = 1,
                          TotalPrice = 10000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112B19",
                          PdId = "46048YGEN",
                          Size = "16",
                          Quantity = 2,
                          TotalPrice = 11000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112C19",
                          PdId = "42064SNON",
                          Size = "18",
                          Quantity = 5,
                          TotalPrice = 500000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112A20",
                          PdId = "46052YWTN",
                          Size = "18",
                          Quantity = 6,
                          TotalPrice = 1000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112B20",
                          PdId = "45060YBEE",
                          Size = "14",
                          Quantity = 3,
                          TotalPrice = 3000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112C20",
                          PdId = "47018YNOE",
                          Size = "16",
                          Quantity = 9,
                          TotalPrice = 4300000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112D20",
                          PdId = "44002YLBE",
                          Size = "14",
                          Quantity = 30,
                          TotalPrice = 1100000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112E20",
                          PdId = "46037YGEB",
                          Size = "16",
                          Quantity = 7,
                          TotalPrice = 3000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112A21",
                          PdId = "44011YWTB",
                          Size = "18",
                          Quantity = 8,
                          TotalPrice = 2200000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112B21",
                          PdId = "44038YBKB",
                          Size = "18",
                          Quantity = 2,
                          TotalPrice = 700000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112C21",
                          PdId = "45059RNON",
                          Size = "20",
                          Quantity = 12,
                          TotalPrice = 1100000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112D21",
                          PdId = "38032YGRN",
                          Size = "16",
                          Quantity = 3,
                          TotalPrice = 6000000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112E21",
                          PdId = "46012YBEN",
                          Size = "14",
                          Quantity = 4,
                          TotalPrice = 4300000,
                      },
                      new OrderDetail
                      {
                          OdId = "1112F21",
                          PdId = "46048YBEN",
                          Size = "20",
                          Quantity = 11,
                          TotalPrice = 1200000,
                      }

                  );
                context.SaveChanges();
            }

        }
    }
}