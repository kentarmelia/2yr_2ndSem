using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task_Scheduler
{
    class clsMessage
    {
       static string title;
       static string trigger;
       static string setDate;
       static DateTime setAlarm;
       static int recurD;
       static int recurW;
       static int[] day = new int[6];
       static string messTitle;
       static string description;

        public static string Title { get => title; set => title = value; }
        public static string Trigger { get => trigger; set => trigger = value; }
        public static string SetDate { get => setDate; set => setDate = value; }
        public static DateTime SetAlarm { get => setAlarm; set => setAlarm = value; }
        public static int RecurD { get => recurD; set => recurD = value; }
        public static int RecurW { get => recurW; set => recurW = value; }
        public static int[] Day { get => day; set => day = value; }
        public static string MessTitle { get => messTitle; set => messTitle = value; }
        public static string Description { get => description; set => description = value; }
    }
}
