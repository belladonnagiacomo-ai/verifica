namespace verifica
{
    internal class Program
    {
        static void completa(string parola, string alfabeto)
        {
            for(int i = 0; i < parola.Length; i++)
            {
                Console.Write(parola[i]);
            }
        }
        static void Main(string[] args)
        {

            string parola = "ILMATNOHRBC";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            completa(parola, alfabeto);
        }
    }
}
