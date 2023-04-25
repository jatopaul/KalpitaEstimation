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

        //Story Get_Method
        //public async Task<IEnumerable<StoryName>> GetAll()
        //{
        //    return await QueryProcedureAsync<StoryName>("[dbo].[usp_Get_StoryNames]");
        //}
        public async Task<IEnumerable<StoryNames>> GetAll()
        {
            return await QueryProcedureAsync<StoryNames>("[dbo].[usp_GetStoryNames]");
        }
        //Story Post_Method
        public async Task<bool> AddStoryDiscription(StoryNames InsertStory)
        {
            var SubmitData = new
            {
                StoryName = InsertStory.StoryName,
                StoryDiscription = InsertStory.StoryDiscription,
                AddBy = InsertStory.AddBy,
                IsDeleted = InsertStory.IsDeleted,
                ProjectId = InsertStory.ProjectId,
            };
            await QueryProcedureAsync<StoryNames>("[dbo].[usp_PostStoryNames]", SubmitData);
            return true;
        }

        //Story Put_Method
        public async Task<bool>UpdateStoryTable(StoryNames UpdateStory)

        {
            var SubmitData = new
            {
                StoryId = UpdateStory.StoryId,
                StoryName = UpdateStory.StoryName,
                StoryDiscription = UpdateStory.StoryDiscription,
                Addby = UpdateStory.AddBy,
                IsDeleted = UpdateStory.IsDeleted,
                ProjectId = UpdateStory.ProjectId,
            };
            await QueryProcedureAsync<StoryNames>("[dbo].[usp_PutStoryNames]", SubmitData);
            return true;
        }


        public async Task<bool> DeleteStoryById(int Id)
        {
            var Data = new
            {
                //Action = "DELETE",
                StoryId = Id
            };
            await QueryProcedureAsync<StoryNames>("[dbo].[usp_DeleteStoryNames]", Data);
            return true;
        }


    }
}
