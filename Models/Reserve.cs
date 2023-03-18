using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPilar.Models
{
    public class Reserve
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime ReserveStartDate { get; set; }
        [Required]
        public DateTime ReserveEndDate { get; set; }

        public DateTime BookWithdrawnDate { get; set; }
        public DateTime BookReturnedDate { get; set; }
        public double ReserveTotal { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
