namespace ex1.Models;

public class MaeModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public DateTime Data_Nascimento { get; set; }

    
    public virtual ICollection<BebeModel> Bebes { get; set; }
}