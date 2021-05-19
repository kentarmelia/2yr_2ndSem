using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task_Scheduler
{
    public class clsMessage
    {
       public string title { get; set; }
       public string trigger { get; set; }
       public string Action { get; set; }
       public string setDate { get; set; }
       public DateTime setAlarm { get; set; }
       public int recurD { get; set; }
       public int recurW { get; set; }   
       private int[] day = new int[6];
        public string triggerview { get; set; }
        public string messTitle { get; set; }
       public string message { get; set; }
        public string created { get; set; }
        public int[] Day { get => day; set => day = value; }
        public int mon { get; set; }
        public int tue { get; set; }
        public int wed { get; set; }
        public int thu { get; set; }
        public int fri { get; set; }
        public int sat { get; set; }
        public int sun { get; set; }
        public int remaindingRW { get; set; }
    }
}
