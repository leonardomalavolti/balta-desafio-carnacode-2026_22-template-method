namespace DesignPatternChallenge.TemplateMethod;

public abstract class OrderProcessor
{
    public void ProcessOrder(string customerId, List<string> items, decimal amount)
    {
        Console.WriteLine($"\n=== Processando Pedido ({GetType().Name}) ===");

        if (!ValidateOrder(customerId, amount)) return;
        CheckStock(items);
        decimal total = CalculateTotal(amount);
        ProcessPayment(total);
        SeparateItems(items);
        ScheduleShipping(items);
        NotifyCustomer(customerId);

        Console.WriteLine($"\n✅ Pedido {GetType().Name} processado com sucesso!");
    }

    // Passos do template
    protected abstract bool ValidateOrder(string customerId, decimal amount);
    protected virtual void CheckStock(List<string> items)
    {
        Console.WriteLine("Verificando estoque...");
        foreach (var item in items)
        {
            Console.WriteLine($"  → {item}: Disponível");
        }
        Console.WriteLine("✓ Estoque confirmado");
    }
    protected abstract decimal CalculateTotal(decimal amount);
    protected abstract void ProcessPayment(decimal total);
    protected virtual void SeparateItems(List<string> items)
    {
        Console.WriteLine("Separando itens no estoque...");
        Console.WriteLine("✓ Itens separados");
    }
    protected abstract void ScheduleShipping(List<string> items);
    protected abstract void NotifyCustomer(string customerId);
}
