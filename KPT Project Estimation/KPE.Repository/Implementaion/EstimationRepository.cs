using KPE.Model.Common;
using KPE.Model.DbModel;
using KPE.Repository.Infrastructure.Interface;
using KPE.Repository.Interface;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Repository.Implementaion
{
    public class EstimationRepository : BaseRepository, IEstimationRepository
    {
        public EstimationRepository(
          IOptions<DatabaseAdvancedSettingOptions> settingsOptions,
                     IQueryBuilder queryBuilder,
          IUnitOfWork unitOfWork) : base(settingsOptions, queryBuilder, unitOfWork)
        {
            //_unitOfWork = unitOfWork;//
        }

        /*public async Task<bool> AddConnection(ConnectionString connectionstring)
        {
            var conquery = new
            {
                Connectionquery = connectionstring.Connectionquery               
            };
            await QueryProcedureAsync<ConnectionString>("",conquery);
            return true;
        }*/
        public async Task<IEnumerable<StoryName>> GetAll()
        {
            return await QueryProcedureAsync<StoryName>("[dbo].[spStoryNames]");
        }

    }
}
