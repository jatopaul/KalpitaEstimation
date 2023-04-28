using KPE.Model.Common;
using KPE.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KPT_Project_Estimation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstimateController : ControllerBase
    {

        private readonly IEstimationService _estimationService;
        public EstimateController(IEstimationService estimationService)
        {
            _estimationService = estimationService ?? throw new ArgumentNullException(nameof(estimationService));
        }


        //[Route("Roles")]
        //[HttpGet]
        //public async Task<ActionResult<List<StoryName>>> GetAll()
        //{
        //    return await _estimationService.GetAll();
        //}

        [Route("Rules")]
        [HttpGet]
        public async Task<ActionResult<List<StoryNames>>> GetAll()
        {
            return await _estimationService.GetAll();
        }

        //Get method for ProjEstimationGet
        [Route("ProjEstimationGet")]
        [HttpGet]
        public async Task<ActionResult<List<ProjectStoryEstimations>>> GetProjectEstimation()
        {
            return await _estimationService.GetProjectEstimation();
        }



        [Route("Addconnection")]
        [HttpPost]
        public async Task<ResponseModel<bool>> AddStoryDiscription(StoryNames InsertStory)
        {
            return  await _estimationService.AddStoryDiscription(InsertStory);
             
        }




        [Route("ProjEstimationPost")]
        [HttpPost]
        public async Task<ResponseModel<bool>> PostProjectEstimation(ProjectStoryEstimations InsertProjectEstimation)
        {
            return await _estimationService.PostProjectEstimation(InsertProjectEstimation);

        }





        [Route("StoryUpdate")]
        [HttpPut]
        public async Task<ResponseModel<bool>>UpdateStoryTable(StoryNames UpdateStory)
        {
            return await _estimationService.UpdateStoryTable(UpdateStory);
        }



        [Route("ProjEstimationUpdate")]
        [HttpPut]
        public async Task<ResponseModel<bool>> UpdateProjectEstimation(ProjectStoryEstimations UpdateProjectEstimation)
        {
            return await _estimationService.UpdateProjectEstimation(UpdateProjectEstimation);
        }







        [Route("DeleteStoryById/{Id}")]
        [HttpDelete]
        public async Task<ResponseModel<bool>> DeleteStoryById(int Id)
        {
            return await _estimationService.DeleteStoryById(Id);
        }



        [Route("DeleteProjectEstimationById/{Id}")]
        [HttpDelete]
        public async Task<ResponseModel<bool>> DeleteProjectEstimationById(int Id)
        {
            return await _estimationService.DeleteProjectEstimationById(Id);
        }

    }
}
