namespace JwtTest.Interfaces
{
    public interface INewsService
    {
        string GetLatestNews();

        string GetLatestNewsPaid();
    }
}
