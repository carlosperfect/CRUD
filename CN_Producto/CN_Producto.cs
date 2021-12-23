using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class lista
    {
        private CD_Producto objetoCD = new CD_Producto();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string nombre, string desc, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}