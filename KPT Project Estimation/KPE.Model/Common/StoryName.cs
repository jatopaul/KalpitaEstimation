using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Model.Common
{
    public class StoryNames
    {
        public int StoryId { get; set; }
        public string? StoryName { get; set; }

        public string? StoryDiscription { get; set; }    
        public string? AddBy { get; set; }
        public bool IsDeleted { get; set; }
        public int ProjectId { get; set; }




    }
}
