namespace ex2.Models;

public class BebeModel
{
    public int Id { get; set; }
    public DateTime Data_Nascimento { get; set; }
    public decimal Peso_Nascimento { get; set; }
    public int Altura { get; set; }
    public int Id_Mae { get; set; }
    public int Id_Parto { get; set; }

    public virtual PartoModel Parto { get; set; }
    public virtual MaeModel Mae { get; set; }
}