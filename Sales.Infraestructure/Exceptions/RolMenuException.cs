namespace Sales.Infraestructure.Exceptions
{
    public class RolMenuException : Exception
    {
        public RolMenuException(string message) : base(message)
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
