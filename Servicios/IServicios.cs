using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HPV.Core.Dominio;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicios
    {
        //metodos hotel
        [OperationContract]
        int modificarHotel(Hotel hotel);

        //metodos direccion
        [OperationContract]
        Direccion obtenerDireccion();
        [OperationContract]
        int modificarDireccion(Direccion direccion);

        //metodos publicidad
        [OperationContract]
        int insertarPublicidad(Publicidad publicidad);
        [OperationContract]
        int modificarPublicidad(Publicidad publicidad);
        [OperationContract]
        int eliminarPublicidad(int idPubliciad);
        [OperationContract]
        Publicidad obtenerPublicidad(int idPublicidad);
        [OperationContract]
        List<Publicidad> obtenerPublicidades();
    }
}
