using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPService.Persistencia;
using SOAPService.Dominio;

namespace SOAPService
{    
    public class Asesores : IAsesores
    {
         
        private AsesorDAO asesorDAO = new AsesorDAO();
       //private AsesorDAO AsesorDAO
       // {
       //     get
       //     {
       //         if (asesorDAO == null)
       //             asesorDAO = new AsesorDAO();
       //         return asesorDAO;
       //     }
       // }
        private SedeDAO sedeDAO = new SedeDAO();
        //private SedeDAO SedeDAO{
        //    get{
        //        if (sedeDAO==null)
        //            sedeDAO=new SedeDAO();
        //          return sedeDAO;
        //    }            
        //}


public Asesor CrearAsesor(string nombre, string correo, int sede)
{
    Sede sedeExistente=sedeDAO.Obtener(sede);
    Asesor asesorACrear=new Asesor(){

    Nombre=nombre,
    Correo=correo,
    Sede=sedeExistente
 };
    return asesorDAO.Crear(asesorACrear);
}

public Asesor ObtenerAsesor(int codigo)
{
 	return asesorDAO.Obtener(codigo);
}

public Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede)
{
    Sede sedeExistente = sedeDAO.Obtener(sede);
    Asesor asesorModificar = new Asesor()
    {
        Codigo = codigo,
        Nombre = nombre,
        Correo = correo,
        Sede   = sedeExistente
    };

    return asesorDAO.Modificar(asesorModificar);
}

public void  EliminarAsesor(int codigo)
{
    Asesor asesorExistente = asesorDAO.Obtener(codigo);
    asesorDAO.Eliminar(asesorExistente);
}

public List<Asesor>  ListarAsesores()
{
    return asesorDAO.ListarTodos().ToList();
}

}
}

