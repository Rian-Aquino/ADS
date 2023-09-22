using System.Collections.ObjectModel;
using System.ComponentModel;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TarefasApp.Repositories
{
    internal class TaskRepository
    {
        private static ObservableCollection<TaskEntity> _tasks = new ObservableCollection<TaskEntity> ();
        public static ObservableCollection<TaskEntity> Tasks { get => _tasks; set => _tasks = value; }

        public static void SaveTask(TaskEntity entity) { _tasks.Add(entity); }
        public static void EditTask(TaskEntity task)
        {
            TaskEntity taskEntity = GetTaskById(task.Id);
            if (taskEntity != null)
            {
                taskEntity.Title = task.Title;
                taskEntity.Description = task.Description;
                taskEntity.CreatedAt = task.CreatedAt;
                taskEntity.PriorityType = task.PriorityType;

                taskEntity.OnPropertyChanged(nameof(taskEntity.Title));
                taskEntity.OnPropertyChanged(nameof(taskEntity.Description));
                taskEntity.OnPropertyChanged(nameof(taskEntity.CreatedAt));
                taskEntity.OnPropertyChanged(nameof(taskEntity.PriorityType));
            }
        }
        public static void DeleteTask(TaskEntity entity) { _tasks.Remove(entity); }
        public static TaskEntity GetTaskById(int id) { return _tasks.FirstOrDefault(t => t.Id == id); }
    }

    public class TaskEntity : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set
            {
                if (_createdAt != value)
                {
                    _createdAt = value;
                    OnPropertyChanged(nameof(CreatedAt));
                }
            }
        }

        private TaskPriorityType _priorityType;
        public TaskPriorityType PriorityType
        {
            get { return _priorityType; }
            set
            {
                if (_priorityType != value)
                {
                    _priorityType = value;
                    OnPropertyChanged(nameof(PriorityType));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public enum TaskPriorityType
    {
        HIGH,
        MEDIUM,
        LOW
    }
}
