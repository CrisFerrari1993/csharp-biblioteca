namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.GeneraDocumenti();
            biblioteca.GeneraDocumenti();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Scegli un opzione");
                Console.WriteLine("1) Effettua un prestito");
                Console.WriteLine("2) Mostra i documenti");
                Console.WriteLine("3) Cerca Prestiti");
                Console.WriteLine("4) Esci");
                int risposta = Convert.ToInt32(Console.ReadLine());

                switch (risposta)
                {
                    case 1:
                        biblioteca.checkDocument();
                        break;
                    case 2:
                        biblioteca.GetAllDocuments();
                        break;
                    case 3:
                        biblioteca.GetPrestito();
                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Non è stata selezionata un opzione valida");
                        break;
                }
            }

        }
    }
}
