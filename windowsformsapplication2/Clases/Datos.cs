using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public static class Sesion
    {
        public static string Log;
    }

	public class Datos
	{
		#region Variables globales
		private static SqlConnection MiConexion;
        private static String LogId;
		#endregion

		#region Métodos públicos


        #region Reporteria

        public static void GetReportesMCH(ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetReportesMCH", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros                

                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
            }
            catch (Exception E)
            {
            }
        }

        public static void GetCamposReporteMCH(Int32 iReporte, ref DataTable dtTabla)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetCamposReporteMCH", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                MiComando.Parameters.Add(ParametroEntrada("@IdReporte", SqlDbType.BigInt, iReporte));


                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);

                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
            }
            catch (Exception E)
            {
            }
        }

        public static void GetDataQueryMCH(string query, ref DataTable dtTabla)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand(query, MiConexion);
                MiComando.CommandType = CommandType.Text;

                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);

                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
            }
            catch (Exception E)
            {
            }
        }
        #endregion


        #region Manejo de usuarios
        public static int VerificarLogIn(string ps_usuario, string ps_contraseña)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_LoginUser", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Login_user", SqlDbType.VarChar, 20, ps_usuario));
                MiComando.Parameters.Add(ParametroEntrada("@Password", SqlDbType.VarChar, 16, ps_contraseña));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }

        public static int CrearUsuario(string ps_nombre, string ps_usuario, string ps_contraseña, string ps_login)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_AgregarUsuario", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Login_user", SqlDbType.VarChar, 20, ps_usuario));
                MiComando.Parameters.Add(ParametroEntrada("@Pass", SqlDbType.VarChar, 16, ps_contraseña));
                MiComando.Parameters.Add(ParametroEntrada("@Nombre", SqlDbType.VarChar, 255, ps_contraseña));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_contraseña));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }

        public static int DesasociarOpcion(Int32 IdPerfil, String Opcion)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_desasociar_Perfil_Opcion", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Id_Perfil", SqlDbType.BigInt, IdPerfil));
                MiComando.Parameters.Add(ParametroEntrada("@Opcion", SqlDbType.VarChar, 50, Opcion));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }



        public static int CrearPerfil(string ps_nombre, string ps_descripcion, string ps_login)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_AgregarPerfil", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Nombre", SqlDbType.VarChar, 20, ps_nombre));
                MiComando.Parameters.Add(ParametroEntrada("@Descripcion", SqlDbType.VarChar, 100, ps_descripcion));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_login));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }

        public static int VerificaPermiso(string LoginUser, int opcion)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_VerificaPermiso", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Login_user", SqlDbType.VarChar, 20, LoginUser));
                MiComando.Parameters.Add(ParametroEntrada("@Id_Opcion", SqlDbType.Int, 100, opcion));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }
        public static int ObtenerPerfil(ref Int32[] Id, ref String[] Nombre, ref String[] Descripcion)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_ObtenerPerfiles", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < MisTablas.Tables[0].Rows.Count; i++)
                        {
                            Id[i] = new Int32();
                            Id[i] = Convert.ToInt32(MisTablas.Tables[0].Rows[i][0]);
                            Nombre[i] = MisTablas.Tables[0].Rows[i][1].ToString();
                            Descripcion[i] = MisTablas.Tables[0].Rows[i][2].ToString();
                        }
                    }
                    pi_Resultado = MisTablas.Tables[0].Rows.Count;
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }

        public static int ObtenerPerfilOpciones(int Id, ref int[] OpcionesId, ref string[] Nombre, ref int[] Tipo)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_ObtenerPerfilOpciones", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@IdPerfil", SqlDbType.Int, 3, Id));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < MisTablas.Tables[0].Rows.Count; i++)
                        {
                            OpcionesId[i] = new Int32();
                            Tipo[i] = new Int32();
                            OpcionesId[i] = Convert.ToInt32(MisTablas.Tables[0].Rows[i][0]);
                            Nombre[i] = MisTablas.Tables[0].Rows[i][1].ToString();
                            Tipo[i] = Convert.ToInt32(MisTablas.Tables[0].Rows[i][2]);
                        }
                    }
                    pi_Resultado = MisTablas.Tables[0].Rows.Count;
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }
        public static int CrearAsociacionPerfilOpcion(int idperfil, int idopcion, string ps_login)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Asociar_Perfil_Opcion", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Id_Perfil", SqlDbType.Int, 3, idperfil));
                MiComando.Parameters.Add(ParametroEntrada("@Id_Opcion", SqlDbType.Int, 3, idopcion));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_login));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }


        public static int ObtenerPerfilUsuarios(int Id, ref  string[] OpcionesId, ref string[] Nombre, ref int[] Tipo)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_ObtenerPerfilUsuarios", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@IdPerfil", SqlDbType.Int, 3, Id));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < MisTablas.Tables[0].Rows.Count; i++)
                        {
                            Tipo[i] = new Int32();
                            OpcionesId[i] = MisTablas.Tables[0].Rows[i][0].ToString();
                            Nombre[i] = MisTablas.Tables[0].Rows[i][1].ToString();
                            Tipo[i] = Convert.ToInt32(MisTablas.Tables[0].Rows[i][2]);
                        }
                    }
                    pi_Resultado = MisTablas.Tables[0].Rows.Count;
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }
        public static int CrearAsociacionPerfilUsuarios(int idperfil, string idopcion, string ps_login)
        {
            int iResultado, pi_Resultado;
            string ps_Mensaje;
            try
            {
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;


                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Asociar_Perfil_Usuario", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Id_Perfil", SqlDbType.Int, 3, idperfil));
                MiComando.Parameters.Add(ParametroEntrada("@Login_user", SqlDbType.VarChar, 20, idopcion));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_login));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_Resultado = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count > 0)
                    {
                        pi_Resultado = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
            return pi_Resultado;
        }


        #endregion


        /* ---------------------- Persona ---------------------- */
        public static void CrearPersona(string ps_Codigo, string ps_NombrePersona, string ps_CUI, string ps_NoRegistro, Int32 pi_NoCedula, int pi_Sexo, DateTime pd_Fecha, int pi_Comunidad, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                string sSexo = pi_Sexo.ToString();
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_CrearPersona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Codigo", SqlDbType.VarChar, 25, ps_Codigo));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNombre", SqlDbType.VarChar, 225, ps_NombrePersona));
                MiComando.Parameters.Add(ParametroEntrada("@vchrCUI", SqlDbType.VarChar, 10, ps_CUI));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                if (pi_NoCedula >= 0)
                {
                    MiComando.Parameters.Add(ParametroEntrada("@intNo_Cedula", SqlDbType.Int, pi_NoCedula));
                }
                else
                {
                    MiComando.Parameters.Add(ParametroEntrada("@intNo_Cedula", SqlDbType.Int, null));
                }
                MiComando.Parameters.Add(ParametroEntrada("@Sexo", SqlDbType.VarChar, 1, sSexo));
                MiComando.Parameters.Add(ParametroEntrada("@Fecha_Nacimiento", SqlDbType.DateTime, pd_Fecha));
                MiComando.Parameters.Add(ParametroEntrada("@intID_Comunidad", SqlDbType.Int, pi_Comunidad));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        public static void ModificarPersona(Int32 pi_ID, string ps_Codigo, string ps_NombrePersona, string ps_CUI, string ps_NoRegistro, Int32 pi_NoCedula, string ps_Sexo, DateTime pd_Fecha, int pi_Comunidad, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_ModificarPersona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Codigo", SqlDbType.VarChar, 25, ps_Codigo));
                MiComando.Parameters.Add(ParametroEntrada("@ID_Persona", SqlDbType.Int, pi_ID));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNombre", SqlDbType.VarChar, 225, ps_NombrePersona));
                MiComando.Parameters.Add(ParametroEntrada("@vchrCUI", SqlDbType.VarChar, 10, ps_CUI));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                if (pi_NoCedula >= 0)
                {
                    MiComando.Parameters.Add(ParametroEntrada("@intNo_Cedula", SqlDbType.Int, pi_NoCedula));
                }
                else
                {
                    MiComando.Parameters.Add(ParametroEntrada("@intNo_Cedula", SqlDbType.Int, null));
                }
                MiComando.Parameters.Add(ParametroEntrada("@Sexo", SqlDbType.VarChar, 1, ps_Sexo));
                MiComando.Parameters.Add(ParametroEntrada("@Fecha_Nacimiento", SqlDbType.DateTime, pd_Fecha));
                MiComando.Parameters.Add(ParametroEntrada("@intID_Comunidad", SqlDbType.Int, pi_Comunidad));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        public static void EliminarPersona(Int32 pi_ID, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_EliminarPersona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Persona", SqlDbType.Int, pi_ID));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        public static void BuscarPersona(string ps_NombrePersona, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarPersona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrNombre", SqlDbType.VarChar, 225, ps_NombrePersona));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        /*
        public static void BuscarPersonaPorID(Int32 pi_IDPersona, ref string ps_Mensaje, ref Int32 pi_Resultado, ref string ps_Nombre)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarPersona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@intIDPersona", SqlDbType.Int, pi_IDPersona));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                if (MiTabla.Rows.Count > 0 )
                {
                    ps_Nombre = MiTabla.Rows[0][1].ToString();
                }
                else
                {
                    ps_Nombre = "";
                }
                
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        */

        /* ---------------------- Contrato ---------------------- */
        public static void CrearContrato(string ps_IDPersona, string ps_IDContador, ref string ps_Mensaje, ref Int32 pi_Resultado, ref Int32 pi_NuevoSecuencial)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataSet MisTablas;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_CrearContrato", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrPersona", SqlDbType.NChar, 25, ps_IDPersona));
                MiComando.Parameters.Add(ParametroEntrada("@vchrContador", SqlDbType.VarChar, 50, ps_IDContador));

                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MisTablas = new DataSet();
                MiAdaptador = new SqlDataAdapter(MiComando);


                // Ejecución del stored procedure
                MiAdaptador.Fill(MisTablas);
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
                pi_NuevoSecuencial = -1;
                if (MisTablas.Tables.Count > 0)
                {
                    if (MisTablas.Tables[0].Rows.Count> 0)
                    {
                        pi_NuevoSecuencial = Convert.ToInt32(MisTablas.Tables[0].Rows[0][0]);
                    }
                }
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -100;
            }
        }
        public static void EliminarContrato(int pi_ID, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_EliminarContrato", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrContrato", SqlDbType.Int, pi_ID));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -100;
            }
        }
        public static void BuscarContrato(string ps_NombrePersona, string ps_IDContador, bool pb_Historico, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarContrato", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrNombre", SqlDbType.VarChar, 225, ps_NombrePersona));
                MiComando.Parameters.Add(ParametroEntrada("@vchrContador", SqlDbType.VarChar, 50, ps_IDContador));
                MiComando.Parameters.Add(ParametroEntrada("@intHistorico", SqlDbType.Int, pb_Historico ? 1 : 0));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -100;
            }
        }
        public static void VerificarContrato(string ps_IDPersona, string ps_IDContador, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_VerificarContrato", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrPersona", SqlDbType.NChar, 25, ps_IDPersona));
                MiComando.Parameters.Add(ParametroEntrada("@vchrContador", SqlDbType.VarChar, 50, ps_IDContador));

                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -100;
            }
        }

        /* ---------------------- Contador ---------------------- */
        public static void BuscarContador(string ps_CodigoContador, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarContador", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_contador", SqlDbType.VarChar, 225, ps_CodigoContador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        //Obtener la cuenta corriente******************Nuevo*************
        public static DataTable getCC(Int32 pi_Contrato, DateTime pd_FechaInici, DateTime pd_FechaFin ,ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_CuentaCorriente", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                MiComando.Parameters.Add(ParametroEntrada("@id_Contrato", SqlDbType.Int, pi_Contrato));
                MiComando.Parameters.Add(ParametroEntrada("@FechaInicial", SqlDbType.DateTime, pd_FechaInici));
                MiComando.Parameters.Add(ParametroEntrada("@FechaFinal", SqlDbType.DateTime, pd_FechaFin));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        //********************************************Obtener el reporte de caja ***************************
        public static DataTable getConsultaCaja(DateTime pd_FechaInici, DateTime pd_FechaFin, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Consultar_Caja", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                MiComando.Parameters.Add(ParametroEntrada("@FechaInicial", SqlDbType.DateTime, pd_FechaInici));
                MiComando.Parameters.Add(ParametroEntrada("@FechaFinal", SqlDbType.DateTime, pd_FechaFin));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        //**************************************************************************************************
        //***************************************************************
        //Obtener el monto a pagar
        public static DataTable getMonto(Int32 pi_Mes, Int32 pi_Año, String nombre_comunidad, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarAbono", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                MiComando.Parameters.Add(ParametroEntrada("@Mes", SqlDbType.Int, pi_Mes));
                MiComando.Parameters.Add(ParametroEntrada("@Año", SqlDbType.Int, pi_Año));
                MiComando.Parameters.Add(ParametroEntrada("@nombre_comunidad", SqlDbType.VarChar, nombre_comunidad));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }




        //Obtener reporte
        public static DataTable getReporteComunidades(int pi_Comunidad, Int32 pi_Mes, Int32 pi_Año, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_reporte_comunidad", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@id_comunidad", SqlDbType.VarChar, pi_Comunidad));
                MiComando.Parameters.Add(ParametroEntrada("@mes", SqlDbType.Int, pi_Mes));
                MiComando.Parameters.Add(ParametroEntrada("@año", SqlDbType.Int, pi_Año));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }

        public static DataTable getEstadoCuenta(string pi_contador, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_estado_cuenta", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@contador", SqlDbType.VarChar, pi_contador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }


        public static DataTable getComunidades(Int32 pi_CodigoHidroelecdtrica, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable ldt_comunidades;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetComunidades", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_comunidad", SqlDbType.Int, pi_CodigoHidroelecdtrica));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                ldt_comunidades = MiTabla;

                return ldt_comunidades;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }

        /*MODIFICACIONES CONTADOR PARTE 2*/
        public static DataTable getTipoServicio(ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable ldt_tipoServicio;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetTipoServicio", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipoServicio = MiTabla;

                return ldt_tipoServicio;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        public static void CrearContador(string ps_NoContador, string psDireccion, string psNoPoste, Int32 pi_Comunidad, Int32 pi_tipoServicio, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_CrearContador", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrCodigo", SqlDbType.VarChar, 100, ps_NoContador));
                MiComando.Parameters.Add(ParametroEntrada("@vchrDireccion", SqlDbType.VarChar, 255, psDireccion));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNo_Poste", SqlDbType.VarChar, 45, psNoPoste));
                MiComando.Parameters.Add(ParametroEntrada("@intNo_Comunidad", SqlDbType.Int, pi_Comunidad.ToString()));
                MiComando.Parameters.Add(ParametroEntrada("@intTipoServicio", SqlDbType.Int, pi_tipoServicio.ToString()));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        public static void ModificarContador(string ps_NoContador, string psDireccion, string psNoPoste, Int32 pi_Comunidad, Int32 pi_tipoServicio, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_ModificarContador", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@vchrCodigo", SqlDbType.VarChar, 100, ps_NoContador));
                MiComando.Parameters.Add(ParametroEntrada("@vchrDireccion", SqlDbType.VarChar, 225, psDireccion));
                MiComando.Parameters.Add(ParametroEntrada("@vchrNo_Poste", SqlDbType.VarChar, 45, psNoPoste));
                MiComando.Parameters.Add(ParametroEntrada("@intNo_Comunidad", SqlDbType.Int, pi_Comunidad.ToString()));
                MiComando.Parameters.Add(ParametroEntrada("@intTipo_servicio", SqlDbType.Int, pi_tipoServicio.ToString()));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        
        public static void EliminarContador(string ps_NoContador, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_EliminarContador", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Contador", SqlDbType.VarChar, 100, ps_NoContador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }

        /* ---------------------- Parametros ---------------------- */
        public static void MostrarParametros(ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Mostrar_Parametros", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros                
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        public static void InsertarParametro(Int32 pi_idParametro, Int32 pi_tipParametro, string ps_parametro, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Insertar_Parametro", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@id_parametro_actual", SqlDbType.Int, pi_idParametro));
                MiComando.Parameters.Add(ParametroEntrada("@tip_parametro", SqlDbType.Int, pi_tipParametro));
                MiComando.Parameters.Add(ParametroEntrada("@parametro_nuevo", SqlDbType.VarChar, 225, ps_parametro));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }

        /* ---------------------- Parametros ---------------------- */
        public static void BuscarAyudaIndividual(string ps_TipoOperacion, string ps_Registro, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarAyuda", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@chrOperacion", SqlDbType.Char, 1, ps_TipoOperacion));
                MiComando.Parameters.Add(ParametroEntrada("@vchrRegistro", SqlDbType.VarChar, 50, ps_Registro));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        public static void BuscarAyudaTabla(string ps_TipoOperacion, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_BuscarAyuda", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@chrOperacion", SqlDbType.Char, 1, ps_TipoOperacion));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }

        /*------------------------Contraseña----------------------- */
        public static void IngresarPassword(string ps_password, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Comparar_Password", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@password", SqlDbType.VarChar, 30, ps_password));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        public static void CambiarPassword(string ps_password_actual, string ps_password_nuevo, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Cambiar_Password", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@password_actual", SqlDbType.VarChar, 30, ps_password_actual));
                MiComando.Parameters.Add(ParametroEntrada("@password_nuevo", SqlDbType.VarChar, 30, ps_password_nuevo));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }

        /* ----------------- Copia Seguridad ------------------- */

        public static void GenerarCopiaSeguridad(string ps_Ruta, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GenerarBackup", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametro
                MiComando.Parameters.Add(ParametroEntrada("@vchrUbicacion", SqlDbType.VarChar, 1000, ps_Ruta));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));

                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch
            {
                pi_Resultado = 3;
            }
        }
        /*-----------------Lecturas-------------------------*/
        public static void GetDatosLectura(string ps_CodigoContador, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetDatosLectura", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@NO_contador", SqlDbType.VarChar, 225, ps_CodigoContador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }

        public static DataTable getTipCargoAbono(ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetTipCargoAbono", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }

        public static DataTable getLecturaMes(string psContrato, DateTime pdtFechaLectura, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetLecturaMes", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@NO_CONTRATO", SqlDbType.VarChar, 225, psContrato));
                MiComando.Parameters.Add(ParametroEntrada("@FECHA_LECTURA", SqlDbType.DateTime, pdtFechaLectura));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }

        public static void InsertarLectura(string psContrato, DateTime pdtFechaLectura, int piLectura, int piTipCargoAbono, double pdMonto, string psDescripcion, int piInsertarCuotaFija, int piTipoCargoAbonoFija, double pdMontoFija, string psDescripcionFija, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_InsertarLectura", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@NO_CONTRATO", SqlDbType.VarChar, 225, psContrato));
                MiComando.Parameters.Add(ParametroEntrada("@FECHA_LECTURA", SqlDbType.DateTime, pdtFechaLectura));
                MiComando.Parameters.Add(ParametroEntrada("@LECTURA", SqlDbType.Int, piLectura));
                MiComando.Parameters.Add(ParametroEntrada("@TIP_CARGO_ABONO", SqlDbType.Int, piTipCargoAbono));
                MiComando.Parameters.Add(ParametroEntrada("@MONTO", SqlDbType.Decimal, pdMonto));
                MiComando.Parameters.Add(ParametroEntrada("@DESCRIPCION", SqlDbType.VarChar, 255, psDescripcion));
                MiComando.Parameters.Add(ParametroEntrada("@INSERTAR_CUOTA_FIJA", SqlDbType.Int, piInsertarCuotaFija));
                MiComando.Parameters.Add(ParametroEntrada("@TIP_CARGO_ABONO_FIJA", SqlDbType.Int, piTipoCargoAbonoFija));
                MiComando.Parameters.Add(ParametroEntrada("@MONTO_FIJA", SqlDbType.Decimal, pdMontoFija));
                MiComando.Parameters.Add(ParametroEntrada("@DESCRIPCION_CUOTA_FIJA", SqlDbType.VarChar, 255, psDescripcionFija));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        /*-----------------Fin Lecturas-------------------------*/


        /*------------------ Pagos -------------------------------*/

        public static void BuscarPagosPendientes(string ps_IDContador, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_pago_pendiente", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@id_contador", SqlDbType.VarChar, 100, ps_IDContador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }

        public static void RealizarPago(string pd_Monto, string ps_Lectura, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_pago_lectura", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@id_lectura", SqlDbType.Int, ps_Lectura));
                MiComando.Parameters.Add(ParametroEntrada("@monto", SqlDbType.Decimal, pd_Monto));

                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }

        /*------------------ Fin Pagos -------------------------------*/
        /*---------------------Calculo de la Mora---------------------*/
        public static void ObtenerParametro(int pi_TipoParametro, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetParametro", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Parametro", SqlDbType.Int, pi_TipoParametro));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }

        #region "Cobros Adicionales"

        public static DataTable SelectTipoCargoAbono()
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_SelectCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                  // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception )
            {
                return new DataTable();
            }
        }

        public static DataTable JoinCobroAdicional()
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_JoinCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }


        public static DataTable JoinCobroAdicionalMantenimiento(int IdCobroAdicional)
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_JoinCobroAdicionalMantenimiento", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@pIdCobroAdicional", SqlDbType.Int, IdCobroAdicional));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static DataTable CalculaCobroAdicional(int IdCobroAdicional,decimal monto)
        {
            try
            {
                DataTable ldt_tipCargoAbono;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_CalculaCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@pIdCobroAdicional", SqlDbType.Int, IdCobroAdicional));
                MiComando.Parameters.Add(ParametroEntrada("@pMonto", SqlDbType.Decimal, monto));
              
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                //MiComando.Parameters.Add(ParametroSalida("@vchrNo_Registro", SqlDbType.VarChar, 3, ps_NoRegistro));
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                // Se desconecta de la base de datos
                Desconectar();
                ldt_tipCargoAbono = MiTabla;

                return ldt_tipCargoAbono;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }




        public static void InsertCobroAdicional(string descripcion, decimal montoFijo, decimal porcentaje, int cargoAbono)
        {
         
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_InsertCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@pDescripcion", SqlDbType.Text, descripcion));
                MiComando.Parameters.Add(ParametroEntrada("@pMonto_Fijo", SqlDbType.Decimal, montoFijo));
                MiComando.Parameters.Add(ParametroEntrada("@pporcentaje", SqlDbType.Decimal, porcentaje));
                MiComando.Parameters.Add(ParametroEntrada("@pCargoAbono", SqlDbType.Int, cargoAbono));

                

                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                // Se desconecta de la base de datos
                Desconectar();
            }
            catch (Exception )
            {
               

            }
        }

        public static void UpdateCobroAdicional(int id, string descripcion, decimal montoFijo, decimal porcentaje, int cargoAbono)
        {

            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_UpdateCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@pId", SqlDbType.Int, id));  
                MiComando.Parameters.Add(ParametroEntrada("@pDescripcion", SqlDbType.Text, descripcion));
                MiComando.Parameters.Add(ParametroEntrada("@pMonto_Fijo", SqlDbType.Decimal, montoFijo));
                MiComando.Parameters.Add(ParametroEntrada("@pporcentaje", SqlDbType.Decimal, porcentaje));
                MiComando.Parameters.Add(ParametroEntrada("@pCargoAbono", SqlDbType.Int, cargoAbono));



                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                // Se desconecta de la base de datos
                Desconectar();
            }
            catch (Exception)
            {


            }
        }

        public static void DeleteCobroAdicional(int id)
        {

            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_DeleteCobroAdicional", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@pid", SqlDbType.Int, id));
               


                // Ejecución del stored procedure
                MiComando.ExecuteNonQuery();
                // Se desconecta de la base de datos
                Desconectar();
            }
            catch (Exception)
            {


            }
        }




        #endregion


        public static void VerCuotasPendientesSinMora(string ps_Contador, ref string ps_Mensaje, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_GetCuotaPendienteSinMora", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@Contador", SqlDbType.VarChar,255, ps_Contador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = -1;
            }
        }
        public static void InsertarCargoAbono(Int64 pi_Lectura, Int32 pi_TipoCargoAbono, double pd_Monto, string ps_Descripcion, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_InsertarCargoAbono", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@ID_LECTURA", SqlDbType.Int, pi_Lectura));
                MiComando.Parameters.Add(ParametroEntrada("@TIP_CARGO_ABONO", SqlDbType.Int, pi_TipoCargoAbono));
                MiComando.Parameters.Add(ParametroEntrada("@MONTO", SqlDbType.Decimal, pd_Monto));
                MiComando.Parameters.Add(ParametroEntrada("@DESCRIPCION", SqlDbType.VarChar, 255, ps_Descripcion));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
            }
        }
        /*--------------------Fin Calculo de la Mora------------------*/
        //*********************************Manejo de Caja************************************************
        public static void AbrirCaja(string ps_usuario, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Abrir_Caja", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_usuario));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void CerrarCaja(string ps_usuario, double pd_monto_cierre, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Cerrar_Caja", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar, 20, ps_usuario));
                MiComando.Parameters.Add(ParametroEntrada("@Monto", SqlDbType.Decimal, pd_monto_cierre));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void IngresoSalidaCaja(double pd_monto_trans, int pi_tipo_trans, string ps_descripcion, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Ingreso_Detalle_AC", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                MiComando.Parameters.Add(ParametroEntrada("@Monto", SqlDbType.Decimal, pd_monto_trans));
                MiComando.Parameters.Add(ParametroEntrada("@Tipo_Operacion", SqlDbType.Int, pi_tipo_trans));
                MiComando.Parameters.Add(ParametroEntrada("@Descipcion", SqlDbType.VarChar, 255, ps_descripcion));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void EstadoCaja(ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Verificar_Estado_Caja", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros  
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static DataTable getUsuarioCaja(ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_UsuarioCaja", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        //***********************************************************************************************
        //****************************Manejo de saldos **************************************************
        public static void InsertarSaldoPersona(int pi_id_contador,double pd_saldo,ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_InsertarSaldo", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Contador", SqlDbType.Int, pi_id_contador));
                MiComando.Parameters.Add(ParametroEntrada("@Monto", SqlDbType.Decimal, pd_saldo));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void GetSaldoPersona(int pi_ID_Contador, ref Int32 pi_Resultado, ref DataTable dtTabla)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Get_Saldo_Persona", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Contador", SqlDbType.Int, pi_ID_Contador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                dtTabla = MiTabla;
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = -1;
            }
        }

        //***********************************************************************************************
        //**************************************Recibo de Pago*******************************************
        public static DataTable getRP(Int32 pi_IDLectura, ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Reporte_Recibo", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros

                MiComando.Parameters.Add(ParametroEntrada("@ID_Lectura", SqlDbType.Int, pi_IDLectura));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        public static void InsertarReciboPago(int pi_ID_LEctura,double pd_Monto, string ps_Login, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Insertar_Recibo", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Lectura", SqlDbType.Int, pi_ID_LEctura));
                MiComando.Parameters.Add(ParametroEntrada("@Monto", SqlDbType.Decimal, pd_Monto));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar,20, ps_Login));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        //***********************************************************************************************
        //*********************************Eliminación de Pagos***************************************
        public static DataTable getPagosGontador(int pi_ID_Contador,ref string ps_Mensaje, ref Int32 pi_Resultado)
        {
            try
            {
                DataTable Datos;
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;
                SqlDataAdapter MiAdaptador;
                DataTable MiTabla;
                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Consultar_Pagos_Realizados", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Contador", SqlDbType.Int, pi_ID_Contador));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;
                MiTabla = new DataTable();
                MiAdaptador = new SqlDataAdapter(MiComando);
                MiAdaptador.Fill(MiTabla);
                // Ejecución del stored procedure
                pi_Resultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                Datos = MiTabla;

                return Datos;
            }
            catch (Exception E)
            {
                ps_Mensaje = E.Message;
                pi_Resultado = 0;
                return new DataTable();
            }
        }
        public static void InsertarBitacoraPagosEliminados(int pi_ID_Cargo_Abono, string ps_Usuario, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_bitacora_cargo_abono", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Cargo_Abono", SqlDbType.Int, pi_ID_Cargo_Abono));
                MiComando.Parameters.Add(ParametroEntrada("@Usuario", SqlDbType.VarChar,20, ps_Usuario));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void EliminarPago(int pi_ID_Cargo_Abono, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Eliminar_Pago", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Cargo_Abono", SqlDbType.Int, pi_ID_Cargo_Abono));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        public static void EliminarPagoDetalleCaja(int pi_ID_Cargo_Abono, ref Int32 pi_Resultado)
        {
            int iResultado;
            try
            {
                // Se conecta  base de datos
                Conectar();

                // Declaración de varables locales
                SqlCommand MiComando;

                // Inicialización del stored procedure
                MiComando = new SqlCommand("sp_Eliminar_Pago_DCA", MiConexion);
                MiComando.CommandType = CommandType.StoredProcedure;

                // Inicialización de parametros
                MiComando.Parameters.Add(ParametroEntrada("@ID_Cargo_Abono", SqlDbType.Int, pi_ID_Cargo_Abono));
                SqlParameter Retorno = MiComando.Parameters.Add(new SqlParameter("@Return", SqlDbType.Int));
                Retorno.Direction = ParameterDirection.ReturnValue;

                MiComando.ExecuteNonQuery();
                iResultado = Convert.ToInt16(Retorno.Value);
                // Se desconecta de la base de datos
                Desconectar();
                pi_Resultado = iResultado;
            }
            catch (Exception E)
            {
                pi_Resultado = 0;
            }
        }
        //***********************************************************************************************

		#endregion

		#region Métodos privados
		private static void Conectar()
		{

            //Conectar("Data Source=(local);Initial Catalog=MCH;Integrated Security=True");
            //Conectar("server=(local);Integrated Security=SSPI;database=MCH");
            //Conectar("Data Source=JUANPC\\SQLEXPRESS;Initial Catalog=MCH;Integrated Security=True");
            Conectar("server=(local)\\sqlexpress;Integrated Security=SSPI;database=MCH");
            //Conectar("server=(local);Integrated Security=SSPI;database=MCH");
            //Conectar("Data Source=JOSE-PC\\SQLEXPRESS;Initial Catalog=MCH;Integrated Security=True");
            //Conectar("server=URL-B5EA88D3100\\SQLEXPRESS;Integrated Security=SSPI;database=MCH");
            //Conectar("server=LASCONCHAS02-PC\\SQLEXPRESS;Integrated Security=SSPI;database=MCH");
            
        }

		private static void Conectar(string pConnectionString)
		{
			MiConexion = new SqlConnection(pConnectionString);
			MiConexion.Open();
		}

		private static void Desconectar()
		{
			MiConexion.Close();
		}

		private static SqlParameter ParametroEntrada(string pNombre, SqlDbType pType, int pLongitud, object pValor)
		{
			SqlParameter MiParametro;

			if (pLongitud >= 0)
				MiParametro = new SqlParameter(pNombre, pType, pLongitud);
			else
				MiParametro = new SqlParameter(pNombre, pType);
			
			MiParametro.Value = pValor;

			return MiParametro;
		}

		private static SqlParameter ParametroEntrada(string pNombre, SqlDbType pType, object pValor)
		{
			return ParametroEntrada(pNombre, pType, -1, pValor);
		}

		private static SqlParameter ParametroSalida(string pNombre, SqlDbType pType, int pLongitud)
		{
			SqlParameter MiParametro;

			if (pLongitud >= 0)
				MiParametro = new SqlParameter(pNombre, pType, pLongitud);
			else
				MiParametro = new SqlParameter(pNombre, pType);
			
			MiParametro.Direction = ParameterDirection.Output;

			return MiParametro;
		}

		private static SqlParameter ParametroSalida(string pNombre, SqlDbType pType)
		{
			return ParametroSalida(pNombre, pType, -1);
		}

		#endregion

	}
}
