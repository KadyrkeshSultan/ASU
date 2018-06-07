using ASU.DTO.Actors;

namespace ASU.DTO.Documents
{
    public class OrderDocument : BaseDatedDocument
    {
        public StampProducer Producer { get; set; }
        public string Reason { get; set; }

        public OrderDocument()
        {

        }
    }
}
