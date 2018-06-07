using System.Collections.Generic;

namespace ASU.DTO
{
    public class DynamicEntity : BaseDTO
    {
        public IList<DynamicEntityParam> Params { get; set; }

        public DynamicEntity()
        {

        }
    }
}
