namespace DesignPatternChallenge.TemplateMethod;

public class MarketplaceOrderProcessor : OrderProcessor
{
    protected override bool ValidateOrder(string sellerId, decimal amount)
    {
        Console.WriteLine("[Marketplace] Validando pedido...");
        if (string.IsNullOrEmpty(sellerId))
        {
            Console.WriteLine("❌ Vendedor inválido");
            return false;
        }
        Console.WriteLine("✓ Pedido validado");
        return true;
    }

    protected override decimal CalculateTotal(decimal amount)
    {
        decimal commission = amount * 0.15m;
        decimal sellerAmount = amount - commission;
        Console.WriteLine($"Total: R$ {amount:N2}, Comissão: R$ {commission:N2}, Repasse vendedor: R$ {sellerAmount:N2}");
        return amount;
    }

    protected override void ProcessPayment(decimal total)
    {
        Console.WriteLine("[Marketplace] Processando split payment...");
        Console.WriteLine("✓ Pagamento dividido entre marketplace e vendedor");
    }

    protected override void ScheduleShipping(List<string> items)
    {
        Console.WriteLine("[Marketplace] Agendar envio com opção do vendedor...");
        Console.WriteLine("✓ Envio agendado");
    }

    protected override void NotifyCustomer(string sellerId)
    {
        Console.WriteLine("[Marketplace] Notificando partes...");
        Console.WriteLine("  → Cliente notificado");
        Console.WriteLine("  → Vendedor notificado");
        Console.WriteLine("✓ Notificações enviadas");
    }
}
