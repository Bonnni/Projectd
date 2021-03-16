using System;
using System.Collections.Generic;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if (!context.Players.Any() && !context.Teams.Any()) {
                context.Teams.AddRange(new List<Team> {
                        new Team {Name = "Барселона"},
                        new Team {Name = "Реал Мадрид"},
                        new Team {Name = "Манчестер Юнайтед"}
                    });
                context.SaveChanges();
                context.Players.AddRange(new List<Player> {
                    new Player {FirstName = "Татьяна", LastName = "Александрова", TeamId = 1, Gender = "Женский", BirthDay = "03.03.2021", Country = "Россия"},
                    new Player {FirstName = "Александр ", LastName = "Белозерцев",TeamId = 1, Gender = "Мужской", BirthDay = "03.03.2021", Country = "США"},
                    new Player {FirstName = "Елена", LastName = "Богородицкая", TeamId = 1, Gender = "Женский", BirthDay = "03.03.2021", Country = "Италия"},
                    new Player {FirstName = "Елена", LastName = "Великанова", TeamId = 2, Gender = "Женский", BirthDay = "03.03.2021", Country = "Италия"},
                    new Player {FirstName = "Алла", LastName = "Власова", TeamId = 2, Gender = "Женский", BirthDay = "03.03.2021", Country = "США"},
                    new Player {FirstName = "Павел", LastName = "Гребенников ", TeamId = 2, Gender = "Мужской", BirthDay = "03.03.2021", Country = "Россия"},
                    new Player {FirstName = "Вадим", LastName = "Гильмутдинов", TeamId = 3, Gender = "Мужской", BirthDay = "03.03.2021", Country = "Италия"},
                    new Player {FirstName = "Даниил", LastName = "Насыров", TeamId = 3, Gender = "Мужской", BirthDay = "03.03.2021", Country = "США"},
                    new Player {FirstName = "Николай", LastName = "Сергеев", TeamId = 3, Gender = "Мужской", BirthDay = "03.03.2021", Country = "США"},
                    new Player {FirstName = "Куперт", LastName = "Захаров", TeamId = 3, Gender = "Мужской", BirthDay = "03.03.2021", Country = "Россия"}
                });
                context.SaveChanges();
            }
        }
    }
}
