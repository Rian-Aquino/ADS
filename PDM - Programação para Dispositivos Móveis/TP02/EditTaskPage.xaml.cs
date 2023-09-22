using TarefasApp.Repositories;
using TarefasApp.Utils;

namespace TarefasApp;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

public partial class EditTaskPage : ContentPage
{
	public EditTaskPage(TaskEntity task)
	{
		InitializeComponent();
        BindingContext = task;

        var priorityList = new List<string>
        {
            "Alta",
            "Média",
            "Baixa"
        };

        priorityPicker.ItemsSource = priorityList;
        priorityPicker.SelectedIndex = priorityList.IndexOf(
            PriorityUtils.stringFromTaskPriorityType(task.PriorityType));
    }

    private async void EditTask(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleEntry.Text))
        {
            await DisplayAlert("Erro", "O campo Título é obrigatório.", "OK");
            return;
        }

        if (priorityPicker.SelectedItem == null)
        {
            await DisplayAlert("Erro", "Selecione a Prioridade da tarefa.", "OK");
            return;
        }

        string title = titleEntry.Text;
        string description = descriptionEditor.Text;
        DateTime createdAt = createdAtDatePicker.Date;
        TaskPriorityType priorityType = PriorityUtils.readFromString(priorityPicker.SelectedItem.ToString());

        TaskRepository.EditTask(
            new TaskEntity { 
                Id = ((TaskEntity)BindingContext).Id,
                CreatedAt = createdAt,
                Title = title,
                Description = description,
                PriorityType = priorityType,
            });

        await Navigation.PopModalAsync();
    }

    public async void CloseModal(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}