namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score score1 = new Score();
            score1.name = "Ahmed";
            score1.points = 5000;
            score1.level = 13;

            bool starEarned1 = score1.EarnedStar();
            Console.WriteLine($"Did {score1.name} earned a star? {starEarned1}");


            Score score2 = new Score();
            score2.name = "Isa";
            score2.points = 50000;
            score2.level = 23;

            bool starEarned2 = score2.EarnedStar();
            Console.WriteLine($"Did {score2.name} earned a star? {starEarned2}");
        }

        class Score
        {
            public string name = "";
            public int points = 0;
            public int level = 0;

            public bool EarnedStar() => (points / level) > 1000;
        }
    }
}
