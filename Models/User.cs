using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace house_bank_aspdotnet_mcv.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "vui lòng nhập tên")]
    [StringLength(255)]

    public string? Name { get; set; }

    [Required(ErrorMessage = "")]
    [StringLength(255)]

    public string? Email { get; set; }

    [Required(ErrorMessage = "")]
    [StringLength(255)]

    public string? Password { get; set; }

    [Required]
    public string? Role { get; set; }

    [Required]
    public string? Phone { get; set; }
}