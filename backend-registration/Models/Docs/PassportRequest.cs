using System;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models.Accounts
{
    public class PassportRequest
    {
        [Required]
        public string Address { get; set; }

        [Required]
        public int SeriesPassport { get; set; }

        [Required]
        public int NumberPassport { get; set; }

        [Required]
        public DateTime DateIssuePassport { get; set; }
    }
}
