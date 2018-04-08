using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    /// <summary>
    /// 数据模式
    /// </summary>
    public class Schema
    {
        //模式序列
        [Key]
        public System.Guid SchemaSN{ get; set; }
        //数据源序列
        public Nullable<System.Guid> SourceSN { get; set; }
        //模式名
        public string SchemaName { get; set; }
        //方面,主题标识
        public string Aspect { get; set; }
        //关键词
        public string Keywords { get; set; } 
        //备注
        public string Comments { get; set; }
        //操作记录
        public virtual ICollection<SchemaRcd> Records { get; set; }

      
    }
}
