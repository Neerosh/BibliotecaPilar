using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPilar.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserType { get; set; }

        public ICollection<Reserve> Reserves { get; set; }

        public void ClearFields() { 
            Name = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            UserType = string.Empty;
        }

    }
}
