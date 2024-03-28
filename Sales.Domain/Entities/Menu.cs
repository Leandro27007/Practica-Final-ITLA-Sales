using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Menu : BaseAuditable, IActivable
    {
        public string Descripcion { get; set; }
        public int MenuPadre { get; set; }
        public string Icon { get; set; }
        public string Controlador { get; set; }
        public string PaginaAccion { get; set; }
        public bool EsActivo { get; set; }
    }
}
