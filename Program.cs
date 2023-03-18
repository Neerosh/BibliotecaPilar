using BibliotecaPilar.Data;
using BibliotecaPilar.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace BibliotecaPilar
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (DataContext dataContext = new DataContext())
            {
                //Criação dos usuários padrões
                if (dataContext.Users.Where(user => user.UserType == "Administrador").FirstOrDefault() == null)
                {
                    Models.User user = new Models.User()
                    {
                        Name = "Administrador",
                        Username = "admin",
                        Password = "admin",
                        UserType = "Administrador"
                    };
                    dataContext.Users.Add(user);
                }

                if (dataContext.Users.Where(user => user.UserType == "Usuário").FirstOrDefault() == null)
                {
                    Models.User user = new Models.User()
                    {
                        Name = "Usuário Padrão",
                        Username = "usuario",
                        Password = "123",
                        UserType = "Usuário"
                    };
                    dataContext.Users.Add(user);
                }

                dataContext.SaveChanges();
            };

            Application.Run(new Login());
        }
    }
}