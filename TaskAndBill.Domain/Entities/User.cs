namespace TaskAndBill.Domain.Entities;

public class User : BaseEntity
{

    public string Email { get; set; }

    public string UserName { get; set; }

    public UserRole Role { get; set; }


}

public enum UserRole
{
    Freelancer,
    Client
}