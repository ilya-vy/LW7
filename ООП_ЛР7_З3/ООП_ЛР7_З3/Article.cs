namespace ООП_ЛР7_З3
{
    public class Article
    {
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Price { get; set; }

        public Article(string name, string shopName, string price)
        {
            Name = name;
            ShopName = shopName;
            Price = price;
        }
    }
}
