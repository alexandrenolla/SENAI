namespace ex3.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Cpf { get; set; }
    public string Password { get; set; }

    public virtual Student Student { get; set; }
    public virtual Teacher Teacher { get; set; }
    
}