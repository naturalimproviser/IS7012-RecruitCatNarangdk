using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatNarangdk.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        [DisplayName("Industry Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IndustryName { get; set; }
        [DisplayName("Industry Location")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string IndustryLocation { get; set; }
        [DisplayName("Contact Number")]
        [StringLength(10)]
        [Phone]
        [Required]
        public string ContactNumber { get; set; }
        [DisplayName("Email ID")]
        [EmailAddress]
        [Required]
        public string EmailId { get; set; }
        [DisplayName("Founded Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? IndustryFoundedDate { get; set; }
        [DisplayName("Private Firm")]
        public bool IsPrivate { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
