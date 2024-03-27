using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class TipoDocumentoVentaDb : DaoBase<TipoDocumentoVenta>, ITipoDocumentoVentaDb
    {


        public TipoDocumentoVentaDb(SalesContext context) : base(context) { }


        /*      public bool Exists(string id)
              {
                  int.TryParse(id, out int outId);

                  return this._documentos.Exists(u => u.Id == outId);
              }

              public List<TipoDocumentoVenta> GetAll()
              {
                  return this._documentos.Where(vd => !vd.Eliminado).ToList();
              }

              public TipoDocumentoVenta GetById(int Id)
              {
                  return this._documentos.Single(vd => vd.Id == Id);
              }

              public DataResult Save(TipoDocumentoVenta entity)
              {
                  DataResult result = new DataResult();
                  try
                  {
                      if (this.Exists(entity.Id.ToString()))
                          throw new TipoDocumentoVentaException("El usuario ya se encuentra registrada.");

                  }

                  catch (Exception ex)
                  {
                      result.Success = false;
                      result.Message = $"Ocurrió el siguiente error: {ex.Message}";
                  }

                  return result;
              }

              public void Update(TipoDocumentoVenta entity)
              {
                  this._documentos.Add(entity);
              }*/
    }
}
