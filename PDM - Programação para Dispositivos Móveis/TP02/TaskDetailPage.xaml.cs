using TarefasApp.Repositories;
using TarefasApp.Utils;

namespace TarefasApp;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

public partial class TaskDetailPage : ContentPage
{
    public TaskDetailPage(TaskEntity selectedTask)
    {
        InitializeComponent();
        BindingContext = selectedTask;

        priorityLabel.Text = PriorityUtils.stringFromTaskPriorityType(selectedTask.PriorityType);
    }

    public async void GoToEditTask(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EditTaskPage((TaskEntity)BindingContext));
    }

    public async void DeleteTask(object sender, EventArgs e)
    {
        string res = await DisplayActionSheet("Deseja excluir essa tarefa?", "Cancelar", "OK");

        if (res == "OK")
        {
            TaskRepository.DeleteTask((TaskEntity)BindingContext);
            await Navigation.PopAsync();
        }

    }
}