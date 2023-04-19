using KPE.Repository.Infrastructure.Interface;

namespace KPE.Repository.Infrastructure
{
    public class SqlQueryBuilder : IQueryBuilder
    {
        public string GetAllQuery(string tablename)
        {
            return $"select * from{tablename}";
        }
    }
}
