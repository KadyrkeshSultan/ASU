using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ASU.DTO.Reports
{
    public class Row : IReportDataPartRow
    {
        protected const string ElementName = "Row";
        protected static XmlSerializer _xmlSerializer;
        public IList<string> Columns { get; protected set; }
        public object[] Data { get; set; }

        public object this[string column]
        {
            get
            {
                return this.Data[this.Columns.IndexOf(column)]; ;
            }
            set
            {
                this.Data[this.Columns.IndexOf(column)] = value;
            }
        }

        public Row(IList<string> columns, object[] row)
        {
            this.Columns = columns;
            this.Data = row.ToArray<object>();
        }

        public Row(IList<string> columns)
        {
            this.Columns = columns;
            this.Data = new object[columns.Count];
        }
    }
}
