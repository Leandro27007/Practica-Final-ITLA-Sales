namespace Sales.Infraestructure.Exceptions
{
    public class CategoriaException : Exception
    {
        public CategoriaException(string message) : base(message)
        {
            SaveError(message);
        }

        void SaveError(string message)
        {
            //Logica para guardar el error.
            Console.WriteLine(message);
        }
    }
}
