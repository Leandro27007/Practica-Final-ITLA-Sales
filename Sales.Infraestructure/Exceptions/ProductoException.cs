namespace Sales.Infraestructure.Exceptions
{
    public class ProductoException : Exception
    {
        public ProductoException(string message) : base(message)
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
