using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class AdressRcd : OPRecord
    {
        public virtual SourceAddress _theAddress { get; set; }
    }
}
