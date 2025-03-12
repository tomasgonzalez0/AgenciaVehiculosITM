using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehiculosITM.Models;
using System.Web.Http;
using VehiculoesITM.Clases;



namespace VehiculosITM.Controllers
{
    [RoutePrefix("api/Vehiculo")]
    public class VehiculosController : ApiController
    {
        // GET: Vehiculoes


            [HttpGet]
            [Route("ConsultarTodos")]
            public List<Vehiculo> ConsultarTodos()
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.ConsultarTodos();

            }
            [HttpGet]
            [Route("Consultarxid")]
            public Vehiculo Consultarxid(int id)
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.Consultarxid(id);
            }
            [HttpPost]
            [Route("Ingresar")]
            public string Ingresar([FromBody] Vehiculo vehiculo)
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.Ingresar(vehiculo);
            }
            [HttpPut]
            [Route("Actualizar")]
            public string Actualizar([FromBody] Vehiculo vehiculo)
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.Actualizar(vehiculo);
            }
            [HttpDelete]
            [Route("Eliminar")]
            public string Eliminar(Vehiculo vehiculo)
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.Eliminar(vehiculo);
            }
            [HttpDelete]
            [Route("Eliminarid")]
            public string Eliminarxid(int id)
            {
                ManejoVehiculoes manejoVehiculoes = new ManejoVehiculoes();
                return manejoVehiculoes.eliminarxid(id);
            }

        }


    }

