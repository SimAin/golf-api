namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Course 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int hole1_par { get; set; }
    public int hole2_par { get; set; }
    public int hole3_par { get; set; }
    public int hole4_par { get; set; }
    public int hole5_par { get; set; }
    public int hole6_par { get; set; }
    public int hole7_par { get; set; }
    public int hole8_par { get; set; }
    public int hole9_par { get; set; }
    public int hole10_par { get; set; }
    public int hole11_par { get; set; }
    public int hole12_par { get; set; }
    public int hole13_par { get; set; }
    public int hole14_par { get; set; }
    public int hole15_par { get; set; }
    public int hole16_par { get; set; }
    public int hole17_par { get; set; }
    public int hole18_par { get; set; }

    public int front9_par { get { 
                return hole1_par + hole2_par + hole3_par +
                    hole4_par + hole5_par + hole6_par + 
                    hole7_par + hole8_par + hole9_par; } }
    public int back9_par { get { 
                return hole10_par + hole11_par + hole12_par + 
                    hole13_par + hole14_par + hole15_par +
                    hole16_par + hole17_par + hole18_par; } }

    public int total { get { return front9_par + back9_par; } }

    public List<Tuple<int, int>> getParList(){
        var scores = new List<Tuple<int, int>> ();
        scores.Add(Tuple.Create(1, hole1_par));
        scores.Add(Tuple.Create(2, hole2_par));
        scores.Add(Tuple.Create(3, hole3_par));
        scores.Add(Tuple.Create(4, hole4_par));
        scores.Add(Tuple.Create(5, hole5_par));
        scores.Add(Tuple.Create(6, hole6_par));
        scores.Add(Tuple.Create(7, hole7_par));
        scores.Add(Tuple.Create(8, hole8_par));
        scores.Add(Tuple.Create(9, hole9_par));
        scores.Add(Tuple.Create(10, hole10_par));
        scores.Add(Tuple.Create(11, hole11_par));
        scores.Add(Tuple.Create(12, hole12_par));
        scores.Add(Tuple.Create(13, hole13_par));
        scores.Add(Tuple.Create(14, hole14_par));
        scores.Add(Tuple.Create(15, hole15_par));
        scores.Add(Tuple.Create(16, hole16_par));
        scores.Add(Tuple.Create(17, hole17_par));
        scores.Add(Tuple.Create(18, hole18_par));

        return scores;

    }
}