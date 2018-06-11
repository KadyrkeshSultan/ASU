namespace ASU.DTO.Filters
{
    public class BaseEntityFilter : BaseSearchFilter
    {
        public string OwnerId { get; set; }
        public string ParentId { get; set; }
        public string[] Types { get; set; }

        public BaseEntityFilter()
        {

        }
    }
}
