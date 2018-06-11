namespace ASU.DTO.Filters
{
    public class BaseActorFilter : BaseSearchFilter
    {
        public string OwnerId { get; set; }
        public string[] Roles { get; set; }

        public BaseActorFilter()
        {

        }
    }
}
