using System.Collections.Generic;

namespace ASU.DTO.Filters
{
    public class FilterData
    {
        public string Filter { get; set; }
        public Dictionary<string, object> Params { get; set; }

        public FilterData()
        {
            this.Params = new Dictionary<string, object>();
        }

        public static FilterData GetById(string filter, decimal id)
        {
            FilterData filterDatum = new FilterData()
            {
                Filter = filter,
                Params = new Dictionary<string, object>()
                {
                    { "UIN_ID", id }
                }
            };
            return filterDatum;
        }
    }
}
