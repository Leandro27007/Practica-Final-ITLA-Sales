namespace Sales.Web.Models.Result
{
    public class ServiceResult<T>
    {
        public string? message { get; set; }
        public bool success { get; set; } = true;
        public T data { get; set; }
    }
}
