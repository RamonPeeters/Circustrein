using System.Collections.Generic;
using System.Linq;

namespace CircusTrein
{
    public class Trein
    {
        private readonly List<Wagon> Wagons;

        public Trein()
        {
            Wagons = new List<Wagon>();
        }

        public void Verdeel(List<Dier> dieren)
        {
            Dier[] gesorteerdeDieren = dieren.OrderBy(v => v.DierVoedsel).ThenBy(g => g.DierGrootte).ToArray();

            Wagons.Clear();
            for (int i = 0; i < gesorteerdeDieren.Length; i++)
            {
                AddToWagon(gesorteerdeDieren[i]);
            }
        }

        private void AddToWagon(Dier dier)
        {
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i].TryAdd(dier))
                {
                    return;
                }
            }
            Wagons.Add(new Wagon(dier));
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }
    }
}
