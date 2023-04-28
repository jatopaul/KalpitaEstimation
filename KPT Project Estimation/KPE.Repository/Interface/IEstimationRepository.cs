using KPE.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Repository.Interface
{
    public interface IEstimationRepository
    {
        Task<IEnumerable<StoryNames>> GetAll();
        Task<IEnumerable<ProjectStoryEstimations>> GetProjectEstimation();
        Task<bool> AddStoryDiscription(StoryNames InsertStory);



        Task<bool> PostProjectEstimation(ProjectStoryEstimations InsertProjectEstimation);



        Task<bool> UpdateStoryTable(StoryNames UpdateStory);
        Task<bool> UpdateProjectEstimation(ProjectStoryEstimations UpdateProjectEstimation);
        Task<bool> DeleteStoryById(int Id);
        Task<bool> DeleteProjectEstimationById(int Id);

    }
}
