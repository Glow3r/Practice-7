namespace Practice_7
{
    class Triad
    {
        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public static Triad operator +(Triad triad, int summand = 1) => new Triad(
                triad.First + summand,
                triad.Second + summand,
                triad.Third + summand);

        public static Triad operator +(Triad firsttriad, Triad secondtriad) => new Triad(
                firsttriad.First + secondtriad.First,
                firsttriad.Second + secondtriad.Second,
                firsttriad.Third + secondtriad.Third);
       
        public Triad Multiply(int multiplier = 2) => new Triad(First * multiplier, Second * multiplier, Third * multiplier);

        public bool AreEqual() => First == Second && Second == Third;
    }
}
