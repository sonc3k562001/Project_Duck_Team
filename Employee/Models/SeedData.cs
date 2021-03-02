using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Employee.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name= "Nguyen Giang Son",
                        Birthday ="25-07-2001",
                        Address="Duy Tien - Ha Nam",
                        Email ="Sondz@gmail.com",
                        Salary =123,
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2016%2F08%2F20%2F05%2F36%2Favatar-1606914_1280.png&imgrefurl=https%3A%2F%2Fpixabay.com%2Fvi%2Fvectors%2Favatar-n%25E1%25BB%25AF-c%25C3%25B4-g%25C3%25A1i-kh%25C4%2583n-tr%25C3%25B9m-%25C4%2591%25E1%25BA%25A7u-tr%25E1%25BA%25BB-1606914%2F&tbnid=TPGk4efJrUajnM&vet=12ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ..i&docid=1LWewHUxHzMhdM&w=1280&h=1280&q=avatar%20png&ved=2ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ"
                    },
                    new Employee
                    {
                    Name = "Nguyen Giang",
                        Birthday = "25-04-2001",
                        Address = "Cau Giay - Ha Noi",
                        Email = "Giang@gmail.com",
                        Salary = 345,
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2016%2F08%2F20%2F05%2F36%2Favatar-1606914_1280.png&imgrefurl=https%3A%2F%2Fpixabay.com%2Fvi%2Fvectors%2Favatar-n%25E1%25BB%25AF-c%25C3%25B4-g%25C3%25A1i-kh%25C4%2583n-tr%25C3%25B9m-%25C4%2591%25E1%25BA%25A7u-tr%25E1%25BA%25BB-1606914%2F&tbnid=TPGk4efJrUajnM&vet=12ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ..i&docid=1LWewHUxHzMhdM&w=1280&h=1280&q=avatar%20png&ved=2ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ"
                    },
                    new Employee
                    {
                        Name = "Nguyen Van A",
                        Birthday = "25-04-2000",
                        Address = "Mai Dich - Ha Noi",
                        Email = "AVan@gmail.com",
                        Salary = 150,
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2016%2F08%2F20%2F05%2F36%2Favatar-1606914_1280.png&imgrefurl=https%3A%2F%2Fpixabay.com%2Fvi%2Fvectors%2Favatar-n%25E1%25BB%25AF-c%25C3%25B4-g%25C3%25A1i-kh%25C4%2583n-tr%25C3%25B9m-%25C4%2591%25E1%25BA%25A7u-tr%25E1%25BA%25BB-1606914%2F&tbnid=TPGk4efJrUajnM&vet=12ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ..i&docid=1LWewHUxHzMhdM&w=1280&h=1280&q=avatar%20png&ved=2ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ"
                    },
                    new Employee
                    {
                        Name = "Nguyen Van B",
                        Birthday = "25-04-1999",
                        Address = "Mai Dich - Ha Noi",
                        Email = "BXinhGai@gmail.com",
                        Salary = 210,
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2016%2F08%2F20%2F05%2F36%2Favatar-1606914_1280.png&imgrefurl=https%3A%2F%2Fpixabay.com%2Fvi%2Fvectors%2Favatar-n%25E1%25BB%25AF-c%25C3%25B4-g%25C3%25A1i-kh%25C4%2583n-tr%25C3%25B9m-%25C4%2591%25E1%25BA%25A7u-tr%25E1%25BA%25BB-1606914%2F&tbnid=TPGk4efJrUajnM&vet=12ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ..i&docid=1LWewHUxHzMhdM&w=1280&h=1280&q=avatar%20png&ved=2ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ"
                    },
                    new Employee
                    {
                        Name = "Nguyen Van C",
                        Birthday = "25-04-1999",
                        Address = "Xuan Thuy - Ha Noi",
                        Email = "CDeptrai@gmail.com",
                        Salary = 200,
                        Img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.pixabay.com%2Fphoto%2F2016%2F08%2F20%2F05%2F36%2Favatar-1606914_1280.png&imgrefurl=https%3A%2F%2Fpixabay.com%2Fvi%2Fvectors%2Favatar-n%25E1%25BB%25AF-c%25C3%25B4-g%25C3%25A1i-kh%25C4%2583n-tr%25C3%25B9m-%25C4%2591%25E1%25BA%25A7u-tr%25E1%25BA%25BB-1606914%2F&tbnid=TPGk4efJrUajnM&vet=12ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ..i&docid=1LWewHUxHzMhdM&w=1280&h=1280&q=avatar%20png&ved=2ahUKEwj964qVo7HtAhXTwIsBHf1RD8QQMygHegUIARC7AQ"
                    }
                    );
            }
            context.SaveChanges();
        }
    }
}
