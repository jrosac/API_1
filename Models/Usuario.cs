using System.ComponentModel.DataAnnotations;

namespace API_1.Models;

public class Usuario
{
    [Key]
    public int cpf { get; set; }
    public string? nome { get; set; }
    public DateTime data_Nascimento { get; set; }
}