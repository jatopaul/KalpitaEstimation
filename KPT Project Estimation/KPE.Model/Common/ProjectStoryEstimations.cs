using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Model.Common
{
    public class ProjectStoryEstimations
    {
        public int ProjectStoryEstimationID { get; set; }
        public int ProjectId { get; set; }
        public int StoryId { get; set; }
        public int VerionNo { get; set; }
        public int CategpryId { get; set; }
        public float CutomTotal { get; set; }
        public float CountOfModules { get; set; }
        public String ProjectStoryEstimationDescription { get; set; }

        public DateTime AddDate { get; set; }
        public String AddBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
