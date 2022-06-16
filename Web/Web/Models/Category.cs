using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [StringLength(15, ErrorMessage = "Category Name must between 6 to 15 characters ", MinimumLength = 6)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "Description must between 15 to 100 characters ", MinimumLength = 15)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image")]
        [Url]
        public string Image { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
