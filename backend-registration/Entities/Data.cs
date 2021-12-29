using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Entities
{
    //[Owned]
    public class Data
    {
        [Key]
        public int Id { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public string Address { get; set; }

        public int SeriesPassport { get; set; }

        public int NumberPassport { get; set; }

        public DateTime DateIssuePassport { get; set; }

        public int SeriesDriverLicence { get; set; }

        public int NumberDriverLicence { get; set; }

        public DateTime DateIssueDriverLicence { get; set; }

        public DateTime ValidityPeriodDriverLicence { get; set; }

        public int NumberIdentityCard { get; set; }
    }
}
