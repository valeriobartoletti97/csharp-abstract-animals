namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();
            animali.Add(new Cane());
            animali.Add(new Delfino());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            foreach (Animale animale in animali)
            {
                animale.Mangia();
                animale.Verso();
                animale.Dormi();
            }
        }
    }
}
