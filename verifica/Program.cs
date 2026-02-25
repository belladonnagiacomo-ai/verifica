namespace verifica
{
    internal class Program
    {
        static void completa(string parola, string alfabeto)
        {
            bool c;
            for (int i = 0; i < alfabeto.Length; i++)
            {
                c = false;
                for (int j = 0; j < parola.Length; j++)
                {
                   c = parola.Contains(alfabeto[i]);
                   

                }
                if (c == true)
                {

                }
                else
                {
                    parola += alfabeto[i];
                }
               
            }
            Console.WriteLine(parola);
        }
        static void diverso(string p)
        {
            string pa = p;
            bool c;
            int k = 0;
            for(int i = 0; i < p.Length; i++)
            {
                k = 0;
                for(int j = 0; j < p.Length; j++)
                {
                   
                    if (p[i] == pa[j])
                    {
                        k++;
                        if(k >= 2)
                        {
                            Console.WriteLine("La parola " + p + " contiene piu volte la stessa lettera");
                            return;
                        }
                    }
                    
                }
               
            }
            Console.WriteLine("La parola non si ripete in lettere");
        }
        static void lancioD(int[] array)
        {
          
            Random rand = new Random();
            for(int i = 0; i < 20; i++)
            {
                int rnd = rand.Next(1, 6);
                array[i] = rnd;
                
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("dimmi una parola");
            string p = Console.ReadLine();
            diverso(p);
            Console.WriteLine("--------------------------------------");
            string parola = "ILMATNOHRBC";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            completa(parola, alfabeto);
        }
    }
}
