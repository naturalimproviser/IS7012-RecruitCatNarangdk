using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatNarangdk.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        [DisplayName("Job Description")]
        [StringLength(60, MinimumLength = 10)]
        [Required]
        public string JobDescription { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(1, 100000)]
        [DataType(DataType.Currency)]
        public decimal MaxSalary { get; set; }
        [DisplayName("Full Time")]
        public bool IsFullTime { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}

