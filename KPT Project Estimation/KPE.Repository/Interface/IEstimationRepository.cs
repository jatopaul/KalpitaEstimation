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
        Task<IEnumerable<StoryName>> GetAll();
    }
}
