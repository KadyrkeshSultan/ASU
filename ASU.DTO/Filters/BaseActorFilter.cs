namespace ASU.DTO.Filters
{
    public class BaseActorFilter : BaseSearchFilter
    {
        public decimal? OwnerId { get; set; }
        public string[] Roles { get; set; }

        public BaseActorFilter()
        {

        }
    }
}
