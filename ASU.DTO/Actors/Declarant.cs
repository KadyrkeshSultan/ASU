namespace ASU.DTO.Actors
{
    /// <summary>
    /// Заявитель
    /// </summary>
    public class Declarant : BaseTypedActor
    {
        public string Address { get; set; }
        public string IIN { get; set; }
        public string Phone { get; set; }

        public override string RoleMnemo => "ActorRoles_Declarant";

        public Declarant()
        {

        }
    }
}
