using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatNarangdk.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        [DisplayName("First Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string Gender { get; set; }
        [DisplayName("Email Address")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Social Security Number")]
        [StringLength(10, MinimumLength = 10)]
        [Required(ErrorMessage = "SSN is Required")]
        public string SocialSecurityNumber { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? StartDate { get; set; }
        [DisplayName("Target Salary")]
        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TargetSalary { get; set; }
        [DisplayName("Job Title")]
        [Required]
        public int JobTitleId { get; set; }
        [DisplayName("Performance Rating")]
        [StringLength(5)]
        [Required]
        public string PerformanceRating { get; set; }
        public Industry Industry { get; set; }
        [DisplayName("Industry Name")]
        public int IndustryId { get; set; }
        public Company Company { get; set; }
        [DisplayName("Company Name")]
        public int? CompanyId { get; set; }
        [DisplayName("Job Title Name")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Full Name")]
        [Required]
        public string FullName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }
    }
}