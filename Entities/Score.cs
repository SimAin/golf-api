namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Score 
{
    public int Scoreid { get; set; }
    public int Courseid { get; set; }
    public int Playerid { get; set; }
    public DateTime date {get; set;}
    public int hole1_score { get; set; }
    public int hole2_score { get; set; }
    public int hole3_score { get; set; }
    public int hole4_score { get; set; }
    public int hole5_score { get; set; }
    public int hole6_score { get; set; }
    public int hole7_score { get; set; }
    public int hole8_score { get; set; }
    public int hole9_score { get; set; }
    public int hole10_score { get; set; }
    public int hole11_score { get; set; }
    public int hole12_score { get; set; }
    public int hole13_score { get; set; }
    public int hole14_score { get; set; }
    public int hole15_score { get; set; }
    public int hole16_score { get; set; }
    public int hole17_score { get; set; }
    public int hole18_score { get; set; }

    public int front9_total 
    {
        get { 
                return hole1_score + hole2_score + hole3_score +
                    hole4_score + hole5_score + hole6_score + 
                    hole7_score + hole8_score + hole9_score; 
            }
    }
    public int back9_total 
    {
        get { 
                return hole10_score + hole11_score + hole12_score + 
                    hole13_score + hole14_score + hole15_score +
                    hole16_score + hole17_score + hole18_score; 
            }
    }
    public int total
    {
        get { 
                return front9_total + back9_total; 
            }
    }
}