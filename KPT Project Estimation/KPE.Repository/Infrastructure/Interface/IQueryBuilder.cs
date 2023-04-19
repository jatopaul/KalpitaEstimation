using System;
using System.Collections.Generic;
using System.Text;

namespace KPE.Repository.Infrastructure.Interface
{
    public interface IQueryBuilder
    {
        string GetAllQuery(string tablename);
    }
}
