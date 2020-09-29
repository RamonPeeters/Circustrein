namespace CircusTrein
{
    public class Dier
    {
        public Voedsel DierVoedsel { get; }
        public Grootte DierGrootte { get; }

        public Dier(Voedsel dierVoedsel, Grootte dierGrootte)
        {
            DierVoedsel = dierVoedsel;
            DierGrootte = dierGrootte;
        }
    }
}
