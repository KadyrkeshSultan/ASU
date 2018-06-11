namespace ASU.DTO.Filters
{
    public class UserFilter : BaseFilter
    {
        public string OrganizationId { get; set; }

        public UserFilter()
        {
            base.MaxCount = 5000;
        }
    }
}
