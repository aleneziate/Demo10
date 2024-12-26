using System.Net.Quic;
using Demo10.Models;

Product p=new Product();
string name;
int price, quantity;
Console.WriteLine("Enter product name");
name = Console.ReadLine();
Console.WriteLine("Enter price");
price  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter quantity ");
quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( p.GetInfo(name));
Console.WriteLine(p.GetInfo(name, price));
Console.WriteLine( p.GetInfo(name, price,quantity) + "Total: " +(price*quantity));
 