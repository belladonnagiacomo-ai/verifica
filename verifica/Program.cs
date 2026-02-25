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
        static void Main(string[] args)
        {

            string parola = "ILMATNOHRBC";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            completa(parola, alfabeto);
        }
    }
}
