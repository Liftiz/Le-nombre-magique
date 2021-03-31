using System;

namespace Le_nombre_magique
{
    class Program
    {

        static int DemanderNombre(int min, int max)
        {
           
            int nombre = 0;
            while ((nombre < min) || (nombre > max)) {
                Console.Write("Rentrer un nombre entre " + min + " et " + max + " : ");
                string repons = Console.ReadLine();
                try
            {   
                nombre = int.Parse(repons);
                    if ((nombre < min) || (nombre > max)) {
                        Console.WriteLine("Erreur : le nombre doit etre entre " + min + " et " + max);
                    }
            }
            catch
            {
                Console.WriteLine("Erreur");
            }
            }
            return nombre;
        }
        static void Main(string[] args)
        {

            const int nb_min = 1;
            const int nb_max = 10;
            const int nb_magique = 5;
           int nomb = DemanderNombre(nb_min, nb_max);
            Console.Write("Voter nombre est " + nomb);

            if (nb_magique > nomb)
            {
                Console.WriteLine("Le nombre magique est plus grand");
            }
            else if ( nb_magique < nomb)
            {
                Console.WriteLine("Le nombre magique est plus petit");
            }
            else
            {
                Console.WriteLine("Vous avez trouver le nombre magique");
            }
        }
    }
}
