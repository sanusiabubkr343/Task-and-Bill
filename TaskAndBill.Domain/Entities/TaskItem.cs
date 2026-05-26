namespace TaskAndBill.Domain.Entities;

public class TaskItem :BaseEntity
{

    public string Title { get; set; }

    public string Description { get; set; }

    public TaskStatus Status { get; set; }

    public Guid AssignedToUserId { get; set; }

    public virtual User AssignedToUser { get; set; }

    public  Guid CreatedByClientId { get; set; }

    public virtual User CreatedByClient { get; set; }

    public int Budget { get; set; }

    public DateTime Deadline { get; set; }

    public DateTime CompletedAt { get; set; }

}


public enum TaskStatus
{
    Pending,
    InProgress,
    Completed
}