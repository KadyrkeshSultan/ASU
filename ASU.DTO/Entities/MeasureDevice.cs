namespace ASU.DTO.Entities
{
    /// <summary>
    /// Средство измерения
    /// </summary>
    public class MeasureDevice : BaseEntity
    {
        public string AllowedByCat { get; set; }
        public string AllowedByClass { get; set; }
        public string AllowedByRandom { get; set; }
        public string MDProducer { get; set; }
        public string MDProductionDate { get; set; }
        public string MeasurmentRange { get; set; }

        public string Number => base.Name;
        public string QualifiedName { get; set; }

        //public string Type => $"{this.QualifiedName} - {base.Mnemo}";
        public MeasurementType MeasurementType { get; set; }
        public string MeasurementTypeId { get; set; }
        /// <summary>
        /// Межпроверочный интервал
        /// </summary>
        public DictionaryItemDTO VerificationGap { get; set; }
        public string VerificationProc { get; set; }

        public MeasureDevice()
        {

        }

        //public MeasureDevice(MeasureDevice item)
        //{
        //    base.OriginalId = item.Id;
        //    base.Owner = item.Owner;
        //    this.AllowedByCat = item.AllowedByCat;
        //    this.AllowedByClass = item.AllowedByClass;
        //    this.AllowedByRandom = item.AllowedByRandom;
        //    this.MDProducer = item.MDProducer;
        //    this.MDProductionDate = item.MDProductionDate;
        //    this.MeasurmentRange = item.MeasurmentRange;
        //    base.Mnemo = item.Mnemo;
        //    base.Name = item.Name;
        //    base.Note = item.Note;
        //    base.Parent = item.Parent;
        //    this.VerificationGap = item.VerificationGap;
        //    this.QualifiedName = item.QualifiedName;
        //    this.VerificationProc = item.VerificationProc;
        //}
    }
}
