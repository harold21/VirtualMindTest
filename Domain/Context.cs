using Model;

namespace Domain
{
    public class Context
    {
        public static string GetCotization(ICurrency currency, string url)
        {
            return currency.GetCotization(url);
        }
    }
}
