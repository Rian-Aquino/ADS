using Command.Repository.Interfaces;

namespace Command.Repository
{
    public class Author : IAuthor
    {
        private String _name;
        private String _email;
        private Char _gender;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public char Gender { get => _gender; set => _gender = value; }

        public Author(string name, string email, char gender)
        {
            _name = name;
            _email = email;
            _gender = gender;
        }

        public override string ToString()
        {
            return $"Author[name={_name}, email={_email}, gender={_gender}]";
        }
    }
}
