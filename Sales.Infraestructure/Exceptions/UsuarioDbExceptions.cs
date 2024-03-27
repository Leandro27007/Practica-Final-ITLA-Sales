namespace Sales.Infraestructure.Exceptions
{
    public class UsuarioDbExceptions : Exception
    {
        public UsuarioDbExceptions(string message) : base(message)
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
