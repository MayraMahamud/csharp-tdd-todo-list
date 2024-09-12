using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<string> tasks = new List<string>();
        public List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId;

        public TodoList()
        {
            _tasks = new List<TaskItem>();
            _nextId = 1;
        }

        public Guid AddTask3(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {

                var task = new TaskItem(description);
                task.Id = Guid .NewGuid();  
                _tasks.Add(task);
                return task.Id;

               
            } return Guid.Empty;


        }
        public void AddTask2(string name, bool isComplete)
        {
            //_tasks.Add(new Task(name, isComplete));
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

       
        
        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }



        public List<string> GetTasks()
        {
            return tasks;
        }

        public string SeeAllTasks(string tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task}");

            }
            return tasks;

        }

       
       

        public void DisplayTasks()
        {
            foreach(var task in tasks)
            {
                //Console.WriteLine($"Task:{task.Name}, Status: {(task.IsComplete ? "Complete" : "Incomplete")}");
            }
        }

        public List<TaskItem> GetCompleteTasks()
        {
            return _tasks.Where(task => !task.IsComplete).ToList();  
           

        }

        public List<TaskItem> GetIncompleteTasks()
        {
            return _tasks.Where(task => task.IsComplete).ToList();


        }

        public void TaskStatus(string taskName) 
        {
            foreach( var task in _tasks) 
            {
                if(task.Name == taskName)
                {
                    task.IsComplete = !task.IsComplete; 
                }

            }

        }

        public string SearchTask(string taskName) 
        {
            foreach(var tasks in _tasks)
            {
                if (tasks.Name == taskName)
                {
                    return $"Task {taskName} found";
                }
            }
            return $"Task '{taskName}' not found";  
        }

        public List<TaskItem> GetTasksAlphabeticalDesc() 
        {
            return _tasks.OrderByDescending(task => task.Name).ToList();    
        }


        public List<TaskItem> GetTasksAlphabeticalAsc()
        {
            return _tasks.OrderBy(task => task.Name).ToList();
        }


        public TaskItem GetTaskById(Guid id)
        {
            foreach (var task in _tasks) 
            {
                if(task.Id == id)
                {  
                    return task;
                }   
            }
            return null;
           
        }




    }
}


  



