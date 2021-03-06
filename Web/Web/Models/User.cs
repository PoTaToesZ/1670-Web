using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(15,ErrorMessage =  "First Name must between 6 to 15 characters ",MinimumLength = 6)]
        public string FName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(15, ErrorMessage = "Last Name must between 6 to 15 characters ", MinimumLength = 6)]
        public string LName { get; set; }

        [Required]
        [Display(Name = "Home Address")]
        [StringLength(100, ErrorMessage = "Home Address must between 15 to 100 characters ", MinimumLength = 15)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Image")]
        [Url]
        public string Image { get; set; }
    }
}
