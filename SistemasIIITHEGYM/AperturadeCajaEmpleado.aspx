﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GYMPaginasMaestras/PaginaMaestraEmpleado.Master" AutoEventWireup="true" CodeBehind="AperturadeCajaEmpleado.aspx.cs" Inherits="SistemasIIITHEGYM.AperturadeCajaEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="lblusuario" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="White"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--modal para el registro exitoso--%>
             <div class="modal fade" id="modal-default">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <%--<button type="button" class="close" data-dismiss="modal" aria-label="Close">--%>
                  <%--<span aria-hidden="true">&times;</span></button>--%>
                <h4 class="modal-title">THEGYM</h4>
              </div>
              <div class="modal-body">
                <p>¡Apertura de caja registrada exitosamente!&hellip;</p>
              </div>
              <div class="modal-footer">
                <%--<button type="button" class="btn btn-default pull-left" data-dismiss="modal">Close</button>
                <button type="button" class="btn btn-primary">Save changes</button>--%>
              </div>
            </div>
            <!-- /.modal-content -->
          </div>
          <!-- /.modal-dialog -->
        </div>
        <!-- /.modal -->



    <!-- Select2 -->
    <link rel="stylesheet" href="../../bower_components/select2/dist/css/select2.min.css">
        <%--evitar error con el required validator--%>
    <script type ="text/javascript">

 function show()
    {
        document.write("<head runat='server'></head>");
    }



    </script>
    <!-- Main content -->
<%--    TituloSuperior--%>
    <%--<section class="content-header">
                    <h1>Operaciones de caja <small>TheGym</small> </h1>
                </section>--%>
    <!-- SELECT2 EXAMPLE -->
    <div class="box box-default">
        <div class="box-header with-border">
            <h3 class="box-title">Registrar apertura </h3>
            <div class="box-tools pull-right">
<%--                boton minimizar y cerrar--%>
<%--                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>--%>
            </div>
        </div>
        <!-- /.box-header -->
                <div class="box-body">
          <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Fecha:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                      <asp:Label ID="lblFecha" CssClass="text-muted" runat="server" Text="HoraActual"></asp:Label>
                  </div>
                </div>
                    <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Usuario:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                      <asp:Label ID="lblnombreusuario" CssClass="text-muted" runat="server" Text="APELLIDO, Nombre"></asp:Label>
                  </div>
                </div>
                    <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Monto de Apertura:</label>
                 <%--input dinero--%>
                 <div class="input-group" style="left: 0px; top: 0px; width: 320px">
                <span class="input-group-addon">$</span>
                     <asp:TextBox ID="tbmonto" Cssclass="form-control" runat="server" style="left: 0px; top: 0px; height: 42px; width: 44%" TextMode="Number"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="tbmonto" Display="None" ErrorMessage="Ingrese un monto" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator12_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator12_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator12">
                      </ajaxToolkit:ValidatorCalloutExtender>
              </div>
                 <%--fin input dinero--%>
                </div>
             <br />
              <!-- /.form-group -->
            </div>
            <!-- columna2 inicio/.col -->
            <div class="col-md-6">
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Hora:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                      <asp:Label ID="lblhora" CssClass="text-muted" runat="server" Text="HoraActual"></asp:Label>
                  </div>
                </div>
                    <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Sucursal:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                      <asp:Label ID="lblsucursal" CssClass="text-muted" runat="server" Text="SUCURSAL"></asp:Label>
                  </div>
                </div>
                    <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Estado:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                      <asp:Label ID="lblestadocaja" CssClass="text-muted" runat="server" Text="Apertura"></asp:Label>
                  </div>
                </div>
               <br />
              <!-- /.form-group -->
                <asp:Label ID="lblerror" CssClass="error-text" runat="server"></asp:Label>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
<div class="box-footer">
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btnregistrar" CssClass="btn btn-info" runat="server" Text="Registrar" OnClick="btnregistrar_Click" />
                
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btncancelar" runat="server" CssClass="btn btn-default" Text="Cancelar" CausesValidation="False" />
                
              </div>
    </div>
    <!-- /.box -->
</asp:Content>
