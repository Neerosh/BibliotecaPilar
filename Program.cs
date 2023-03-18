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
                //Cria��o dos usu�rios padr�es
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

                if (dataContext.Users.Where(user => user.UserType == "Usu�rio").FirstOrDefault() == null)
                {
                    Models.User user = new Models.User()
                    {
                        Name = "Usu�rio Padr�o",
                        Username = "usuario",
                        Password = "123",
                        UserType = "Usu�rio"
                    };
                    dataContext.Users.Add(user);
                }

                dataContext.SaveChanges();
            };

            Application.Run(new Login());
        }
    }
}