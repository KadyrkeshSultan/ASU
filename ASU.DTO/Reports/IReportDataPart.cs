namespace ASU.DTO.Reports
{
    public interface IReportDataPart
    {
        IReportDataPartRow this[int row] { get; }
        string Mnemo { get; set; }
        string Name { get; set; }
    }
}
