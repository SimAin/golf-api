namespace WebApi.Entities
{
    public class Scorecard
    {
       public Scorecard(string name, DateTime date, List<Tuple<int, int>> scores, List<Tuple<int, int>> pars){

           courseName = name;
           roundDate = date;
           results = new List<hole>();
           for (int i = 0; i < pars.Count; i++)
            {
                if (scores[i].Item1 == pars[i].Item1)
                {
                    results.Add(new hole(scores[i].Item1, scores[i].Item2, pars[i].Item2));    
                    
                } else {
                    throw new Exception();
                } 
            }
       }

        public string courseName { get; set; }
        public DateTime roundDate { get; set;}

        public List<hole> results {get; set;}

    }
}