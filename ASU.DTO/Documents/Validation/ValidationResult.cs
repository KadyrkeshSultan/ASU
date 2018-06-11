using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO.Documents.Validation
{
    public class ValidationResult
    {
        public string Code { get; set; }
        public string String { get; set; }
        public eResult Result
        {
            get
            {
                if (this.Code == new string(0))
                {
                    return eResult.Ok;
                }
                if (this.Code >= new string(0))
                {
                    return eResult.Warning;
                }
                return eResult.Error;
            }
        }
        public ValidationResult()
        {

        }
    }
}
