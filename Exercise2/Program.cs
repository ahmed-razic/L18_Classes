namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score score1 = new Score();
            Console.WriteLine($"Name: {score1.name}, Points: {score1.points}, Level: {score1.level}");

            Score score2 = new Score("Player1", 5000, 4);
            Console.WriteLine($"Name: {score2.name}, Points: {score2.points}, Level: {score2.level}");
        }

        class Score    
        {
            public string name;
            public int points;
            public int level;

            public Score() : this("unknown", 0, 1)
            {
            }

            public Score(string name, int points, int level)
            {
                this.name = name;
                this.points = points;
                this.level = level;
            }
            public bool EarnedStar() => (points / level) > 1000;
        }
    }
}
