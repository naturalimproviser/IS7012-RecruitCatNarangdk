using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatNarangdk.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CompanyName { get; set; }
        [DisplayName("Job Roles")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CompanyPosition { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaxSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? StartDate { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Location { get; set; }
        [DisplayName("Industry Name")]
        public int IndustryId { get; set; }
        [DisplayName("No of Candidates")]
        [Range(1, 100000)]
        [Required]
        public int? NumberOfCandidates { get; set; }
        [DisplayName("Yearly Revenue")]
        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CompanyNetWorth { get; set; }
        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
    }
}

