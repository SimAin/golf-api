namespace WebApi.Entities
{
    public class hole{

        public hole (int no, int s, int p){
            holeNumber = no;
            score = s;
            par = p;
            result = s-p;
        }

        public int holeNumber {get;set;}
        public int score { get; set; }
        public int par { get; set; }
        public int result { get; set; }
    }
}