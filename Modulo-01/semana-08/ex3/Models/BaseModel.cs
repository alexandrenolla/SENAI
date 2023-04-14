namespace ex3.Models;

public abstract class BaseModel
{
    public int Id { get; set; }
    public DateTime DateDeInclusao { get; set; }
    public DateTime DateDeAlteracao { get; set; }
}