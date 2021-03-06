﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using SistemasIIITHEGYM.BussinesLayer;


namespace SistemasIIITHEGYM.BussinesLayer
{
    public class TheGym
    {
        //POR FAVOR, COMENTAR TODO.
        //variables para realizar el registro de sucursal
        public string NombreSucursal;
        public string CalleSucursal;
        public string BarrioSucursal;
        public string NumeroSucursal;
        public string FKLocalidadSucursal;
        public long TelefonoSucursal;
        //variable para realizar la busqueda de cliente
        public string NombreClienteBusc;
        public string DNIClienteBusc = "0";
        //variable para relaizar la busqueda de proveedor
        public string NombreProveedorBusc;
        public string CUITProveedorBusc;

        //variable para realizar la busqueda de deposito
        public string NombreDepositoBusc;
        //variables para realizar la consulta de empleado
        public string NombreEmpleadoBusc;
        public string DNIEmpleadoBusc = "";
        public string IDEmpleadoBusc = "0";
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
        //variables para registrar plan
        public string Nombreplanins;
        public string duracionplanins;
        public string precioplanins;
        //variables para registrar Detalles de Plan
        public string FK_plan;
        public string FK_actividad;
        public string Dias_semanas;
        //para buscar un producto
        public string NomProd;
        //variables para realizar la edicion de empleado
        public string DNIEditar = "0";
        public string NombreClienteEditar;
        public string ApellidoClienteEditar;
        public string TelefonoClienteEditar;
        public string CalleClienteEditar;
        public string NumeroClienteEditar;
        public string BarrioClienteEditar;
        public string FKLocalidadClienteEditar;
        public string FKTipoDocClienteEditar;
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
        public string CuposActividad;
        public string DescripcionActividad;
        public string IdProducto;
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
        //variable para registrar proveedor
        public string NombreProveedor;
        public string CUITProveedor;
        public string TelefonoProveedor;
        public string EmailProveedor;
        public string CalleProveedor;
        public string NumCasaProveedor;
        public string FKLocalidadProveedor;
        public string RepresentanteProveedor;
        //Variables para Registrar Horario de Instructor
        public string FKEmpleadoReg;
        public string FKActividadReg;
        public string FKSemanaReg;
        public string DesdeReg;
        public string HastaReg;
        //Variable para buscar ID det pla
        public string FechaIdDetCaja;
        //variables para registrar movimiento de caja
        public string FKFormaPagoMov;
        public string FKDetCajaMov;
        public string MontoMov;
        public string EstadoMov;
        public string ConceptoMov;
        public string ComprobanteMov;
        public string HoraMov;
        //Variable para registrar Cuota
        public string FK_planCuota;
        public string MontoCuota;
        public string FechaCuota;
        public string VencimientoCuota;
        public string FK_clienteCuota;
        //variables para realizar la busqueda de  cuotas
        public string ClienteCuota;
        //variables para buscar una cuota seleccionada
        public string CuotaBusca;
        // varialbe para calcular vencimiento
        public string IDPlanVencimiento;
        //varaible para buscar monto de plan
        public string IdPlanMonto;
        //Variable para obtener todos los datos de Cliente
        public string IdClienteSearch;
        //variable para obtener todos los datos de proveedor
        public string IdProv;
        //variable para obtener todos los datos de deposito
        public string IdDep;
        //Variable para editar Empleados
        public string NombreEmpladoEdit;
        public string ApellidoEmpleadoEdit;
        public string FechaNacEmpleadoEdit;
        public string EmailEmpleadoEdit;
        public string TelefEmpleadoEdit;
        public string DocumentoEmpleadoEdit;
        public string FechaContEmpleadoEdit;
        public string TitulEmpleadoEdit;
        public string FKCargoEmpleadoEdit;
        public string FKTipoDocEmpleadoEdit;
        public string FKSucursalEmpleadoEdit;
        public string CalleEmpleadoEdit;
        public string BarrioEmpleadoEdit;
        public string NumeroEmpleadoEdit;
        public string FKLocalidadEmpleadoEdit;
        //variables para editar proveedores
        public string NombreProvEdit;
        public string CUITProvEdit;
        public string EmailProvEdit;
        public string RepresentanteProvEdit;
        public string TelProvEdit;
        public string CalleProvEdit;
        public string NumCasaProvEdit;
        public string FKLocalidadesProvEdit;
        //variables para registrar apertura y cierre de caja 
        public string FK_empleado;
        public string FK_caja;
        public string Estadocaja;
        public string Monto;
        public string FechaCaja;
        public string FK_det_caja;
        //variable para Cargar sucursal
        public string IdEmpleadoCargaSuc;
        //variable para cargar caja
        public string IdSucursalCarga;
        //variable para buscar una sucursal
        public string NomSucBuscar;
        //Variable para Editar una sucursal
        public string IDSucEditar;
        public string NombreSucEditar;
        public string TelefonoSucEditar;
        public string CalleSucEditar;
        public string BarrioSucEditar;
        public string NumeroSucEditar;
        public string FKLocSucEditar;
        //Variable para actualiza Actividad
        public string IdActEdit;
        public string NombreActEdit;
        public string DescripcionActEdit;
        public string CuposActEdit;
        public string FKEmpleadoActEdit;
        public string FKSucuActEdit;
        //Variable para buscar una actividad
        public string IDActBuscar;
        public string IDSucActBuscar;
        public string IDEmpActBuscar;
        //variable para buscar empleado en ingreso
        public string IDEmpleadoIngreso;
        //variable para estado empleado en ingreso
        public string EstadoIngresoEmpleado;
        //Variable para ingreso de cliente y vencimiento cuota
        public string IDIngresoCliente;
        //para ingresar una factura
        public string FKclienteFac;
        public string FKempleadoFac;
        public string FechaFac;
        public string HoraFac;
        public string TotalFac;
        //variable para registrar ingreso cliente
        public string IDSucIngreso;
        //variable para Id Grupo muscular
        public string FK_Grupo;
        //Variable para buscar Plan
        public string IdPlanBuscar;
        //variable para agregar Ejercicio
        public string NombreEjercicio;
        public string DescripcionEjercicio;
        public string ImagenesEjercicio;
        public string FKgrupomuscular;
        public string FKelementos;
        public string IdEjercicio;
        //variable para agregar rutina
        public string NombreRutina;
        public string IDEmpleado;
        public string IDCliete;
        public string EstadoRutina;
        //variable para agregar detalle drutina
        public string IDRutina;
        public string Serie;
        public string Repeticion;
        public string Dia;
        public string IDEjercicio;
        public string Fecha;
        //Variable buscar id adm
        public string emailbusadm;
        //Variable para buscar un producto por proveedor
        public string ProductName;
        public string idproveedor;
        //variable para agregar producto
        public string NombreProducto;
        public string DescripcionProducto;
        public string PrecioCompra;
        public string PrecioVenta;
        public string FKproveedor;
        //variable para agregar Orden de compra
        public string fkempleadoorden;
        public string fkproveedororden;
        public string fechaorden;
        public string horaorden;
        public string totalorden;
        //variable para agregar detalle orden
        public string fkorden;
        public string fkproducto;
        public string cantidadorden;
        public string precioorden;
        public string idorden;
        //variable para tener la hora del dia
        public string HoraDia;
        //variable para Add Cronograma
        public string fksemana;
        public string fkactividad;
        public string fkprofesor;
        public string desdeCronograma;
        public string hastaCronograma;
        //Variable para buscar productos de un deposito
        public string NombreProdBusc;
        public string SucBuscProd;
        //Variables para registrar Factura de Venta
        public string FactVentaCliente;
        public string FactVentaEmpleado;
        public string FactVentaTotal;
        public string FactVentaFecha;
        public string FactVentaHora;
        public string FactVentaFormaPago;
        public string FactVentaComprobante;
        public string FactVentaFactura;
        public string FactVentaProducto;
        public string FactVentaPrecio;
        public string FactVentaCantidad;
        public string FactVentaSucursal;
        public string FactVentaMovimiento;
        //Variables para registrar Facturas
        public string FacturaIDProv;
        public string FacturaIDOrden;
        public string FacturaFKTipoComp;
        public string FacturaFKServicio;
        public string FacturaMonto;
        public string FacturaFecha;
        public string FacturaFKEmpleado;
        public string FacturaIDSucursal;
        public string FacturaProducto;
        public string FacturaCantidad;
        public string FacturaConcepto;
        public string FacturaDetCaja;
        public string FacturaHora;
        public string FacturaIDFact;
        //variable para generar reporte
        public string FechaIn;
        public string FechaFin;
        public string Estado;
        public string Capital;
        //Variables para busqueda de Factura Venta
        public string FacturaDesde;
        public string FacturaHasta;


