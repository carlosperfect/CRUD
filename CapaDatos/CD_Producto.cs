using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Producto
    {
        private Conexion_DB conexion = new Conexion_DB();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from producto";
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            conexion.CerrarConexion();
            return Tabla;

        }

        public void  Insertar(string nombre,string desc,string marca,double precio,int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO PRODUCTO VALUES ('"+nombre+"','"+desc+"','"+marca+"',"+precio+","+stock+")";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM PRODUCTO where Id="+id+"";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /*public void Editar(string nombre, string desc, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE PRODUCTO SET @Nombre='"+nombre+"'";
            comando.ExecuteNonQuery();

        }*/
    }
}
