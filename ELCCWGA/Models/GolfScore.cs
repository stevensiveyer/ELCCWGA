using System.ComponentModel.DataAnnotations;

namespace ELCCWGA.Models;
public class GolfScore
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; } = default!;

    [Required]
    public DateOnly Date { get; set; } = default!;

    [Required, MaxLength(10)]
    public string Tee { get; set; } = default!;

    public int Creek1 { get; set; }

    public int Creek2 { get; set; }

    public int Creek3 { get; set; }

    public int Creek4 { get; set; }

    public int Creek5 { get; set; }

    public int Creek6 { get; set; }

    public int Creek7 { get; set; }

    public int Creek8 { get; set; }

    public int Creek9 { get; set; }

    public int Lake1 { get; set; }

    public int Lake2 { get; set; }

    public int Lake3 { get; set; }

    public int Lake4 { get; set; }

    public int Lake5 { get; set; }

    public int Lake6 { get; set; }

    public int Lake7 { get; set; }

    public int Lake8 { get; set; }

    public int Lake9 { get; set; }

    public int Hill1 { get; set; }

    public int Hill2 { get; set; }

    public int Hill3 { get; set; }

    public int Hill4 { get; set; }

    public int Hill5 { get; set; }

    public int Hill6 { get; set; }

    public int Hill7 { get; set; }

    public int Hill8 { get; set; }

    public int Hill9 { get; set; }

    public void setHigh()
    {

    }
}
