﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class WholeStructureRcd : OPRecord
    {
        public System.Guid StructureSN { get; set; }

        public virtual WholeStructure _theStructure { get; set; }
    }
}
