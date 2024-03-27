namespace Sales.Infraestructure.Exceptions
{
    public class VentaException : Exception
    {
        public VentaException(string message) :base(message)
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
