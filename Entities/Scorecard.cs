namespace WebApi.Entities
{
    public class Scorecard
    {
       public Scorecard(Course course, Score score, List<Tuple<int, int>> scores, List<Tuple<int, int>> pars){

           courseName = course.Name;
           roundDate = score.date.Date;
           front9_total = score.front9_total;
           back9_total = score.back9_total;
           total = score.total;
           front9ToPar = front9_total - course.front9_par;
           back9ToPar = back9_total - course.back9_par;
           totalToPar = total - course.total;
           holeResults = new List<hole>();
           for (int i = 0; i < pars.Count; i++)
            {
                if (scores[i].Item1 == pars[i].Item1)
                {
                    holeResults.Add(new hole(scores[i].Item1, scores[i].Item2, pars[i].Item2));    
                    
                } else {
                    throw new Exception();
                } 
            }
       }

        public string courseName { get; set; }
        public DateTime roundDate { get; set;}
        public List<hole> holeResults {get; set;}
        public int front9_total { get; set; } 
        public int back9_total { get; set; }
        public int total { get; set; }
        public int front9ToPar { get; set; } 
        public int back9ToPar { get; set; }
        public int totalToPar { get; set; }

    }
}