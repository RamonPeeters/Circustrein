using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Wagon
    {
        private const int MAXIMUM_GROOTTE = 10;
        private readonly List<Dier> Dieren;
        private int Punten => Dieren.Sum(d => (int)d.DierGrootte);

        public Wagon()
        {
            Dieren = new List<Dier>();
        }

        public Wagon(Dier dier) : this()
        {
            Dieren.Add(dier);
        }

        public bool TryAdd(Dier dier)
        {
            // Huidig dier is een vleesetend dier, wagon bevat kleiner of even groot dier
            if (dier.DierVoedsel == Voedsel.Vlees && Dieren.Any(d => d.DierGrootte <= dier.DierGrootte))
                return false;

            // Wagon bevat even groot of groter vleesetend dier
            if (Dieren.Any(d => d.DierGrootte >= dier.DierGrootte && d.DierVoedsel == Voedsel.Vlees))
                return false;

            // Dier past niet in wagon
            if (Punten + (int)dier.DierGrootte > MAXIMUM_GROOTTE) return false;

            Dieren.Add(dier);
            return true;
        }
    }
}
