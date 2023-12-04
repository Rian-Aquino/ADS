using API.Models;
using Common.Services;

namespace Desktop
{
    public partial class Form1 : Form
    {
        private UsuariosService _usuariosService = new UsuariosService("https://localhost:7166", new HttpClient());
        private List<Usuario> _usuarios = new List<Usuario>();


        public Form1()
        {
            InitializeComponent();
            AtualizarLista();
        }

        public async Task<bool> AtualizarLista()
        {
            var usuarios = await _usuariosService.GetAll();

            var nomesUsuarios = usuarios.Select(u => u.Id + " - " + u.Nome).ToList();

            _usuarios = usuarios;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(nomesUsuarios.ToArray());

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var res = await _usuariosService.Create(new UsuariosService.UsuarioCreateRequest(
                textBox1.Text,
                textBox2.Text
            ));

            if (res)
            {
                AtualizarLista();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {

            await _usuariosService.Update(int.Parse(label7.Text), new Usuario(int.Parse(label7.Text), textBox3.Text, textBox6.Text, checkBox1.Checked));

            AtualizarLista();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = _usuarios.ElementAt(listBox1.SelectedIndex);

            label7.Text = selectedUser.Id.ToString();
            textBox3.Text = selectedUser.Nome;
            textBox6.Text = selectedUser.Senha;
            checkBox1.Checked = selectedUser.Status;

            tabControl1.SelectTab(1);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await _usuariosService.Delete(int.Parse(label7.Text));

            await AtualizarLista();

            label7.Text = "0";
            textBox3.Text = "";
            textBox6.Text = "";
            checkBox1.Checked = false;

            tabControl1.SelectTab(0);
        }
    }
}