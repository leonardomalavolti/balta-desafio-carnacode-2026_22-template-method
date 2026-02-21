namespace DesignPatternChallenge.TemplateMethod;

public class WholesaleOrderProcessor : OrderProcessor
{
    protected override bool ValidateOrder(string companyId, decimal amount)
    {
        Console.WriteLine("[Atacado] Validando pedido...");
        if (string.IsNullOrEmpty(companyId))
        {
            Console.WriteLine("❌ Empresa inválida");
            return false;
        }
        if (amount < 1000m)
        {
            Console.WriteLine("❌ Pedido mínimo de R$ 1.000,00 para atacado");
            return false;
        }
        Console.WriteLine("✓ Pedido validado");
        return true;
    }

    protected override decimal CalculateTotal(decimal amount)
    {
        decimal discount = amount * 0.10m;
        decimal total = amount - discount;
        Console.WriteLine($"Subtotal: R$ {amount:N2}, Desconto: R$ {discount:N2}, Total: R$ {total:N2}");
        return total;
    }

    protected override void ProcessPayment(decimal total)
    {
        Console.WriteLine("[Atacado] Gerando boleto bancário...");
        Console.WriteLine("✓ Boleto gerado");
    }

    protected override void ScheduleShipping(List<string> items)
    {
        Console.WriteLine("[Atacado] Agendando coleta com transportadora...");
        Console.WriteLine("✓ Coleta agendada");
    }

    protected override void NotifyCustomer(string companyId)
    {
        Console.WriteLine("[Atacado] Notificando empresa...");
        Console.WriteLine("  → Email enviado");
        Console.WriteLine("  → SMS enviado");
        Console.WriteLine("✓ Notificações enviadas");
    }
}
