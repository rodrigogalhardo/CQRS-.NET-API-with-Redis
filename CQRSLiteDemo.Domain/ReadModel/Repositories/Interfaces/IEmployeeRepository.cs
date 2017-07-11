﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSLiteDemo.Domain.ReadModel.Repositories.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<EmployeeRM>
    {
        IEnumerable<EmployeeRM> GetAll();
    }
}