        //Metodo para registrar ingreso de cliente
        public DataTable AddIngresoCliente()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDIngresoCliente, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Suc", IDSucIngreso, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddIngresoCliente", parameters);
            return dt;
        }

        //Metodo para consultar vencimiento
        public DataTable ConsultarVencimiento()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDIngresoCliente, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_ConsultarVencimiento", parameters);
            return dt;
        }


        //Metodo para ingreso de cliente
        public DataTable GetOneCliente()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDIngresoCliente, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOneCliente", parameters);
            return dt;
        }

        //Metodo para Editar Actividad
        public void UpdateActividad()
        {
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDActBuscar, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@ID_suc", IDSucActBuscar, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Id_empleado", IDEmpActBuscar, SqlDbType.Int, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreActEdit, SqlDbType.VarChar, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionActEdit, SqlDbType.VarChar, 500);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Cupos", CuposActEdit, SqlDbType.Int, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FKEmpleadoActEdit, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@FK_sucursal", FKSucuActEdit, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateActividad", parameters);
        }


        public DataTable GetOneActividad2()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDActBuscar, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOneActividad", parameters);
            return dt;
        }
        //procedimiento para buscar una cuota seleccionada
        public DataTable getOneCuota()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", CuotaBusca, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("Pa_GetOneCuota", parameters);
            return dt;
        }

        //procedimiento para obtener todas las cuotas de un cliente
        public DataTable GetCuota()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ClienteCuota, SqlDbType.VarChar, 30);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllCuotas", parameters);
            return dt;
        }

        //para obtener el ultimo pago de cuota ingresado
        public DataTable GetLastCuota()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetLastCuota", parameters);
            return dt;
        }

        //Metodos para cajas 
        //public DataTable GetAllCaja()
        //{
        //    SqlParameter[] parameters = new SqlParameter[1];
        //    parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_sucursal", IdSucursalCarga, SqlDbType.Int, 50);
        //    DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllCaja", parameters);
        //    return dt;
        //}

        public DataTable GetActividades()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllActividades", parameters);
            return dt;
        }

        public DataTable GetAllSucursal()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_empleado", IdEmpleadoCargaSuc, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllSucursal", parameters);
            return dt;
        }


        //Metodo para apertura y cierre de caja
        public void AperturaDeCaja()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            //parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_caja", FK_caja, SqlDbType.Int, 50);
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@empleado", FK_empleado, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@estado", Estadocaja, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@monto", Monto, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@fecha", FechaCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AperturaCaja", parameters);
        }

        public DataTable CierreDeCaja()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_DetCaja", FK_det_caja, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_CierreCaja", parameters);
            return dt;
        }

        public DataTable MontoApertura()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaIdDetCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetMontoApertura", parameters);
            return dt;
        }


        public DataTable GetIdDetCaja()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaIdDetCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetIdDetCaja", parameters);
            return dt;
        }

        public void CierreCajaDet()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Monto", Monto, SqlDbType.Money, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FK_empleado, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_CierreCajaDet", parameters);
        }

        //métodos
        //método para agregar una nueva sucursal


        public void UpdateSucursal()
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreSucEditar, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoSucEditar, SqlDbType.BigInt, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleSucEditar, SqlDbType.NVarChar, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioSucEditar, SqlDbType.NVarChar, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroSucEditar, SqlDbType.Int, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocSucEditar, SqlDbType.Int, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDSucEditar, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateSucursal", parameters);
        }

        public void UpdateEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[15];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEmpladoEdit, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoEmpleadoEdit, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_nac", FechaNacEmpleadoEdit, SqlDbType.Date, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailEmpleadoEdit, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefEmpleadoEdit, SqlDbType.BigInt, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Titulo", TitulEmpleadoEdit, SqlDbType.NVarChar, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@FK_cargo", FKCargoEmpleadoEdit, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoDocumento", FKTipoDocEmpleadoEdit, SqlDbType.Int, 50);
            parameters[8] = BussinesDataLayer.DataAccess.AddParameter("@Documento", DocumentoEmpleadoEdit, SqlDbType.NVarChar, 20);
            parameters[9] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleEmpleadoEdit, SqlDbType.NVarChar, 50);
            parameters[10] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioEmpleadoEdit, SqlDbType.NVarChar, 50);
            parameters[11] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroEmpleadoEdit, SqlDbType.Int, 50);
            parameters[12] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadEmpleadoEdit, SqlDbType.Int, 50);
            parameters[13] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_cont", FechaContEmpleadoEdit, SqlDbType.Date, 50);
            parameters[14] = BussinesDataLayer.DataAccess.AddParameter("@DNIedit", DNIEditar, SqlDbType.NVarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateEmpleado", parameters);

        }

        public void UpdateProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProvEdit, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@CUIT", CUITProvEdit, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailProvEdit, SqlDbType.NVarChar, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@NomContacto", RepresentanteProvEdit, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelProvEdit, SqlDbType.BigInt, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleProvEdit, SqlDbType.NVarChar, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumCasaProvEdit, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadesProvEdit, SqlDbType.NVarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateProveedor", parameters);

        }


        public void AddCronograma()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_semana", FKSemanaReg, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FKEmpleadoReg, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Desde", DesdeReg, SqlDbType.Time, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hasta", HastaReg, SqlDbType.Time, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddCronograma", parameters);
        }

        public DataTable GetEstadoDetCaja()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaIdDetCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEstadoDetCaja", parameters);
            return dt;
        }

        public void AddMovimientoCaja()
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_formapago", FKFormaPagoMov, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Monto", MontoMov, SqlDbType.Money, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Estado", EstadoMov, SqlDbType.NVarChar, 20);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Concepto", ConceptoMov, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Comprobante", ComprobanteMov, SqlDbType.NVarChar, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@FK_DetCaja", FKDetCajaMov, SqlDbType.Int, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Hora", HoraMov, SqlDbType.Time, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddMovCaja", parameters);
        }

        public DataTable GetEstadoDetCajaAP()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaIdDetCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEstadoDetCajaAP", parameters);
            return dt;
        }


        public void AddNewSucursal()
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreSucursal, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleSucursal, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioSucursal, SqlDbType.NVarChar, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroSucursal, SqlDbType.Int, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadSucursal, SqlDbType.NVarChar, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoSucursal, SqlDbType.BigInt, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddSucursal", parameters);
        }

        public void AddNewProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProveedor, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@CUIT", CUITProveedor, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleProveedor, SqlDbType.NVarChar, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumCasaProveedor, SqlDbType.Int, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadProveedor, SqlDbType.Int, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoProveedor, SqlDbType.BigInt, 100);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@NomContacto", RepresentanteProveedor, SqlDbType.NVarChar, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailProveedor, SqlDbType.NVarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddProveedor", parameters);
        }


        public DataTable GetAllLocalidades()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllLocalidades", parameters);
            return dt;
        }

        public DataTable GetLastPlan()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetLastPlan", parameters);
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

        public void AddDetallePlan()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_plan", FK_plan, SqlDbType.Int, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_actividad", FK_actividad, SqlDbType.Int, 100);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Dias_semana", FK_actividad, SqlDbType.Int, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddDetallePlan", parameters);
        }

        //metodo para agregar un nuevo plan
        public void AddNewPlan()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", Nombreplanins, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad_dias", duracionplanins, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Precio", precioplanins, SqlDbType.Money, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddPlan", parameters);
        }

        //metodo para agregar una nueva factura
        public void AddFacturaSinC()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_Empleado", FKempleadoFac, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Total", TotalFac, SqlDbType.Money, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaFac, SqlDbType.Date, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hora", HoraFac, SqlDbType.Time, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddFactura", parameters);
        }


        //método para agregar una nueva actividad

        public void AddNewActividad()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreActividad, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Profesor", ProfesorActividad, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", SucursalActividad, SqlDbType.Int, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Cupos", CuposActividad, SqlDbType.Int, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionActividad, SqlDbType.VarChar, 500);
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

        //metodo para consultar proveedor
        public DataTable GetProveedorNom()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProveedorBusc, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetProveedor", parameters);
            return dt;
        }

        //metodo para consultar deposito
        public DataTable GetDepositoNom()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreDepositoBusc, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDeposito", parameters);
            return dt;
        }




        public DataTable GetVencimiento()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("Id_Plan", IDPlanVencimiento, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetVencimiento", parameters);
            return dt;
        }

        public void AddCuota()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_Plan", FK_planCuota, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Monto", MontoCuota, SqlDbType.Money, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaCuota, SqlDbType.DateTime, 30);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Vencimiento", VencimientoCuota, SqlDbType.Date, 20);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_Cliente", FK_clienteCuota, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddCuota", parameters);
        }


        //método para consultar un empleado
        public DataTable GetEmpleadoNom()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEmpleadoBusc, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDEmpleadoBusc, SqlDbType.Int, 50);
            //parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@K_cargo", CargoEmpleadoBusc, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEmpleado", parameters);
            return dt;
        }

        public void UpdateCliente()
        {
            SqlParameter[] parameters = new SqlParameter[11];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreClienteEditar, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoClienteEditar, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha_nac", FechaClienteEditar, SqlDbType.Date, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Email", EmailClienteEditar, SqlDbType.NVarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Telefono", TelefonoClienteEditar, SqlDbType.BigInt, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Calle", CalleClienteEditar, SqlDbType.NVarChar, 50);
            parameters[6] = BussinesDataLayer.DataAccess.AddParameter("@Numero", NumeroClienteEditar, SqlDbType.Int, 50);
            parameters[7] = BussinesDataLayer.DataAccess.AddParameter("@Barrio", BarrioClienteEditar, SqlDbType.NVarChar, 50);
            parameters[8] = BussinesDataLayer.DataAccess.AddParameter("@FK_localidad", FKLocalidadClienteEditar, SqlDbType.NVarChar, 50);
            parameters[9] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNIClienteEditar, SqlDbType.Int, 100);
            parameters[10] = BussinesDataLayer.DataAccess.AddParameter("@DNIEdit", DNIEditar, SqlDbType.Int, 100);

            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateCliente", parameters);
        }

        public DataTable GetActividad()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllActividades", parameters);
            return dt;
        }


        public DataTable GetOneActividad()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreActividadBuscar, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetActividad", parameters);
            return dt;
        }

        //este tambien
        public DataTable GetOrdenIDprov()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_proveedor", idproveedor, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOrdenProveedor", parameters);
            return dt;
        }

        //aqui este faltaba
        public DataTable GetoneProducto()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id", IdProducto, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOneProducto", parameters);
            return dt;
        }
        //para buscar el producto y añadirlo al carrito de la factura
        public DataTable GetBusquedaProductos()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NomProd, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_getProductoBusqueda", parameters);
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

        public DataTable GetTotalPlan()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_plan", IdPlanMonto, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetMontoPlan", parameters);
            return dt;
        }

        public DataTable GetAllDatosCliente()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_cliente", IdClienteSearch, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllDatosCliente", parameters);
            return dt;
        }


        public DataTable GetAllDatosProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID_Proveedor", IdProv, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllDatosProveedor", parameters);
            return dt;
        }


        public DataTable GetAllDatosDeposito()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID_Deposito", IdDep, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllDatosDeposito", parameters);
            return dt;
        }

        public DataTable GetOneSucursal()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NomSucBuscar, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOneSucursal", parameters);
            return dt;
        }


        public DataTable GetOneSucursalID()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IdSucursalCarga, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOneSucursalID", parameters);
            return dt;
        }

        public DataTable IngresoNombreEmp()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDEmpleadoIngreso, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_IngresoNombreEmp", parameters);
            return dt;
        }

        public DataTable GetIngresoEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDEmpleadoIngreso, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetIngresoEmpleado", parameters);
            return dt;
        }

        public DataTable GetEgresoEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDEmpleadoIngreso, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEgresoEmpleado", parameters);
            return dt;
        }

        public void AddIngresoEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDEmpleadoIngreso, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@estado", EstadoIngresoEmpleado, SqlDbType.VarChar, 10);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddIngresoEmpleado", parameters);

        }

        public DataTable GetCuotasVencidas()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetCuotasVencidas", parameters);
            return dt;
        }

        public DataTable GetTodosClientesNombres()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@DNI", DNICliente, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetTodosClientesNombres", parameters);
            return dt;
        }

        public DataTable GetGruposMusculares()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetGruposMusculares", parameters);
            return dt;
        }

        public DataTable GetEjercicosxGrupo()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", FK_Grupo, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEjercicosxGrupo", parameters);
            return dt;
        }

        public DataTable GetMovimientoCaja()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FechaCaja, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetMovimientoCaja", parameters);
            return dt;
        }

        public void InhabilitarCliente()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@id", IdClienteSearch, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_InhabilitaCliente", parameters);
        }

        public void InhabilitarEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@id", IDEmpleadoBusc, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_InhabilitarEmpleado", parameters);
        }

        public void InhabilitarActividad()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@id", IDActBuscar, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_InhabilitarActividad", parameters);
        }

        public void InhabilitarPlans()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@id", IdPlanBuscar, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_InhabilitarPlans", parameters);
        }

        public DataTable GetPlans()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", Nombreplanins, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetPlans", parameters);
            return dt;
        }

        public DataTable GetDetPlans()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_plan", IdPlanBuscar, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDetPlan", parameters);
            return dt;
        }

        //public string Nombreplanins;
        //public string duracionplanins;
        //public string precioplanins;
        ////variables para registrar Detalles de Plan
        //public string FK_plan;
        //public string FK_actividad;
        //public string Dias_semanas;

        public void UpdatePlan()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@IdPlan", IdPlanBuscar, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", Nombreplanins, SqlDbType.VarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Precio", precioplanins, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Duracion", duracionplanins, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("@PA_UpdatePlan", parameters);
        }

        public void UpdateDetallePlan()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_plan", FK_plan, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Id_actividad", FK_actividad, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Dias_semanas", Dias_semanas, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("@PA_UpdateDetPlan", parameters);
        }

        //PA_DeleteDetPlan

        public void DeleteDetPlan()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("@PA_DeleteDetPlan", parameters);
        }

        public DataTable GetElementos()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetElementos", parameters);
            return dt;
        }


        public void AddEjercicio()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEjercicio, SqlDbType.VarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionEjercicio, SqlDbType.VarChar, 1000);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Imagenes", ImagenesEjercicio, SqlDbType.NVarChar, 500);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@FKgrupomuscular", FKgrupomuscular, SqlDbType.Int, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FKelementos", FKelementos, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddEjercicio", parameters);
        }


        public DataTable GetEjercicio()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEjercicio, SqlDbType.VarChar, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetEjercicio", parameters);
            return dt;
        }

        public void UpdateEjercicio()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_ejercicio", IdEjercicio, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreEjercicio, SqlDbType.VarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionEjercicio, SqlDbType.VarChar, 1000);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@FK_grupomuscular", FKgrupomuscular, SqlDbType.Int, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_ELEMENTOS", FKelementos, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_UpdateEjercicio", parameters);
        }

        public DataTable AddRutina()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_Empleado", IDEmpleado, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Id_Cliente", IDCliete, SqlDbType.Int, 10);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreRutina, SqlDbType.VarChar, 20);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddRutina", parameters);
            return dt;
        }

        public void AddDetalleRutina()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_rutina", IDRutina, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Serie", Serie, SqlDbType.Int, 10);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Rep", Repeticion, SqlDbType.Int, 10);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Dia", Dia, SqlDbType.VarChar, 20);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Id_ejercicio", IDEjercicio, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddDetalleRutina", parameters);

        }

        public DataTable GetAdmNomAp()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Email", emailbusadm, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAdmAp", parameters);
            return dt;
        }

        public DataTable GetLastOrden()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetLastOrden", parameters);
            return dt;
        }

        public DataTable GetProductPorProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", ProductName, SqlDbType.NVarChar, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@ID", idproveedor, SqlDbType.Int, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetProductoPorProveedor", parameters);
            return dt;
        }

        public DataTable GetSucEmailEmpleado()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Email", emailbusadm, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetSucEmailEmpleado", parameters);
            return dt;
        }

        public DataTable GetProveedores()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetProveedores", parameters);
            return dt;
        }



        public void AddProducto()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProducto, SqlDbType.VarChar, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionProducto, SqlDbType.VarChar, 100);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FK_proveedor", FKproveedor, SqlDbType.Int, 10);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@PrecioCompra", PrecioCompra, SqlDbType.Money, 20);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@PrecioVenta", PrecioVenta, SqlDbType.Money, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddProducto", parameters);

        }

        public DataTable GetProducto()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProducto, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetProducto", parameters);
            return dt;
        }


        public DataTable GetUpProducto()
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_producto", IdProducto, SqlDbType.Int, 10);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProducto, SqlDbType.NVarChar, 10);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FK_proveedor", FKproveedor, SqlDbType.Int, 10);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@PrecioCompra", PrecioCompra, SqlDbType.Money, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@PrecioVenta", PrecioVenta, SqlDbType.Money, 100);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Descripcion", DescripcionProducto, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetUpProducto", parameters);
            return dt;
        }

        public DataTable GetIDemp()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Email", emailbusadm, SqlDbType.Int, 10);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetIDemp", parameters);
            return dt;
        }

        public DataTable AddOrdenCompra()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", fkempleadoorden, SqlDbType.Int, 10);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_proveedor", fkproveedororden, SqlDbType.Int, 10);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", fechaorden, SqlDbType.Date, 10);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hora", horaorden, SqlDbType.Time, 10);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Total", totalorden, SqlDbType.Money, 10);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddOrdenCompra", parameters);
            return dt;
        }


        public void AddDetOrden()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_orden", fkorden, SqlDbType.Int, 10);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", fkproducto, SqlDbType.Int, 10);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad", cantidadorden, SqlDbType.Int, 10);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Precio", precioorden, SqlDbType.Money, 10);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddDetOrden", parameters);
        }

        public DataTable GetDetalleOrden()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", idorden, SqlDbType.Int, 10);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDetalleOrden", parameters);
            return dt;
        }


        public DataTable GetHoraDia()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_HoraDia", parameters);
            return dt;
        }

        public DataTable GetHoraDiaIngreso()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_HoraDiaIngreso", parameters);
            return dt;
        }

        public DataTable GetRutinaNombre()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreRutina, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllNombresRutinas", parameters);
            return dt;
        }

        public DataTable GetAllClientes()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetClientes", parameters);
            return dt;
        }

        public DataTable GetRutina()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoCliente, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetRutina", parameters);
            return dt;
        }




        public void InhabilitarRutina()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@id", IDRutina, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_InhabilitarRutina", parameters);
        }

        public DataTable GetDetalleRutina()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@ID", IDRutina, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDetalleRutina", parameters);
            return dt;
        }

        public void BorrarDetalle()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Id_rutina", IDRutina, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_BorrarDetalle", parameters);
        }


        public void AddCronogramaSemanal()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Dia", fksemana, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Desde", desdeCronograma, SqlDbType.Time, 100);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Hasta", hastaCronograma, SqlDbType.Time, 100);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Profesor", fkprofesor, SqlDbType.VarChar, 100);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Actividad", fkactividad, SqlDbType.VarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddCronogramaSemanal", parameters);

        }

        public DataTable GetClientesRutina()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Apellido", ApellidoCliente, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetClientesRutina", parameters);
            return dt;
        }

        public DataTable GetPlanEstadistica()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetPlanEstadistica", parameters);
            return dt;
        }

        public DataTable GetAllPlanEstadistica()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllPlanEstadistica", parameters);
            return dt;
        }

        public DataTable GetAsistenciaEstadistica()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAsistenciaEstadistica", parameters);
            return dt;
        }
        public void AddBorrarActividad()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Actividad", fkactividad, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddBorrarActividad", parameters);

        }

        public DataTable GetProductoVenta()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Nombre", NombreProdBusc, SqlDbType.NVarChar, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", SucBuscProd, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetProductoVenta", parameters);
            return dt;
        }

        public DataTable AddFacturaVenta()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_cliente", FactVentaCliente, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FactVentaEmpleado, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Total", FactVentaTotal, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FactVentaFecha, SqlDbType.Date, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Hora", FactVentaHora, SqlDbType.Time, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddFacturaVenta", parameters);
            return dt;
        }

        public void AddMovimientoCajaVenta()
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_formapago", FactVentaFormaPago, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FactVentaTotal, SqlDbType.Money, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Comprobante", FactVentaComprobante, SqlDbType.NVarChar, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hora", FactVentaHora, SqlDbType.Time, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_factura", FactVentaFactura, SqlDbType.Int, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FactVentaFecha, SqlDbType.Date, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_MovimientoCajaVenta", parameters);           
        }

        public void AddDetalleFacturaVenta()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_factura", FactVentaFactura, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", FactVentaProducto, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Precio", FactVentaPrecio, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad", FactVentaCantidad, SqlDbType.Int, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", FactVentaSucursal, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddDetalleFacturaVenta", parameters);
        }

        public DataTable AddMovStock()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FactVentaFecha, SqlDbType.Date, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", FactVentaSucursal, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FK_factura", FactVentaFactura, SqlDbType.Int, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FactVentaEmpleado, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddMovStock", parameters);
            return dt;
        }

        public void AddDetMovStock()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_MovStock", FactVentaMovimiento, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", FactVentaProducto, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad", FactVentaCantidad, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddDetMovStock", parameters);
        }

        public DataTable GetTipoMovimiento()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetTipoMovimiento", parameters);
            return dt;
        }

        public DataTable GetServicios()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetServicios", parameters);
            return dt;
        }

        public DataTable GetOrdenDeProv()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_proveedor", FacturaIDProv, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetOrdenesDeProv", parameters);
            return dt;
        }

        public DataTable GetDetOrden()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_orden", FacturaIDOrden, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDetOrden", parameters);
            return dt;
        }

        public void AddFacturaPagoServicio()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_tipocomprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_servicio", FacturaFKServicio, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FacturaMonto, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FacturaFecha, SqlDbType.Date, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FacturaFKEmpleado, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddFacturaPagoServicio", parameters);
        }

        public void AddFacturaPagoProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_orden", FacturaIDOrden, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_tipocomprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FacturaMonto, SqlDbType.Money, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FacturaFecha, SqlDbType.Date, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FacturaFKEmpleado, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddFacturaPagoProveedor", parameters);
        }

        public void AddFacturaPagoOtros()
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_tipocomprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FacturaMonto, SqlDbType.Money, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Fecha", FacturaFecha, SqlDbType.Date, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@FK_empleado", FacturaFKEmpleado, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddFacturaPagoOtros", parameters);
        }

        public void ActualizaStockOrden()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", FacturaProducto, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad", FacturaCantidad, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", FacturaIDSucursal, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_ActualizaStockOrden", parameters);
        }

        

        public DataTable ProductoEnDeposito()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", FacturaProducto, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", FacturaIDSucursal, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_ProductoEnDeposito", parameters);
            return dt;
        }


        public DataTable AddProductoADeposito()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_producto", FacturaProducto, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Cantidad", FacturaCantidad, SqlDbType.Int, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@Sucursal", FacturaIDSucursal, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_AddProductoADeposito", parameters);
            return dt;
        }


        public DataTable GetFacturaAllTipo()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoComprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactTipoAll", parameters);
            return dt;
        }

        public DataTable GetFacturaAllTipoProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoComprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactTipoAllProveedor", parameters);
            return dt;
        }


        public DataTable GetFacturaAllTipoServicios()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoComprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactTipoAllServicios", parameters);
            return dt;
        }

        public DataTable GetFacturaAllTipoProv()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoComprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_proveedor", FacturaIDProv, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactProv", parameters);
            return dt;
        }

        public DataTable GetFacturaAllTipoServicio()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_TipoComprobante", FacturaFKTipoComp, SqlDbType.Int, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FK_Servicio", FacturaFKServicio, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactTipoServicio", parameters);
            return dt;
        }

        public void PagarFacturaProveedor()
        {
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FacturaMonto, SqlDbType.Money, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Concepto", FacturaConcepto, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FK_detCaja", FacturaDetCaja, SqlDbType.Int, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hora", FacturaHora, SqlDbType.Time, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_factura", FacturaIDFact, SqlDbType.Int, 50);
            parameters[5] = BussinesDataLayer.DataAccess.AddParameter("@FK_orden", FacturaIDOrden, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_PagoFacturaProveedor", parameters);
        }

        public void PagarFacturaServicio()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Monto", FacturaMonto, SqlDbType.Money, 50);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Concepto", FacturaConcepto, SqlDbType.NVarChar, 50);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FK_detCaja", FacturaDetCaja, SqlDbType.Int, 50);
            parameters[3] = BussinesDataLayer.DataAccess.AddParameter("@Hora", FacturaHora, SqlDbType.Time, 50);
            parameters[4] = BussinesDataLayer.DataAccess.AddParameter("@FK_factura", FacturaIDFact, SqlDbType.Int, 50);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_PagoFacturaServicio", parameters);
        }

        public DataTable GetPlanChart()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllPlanChart", parameters);
            return dt;
        }

        public DataTable GetProductoChart()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllProductoChart", parameters);
            return dt;
        }

        public DataTable GetConceptos()
        {

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@capital", Estado, SqlDbType.NVarChar, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetConceptos", parameters);
            return dt;
        }

        public DataTable GetReporteDineroConcepto()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Estado", Estado, SqlDbType.NVarChar, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FechaIn", FechaIn, SqlDbType.Date, 1000);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FechaFin", FechaFin, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetReporteDineroConcepto", parameters);
            return dt;
        }

        public DataTable GetReporteDineroConceptoTotal()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Capital", Capital, SqlDbType.NVarChar, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FechaIn", FechaIn, SqlDbType.Date, 100);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FechaFin", FechaFin, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetReporteDineroConceptoTotal", parameters);
            return dt;
        }

        public DataTable GetSumTotal()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FechaIn", FechaIn, SqlDbType.Date, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FechaFin", FechaFin, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetSumTotal", parameters);
            return dt;
        }

        public DataTable GetSumTotalConcepto()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Estado", Estado, SqlDbType.NVarChar, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FechaIn", FechaIn, SqlDbType.Date, 100);
            parameters[2] = BussinesDataLayer.DataAccess.AddParameter("@FechaFin", FechaFin, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetSumTotalConcepto", parameters);
            return dt;
        }

        public DataTable GetFacturaVentaFecha()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@Desde", FacturaDesde, SqlDbType.Date, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@Hasta", FacturaHasta, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetFactVentaFechas", parameters);
            return dt;
        }

        public DataTable GetDetalleFactura()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_Factura", FacturaIDFact, SqlDbType.Int, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetDetFactura", parameters);
            return dt;
        }

        public DataTable GetDeposito()
        {
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetAllDeposito", parameters);
            return dt;
        }

        public DataTable GetMovimiento()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FK_deposito", IdDep, SqlDbType.Int, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetMovimientoStock", parameters);
            return dt;
        }

        public DataTable GetReporteDineroConceptoTotales()
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = BussinesDataLayer.DataAccess.AddParameter("@FechaIn", FechaIn, SqlDbType.Date, 100);
            parameters[1] = BussinesDataLayer.DataAccess.AddParameter("@FechaFin", FechaFin, SqlDbType.Date, 100);
            DataTable dt = BussinesDataLayer.DataAccess.ExcecuteDTbyProcedure("PA_GetReporteDineroConceptoTotales", parameters);
            return dt;
        }


    }
}