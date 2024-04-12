using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuongTanDung_Tuan3.Models
{
    public class ApplicationsUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
    }
}
