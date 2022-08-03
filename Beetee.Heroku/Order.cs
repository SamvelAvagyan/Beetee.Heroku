namespace Beetee.Heroku
{
    public enum WebsiteType
    {
        LandingPage,
        OnlineShop,
        Blog,
        News
    }

    public class Order
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public WebsiteType WebsiteType { get; set; }
    }
}
