namespace ASU.DTO.Actors
{
    public abstract class BaseTypedActor : BaseActor
    {
        public abstract string RoleMnemo { get; }

        protected BaseTypedActor()
        {

        }
    }
}
