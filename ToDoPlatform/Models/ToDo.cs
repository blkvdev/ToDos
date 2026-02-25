
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoPlatform.Models;

[Table("todos")]
public class ToDo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    public string UserID { get; set; }
    [ForeignKey(nameof(UserID))]
    [Display(Name = "Usuário")]
    public AppUser User { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Título")]
   
    public string Title { get; set; }

    [Display(Name ="Descrição")]
    public string Description { get; set; }

    [Display(Name = "Concluído")]
    public bool Done { get; set; } = false;

    [Display(Name = "Data de Cadastro")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}
