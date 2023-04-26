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


        [Route("Addconnection")]
        [HttpPost]
        public async Task<ResponseModel<bool>> AddStoryDiscription(StoryNames InsertStory)
        {
            return  await _estimationService.AddStoryDiscription(InsertStory);
             
        }

        [Route("StoryUpdate")]
        [HttpPut]
        public async Task<ResponseModel<bool>>UpdateStoryTable(StoryNames UpdateStory)
        {
            return await _estimationService.UpdateStoryTable(UpdateStory);
        }

        [Route("DeleteStoryById/{Id}")]
        [HttpDelete]
        public async Task<ResponseModel<bool>> DeleteStoryById(int Id)
        {
            return await _estimationService.DeleteStoryById(Id);
        }



    }
}
