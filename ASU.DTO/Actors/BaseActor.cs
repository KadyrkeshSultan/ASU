namespace ASU.DTO.Actors
{
    public class BaseActor : BaseDTO
    {
        public string Mnemo { get; set; }
        public string Name { get; set; }
        public string OriginalId { get; set; }

        public BaseActor()
        {

        }

        //public BaseActor ToBase()
        //{
        //    BaseActor baseActor = new BaseActor()
        //    {
        //        Id = base.Id,
        //        Name = this.Name,
        //        Mnemo = this.Mnemo
        //    };
        //    return baseActor;
        //}
    }
}
