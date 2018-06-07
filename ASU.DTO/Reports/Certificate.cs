using ASU.DTO.Actors;
using ASU.DTO.Documents;
using System;

namespace ASU.DTO.Reports
{
    public class Certificate
    {
        public string Ambiguity { get; set; }
        public Attachment[] Attachments { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string CertificateNumber { get; set; }
        public string Class { get; set; }
        public string Client { get; set; }
        public string Code { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Device Device { get; set; }
        public string DKP { get; set; }
        public decimal DocId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Methodology { get; set; }
        public bool Russian { get; set; }
        public Stamp[] Stamps { get; set; }
        public string VerificationObjects { get; set; }
        public Verificator Verificator { get; set; }

        public Certificate()
        {

        }
    }
}
