using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using VehiculosITM.Models;

namespace VehiculoesITM.Clases
{
	public class ManejoVehiculoes
	{
        private Vehiculos_ITMEntities2 dbVehiculo = new Vehiculos_ITMEntities2();

        public string Ingresar(Vehiculo vehiculo)
        {
            try
            {
                dbVehiculo.Vehiculoes.Add(vehiculo);
                dbVehiculo.SaveChanges();
                return "Vehiculo ingresado correctamente";
            }

            catch (Exception ex)
            {
                return "error al ingresar el Vehiculo: " + ex.Message;

            }
        }
        public List<Vehiculo> ConsultarTodos()
        {
            return dbVehiculo.Vehiculoes.ToList();

        }
        public Vehiculo Consultarxid(int id)
        {
            return dbVehiculo.Vehiculoes.FirstOrDefault(e => e.id_vehiculo == id); //consulta una Vehiculo por su id
                                                                             //retorna la vent consultado

        }
        public string Actualizar(Vehiculo vehiculo)
        {

            Vehiculo veh = dbVehiculo.Vehiculoes.FirstOrDefault(e => e.id_vehiculo == vehiculo.id_vehiculo);
            try
            {

                if (veh == null)
                {

                    return "El Vehiculo no existe";
                }
                dbVehiculo.Vehiculoes.AddOrUpdate(vehiculo);
                dbVehiculo.SaveChanges(); 
                return "Vehiculo  actualizado correctamente"; 


            }
            catch (Exception ex)
            {
                return "error al actualizar el Vehiculo: " + ex.Message; //retorna un mensaje de error

            }

        }
        public string Eliminar(Vehiculo vehiculo)
        {

            try
            {
                Vehiculo veh = dbVehiculo.Vehiculoes.FirstOrDefault(e => e.id_vehiculo == vehiculo.id_vehiculo);
                if (veh == null)
                {
                    return "La Vehiculo no existe";
                }
                dbVehiculo.Vehiculoes.Remove(veh);
                dbVehiculo.SaveChanges();
                return "Vehiculo eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return "error al eliminar el Vehiculo " + ex.Message;
            }
        }
        public string eliminarxid(int id)
        {
            try
            {
                Vehiculo veh = dbVehiculo.Vehiculoes.FirstOrDefault(e => e.id_vehiculo == id);
                if (veh == null)
                {
                    return "La Vehiculo no existe";
                }
                dbVehiculo.Vehiculoes.Remove(veh);
                dbVehiculo.SaveChanges();
                return "Vehiculo eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "error al eliminar el Vehiculo " + ex.Message;
            }

        }
    }
}

    
