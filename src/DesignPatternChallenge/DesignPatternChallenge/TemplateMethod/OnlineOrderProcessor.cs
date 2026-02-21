namespace DesignPatternChallenge.TemplateMethod;

public class OnlineOrderProcessor : OrderProcessor
{
    protected override bool ValidateOrder(string customerId, decimal amount)
    {
        Console.WriteLine("[Online] Validando pedido...");
        if (string.IsNullOrEmpty(customerId))
        {
            Console.WriteLine("❌ Cliente inválido");
            return false;
        }
        Console.WriteLine("✓ Pedido validado");
        return true;
    }

    protected override decimal CalculateTotal(decimal amount)
    {
        decimal shipping = 15m;
        decimal total = amount + shipping;
        Console.WriteLine($"Subtotal: R$ {amount:N2}, Frete: R$ {shipping:N2}, Total: R$ {total:N2}");
        return total;
    }

    protected override void ProcessPayment(decimal total)
    {
        Console.WriteLine("[Online] Processando pagamento com cartão...");
        Console.WriteLine("✓ Pagamento aprovado");
    }

    protected override void ScheduleShipping(List<string> items)
    {
        Console.WriteLine("[Online] Agendando envio via Correios...");
        Console.WriteLine("✓ Envio agendado");
    }

    protected override void NotifyCustomer(string customerId)
    {
        Console.WriteLine("[Online] Enviando email de confirmação...");
        Console.WriteLine("✓ Email enviado");
    }
}
