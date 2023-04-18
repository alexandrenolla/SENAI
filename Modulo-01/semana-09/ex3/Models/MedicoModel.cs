namespace ex2.Models;

public class MedicoModel
{
    public int Id { get; set; }
    public string CRM { get; set; }
    public string Nome { get; set; }
    public int Celular { get; set; }
    public string Especialidade { get; set; }


    public virtual ICollection<PartoModel> Partos { get; set; }
}