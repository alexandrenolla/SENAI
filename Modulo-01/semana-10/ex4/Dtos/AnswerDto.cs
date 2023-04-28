namespace ex4.Dtos;

public class AnswerAtualizarDto
{
    public float Score { get; set; }
    public string Observation { get; set; }
}

public  class AnswerCriarDto
{
    public string Response { get; set; }
    public float Score { get; set; }
    public string Observation { get; set; }
    public int StudentId { get; set; }
    public int QuestionId { get; set; }
}