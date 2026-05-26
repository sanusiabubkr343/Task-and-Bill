namespace TaskAndBill.Domain.Entities;

public class Invoice:BaseEntity
{

    public TaskItem TaskItemId { get; set; }

    public virtual TaskItem TaskItem { get; set; }

    public Guid FreelancerUserId { get; set; }

    public virtual User FreelancerUser { get; set; }

    public int Amount { get; set; }

    public DateTime DueDate { get; set; }

}


public enum InvoiceStatus
{
    Unpaid,
    Paid,
    Overdue
}