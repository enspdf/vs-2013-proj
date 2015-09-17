using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class AreaModel
    {
        DataEmpresaDataContext contexto = new DataEmpresaDataContext();

        public List<area> ListarAreas()
        {
            List<area> lista = new List<area>();
            var consulta = contexto.PR_LISTAR_AREA();

            foreach (var area in consulta)
            {
                area a = new area();
                a.area_cod = area.area_cod;
                a.area_des = area.area_des;

                lista.Add(a);
            }
            return lista;
        }

        public area BuscarArea(int codigo)
        {
            area a = new area();
            try
            {
                var consulta = contexto.PR_BUSCAR_AREA(codigo);

                foreach (var area in consulta)
                {
                    a.area_cod = area.area_cod;
                    a.area_des = area.area_des;
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return a;
        }

        public string InsertarArea(area a)
        {
            string resultado = String.Empty;
            try
            {
                contexto.PR_INSERTAR_AREA(a.area_des);
                resultado = "Ok";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        public string ActualizarArea(area a)
        {
            string resultado = String.Empty;
            try
            {
                contexto.PR_ACTUALIZAR_AREA(a.area_cod, a.area_des);
                resultado = "Ok";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        public string EliminarArea(int codigo)
        {
            string resultado = String.Empty;
            try
            {
                contexto.PR_ELIMINAR_AREA(codigo);
                resultado = "Ok";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }
    }
}