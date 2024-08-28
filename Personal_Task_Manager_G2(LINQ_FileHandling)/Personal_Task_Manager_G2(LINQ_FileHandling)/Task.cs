using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager_G2_LINQ_FileHandling_
{
    //Task class to represent an individual task with description & status
  public class Task
    {
        //Description of the task
        public string Description {  get; set; }
        
        //Indicates whether the task is completed
        public bool IsCompleted { get; set; }

    }
}
