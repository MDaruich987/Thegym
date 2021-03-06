﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GYMPaginasMaestras/PaginaMaestaGerente.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpleadoGerente.aspx.cs" Inherits="SistemasIIITHEGYM.RegistrarEmpleadoGerente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="lblusuario" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="White"></asp:Label>
    <link href="EstilosCSS.css" rel="stylesheet" />

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
                <p>¡Empleado registrado exitosamente!&hellip;</p>
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


            <%--<div class="checkbox">
                      <label>
                        <input type="checkbox"> Remember me
                      </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;</div>--%>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
            <%--<div class="box-footer">
                <button type="submit" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-info pull-right">Sign in</button>
              </div>--%>
    <script type ="text/javascript">
        $(document).ready(function () {
            var mensaje = "";
            // alert("Page is loaded!!");

            $("#btnaceptarregistro").click(function () {
                alert("El cliente se Registro exitosamente");
                alert($("#tbnombre").valueOf());

            });

        });

       
 function show()
    {
        document.write("<head runat='server'></head>");
    }



    </script>
        <section class="content-header" style="left: 0px; top: 0px; height: 26px">
      <h1>
          Registrar Empleado
        <small>TheGym</small>
      </h1>
    </section>
     <!-- Main content -->
    <section class="content">
      <div class="row">
        <!-- left column -->
        <div class="col-md-6">
          <!-- general form elements -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title" style="width: 390px">Información personal</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
              <div class="box-body">
                  <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Nombre:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                    <asp:TextBox  CssClass="form-control" ID="tbnombre"  runat="server" Height="24px" Width="156px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbnombre" Display="None" ErrorMessage="Ingrese el nombre" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="validadornombre" runat="server" BehaviorID="validadornombre" TargetControlID="RequiredFieldValidator1">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                    <br />
                   <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Apellido:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:TextBox  CssClass="form-control" ID="tbapellido"  runat="server" Height="24px" Width="156px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbapellido" Display="None" ErrorMessage="Ingrese el apellido" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="validadorapellido" runat="server" BehaviorID="validadorapellido" TargetControlID="RequiredFieldValidator2">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                   <br />
                <%--<div class="form-group">
                  <label for="exampleInputPassword1">Fecha de Nacimiento:</label><asp:TextBox type="date" CssClass="form-control" ID="tbfechanacimiento"  runat="server" Height="24px" Width="128px"></asp:TextBox>
                </div>--%>
                   <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Fecha de Nacimiento:</label>
                       <br />

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:TextBox  CssClass="form-control"   ID="tbfechadenacimiento"  runat="server" Height="24px" Width="156px" TextMode="Date"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbfechadenacimiento" Display="None" ErrorMessage="Ingrese la fecha de Nacimiento" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="validadorfechanacimiento" runat="server" BehaviorID="validadorfechanacimiento" TargetControlID="RequiredFieldValidator3">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                   <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Tipo de documento:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:DropDownList  CssClass="form-control"   ID="ddltipodedocumento"  runat="server" Height="32px" Width="156px"></asp:DropDownList>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddltipodedocumento" Display="None" ErrorMessage="Seleccione el tipo de Documento" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator5_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator5">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                   <br />
                  <br />
                 <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Nº de documento:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 257px">
                    <asp:TextBox  CssClass="form-control"  ID="tbnumerodocumento"  runat="server" Height="24px" Width="156px" TextMode="number"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" CssClass="error-text" ControlToValidate="tbnumerodocumento" ErrorMessage="Ingrese un número válido" ValidationExpression="^\d+$" Display="Dynamic"></asp:RegularExpressionValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbnumerodocumento" Display="None" ErrorMessage="Ingrese el documento" SetFocusOnError="True"></asp:RequiredFieldValidator>
                  </div>
                </div>
                   <br />
                  <br />
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Sucursal:</label><div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:DropDownList  CssClass="form-control"   ID="ddlSucursal"  runat="server" Height="32px" Width="156px" OnSelectedIndexChanged="ddlSucursal_SelectedIndexChanged"></asp:DropDownList>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator91" runat="server" ControlToValidate="ddlSucursal" Display="None" ErrorMessage="Seleccione el tipo la Sucursal" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator91_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator5_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator91">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                   <br />

                <%--<div class="form-group">
                  <label for="exampleInputFile">Fotografía</label>
                    <asp:FileUpload ID="fiupfotografiacliente" runat="server" />
                  <p class="help-block">Seleccione la fotografía del cliente.</p>
                </div>--%>
              </div>
              <!-- /.box-body -->

          </div>
          <!-- /.box -->

          <!-- Form Element sizes -->
          <div class="box box-success">
            <div class="box-header with-border">
              <h3 class="box-title">Información de contacto</h3>
            </div>
            <div class="box-body">           
                <div class="box-body">
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label">Email</label>

                  <div class="col-sm-10">
                    <asp:TextBox  CssClass="form-control"  ID="tbemail"  runat="server" Height="24px" Width="156px" TextMode="email" AutoPostBack="True" OnTextChanged="tbemail_TextChanged"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbemail" Display="None" ErrorMessage="Ingrese el el E-mail" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator7_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator7_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator7">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                    <br />
                <div class="form-group" style="margin-bottom: 5px">
                  <label for="inputPassword3" class="col-sm-2 control-label">Teléfono:</label>

                  <div class="col-sm-10">
                   <asp:TextBox  CssClass="form-control"  ID="tbtelefono"  runat="server" Height="24px" Width="156px" TextMode="Phone"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbtelefono" Display="None" ErrorMessage="Ingrese el teléfono" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator8_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator8_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator8">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>

                <div class="form-group">
                  <div class="col-sm-offset-2 col-sm-10">
                    <%--<div class="checkbox">
                      <label>
                        <input type="checkbox"> Remember me
                      </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;</div>--%>
                  </div>
                </div>
              </div>
              
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
          <!-- /.box -->

        </div>
        <!--/.col (left) -->
        <!-- right column -->
        <div class="col-md-6">
          <!-- Horizontal Form -->
          <div class="box box-info">
            <div class="box-header with-border">
              <h3 class="box-title">Dirección:</h3>
            </div>
            <!-- /.box-header -->
            <!-- form start -->
              <div class="box-body">
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Localidad:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:DropDownList  CssClass="form-control"   ID="ddllocalidad"  runat="server" Height="32px" Width="156px"></asp:DropDownList>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddllocalidad" Display="None" ErrorMessage="Seleccione una localidad" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator9_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator9_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator9">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                   <br />
                 <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Calle:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 257px">
                    <asp:TextBox  CssClass="form-control"  ID="tbcalle"  runat="server" Height="24px" Width="156px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="tbcalle" Display="None" ErrorMessage="Ingrese una calle" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator10_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator10_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator10">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                   <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Barrio:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 257px">
                    <asp:TextBox  CssClass="form-control"  ID="tbbarrio"  runat="server" Height="24px" Width="156px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="tbbarrio" Display="None" ErrorMessage="Ingrese un barrio" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator11_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator11_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator11">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                  <br />
                  <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Nº de casa:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 257px">
                    <asp:TextBox  CssClass="form-control"  ID="tbnumerocasa"  runat="server" Height="24px" Width="128px" TextMode="number"></asp:TextBox>

                      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" CssClass="error-text" ControlToValidate="tbnumerocasa" ErrorMessage="Ingrese un número válido" ValidationExpression="^\d+$" Display="Dynamic"></asp:RegularExpressionValidator>

                      <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="tbnumerocasa" Display="None" ErrorMessage="Ingrese un número" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator12_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator12_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator12">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                <div class="form-group">
                  <div class="col-sm-offset-2 col-sm-10">
                    <%--<div class="checkbox">
                      <label>
                        <input type="checkbox"> Remember me
                      </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;</div>--%>
                  </div>
                </div>
              </div>
              <!-- /.box-body -->
              <%--<div class="box-footer">
                <button type="submit" class="btn btn-default">Cancel</button>
                <button type="submit" class="btn btn-info pull-right">Sign in</button>
              </div>--%>
              <!-- /.box-footer -->
          </div>
          <!-- /.box -->
          <!-- general form elements disabled -->
          <div class="box box-warning">
            <div class="box-header with-border">
              <h3 class="box-title">Información de usuario</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                                    <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label">Usuario:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px">
                    <asp:TextBox  CssClass="form-control"  ID="tbusuario"  runat="server" Height="24px" Width="128px" TextMode="email" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="tbusuario" Display="None" ErrorMessage="Ingrese un usuario" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator13_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator13_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator13">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                    <br />
                <div class="form-group" style="margin-bottom: 5px">
                  <label for="inputPassword3" class="col-sm-2 control-label">Contraseña</label>
                    <br />

                  <div class="col-sm-10">
                   <asp:TextBox  CssClass="form-control"  ID="tbcontraseña"  runat="server" Height="24px" Width="128px" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="tbcontraseña" Display="None" ErrorMessage="Ingrese una contraseña" SetFocusOnError="True"></asp:RequiredFieldValidator>
                  </div>
                    <br />
                    <br />
                  <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Fotografía:</label>

                </div>
                    <div class="col-sm-10" style="left: 0px; top: 0px; width: 397px">
                    <asp:FileUpload ID="fiupfotografiacliente" runat="server" />
                  <p class="help-block">Seleccione la fotografía del cliente.</p>
                      <p class="help-block">
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="fiupfotografiacliente" Display="None" ErrorMessage="RequiredFieldValidator" SetFocusOnError="True"></asp:RequiredFieldValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator6_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator6_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator6">
                          </ajaxToolkit:ValidatorCalloutExtender>
                      </p>
                  </div>
                </div>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

            
  <!-- general form elements disabled -->
          <div class="box box-warning">
            <div class="box-header with-border">
              <h3 class="box-title">Información Laboral</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
                            <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Cargo:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:DropDownList  CssClass="form-control"   ID="ddlcargo"  runat="server" Height="32px" Width="156px"></asp:DropDownList>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="ddlcargo" Display="None" ErrorMessage="Seleccione un cargo" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="ValidatorCalloutExtender20" runat="server" BehaviorID="RequiredFieldValidator20_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator20">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                    <br />
                <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Titulo:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                   <asp:TextBox  CssClass="form-control"  ID="tbtitulo"  runat="server" Height="24px" Width="156px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator90" runat="server" ControlToValidate="tbtitulo" Display="None" ErrorMessage="Ingrese un titulo" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="ValidatorCalloutExtender90" runat="server" BehaviorID="RequiredFieldValidator90_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator90">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                </div>
                <br />
            <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 114px">Contratación:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 258px">
                    <asp:TextBox  CssClass="form-control"  ID="tbfechacontratacion"  runat="server" Height="24px" Width="158px" TextMode="date"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="tbfechacontratacion" Display="None" ErrorMessage="Seleccione una fecha" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      <ajaxToolkit:ValidatorCalloutExtender ID="ValidatorCalloutExtender30" runat="server" BehaviorID="RequiredFieldValidator30_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator30">
                      </ajaxToolkit:ValidatorCalloutExtender>
                  </div>
                 </div>
            </div>
            <!-- /.box-body -->
          </div>





        </div>
        <!--/.col (right) -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
              <div class="box-footer">
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btnregistrar" CssClass="btn btn-info" runat="server" Text="Registrar" OnClick="btnregistrar_Click" />
                
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="btncancelar" runat="server" CssClass="btn btn-default" Text="Cancelar" CausesValidation="False" />
                
                  <br />
                  <asp:Label ID="lblerror" runat="server" CssClass="error-text"></asp:Label>
                
              </div>
</asp:Content>
