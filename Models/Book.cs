using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPilar.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        public string Synopsis { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Status { get; set; }

        public ICollection<Reserve> Reserves { get; set; }

    }
}
