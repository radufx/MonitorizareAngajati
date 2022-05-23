using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonitorizareAngajati.persistence
{
    public class TasksRepository: Repository<Task>
    {
        private DatabaseContext context = new DatabaseContext();
        public IEnumerable<Task> findAll()
        {
            List<Task> tasks = new List<Task>();

            return tasks;
        }

        public override Task save (Task task)
        {
            Tasks taskModel = new Tasks()
            {
                description = task.Description,
                status = task.Status,
                userID = task.UserID
            };
            context.TaskModel.Add(taskModel);
            context.SaveChanges();

            task.setKey(taskModel.id);

            return task;
        }

        public void remove (int id)
        {
            Tasks taskModel = context.TaskModel.Find(id);
            context.TaskModel.Remove(taskModel);
            context.SaveChanges();
        }

        public void removeTasksUser(int userID)
        {
            context.TaskModel.RemoveRange(context.TaskModel.Where(x => x.userID == userID));
            context.SaveChanges();
        }

        public void update(Task task)
        {
            int id = task.getKey();
            Tasks taskModel = context.TaskModel.Find(id);
            taskModel.status = task.Status;
            context.SaveChanges();
        }
    }
}
