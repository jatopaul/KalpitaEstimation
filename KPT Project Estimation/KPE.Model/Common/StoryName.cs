using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.Model.Common
{
    public class StoryName
    {

        public int Story_ID { get; set; }

        public string? Story_Name { get; set; }

        public string Story_Discription { get; set; }

        public DateTime Add_Date { get; set; }
        public string AddBy { get; set; }
        public DateTime Modified_Date { get; set; }

        public bool Is_Deleted { get; set; }

        public int Project_Id { get; set; }




    }
}
