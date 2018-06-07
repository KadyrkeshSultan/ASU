using System.Collections.Generic;

namespace ASU.DTO.Reports
{
    public class ReportDataPart : IReportDataPart
    {
        public IList<string> Columns { get; protected set; }
        public IList<Row> Rows { get; set; }
        public int Count => this.Rows.Count;

        public IReportDataPartRow this[int row] => this.Rows[row];

        public string Mnemo { get; set; }
        public string Name { get; set; }

        public ReportDataPart()
        {

        }

        //public void Init(string name, DataTable data)
        //{
        //    this.Name = name;
        //    this.Mnemo = data.TableName;
        //    this.Columns = new List<string>(data.Columns.Count);
        //    for (int i = 0; i < data.Columns.Count; i++)
        //    {
        //        this.Columns.Add(data.Columns[i].ColumnName);
        //    }
        //    this.Rows = new List<Row>(data.Rows.Count);
        //    for (int j = 0; j < data.Rows.Count; j++)
        //    {
        //        this.Rows.Add(new Row(this.Columns, ((IEnumerable<object>)data.Rows[j].ItemArray).Select<object, object>((object p) => {
        //            if (!(p is DBNull))
        //            {
        //                return p;
        //            }
        //            return null;
        //        }).ToArray<object>()));
        //    }
        //}

        public override string ToString()
        {
            return string.Format($"{this.Name} ({this.Mnemo}) : {this.Rows.Count}");
        }
    }
}
