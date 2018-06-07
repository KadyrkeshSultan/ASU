namespace ASU.DTO.Entities
{
    public class DeviceType : BaseEntity
    {
        public string AllowedByCat { get; set; }
        public string AllowedByClass { get; set; }
        public string AllowedByRandom { get; set; }
        public string DKP { get; set; }
        public string MDProducer { get; set; }
        public string MeasurmentRange { get; set; }

        /// <summary>
        /// Межпроверочный интервал
        /// </summary>
        public DictionaryItemDTO VerificationGap { get; set; }
        public string VerificationProc { get; set; }

        public DeviceType()
        {

        }

        //public DeviceType(DeviceType source)
        //{
        //    base.OriginalId = source.Id;
        //    this.AllowedByCat = source.AllowedByCat;
        //    this.AllowedByClass = source.AllowedByClass;
        //    this.AllowedByRandom = source.AllowedByRandom;
        //    this.DKP = source.DKP;
        //    this.MDProducer = source.MDProducer;
        //    this.MeasurmentRange = source.MeasurmentRange;
        //    base.Mnemo = source.Mnemo;
        //    base.Name = source.Name;
        //    base.Note = source.Note;
        //    base.Parent = source.Parent;
        //    this.VerificationGap = source.VerificationGap;
        //    this.VerificationProc = source.VerificationProc;
        //}
    }
}
