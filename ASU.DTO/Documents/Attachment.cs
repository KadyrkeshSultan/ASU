﻿namespace ASU.DTO.Documents
{
    public class Attachment : BaseDTO
    {
        public string File { get; set; }
        public byte[] FileData { get; set; }
        public string Name { get; set; }
        public Attachment()
        {

        }
    }
}
