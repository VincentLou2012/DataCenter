﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.ETL.Models.PO
{
    public class DataSourceRcd : OPRecord
    {
        public virtual DataSource _theDS { get; set; }
    }
}
