namespace ASU.DTO.Reports
{
    public class ReportBase : ReportDataPart
    {
        public ReportDataPart Settings { get; set; }

        public ReportBase()
        {
            this.Settings = new ReportDataPart();
        }

        //public void Init(string settingsName, DataTable settings, string name, DataTable data)
        //{
        //    base.Init(name, data);
        //    this.Settings = new ReportDataPart();
        //    this.Settings.Init(settingsName, settings);
        //}
    }
}
