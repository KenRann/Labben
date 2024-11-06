namespace Labben
{
    public interface IGetUsers
    {
        IQueryable<Person> GetUsersSync();

        Task <IQueryable<Person>> GetUsersAsync();
    }
}
