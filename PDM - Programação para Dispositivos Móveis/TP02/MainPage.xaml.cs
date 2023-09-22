using TarefasApp.Repositories;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            taskListView.ItemsSource = TaskRepository.Tasks;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Desmarque a seleção do item
            ((ListView)sender).SelectedItem = null;

            // Obtém a tarefa selecionada
            TaskEntity selectedTask = e.SelectedItem as TaskEntity;

            // Abre a página de detalhes passando a tarefa selecionada como parâmetro
            await Navigation.PushAsync(new TaskDetailPage(selectedTask));
        }

        private async void GoToNewTask(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewTask());
        }
    }
}