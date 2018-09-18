﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Web;


namespace SistemasIIITHEGYM.BussinesLayer
{
    public class TheGym
    {
        //POR FAVOR, COMENTAR TODO.
        //variables para realizar el registro de sucursal
        public string NombreSucursal;
        public string DireccionSucursal;
        public long TelefonoSucursal;
        //variable para realizar la busqueda de cliente
        public string NombreClienteBusc;
        public string DNIClienteBusc = "0";
        //variables para realizar la consulta de empleado
        public string NombreEmpleadoBusc;
        public string DNIEmpleadoBusc = "";
        public string CargoEmpleadoBusc = "";
        //variables para realizar registro de empleado
        public string NombreEmpladoIns;
        public string ApellidoEmpleadoIns;
        public string FechaNacEmpleadoIns;
        public string EmailEmpleadoIns;
        public string TelefEmpleadoIns;
        public string DocumentoEmpleadoIns;
        public string FechaContEmpleadoIns;
        public string FotoEmpleadoIns;
        public string TitulEmpleadoIns;
        public string FKCargoEmpleadoIns;
        public string FKTipoDocEmpleadoIns;
        public string FKSucursalEmpleadoIns;
        public string CalleEmpleadoIns;
        public string BarrioEmpleadoIns;
        public string NumeroEmpleadoIns;
        public string FKLocalidadEmpleadoIns;
        //variables para realizar la edicion de empleado
        public string DNIEditar = "0";
        public string NombreClienteEditar;
        public string ApellidoClienteEditar;
        public string TelefonoClienteEditar;
        public string DomicilioClienteEditar;
        public string FechaClienteEditar;
        public string EmailClienteEditar;
        public string DNIClienteEditar;
        //variables para consultar una actividad
        public string NombreActividadBuscar;
        //variables para consultar cliente
        public string NombreClienteBuscar;
        //variables para registrar actividad
        public string NombreActividad;
        public string ProfesorActividad;
        public string SucursalActividad;
        public string HorarioInicioActividad;
        public string HorarioFinActividad;
        public string CuposActividad;
        public string DescripcionActividad;
        // variables para registrar cliente
        public string NombreCliente;
        public string ApellidoCliente;
        public string FechaCliente;
        public string EmailCliente;
        public string TelefonoCliente;
        public string CalleCliente;
        public string NumeroCliente;
        public string BarrioCliente;
        public string FKLocalidadCliente;
        public string DNICliente;
        public string FotoCliente;
        public string FKTipoDocumento;
        //Variable para buscar ID det pla
        public string FechaIdDetCaja;



        //métodos
        //método para agregar una nueva sucursal

