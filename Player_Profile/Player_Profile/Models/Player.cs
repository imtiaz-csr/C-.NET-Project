using Player_Profile.Enum;
using System.ComponentModel.DataAnnotations;

namespace Player_Profile.Models
{
    public abstract class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required(ErrorMessage = "Photo is required !")]
        [Display(Name = "Photo")]
        [StringLength(100, ErrorMessage = "Photo Url can't exceed 100 characters !")]
        public string PhotoUrlPath { get; set; }
        [Required(ErrorMessage = "Name is required !")]
        [StringLength(40, ErrorMessage = "Name can't exceed 40 characters !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender is required !")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Age is required !")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Country is required !")]
        public Country Country { get; set; }
        [StringLength(500, ErrorMessage = "Achievement can't exceed 500 characters !")]
        public string? Achievement { get; set; }
        public bool? IsRetired { get; set; }
    }
}
