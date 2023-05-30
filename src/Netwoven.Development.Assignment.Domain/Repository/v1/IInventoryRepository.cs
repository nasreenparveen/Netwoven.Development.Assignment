using Netwoven.Development.Assignment.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netwoven.Development.Assignment.Domain.Repository.v1
{
    internal interface IInventoryRepository
    {
        DataTable ReadFile(string filename);
        int WriteToDB();
        IEnumerable<Inventory> GetAllAsync();
        Inventory GetById(int id);
    }
}
