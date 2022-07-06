using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationGuide.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string PictureUrl { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Range(7, 20)]
        public int PhoneNumber { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public List<CommercialActivities> CommercialActivities { get; set; }    //1-n ilişki
    }
}