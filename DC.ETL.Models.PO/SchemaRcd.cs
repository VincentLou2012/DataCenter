﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class SchemaRcd : OPRecord
    {
        public int SchemaID { get; set; }
        public virtual Schema _theSchema { get; set; }
    }
}
