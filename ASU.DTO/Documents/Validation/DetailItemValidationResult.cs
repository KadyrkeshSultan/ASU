namespace ASU.DTO.Documents.Validation
{
    public class DetailItemValidationResult : ValidationResult
    {
        public int Begin { get; set; }
        public int End { get; set; }
        public int Count => this.End - this.Begin + 1;
        public int? Quarter { get; set; }
        public DictionaryItemDTO StampType { get; set; }
        public int Year { get; set; }

        public DetailItemValidationResult()
        {

        }
    }
}
