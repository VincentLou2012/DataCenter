using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    /// <summary>
    /// 数据源地址
    /// </summary>
    class SourceAddress
    {
        //地址ID
        [Key]
        public int ID { get; set; }
        //名称
        public string Name { get; set; }
        //地址字符串
        public string Address { get; set; }
        //操作记录
        public virtual ICollection<AdressRcd> Records { get; set; }
    }
}
