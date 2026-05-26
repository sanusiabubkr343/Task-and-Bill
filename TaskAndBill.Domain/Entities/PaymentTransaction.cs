namespace TaskAndBill.Domain.Entities;

public class PaymentTransaction:BaseEntity
{

    public Invoice InvoiceId { get; set; }

    public virtual Invoice Invoice { get; set; }

    public int AmountPaid { get; set; }

    public DateTime PaidAt { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public string PaymentReference { get; set; }


}



public enum PaymentMethod
{
    Cash,
    Card,
    BankTransfer,
}