namespace Command.Repository.Interfaces
{
    public interface IAuthor
    {
        String Name { get; set; }
        String Email { get; set; }
        Char Gender { get; set; }

    }
}
