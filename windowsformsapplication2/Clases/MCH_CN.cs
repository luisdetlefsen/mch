using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public class MCH_CN
    {
        string conn = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=MCH;Integrated Security=True";
        //string conn="Data Source=JUANPC\\SQLEXPRESS;Initial Catalog=MCH;Integrated Security=True";

      
        public DataTable getLectura_Nopagada(String ID_Contador)
        {
            DataTable MiTabla = new DataTable();
                          
                SqlConnection conexion = new SqlConnection(conn);
                conexion.Open();


                SqlCommand cmd  = new SqlCommand("sp_get_lectura_no_pagada", conexion);
                
               
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Contador", Convert.ToInt32(ID_Contador));

                
                SqlDataAdapter MiAdaptador = new SqlDataAdapter(cmd);
                MiAdaptador.Fill(MiTabla);

                conexion.Close();

                return MiTabla;
                
           
        }
        public void Ejecutar_stored_procedure_eliminar_lectura(int id_lectura)
        {
            SqlConnection conexion = new SqlConnection(conn);
            conexion.Open();


            SqlCommand cmd = new SqlCommand("sp_elimina_lectura", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
            cmd.ExecuteNonQuery();



            conexion.Close();
        }

        public void Ejecutar_stored_procedure_sp_ingresar_historial_lectura_eliminada(string nombre_usuario, int id_lectura)
        {
            SqlConnection conexion = new SqlConnection(conn);
            conexion.Open();


            SqlCommand cmd = new SqlCommand("sp_ingresar_historial_lectura_eliminada", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
            cmd.Parameters.AddWithValue("@id_lectura", id_lectura);
            cmd.ExecuteNonQuery();



            conexion.Close();
        }

        public void Ejecutar_stored_procedure_insertar_comunidad(string nombre_sp, string vchrnombrecomunidad, int id_hidroelectrica, int cargo_comunidad)
        {
            SqlConnection conexion = new SqlConnection(conn);
            conexion.Open();

            
                SqlCommand cmd = new SqlCommand(nombre_sp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vchrnombrecomunidad", vchrnombrecomunidad);
                cmd.Parameters.AddWithValue("@ID_Hidroelectrica", id_hidroelectrica);
                cmd.Parameters.AddWithValue("@Cargo_comunidad", cargo_comunidad);
                cmd.ExecuteNonQuery();

            

            conexion.Close();
        }

        public void Ejecutar_stored_procedure_actualizar_comunidad(string nombre_sp, string vchrnombrecomunidad, int id_hidroelectrica, int cargo_comunidad)
        {
            SqlConnection conexion = new SqlConnection(conn);
            conexion.Open();

            
                SqlCommand cmd = new SqlCommand(nombre_sp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vchrnombrecomunidad", vchrnombrecomunidad);
                cmd.Parameters.AddWithValue("@ID_Hidroelectrica", id_hidroelectrica);
                cmd.Parameters.AddWithValue("@Cargo_comunidad", cargo_comunidad);
                cmd.ExecuteNonQuery();

            

            conexion.Close();
        }

        public void Ejecutar_stored_procedure_eliminar_comunidad(string nombre_sp, string vchrnombrecomunidad, int id_hidroelectrica)
        {
            SqlConnection conexion = new SqlConnection(conn);
            conexion.Open();


            SqlCommand cmd = new SqlCommand(nombre_sp, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vchrnombrecomunidad", vchrnombrecomunidad);
            cmd.Parameters.AddWithValue("@ID_Hidroelectrica", id_hidroelectrica);
            cmd.ExecuteNonQuery();


            conexion.Close();
        }
    }
}
