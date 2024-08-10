using JwtTest.Interfaces;

namespace JwtTest.Services
{
    public class NewsService : INewsService
    {
        public string GetLatestNews()
        {
            return "Bugün hiç bir şey olmadı, haber yok!";
        }

        public string GetLatestNewsPaid()
        {
            return "Bugün bir çok şey oldu. İşte haberler!";
        }
    }
}
