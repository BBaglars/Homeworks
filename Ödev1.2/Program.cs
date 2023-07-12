string product1 = "Bilgisayar";
string product2 = "Peçete";
string product3 = "Oyuncak Araba";
string product4 = "Kol Saati";

string[] products = new string[] {product1, product2, product3, product4};

//for (int i = 0; i < products.Length; i++)
//{
//    Console.WriteLine(products[i]);
//}
int i = 0;

while ( i < products.Length )
{
    Console.WriteLine(products[i]);
    i++;
}
