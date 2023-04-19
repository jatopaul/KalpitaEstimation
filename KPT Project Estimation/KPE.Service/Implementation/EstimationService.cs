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
        /*public async Task<bool> AddConnection(ConnectionString connectionstring)
        {
            return await _connectionRepository.AddConnection(connectionstring);
        }*/
        public async Task<List<StoryName>> GetAll()
        {
            IEnumerable<StoryName> user;
            user = await _estimationRepository.GetAll();
            return user.ToList();
        }

        
    }
}
