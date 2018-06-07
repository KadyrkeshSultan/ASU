namespace ASU.DTO
{
    public class DynamicEntityParam
    {
        public string Caption { get; set; }
        public bool IsEmpty => this.Value == null;
        public int MaxLength { get; set; }
        public string Mnemo { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }

        public DynamicEntityParam()
        {

        }
    }
}