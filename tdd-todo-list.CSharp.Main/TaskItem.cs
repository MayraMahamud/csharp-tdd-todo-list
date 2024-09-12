using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public Guid Id { get; set; } 
        public string Description { get; set; } 


        public TaskItem(string description /*string name, int id, bool isComplete = false*/)
        {
           
            Description = description;  
            IsComplete = false;
            Id = Guid.NewGuid();
        }



       

        

    }

    

    


}
