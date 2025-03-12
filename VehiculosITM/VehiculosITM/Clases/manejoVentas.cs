using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using VehiculosITM.Models;

namespace VehiculosITM.Clases
{
	public class ManejoVentas
	{
        private Vehiculos_ITMEntities2 dbVehiculo = new Vehiculos_ITMEntities2();

        public string Ingresar(Venta venta)
        {
            try
            {
                dbVehiculo.Ventas.Add(venta);
                dbVehiculo.SaveChanges();
                return "Venta ingresada correctamente";
            }

            catch (Exception ex)
            {
                return "error al ingresar la Venta: " + ex.Message;

            }
        }
        public List<Venta> ConsultarTodos()
        {
            return dbVehiculo.Ventas.ToList();

        }
        public Venta Consultarxid(int id)
        {
            return dbVehiculo.Ventas.FirstOrDefault(e => e.id_venta == id); //consulta una Venta por su id
                                                                             //retorna la vent consultado

        }
        public string Actualizar(Venta venta)
        {

            Venta ven = dbVehiculo.Ventas.FirstOrDefault(e => e.id_venta == venta.id_venta);
            try
            {

                if (ven == null)
                {

                    return "La venta no existe";
                }
                dbVehiculo.Ventas.AddOrUpdate(venta);
                dbVehiculo.SaveChanges(); 
                return "venta  actualizada correctamente"; 


            }
            catch (Exception ex)
            {
                return "error al actualizar la venta: " + ex.Message; //retorna un mensaje de error

            }

        }
        public string Eliminar(Venta venta)
        {

            try
            {
                Venta ven = dbVehiculo.Ventas.FirstOrDefault(e => e.id_venta == venta.id_venta);
                if (ven == null)
                {
                    return "La venta no existe";
                }
                dbVehiculo.Ventas.Remove(ven);
                dbVehiculo.SaveChanges();
                return "Venta eliminada exitosamente";
            }
            catch (Exception ex)
            {
                return "error al eliminar la venta " + ex.Message;
            }
        }
        public string eliminarxid(int id)
        {
            try
            {
                Venta ven = dbVehiculo.Ventas.FirstOrDefault(e => e.id_venta == id);
                if (ven == null)
                {
                    return "La venta no existe";
                }
                dbVehiculo.Ventas.Remove(ven);
                dbVehiculo.SaveChanges();
                return "Venta eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "error al eliminar la venta " + ex.Message;
            }

        }
    }
}

    
