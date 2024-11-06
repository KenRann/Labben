namespace Labben
{
    public interface IGetUsers
    {
        IQueryable<Person> GetUsers();
    }
}
