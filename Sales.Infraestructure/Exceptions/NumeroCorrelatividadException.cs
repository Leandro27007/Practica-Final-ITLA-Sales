namespace Sales.Infraestructure.Exceptions
{
    public class NumeroCorrelatividadException : Exception
    {
        public NumeroCorrelatividadException(string message) : base(message)
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
