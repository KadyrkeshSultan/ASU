using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Reports
{
    public class Stamp
    {
        public string CenterText
        {
            get
            {
                if(this.Year.HasValue)
                {
                    int? year = this.Year;
                    if ((year.GetValueOrDefault() <= 0 ? false : year.HasValue))
                    {
                        string str = this.Year.ToString();
                        return $"{str[2]}{this.Code}{str[3]}";
                    }
                }
                return $"{this.Code}";
            }
        }

        public string CenterTextWithQuarter
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Quarter))
                {
                    return this.CenterText;
                }
                return string.Concat(this.CenterText, Environment.NewLine, this.Quarter);
            }
        }

        public string Code { get; set; }
        public int Count => this.NumEnd - this.NumStart + 1;
        public string Diameter { get; set; }
        public int NumEnd { get; set; }
        public int NumStart { get; set; }
        public string QREnd { get; set; }
        public string QRStart { get; set; }
        public string Quarter { get; set; }
        public Stamp.eStampType Type { get; set; }
        public int? Year { get; set; }

        public Stamp()
        {

        }

        public enum eStampType
        {
            CandL,
            CandLSimple,
            PP,
            SL,
            SLPlus
        }
    }
}
