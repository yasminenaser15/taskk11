int priceSmall = 25;
int pricelarge = 35;
Console.WriteLine("Enter Number for small carpets : ");
int small = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number for large carpets : ");
int large = Convert.ToInt32(Console.ReadLine());
int cost = (small * priceSmall) + (large * pricelarge);
Double taxRate = .06;
Double tax = cost * taxRate;
Double Total = cost + tax;

Console.WriteLine($"Number for small carpets :{small}");
Console.WriteLine($"Number for large carpets :{large}");
Console.WriteLine($"Price per small room :{priceSmall}$");
Console.WriteLine($"Price per large room :{pricelarge}$");
Console.WriteLine($"the cost :{cost}$");
Console.WriteLine($"the tax :{tax}$");
Console.WriteLine($"the total estimate :{Total}$");
Console.WriteLine("the estimate is valid for 30 days");
