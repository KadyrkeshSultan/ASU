using ASU.DTO.Actors;

namespace ASU.DTO
{
    public class User : BaseDTO
    {
        public bool IsActive { get; set; }
        public string Login { get; set; }
        public BaseActor Organization { get; set; }
        public string Password { get; set; }
        public BaseActor Person { get; set; }

        public User()
        {

        }

        //public static string ComputeHash(string input)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    MD5 mD5 = MD5.Create();
        //    byte[] bytes = Encoding.UTF8.GetBytes(input);
        //    bytes = mD5.ComputeHash(bytes, 0, (int)bytes.Length);
        //    byte[] numArray = bytes;
        //    for (int i = 0; i < (int)numArray.Length; i++)
        //    {
        //        byte num = numArray[i];
        //        stringBuilder.Append(num.ToString("x2"));
        //    }
        //    return stringBuilder.ToString();
        //}
    }
}
