using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Models.Docs
{
    public class DriverLicenceResponce
    {
        public int Id { get; set; }
        public int SeriesDriverLicence { get; set; }
        public int NumberDriverLicence { get; set; }
        public DateTime DateIssueDriverLicence { get; set; }
        public DateTime ValidityPeriodDriverLicence { get; set; }
    }
}
