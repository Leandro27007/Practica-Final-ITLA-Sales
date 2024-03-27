using Sales.AppServices.Core;
using Sales.Infraestructure.Exceptions;

namespace Sales.AppServices
{
    public class SalesAppService
    {
        public ServiceResult Save()
        {

            var result = new ServiceResult();

            try
            {

            }
            catch (VentaException vex)
            {

                result.Success = false;
                result.Message = vex.Message;
            }

            return result;
        }
    }
}
