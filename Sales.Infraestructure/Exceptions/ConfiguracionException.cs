namespace Sales.Infraestructure.Exceptions
{
    public class ConfiguracionException: Exception
    {
        public ConfiguracionException(string message) : base(message)
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
