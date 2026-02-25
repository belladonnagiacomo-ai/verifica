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
            for(int i = 0; i < p.Length; i++)
            {
                if()
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("dimmi una parola");
            string p = Console.ReadLine();
         
            string parola = "ILMATNOHRBC";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            completa(parola, alfabeto);
        }
    }
}
