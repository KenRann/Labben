namespace Labben
{
    public interface IGetUsers
    {
        //IQueryable<Person> GetUsers();
        Task<IQueryable<Person>> GetUsersAsync();
        IQueryable<Person> GetUsersSync();
    }
}
