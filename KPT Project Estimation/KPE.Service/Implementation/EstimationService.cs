using KPE.Model.Common;
using KPE.Repository.Interface;
using KPE.Service.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Service.Implementation
{
    public class EstimationService: IEstimationService
    {
        private readonly IEstimationRepository _estimationRepository;
        public EstimationService(IEstimationRepository estimationRepository, IConfiguration configuration)
        {
            _estimationRepository = estimationRepository ?? throw new ArgumentNullException(nameof(_estimationRepository));
        }
        //public async Task<bool> AddConnection(ConnectionString connectionstring)
        //{
        //    return await _connectionRepository.AddConnection(connectionstring);
        //}


        //Story Get_Method

        public async Task<List<StoryNames>> GetAll()
        {
            IEnumerable<StoryNames> user;
            user = await _estimationRepository.GetAll();
            return user.ToList();
        }

        public async Task<List<ProjectStoryEstimations>> GetProjectEstimation()
        {
            IEnumerable<ProjectStoryEstimations> user;
            user = await _estimationRepository.GetProjectEstimation();
            return user.ToList();
        }



        //Story Post_Method
        public async Task<ResponseModel<bool>> AddStoryDiscription(StoryNames InsertStory)
        {
            bool isValidRequest = false;
            //TicketDetail dataexists = await _ticketRepository.GetTicketinfoById(ticketComment.TicketID);
            //if (dataexists.TicketData.CreatedByEmail.Equals(ticketComment.UserEmail, StringComparison.OrdinalIgnoreCase)
            //    || dataexists.TicketData.AssignedToEmail.Equals(ticketComment.UserEmail, StringComparison.OrdinalIgnoreCase))
            //{
            //    isValidRequest = await _ticketRepository.AddTicketComment(ticketComment);
            //}
            isValidRequest = await _estimationRepository.AddStoryDiscription(InsertStory);
            var res = new ResponseModel<bool>();
            if (isValidRequest)
            {
                res.IsError = !isValidRequest;
                res.Message = "Comment added successfully";
                res.Data = isValidRequest;
            }
            else
            {
                res.IsError = !isValidRequest;
                res.Message = "Error in adding the Comment";
                res.Data = isValidRequest;
            }
            return res;
        }






        //
        public async Task<ResponseModel<bool>> PostProjectEstimation(ProjectStoryEstimations InsertProjectEstimation)
        {
            bool isValidRequest = false;

            isValidRequest = await _estimationRepository.PostProjectEstimation(InsertProjectEstimation);
            var res = new ResponseModel<bool>();
            if (isValidRequest)
            {
                res.IsError = !isValidRequest;
                res.Message = "Comment added successfully";
                res.Data = isValidRequest;
            }
            else
            {
                res.IsError = !isValidRequest;
                res.Message = "Error in adding the Comment";
                res.Data = isValidRequest;
            }
            return res;
        }


















        //Story Put_Method
        public async Task<ResponseModel<bool>> UpdateStoryTable(StoryNames UpdateStory)
        {
            bool isValidRequest = false;

            isValidRequest = await _estimationRepository.UpdateStoryTable(UpdateStory);
            var res = new ResponseModel<bool>();
            if (!isValidRequest)
            {
                res.IsError = !isValidRequest;
                res.Message = "Story Updated successfully";
                res.Data = isValidRequest;
            }
            else
            {
                res.IsError = !isValidRequest;
                res.Message = "Error in Updating Stories";
                res.Data = isValidRequest;
            }
            return res;
        }







        //Story Put_Method
        public async Task<ResponseModel<bool>>  UpdateProjectEstimation(ProjectStoryEstimations UpdateProjectEstimation)
        {
            bool isValidRequest = false;

            isValidRequest = await _estimationRepository.UpdateProjectEstimation(UpdateProjectEstimation);
            var res = new ResponseModel<bool>();
            if (!isValidRequest)
            {
                res.IsError = !isValidRequest;
                res.Message = "Story Updated successfully";
                res.Data = isValidRequest;
            }
            else
            {
                res.IsError = !isValidRequest;
                res.Message = "Error in Updating Stories";
                res.Data = isValidRequest;
            }
            return res;
        }






        //Story Delete_Method
        public async Task<ResponseModel<bool>> DeleteStoryById(int Id)
        {
            string message = "Story deleted successfully";
            bool isError = false;
            await _estimationRepository.DeleteStoryById(Id);
            var res = new ResponseModel<bool>()
            {
                IsError = isError,
                Message = message,
                Data = !isError
            };
            return res;
        }






        //Story Delete_Method
        public async Task<ResponseModel<bool>> DeleteProjectEstimationById(int Id)
        {
            string message = "Story deleted successfully";
            bool isError = false;
            await _estimationRepository.DeleteProjectEstimationById(Id);
            var res = new ResponseModel<bool>()
            {
                IsError = isError,
                Message = message,
                Data = !isError
            };
            return res;
        }
    }
}
