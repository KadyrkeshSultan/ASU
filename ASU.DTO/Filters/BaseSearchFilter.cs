namespace ASU.DTO.Filters
{
    public class BaseSearchFilter : BaseFilter
    {
        public string SearchString { get; set; }

        public BaseSearchFilter()
        {

        }

        public static string MakeLikeRequest(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            if (text.Contains("%"))
                return text;
            return string.Concat('%', text.Trim(), '%');
        }
    }
}
