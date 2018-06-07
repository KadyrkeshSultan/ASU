using ASU.DTO.Actors;
using System;
using System.Collections.Generic;

namespace ASU.DTO.Documents
{
    public class AttestationDocument : BaseDetailedDocument
    {
        public string AccCert { get; set; }
        public IList<Attachment> Attachments { get; set; }
        public DateTime? AttestationDate { get; set; }
        public SimpleDTO AttestationType { get; set; }
        public string Attestator { get; set; }
        public Declarant Declarant { get; set; }
        public string Director { get; set; }
        public DateTime? ExpirationAttDate { get; set; }

        //TODO : Manufature
        public string ManufatureDate { get; set; }
        public BaseActor Metrology { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string NormativeDocs { get; set; }
        public string Producer { get; set; }
        public string WorkNumber { get; set; }

        public AttestationDocument()
        {

        }
    }
}
