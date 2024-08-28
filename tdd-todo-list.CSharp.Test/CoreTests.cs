using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        

        [Test]
        public void AddTaskTest()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Task1");

           
            Assert.Contains("Task1", todoList.GetTasks());
       
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");
            todoList.AddTask("Task2");


            todoList.RemoveTask("Task1");

            Assert.That(todoList.GetTasks().Count, Is.EqualTo(1));
           
            //Assert.Contains("Task1", todoList.GetTasks());
            //Assert.That(todoList.GetTasks, Is.EqualTo(0));
            //Assert.That(todoList.Count, Is.EqualTo(0));
            


        }










        [Test]
        public void SeeAllTaskTest()
        {
            TodoList todoList = new TodoList();
            var tasks = new List<string> { "Task1", "Task2" };

            //todoList.AddTask("Task1");
            //todoList.AddTask("Task2");

            var result = todoList.SeeAllTasks("tasks");

              
            Assert.That(result, Is.EquivalentTo("tasks"));
               
        }

         
        [Test]
        public void TaskStatus()
        {
            TodoList todoList = new TodoList();
           
            todoList.AddTask2("Task1", false);
            todoList.AddTask2("Task1", true);



            todoList.TaskStatus("Task1");

            var task = todoList.GetTasks().Find(t => t.Name == "Task1");


            Assert.IsTrue(task.IsComplete(), Is.True);







            //todoList.TaskStatus(taskName);

            //Assert.IsTrue(task.IsComplete);
        }


        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList todoList= new TodoList();
           
            todoList.AddTask2("Task1", false);
            todoList.AddTask2("Task2", true);
            todoList.AddTask2("Task2", true);

            List<Main.Task> completeTasks = todoList.GetCompleteTasks();

            Assert.That(completeTasks.Count, Is.EqualTo(1));   



        }


        [Test]
        public void GetIncompleteTasksTest()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask2("Task1", false);
            todoList.AddTask2("Task1", false);
            todoList.AddTask2("Task2", true);

            List<Main.Task> incompleteTasks = todoList.GetIncompleteTasks();

            Assert.That(incompleteTasks.Count, Is.EqualTo(1));


        }

        [Test]
        public void SearchTaskTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask2("Task1");
            todoList.AddTask2("Task2");

            string result = todoList.SearchTask("Task1");

            Assert.That(result, Is.EqualTo("Task Task1 found"));

        }

        [Test]
        
        public void GetTasksAlphabeticalDescTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask2("TaskA");
            todoList.AddTask2("TaskB");

            List<Main.Task> Tasks = todoList.GetTasksAlphabeticalDesc();

            Assert.That(todoList.GetTasksAlphabeticalDesc().Count, Is.EqualTo(2));  



        }

        [Test]
        public void GetTasksAlphabeticalAscTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask2("TaskA");
            todoList.AddTask2("TaskB");

            List<Main.Task> Tasks = todoList.GetTasksAlphabeticalAsc();

            Assert.That(todoList.GetTasksAlphabeticalAsc().Count, Is.EqualTo(2));



        }





    }
}