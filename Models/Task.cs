public class Task
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
  public required string Category { get; set; }
  public DateTime DueDate { get; set; }
  public bool IsCompleted { get; set; }
  public int Priority { get; set; }
  public int Status { get; set; }
}