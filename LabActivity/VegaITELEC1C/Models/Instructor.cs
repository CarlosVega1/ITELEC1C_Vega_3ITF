using System.ComponentModel.DataAnnotations;

namespace VegaITELEC1C.Models
{   public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "first name is required")]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }
        [Display(Name = "Is tenured")]
        public bool isTenured { get; set; }
        [Display(Name = "Hiring date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }
        [RegularExpression("[0-9] {3} - [0-9] {3} - [0-9] {4}",
            ErrorMessage = "you must follow the format 000-000-0000")]
        [Display(Name = "Office phone number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        [Display (Name = "Email address")]
        public string? EmailAddress { get; set; }

        [Url]
        [Display(Name = "Personal webpage")]
        public string? PersonalURL { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Password (we won't use this!)")]
        [DataType (DataType.Password)]
        public string? UnusedPassword { get; set; }

        
        [Required]
        [Display(Name = "Rank")]
        public Rank Rank { get; set; }

    
    }
    }

