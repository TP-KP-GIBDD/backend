using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models.Accounts
{
    public class DriverLicenceRequest
    {
        [Required]
        public int SeriesDriverLicence { get; set; }

        [Required]
        public int NumberDriverLicence { get; set; }

        [Required]
        public DateTime DateIssueDriverLicence { get; set; }

        [Required]
        public DateTime ValidityPeriodDriverLicence { get; set; }
    }
}
