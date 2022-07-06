using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationGuide.Data.Models
{
    public class CommercialActivities
    {
        [Key]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public string Business { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }  //1-n ilişki
    }
}