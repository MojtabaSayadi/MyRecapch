using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecapch.Domain.Models.Web
{
    public class WebContactUs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
