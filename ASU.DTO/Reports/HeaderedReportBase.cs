using System;

namespace ASU.DTO.Reports
{
    public class HeaderedReportBase : ReportBase
    {
        public string Caption => this.Header[0]["NAM_Caption"] as string;
        public DateTime Date => Convert.ToDateTime(this.Header[0]["DTM_Date"]);
        public ReportDataPart Header { get; set; }
        public HeaderedReportBase()
        {
            this.Header = new ReportDataPart();
        }

        //public void Init(string settingsName, DataTable settings, string headerName, DataTable header, string name, DataTable data)
        //{
        //    base.Init(settingsName, settings, name, data);
        //    this.Header = new ReportDataPart();
        //    this.Header.Init(headerName, header);
        //}
    }
}
