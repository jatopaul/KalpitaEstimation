using KPE.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Service.Interface
{
    public interface IEstimationService
    {
        Task<List<StoryNames>> GetAll();

        Task<ResponseModel<bool>> AddStoryDiscription(StoryNames InsertStory);
        Task<ResponseModel<bool>> UpdateStoryTable(StoryNames UpdateStory);
        Task<ResponseModel<bool>> DeleteStoryById(int Id);

    }
}
