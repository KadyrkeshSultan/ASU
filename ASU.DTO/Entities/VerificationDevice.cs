using System;

namespace ASU.DTO.Entities
{
    public class VerificationDevice : BaseEntity
    {
        public string AdditionalInfo { get; set; }
        public string DKP { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public VerificationDevice()
        {

        }
    }
}
