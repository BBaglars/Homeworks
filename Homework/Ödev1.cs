Product product1 = new Product();
product1.productName = "Bilgisayar";
product1.shop = "Media Mark";
product1.productPrice = 20000;
product1.numberOfstock = 150;

Product product2 = new Product();
product2.productName = "Peçete";
product2.shop = "BİM";
product2.productPrice = 100;
product2.numberOfstock = 1500;

Product product3 = new Product();
product3.productName = "Oyuncak Araba";
product3.shop = "Toyz Shop";
product3.productPrice = 650;
product3.numberOfstock = 500;

Product product4 = new Product();
product4.productName = "Kol Saati";
product4.shop = "Trendyol";
product4.productPrice = 980;
product4.numberOfstock = 19;

Product[] products = new Product[] {product1, product2, product3, product4};

foreach (var product in products)
{
    Console.WriteLine(product.productName + " : " + product.productPrice + "TL" + " ---> " 
        + product.shop + " = " + product.numberOfstock + " Adet ");
}

class Product
{
    public string productName { get; set; }
    public string shop { get; set; }
    public int numberOfstock { get; set; }
    public int productPrice { get; set; }
}