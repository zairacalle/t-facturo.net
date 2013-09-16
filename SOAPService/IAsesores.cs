using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPService.Dominio;

namespace SOAPService
{    
    [ServiceContract]
    public interface IAsesores
    {
        [OperationContract]
        Asesor CrearAsesor(string nombre, string correo,int sede);
        [OperationContract]
        Asesor ObtenerAsesor(int codigo);
        [OperationContract]
        Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede);
        [OperationContract]
        void EliminarAsesor(int codigo);
        [OperationContract]
        List<Asesor> ListarAsesores();
    }
}
