namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score score1 = new Score();

        }

        class Score
        {
            public string name;
            public int points;
            public int level;

            public Score()
            {
                name = "Ahmed";
                points = 0;
                level = 1;
            }

            public bool EarnedStar() => (points / level) > 1000;
        }
    }
}
