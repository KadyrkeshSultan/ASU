namespace ASU.DTO.Filters
{
    public class UserFilter : BaseFilter
    {
        public decimal? OrganizationId { get; set; }

        public UserFilter()
        {
            base.MaxCount = 5000;
        }
    }
}
