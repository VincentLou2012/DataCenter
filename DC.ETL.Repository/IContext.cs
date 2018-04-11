using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DC.ETL.Repository
{
    public interface IContext
    {
        void InitContext();
        void SetContext(DbContext context);
        DbContext NewContext();
        DbContext GetContext();
        void Dispose();
    }
}
