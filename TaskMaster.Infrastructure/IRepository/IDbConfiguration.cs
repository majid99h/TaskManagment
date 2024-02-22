using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface IDbConfiguration
    {
        string? ConnectionString { get; }
        IDbConnection CreateConnection();
    }
}
