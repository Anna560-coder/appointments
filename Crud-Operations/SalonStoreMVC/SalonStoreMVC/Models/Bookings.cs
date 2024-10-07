using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonStoreMVC.Models
{
    public class Bookings
    {
        [Key]
        public int Id { get; set; }

        
       [Column(TypeName="nvarchar(100)")]
        [DisplayName("Client Name")]
        [Required(ErrorMessage ="This field is required")]
        public string ClientName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName(" Client Surname")]
        [Required(ErrorMessage = "This field is required")]
        public string ClientSurname { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Description { get; set; }

       // [Required(ErrorMessage = "This field is required")]
        public DateTime  Date { get; set; }
        public DateTime Time { get; set; }

    }
}
