namespace Sales.Infraestructure.Exceptions
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message)
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
