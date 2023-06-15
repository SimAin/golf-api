namespace WebApi.Models.Courses;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{
    [Required]
    public string name { get; set; }

    [Required]
    public int hole1_par { get; set; }

    [Required]
    public int hole2_par { get; set; }
    
    [Required]
    public int hole3_par { get; set; }
    
    [Required]
    public int hole4_par { get; set; }
    
    [Required]
    public int hole5_par { get; set; }
    
    [Required]
    public int hole6_par { get; set; }
    
    [Required]
    public int hole7_par { get; set; }
    
    [Required]
    public int hole8_par { get; set; }
    
    [Required]
    public int hole9_par { get; set; }
    
    [Required]
    public int hole10_par { get; set; }
    
    [Required]
    public int hole11_par { get; set; }
    
    [Required]
    public int hole12_par { get; set; }
    
    [Required]
    public int hole13_par { get; set; }
    
    [Required]
    public int hole14_par { get; set; }
    
    [Required]
    public int hole15_par { get; set; }
    
    [Required]
    public int hole16_par { get; set; }
    
    [Required]
    public int hole17_par { get; set; }
    
    [Required]
    public int hole18_par { get; set; }
}