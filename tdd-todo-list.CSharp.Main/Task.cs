using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }


        public Task(string name, bool isComplete = false)
        {
             Name = name;
            IsComplete = isComplete;   
        }



       

        

    }

    

    


}
