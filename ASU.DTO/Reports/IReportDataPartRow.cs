namespace ASU.DTO.Reports
{
    public interface IReportDataPartRow
    {
        object this[string column] { get; }
    }
}
