namespace ASU.DTO.Filters
{
    public class BaseFilter
    {
        public int MaxCount { get; set; }

        public BaseFilter()
        {
            this.MaxCount = 1000;
        }
    }
}
