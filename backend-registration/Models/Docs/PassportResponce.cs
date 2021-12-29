using System;

namespace Registration.Models.Docs
{
    public class PassportResponce
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int SeriesPassport { get; set; }
        public int NumberPassport { get; set; }
        public DateTime DateIssuePassport { get; set; }
    }
}
