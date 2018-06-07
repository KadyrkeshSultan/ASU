namespace ASU.DTO
{
    public class SimpleDTO : BaseDTO
    {
        public string Mnemo { get; set; }
        public string Name { get; set; }

        public SimpleDTO()
        {
        }

        //public override string ToString()
        //{
        //    return this.Name;
        //}
    }
}
