using System;
using System.Collections.Generic;

namespace BestBuyPractices2
{
    public interface IDpartmentRepository
    {
        public IEnumerable<Departments> GetAllDepartments();

        public void InsertDepartment(string newDepartmentName);
    }
}

