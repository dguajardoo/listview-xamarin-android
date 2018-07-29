using System;
using System.Collections.Generic;
using System.Linq;

namespace items
{
    public static class UserData
    {
        public static List<User> Users { get; private set; }

        static UserData()
        {
            var temp = new List<User>();

            AddUser(temp);
            //AddUser(temp);
            //AddUser(temp);

            Users = temp;//.OrderBy(i => i.Name).ToList();
        }

        static void AddUser(List<User> users)
        {
            for (int i = 0; i < 15; i++)
            {
                users.Add(new User()
                {
                    Id = i,
                    Name = "Alumno "+ i,
                    Department = "Xamarin Android & Xamarin Forms Development",
                    ImageUrl = "images/image.png",
                    Details = "Virendra has over 2 years of experience developing mobile applications,"
                });
            }

            /*
            users.Add(new User()
            {
                Name = "Alumno 2",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "Alumno 3",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });

            users.Add(new User()
            {
                Name = "Alumno 4",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            }); users.Add(new User()
            {
                Name = "Alumno 5",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "Alumno 6",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

            users.Add(new User()
            {
                Name = "Alumno 7",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "Alumno 8",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });

            users.Add(new User()
            {
                Name = "Alumno 9",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            }); users.Add(new User()
            {
                Name = "Alumno 10",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "Alumno 11",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

            users.Add(new User()
            {
                Name = "Alumno 12",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "Alumno 13",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });

            users.Add(new User()
            {
                Name = "Alumno 14",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            }); users.Add(new User()
            {
                Name = "Alumno 15",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            */
        }
    }
}
