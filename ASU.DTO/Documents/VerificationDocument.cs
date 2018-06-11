using ASU.DTO.Actors;
using ASU.DTO.Entities;
using System;
using System.Collections.Generic;

namespace ASU.DTO.Documents
{
    public class VerificationDocument : BaseDetailedDocument
    {
        public IList<Attachment> Attachments { get; set; }
        public Declarant Declarant { get; set; }
        public string DKP { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public MeasureDevice MeasureDevice { get; set; }
        public decimal? Parent { get; set; }
        public string VerificationComment { get; set; }
        public IList<VerificationDevice> VerificationDevices { get; set; }
        public SimpleDTO VerificationPassing { get; set; }

        public VerificationDocument()
        {
            this.Attachments = new List<Attachment>();
        }

        public void CalcExpirationDate(DateTime? dateDoc)
        {
            if (base.Details.Count <= 0)
            {
                this.ExpirationDate = null;
                return;
            }
            if (this.MeasureDevice.VerificationGap.Code == 0)
            {
                this.ExpirationDate = null;
                return;
            }
            if (dateDoc.HasValue)
            {
                DateTime value = dateDoc.Value;
                this.ExpirationDate = new DateTime?(value.AddMonths(this.MeasureDevice.VerificationGap.Code));
            }
        }
    }
}
