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



        /*[Route("Addconnection")]
        [HttpPost]
        public async Task<ActionResult<bool>> AddRole([FromForm] ConnectionString connectionString)
        {
            return await _connectionService.AddConnection(connectionString);
        }*/
        [Route("Roles")]
        [HttpGet]
        public async Task<ActionResult<List<StoryName>>> GetAll()
        {



            return await _estimationService.GetAll();
        }
    }
}
