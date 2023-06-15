namespace WebApi.Models.Scores;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{
    public CreateRequest(){}

    [Required]
    public int Scoreid { get; set; }

    [Required]
    public int Courseid { get; set; }

    [Required]
    public int Playerid { get; set; }

    [Required]
    public int hole1_score { get; set; }

    [Required]
    public int hole2_score { get; set; }
    
    [Required]
    public int hole3_score { get; set; }
    
    [Required]
    public int hole4_score { get; set; }
    
    [Required]
    public int hole5_score { get; set; }
    
    [Required]
    public int hole6_score { get; set; }
    
    [Required]
    public int hole7_score { get; set; }
    
    [Required]
    public int hole8_score { get; set; }
    
    [Required]
    public int hole9_score { get; set; }
    
    [Required]
    public int hole10_score { get; set; }
    
    [Required]
    public int hole11_score { get; set; }
    
    [Required]
    public int hole12_score { get; set; }
    
    [Required]
    public int hole13_score { get; set; }
    
    [Required]
    public int hole14_score { get; set; }
    
    [Required]
    public int hole15_score { get; set; }
    
    [Required]
    public int hole16_score { get; set; }
    
    [Required]
    public int hole17_score { get; set; }
    
    [Required]
    public int hole18_score { get; set; }
}