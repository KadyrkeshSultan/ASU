using ASU.DTO.Actors;
using ASU.DTO.Documents;
using System;

namespace ASU.DTO.Reports
{
    public class AttestationCertificate
    {
        public string Ambiguity { get; set; }
        public Attachment[] Attachments { get; set; }
        public DateTime? AttestationDate { get; set; }
        public string AttestationType { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string CertificateNumber { get; set; }
        public string Class { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Declarant { get; set; }
        public string DeviceName { get; set; }
        public string DKP { get; set; }
        public string DocId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsExtraordinary => this.AttestationType == "TeAttestationTypes_Extraordinary";
        public bool IsPeriodic => this.AttestationType == "TeAttestationTypes_Periodic";
        public bool IsPrimary => this.AttestationType == "TeAttestationTypes_Primary";
        public string ManufactureDate { get; set; }
        public string Methodology { get; set; }
        public string Model { get; set; }
        public string NormativeDocs { get; set; }
        public string Producer { get; set; }
        public bool Russian { get; set; }
        public string VerificationObjects { get; set; }
        public Verificator Verificator { get; set; }
        public string WorkNumber { get; set; }

        public AttestationCertificate()
        {

        }
    }
}
