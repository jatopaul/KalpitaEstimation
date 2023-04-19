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
        Task<List<StoryName>> GetAll();
    }
}