        public void AddNewSucursal()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreSucursal, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Direccion", DireccionSucursal, SqlDbType.VarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoSucursal, SqlDbType.BigInt, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddSucursal", parameters);
        }

        public DataTable GetAllLocalidades()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllLocalidades", parameters);
            return dt;
        }

        public DataTable GetAllTipoDocumento()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllTipoDocumento", parameters);
            return dt;
        }
        public void AddNewEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[16];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEmpladoIns, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoEmpleadoIns, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_nac", FechaNacEmpleadoIns, SqlDbType.Date, 20);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailEmpleadoIns, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefEmpleadoIns, SqlDbType.BigInt, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleEmpleadoIns, SqlDbType.NVarChar, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroEmpleadoIns, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioEmpleadoIns, SqlDbType.NVarChar, 50);
            parameters[8] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DocumentoEmpleadoIns, SqlDbType.NVarChar, 20);
            parameters[9] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoDocumento", FKTipoDocEmpleadoIns, SqlDbType.Int, 50);
            parameters[10] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_cont", FechaContEmpleadoIns, SqlDbType.Date, 100);
            parameters[11] = BussinesDataLayer.DataAccess.AddParameter("@Titulo", TitulEmpleadoIns, SqlDbType.NVarChar, 50);
            parameters[12] = BussinesDataLayer.DataAccess.AddParameter("@FK_cargo", FKCargoEmpleadoIns, SqlDbType.Int, 50);
            parameters[13] = BussinesDataLayer.DataAccess.AddParameter("@Foto", FotoEmpleadoIns, SqlDbType.NVarChar, 500);
            parameters[14] = BussinesDataLayer.DataAccess.AddParameter("@FK_sucursal", FKSucursalEmpleadoIns, SqlDbType.Int, 50);
            parameters[15] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadEmpleadoIns, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddEmpleado", parameters);
        }

            //método para agregar una nueva actividad

            public void AddNewActividad()
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreActividad, SqlDbType.VarChar, 50);
                parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Profesor", ProfesorActividad, SqlDbType.Int, 50);
                parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", SucursalActividad, SqlDbType.Int, 50);
                parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Cupos", CuposActividad, SqlDbType.Int, 50);
                parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Hora_inicio", HorarioInicioActividad, SqlDbType.Time, 50);
                parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Hora_fin", HorarioFinActividad, SqlDbType.Time, 50);
                parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionActividad, SqlDbType.VarChar, 50);
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddActividad", parameters);
            }


            //método para consultar un cliente
            public DataTable GetClienteNom()
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreClienteBusc, SqlDbType.VarChar, 50);
                parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNIClienteBusc, SqlDbType.Int, 100);
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetCliente", parameters);
                return dt;
            }

            //método para consultar un empleado
            public DataTable GetEmpleadoNom()
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEmpleadoBusc, SqlDbType.NVarChar, 50);
                parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNIEmpleadoBusc, SqlDbType.Int, 50);
                parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@K_cargo", CargoEmpleadoBusc, SqlDbType.Int, 50);
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEmpleado", parameters);
                return dt;
            }

            public void UpdateCliente()
            {
                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreClienteEditar, SqlDbType.NVarChar, 50);
                parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoClienteEditar, SqlDbType.NVarChar, 50);
                parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_nac", FechaClienteEditar, SqlDbType.Date, 50);
                parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailClienteEditar, SqlDbType.NVarChar, 100);
                parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoClienteEditar, SqlDbType.BigInt, 50);
                parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Domicilio", DomicilioClienteEditar, SqlDbType.NVarChar, 50);
                parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNIClienteEditar, SqlDbType.Int, 100);
                parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@DNIEdit", DNIEditar, SqlDbType.Int, 100);

                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateCliente", parameters);
            }

            public DataTable GetActividad()
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreActividadBuscar, SqlDbType.VarChar, 50);
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetActividad", parameters);
                return dt;
            }

            public DataTable GetCargos()
            {
                SqlParameter[] parameters = new SqlParameter[0];
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllCargos", parameters);
                return dt;
            }


            //Obtener todos los profesores
            public DataTable GetProfesores()
            {
                SqlParameter[] parameters = new SqlParameter[0];
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllProfesores", parameters);
                return dt;
            }

            public DataTable GetSucursales()
            {
                SqlParameter[] parameters = new SqlParameter[0];
                DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllSucursales", parameters);
                return dt;
            }

        public DataTable GetAllPlans()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            //parameters[0] = DataLayer.DataAccess.AddParameter("@Nombre", NombrePlanBusc, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllPlan", parameters);
            return dt;
        }

        public DataTable GetAllMedioPago()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            //parameters[0] = DataLayer.DataAccess.AddParameter("@Nombre", NombrePlanBusc, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllMedioPago", parameters);
            return dt;
        }

        //Metodo para Registrar Cliente 
        public void AddNewCliente()
        {
            SqlParameter[] parameters = new SqlParameter[12];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreCliente, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoCliente, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_Nac", FechaCliente, SqlDbType.Date, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailCliente, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoCliente, SqlDbType.BigInt, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleCliente, SqlDbType.NVarChar, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroCliente, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioCliente, SqlDbType.NVarChar, 50);
            parameters[8] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadCliente, SqlDbType.Int, 50);
            parameters[9] = BussinesDataLayer.DataAccess.AddParameter("@Foto", FotoCliente, SqlDbType.NVarChar, 500);
            parameters[10] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNICliente, SqlDbType.Int, 100);
            parameters[11] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoDocumento", FKTipoDocumento, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddCliente", parameters);
        }

    }
}
