namespace ASU.DTO.Actors
{
    public class SystemUser : BaseTypedActor
    {
        public override string RoleMnemo => "ActorRoles_SystemUser";

        public BaseActor Organization { get; set; }

        public SystemUser()
        {

        }
    }
}
