/* 
 Dupla:
 Gabriel Ferreira de Souza
 Rian Gustavo Quintanilha de Aquino
 */
namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {

            if (id.Text == "admin" && password.Text == "senha@dmin")
                DisplayAlert("Logado com sucesso!", "", "ok");
            else
                DisplayAlert("Não autorizado!", "Você quis dizer?\n\nid: admin\npass: senha@dmin", "ok");
        }

        private void OnClear(object sender, EventArgs e)
        {
            id.Text = "";
            password.Text = "";
        }

        private void OnCredits(object sender, EventArgs e) 
        {
            DisplayAlert("Realizado por", "Gabriel Ferreira de Souza\nRian Gustavo Quintanilha de Aquino", "Nota 10");
        }
    }
}