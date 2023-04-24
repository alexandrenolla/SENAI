namespace ex2.Models;

public class Answer
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public int StudentId { get; set; }
    public string AnswerName { get; set; }
    public float Score { get; set; }
    public string Observation { get; set; }

    public virtual Student Student { get; set; }
    public virtual Question Question { get; set; }
}