namespace PRactica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usando WriteLine
            Console.WriteLine("Hola");
            Console.WriteLine("Mundo");

            Console.WriteLine("--- Separador ---"); // Para ver la diferencia

            // Usando Write
            Console.Write("Adiós "); // Nota el espacio al final de "Adiós "
            Console.Write("Mundo ");
            Console.Write("Cruel");

            Console.WriteLine(); // Agrego un WriteLine vacío para bajar a la siguiente línea antes de que termine el programa
            Console.WriteLine("--- Fin ---");

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
