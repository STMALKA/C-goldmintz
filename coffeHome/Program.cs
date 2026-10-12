using coffeHome;

Till till = new Till() { Id = 1 };
till.pushMoney(50);
Console.WriteLine(till.Lest);

Product p1=new Product { Name = "Coffee", Price = 5, Description = "A hot beverage made from roasted coffee beans." };
Product p2= new Product { Name = "Tea", Price = 3, Description = "A hot beverage made from cured or fresh tea leaves." };
Product p3= new() { Name= "Sandwich", Price = 10};

Money m1 = new Money { Amount = 20, Currency = "USD" };
Money m2 = new Money { Amount = 20, Currency = "USD" };


Address a1 = new Address { streetName = "Main St", streetNumber =123 };
Console.WriteLine(a1.ToString());
Address a2 = a1 with { streetName = "Second St" };
Console.WriteLine(a1.ToString());
Console.WriteLine(a2.ToString());

Customer c1 = new Customer { Name = "JohnDoe", Age = 65 };
//Customer c2 = c1 with { Age = 245 };

Order o1 = new Order { Id = 1, Customer = c1};
o1.addProduct(p1);
o1.addProduct(p2);
o1.pay();
Console.WriteLine(o1.sumPrice());
PriceCalculator priceCalculator = new PriceCalculator(10); 
double totalPrice = priceCalculator.CalculatePriceWithTax(o1.sumPrice());
Console.WriteLine(totalPrice);



