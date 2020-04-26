using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
       
        public List<OrderDetail> OrderDetails { get; set; }
        
        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name="First name")]

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }

    }
}
