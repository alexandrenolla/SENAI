namespace ex1.Models;

public class PartoModel
{
    public int Id { get; set; }
    public int Id_Medico { get; set; }
    public DateTime Data_Parto { get; set; }
    public DateTime Horario_Parto { get; set; }


    public virtual MedicoModel Medico { get; set; }
    public virtual ICollection<BebeModel> Bebes { get; set; }
}