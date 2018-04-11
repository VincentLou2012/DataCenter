using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class TaskRcd : OPRecord
    {
        public System.Guid TaskSN { get; set; }
        public virtual Task _theTask { get; set; }
    }
}
