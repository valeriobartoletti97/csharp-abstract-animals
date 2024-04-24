namespace csharp_abstract_animals
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto allo zoo!");

            List<Animale> animali = new List<Animale>();
            animali.Add(new Cane());
            animali.Add(new Delfino());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());

            //ESERCIZIO 2
            void FaiNuotare(INuotatore animale)
            {
                animale.Nuota();
            }
            void FaiVolare(IVolante animale)
            {
                animale.Vola();
            }
            //
            int contatore = 0;
            foreach (Animale animale in animali)
            {
                contatore++;
                Console.Write($"{contatore}) ");
                animale.Mangia();
                animale.Verso();
                animale.Dormi(); //FINE ESERCIZIO 1

                //Ho usato questa sintassi perchè gli oggetti li ho istanziati con la classe Animale ed avevo già fatto il ciclo
                //Mi accerto che siano di tipo Ivolante oppure INuotatore ed eseguo le funzioni
                if (animale is IVolante)
                {
                    FaiVolare((IVolante)animale);
                }
                if (animale is INuotatore)
                {
                    FaiNuotare((INuotatore)animale);
                }
            }
            Passerotto passerotto2 = new Passerotto();
            animali.Add(passerotto2);
            FaiVolare(passerotto2);
        }
    }
}
