using System;

namespace ASU.DTO.Reports
{
    public class Attestation :HeaderedReportBase
    {
        public const string ColumnVerificator = "NAM_Verificator";
        public DateTime StartDate => Convert.ToDateTime(base.Header[0]["DTM_Start"]);
        public DateTime EndDate => Convert.ToDateTime(base.Header[0]["DTM_End"]);
        public string HeaderVerificator => base.Header[0]["NAM_Verificator"] as string;

        public Attestation()
        {

        }
    }
}
