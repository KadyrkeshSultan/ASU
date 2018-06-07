namespace ASU.DTO.Documents
{
    public class DetailItem : BaseDTO
    {
        public int Begin { get; set; }
        public int End { get; set; }
        public int? Quarter { get; set; }
        public int? QuencherCount { get; set; }
        public DictionaryItemDTO Type { get; set; }
        public int Year { get; set; }

        public int Count => this.End - this.Begin + 1;

        public DetailItem()
        {

        }
    }
}
