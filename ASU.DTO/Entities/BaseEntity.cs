using ASU.DTO.Actors;

namespace ASU.DTO.Entities
{
    public class BaseEntity : SimpleDTO
    {
        public BaseActor Author { get; set; }
        public string Note { get; set; }
        public decimal OriginalId { get; set; }
        public BaseActor Owner { get; set; }
        public BaseEntity Parent { get; set; }

        public BaseEntity()
        {

        }

        //public BaseEntity ToBase()
        //{
        //    BaseEntity baseEntity = new BaseEntity()
        //    {
        //        Name = base.Name,
        //        Mnemo = base.Mnemo,
        //        Author = this.Author,
        //        Owner = this.Owner,
        //        Parent = this.Parent,
        //        Id = base.Id,
        //        Note = this.Note,
        //        OriginalId = this.OriginalId
        //    };
        //    return baseEntity;
        //}
    }
}
