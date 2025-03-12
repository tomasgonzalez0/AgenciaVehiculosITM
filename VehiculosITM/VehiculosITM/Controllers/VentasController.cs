using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehiculosITM.Models;
using VehiculosITM.Clases;
using System.Web.Http;



namespace VehiculosITM.Controllers
{
    [RoutePrefix("api/Venta")]
    public class VentasController : ApiController
    {
        // GET: Ventas


            [HttpGet]
            [Route("ConsultarTodos")]
            public List<Venta> ConsultarTodos()
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.ConsultarTodos();

            }
            [HttpGet]
            [Route("Consultarxid")]
            public Venta Consultarxid(int id)
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.Consultarxid(id);
            }
            [HttpPost]
            [Route("Ingresar")]
            public string Ingresar([FromBody] Venta Venta)
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.Ingresar(Venta);
            }
            [HttpPut]
            [Route("Actualizar")]
            public string Actualizar([FromBody] Venta Venta)
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.Actualizar(Venta);
            }
            [HttpDelete]
            [Route("Eliminar")]
            public string Eliminar(Venta Venta)
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.Eliminar(Venta);
            }
            [HttpDelete]
            [Route("Eliminarid")]
            public string Eliminarxid(int id)
            {
                ManejoVentas manejoVentas = new ManejoVentas();
                return manejoVentas.eliminarxid(id);
            }

        }


    }

