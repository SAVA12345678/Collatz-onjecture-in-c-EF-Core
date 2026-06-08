using System.ComponentModel.DataAnnotations;

public class CollatzSys
{
    [Key]
    public int Id {get; set;}
    public string ChainOfNumbers {get; set;} = string.Empty;
    public long Number {get; set;}

}