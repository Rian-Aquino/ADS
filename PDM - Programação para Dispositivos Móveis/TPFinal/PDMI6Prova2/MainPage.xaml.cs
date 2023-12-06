using Microsoft.Maui.Controls;
using PDMI6Prova2.Models;
using PDMI6Prova2.Pages;
using PDMI6Prova2.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace PDMI6Prova2
{
    public partial class MainPage : ContentPage
    {
        public DatabaseService service = new DatabaseService();
        public ObservableCollection<Livro> LivrosCollection { get; set; }
        Livro livroTeste = new Livro
        {
            NomeLivro = "Livro Teste",
            NomeAutor = "Autor Teste",
            EmailAutor = "autor@teste.com",
            ISBN = "1234567890"
        };
        public Location location;

        public MainPage()
        {
            InitializeComponent();
            LivrosCollection = new ObservableCollection<Livro>();
            listLivros.ItemsSource = LivrosCollection;
        }

        private async void OnAddLivroClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddLivro());
        }

        private async void OnEditLivroClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.BindingContext is Livro livro)
                {
                    await Navigation.PushAsync(new EditLivro(livro));
                }
            }
        }

        private async void OnDeleteLivroClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.BindingContext is Livro livro)
                {
                    bool remove = await DisplayAlert("Excluir item", "Deseja deletar o livro?", "Sim", "Não");

                    if (remove)
                    {
                        service.DeleteLivro(livro);
                        // Atualizar a lista após excluir o livro
                        await UpdateLivros();
                    }
                }
            }
        }

        private async Task UpdateLivros()
        {
            await service.InitializeAsync();
            var livros = await service.GetLivros();
            LivrosCollection.Clear();
            foreach (var livro in livros)
            {
                LivrosCollection.Add(livro);
            }
        }

        protected override async void OnAppearing()
        {
            await UpdateLivros();
            base.OnAppearing();
        }

        private async void OnFooterCreditsTappedAsync(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos", "Realizado por Gabriel Ferreira de Souza e Rian Gustavo Quintanilha de Aquino", "OK!");
        }
    }
}
