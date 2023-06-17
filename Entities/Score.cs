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

    public List<Tuple<int, int>> getScoreList(){
        var scores = new List<Tuple<int, int>> ();
        scores.Add(Tuple.Create(1, hole1_score));
        scores.Add(Tuple.Create(2, hole2_score));
        scores.Add(Tuple.Create(3, hole3_score));
        scores.Add(Tuple.Create(4, hole4_score));
        scores.Add(Tuple.Create(5, hole5_score));
        scores.Add(Tuple.Create(6, hole6_score));
        scores.Add(Tuple.Create(7, hole7_score));
        scores.Add(Tuple.Create(8, hole8_score));
        scores.Add(Tuple.Create(9, hole9_score));
        scores.Add(Tuple.Create(10, hole10_score));
        scores.Add(Tuple.Create(11, hole11_score));
        scores.Add(Tuple.Create(12, hole12_score));
        scores.Add(Tuple.Create(13, hole13_score));
        scores.Add(Tuple.Create(14, hole14_score));
        scores.Add(Tuple.Create(15, hole15_score));
        scores.Add(Tuple.Create(16, hole16_score));
        scores.Add(Tuple.Create(17, hole17_score));
        scores.Add(Tuple.Create(18, hole18_score));

        return scores;

    }
}