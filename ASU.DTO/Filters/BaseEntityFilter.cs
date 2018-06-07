namespace ASU.DTO.Filters
{
    public class BaseEntityFilter : BaseSearchFilter
    {
        public decimal? OwnerId { get; set; }
        public decimal? ParentId { get; set; }
        public string[] Types { get; set; }

        public BaseEntityFilter()
        {

        }
    }
}
