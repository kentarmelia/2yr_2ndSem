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
       public string setAlarm { get; set; }
       public string recurD { get; set; }
       public string recurW { get; set; }   
       private int[] day = new int[6];
        public string triggerview { get; set; }
        public string messTitle { get; set; }
       public string message { get; set; }
        public string created { get; set; }
        public int[] Day { get => day; set => day = value; }
        public string mon { get; set; }
        public string tue { get; set; }
        public string wed { get; set; }
        public string thu { get; set; }
        public string fri { get; set; }
        public string sat { get; set; }
        public string sun { get; set; }
        public string emFrom { get; set; }
        public string emTo { get; set; }
        public string emServer { get; set; }
        public string emPass { get; set; }
        public string emAttach { get; set; }
    }
}
