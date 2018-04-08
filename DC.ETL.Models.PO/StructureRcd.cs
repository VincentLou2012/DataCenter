using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class StructureRcd : OPRecord
    {
        public virtual Structure _theStructure { get; set; }
    }
}
