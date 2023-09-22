using System.Threading.Tasks;
using System.Windows.Input;
using TarefasApp.Repositories;
using TarefasApp.Utils;

namespace TarefasApp;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

public partial class NewTask : ContentPage
{

    public NewTask()
	{
		InitializeComponent();

        var priorityList = new List<string>
        {
            "Alta",
            "Média",
            "Baixa"
        };

        priorityPicker.ItemsSource = priorityList;
        priorityPicker.SelectedIndex = 2;
    }

    private async void CreateTask(object sender, EventArgs e)
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

        TaskRepository.SaveTask(
            new TaskEntity
            {
                Id = TaskRepository.Tasks.Count,
                CreatedAt = createdAt,
                Description = description,
                Title = title,
                PriorityType = priorityType
            });

        await Navigation.PopModalAsync();
    }

    public async void CloseModal(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}