using DesignPatternChallenge.TemplateMethod;

var items = new List<string> { "Notebook", "Mouse", "Teclado" };

var online = new OnlineOrderProcessor();
online.ProcessOrder("CUST001", items, 2500m);

var wholesale = new WholesaleOrderProcessor();
wholesale.ProcessOrder("COMP001", items, 5000m);

var marketplace = new MarketplaceOrderProcessor();
marketplace.ProcessOrder("SELL001", items, 3000m);

Console.WriteLine("\n✅ Template Method garante fluxo consistente e evita duplicação de código.");
