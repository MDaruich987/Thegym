﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GYMPaginasMaestras/MasterPageEntrenador.Master" AutoEventWireup="true" CodeBehind="ConsultarRutinaEntrenador.aspx.cs" Inherits="SistemasIIITHEGYM.ConsultarRutinaEntrenador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="lblusuario" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="White"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link href="EstilosCSS.css" rel="stylesheet" />
    <script type ="text/javascript">
       
 function show()
    {
        document.write("<head runat='server'></head>");
    }
    </script>



    <asp:UpdatePanel ID="upgeneral" runat="server">
        <ContentTemplate>
            <asp:Panel ID="paneledicion" runat="server" Height="1344px">
                <section class="content-header">
                    <h1>Editar Rutina <small>TheGym</small> </h1>
                </section>

            <%--panel de datos generales rutina--%>
                <div class="box box-default">
                <div class="box-header with-border">
                    <h3 class="box-title">Datos de Rutina </h3>
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
                                <label class="col-sm-2 control-label" for="inputEmail3" style="left: 0px; top: 0px; width: 114px">
                                Nombre:</label>
                                <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Height="24px" Width="128px" ReadOnly="True"></asp:TextBox>
                                    <ajaxToolkit:ValidatorCalloutExtender ID="validadornombre" runat="server" BehaviorID="validadornombre" TargetControlID="RequiredFieldValidator1">
                                    </ajaxToolkit:ValidatorCalloutExtender>
                                </div>
                            </div>
                            <br />
                        </div>
            <!-- columna2 inicio/.col -->
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="inputEmail3" style="left: 0px; top: 0px; width: 114px">
                                 Cliente:</label>
                                <div class="col-sm-10" style="left: 0px; top: 0px; width: 253px">
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Height="24px" ReadOnly="True" Width="128px"></asp:TextBox>
                                </div>
                            </div>
                            <br />
              <!-- /.form-group -->
                            <asp:Label ID="Label1" runat="server" CssClass="error-text"></asp:Label>
                        </div>
            <!-- /.col -->
                    </div>
          <!-- /.row -->
                </div>
        <!-- /.box-body -->
                <%--pie con botones registrar--%>
                <%--<div class="box-footer">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnregistrar" runat="server" CssClass="btn btn-info" OnClick="btnregistrar_Click" Text="Registrar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btncancelar" runat="server" CausesValidation="False" CssClass="btn btn-default" Text="Cancelar" />
                </div>--%>
            </div>

          <!-- Horizontal Form -->
                                        <div class="box">
            <div class="box-header with-border">
              <h3 class="box-title">Datos de la rutina</h3>
                <br />
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <div class="row">
                <div class="col-md-8">
                  <p class="text-center">
                    <strong></strong>
                  </p>
                  <asp:GridView ID="gridejerciciosrutina" runat="server" AllowSorting="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Bottom" CellPadding="4" CellSpacing="1" DataKeyNames="Id_ejercicio" Font-Size="Medium" ForeColor="Black" GridLines="Horizontal" Height="188px" HorizontalAlign="Justify" PageSize="6" ShowHeaderWhenEmpty="True" style="margin-left: 107px; margin-bottom: 9px;" Width="451px" AutoGenerateColumns="False" ViewStateMode="Enabled" OnRowDeleting="gridejerciciosrutina_RowDeleting">
                                              <Columns>
                                                   <asp:BoundField DataField="Grupo_muscular" HeaderText="Grupo Muscular"/>
                            <asp:BoundField DataField="Ejercicio" HeaderText="Ejercicio"/>
                            <asp:BoundField DataField="Id_ejercicio" HeaderText="Id ejercio"/>
                            <asp:BoundField DataField="Serie" HeaderText="Serie"/>
                            <asp:BoundField DataField="Rep" HeaderText="Repeticion"/>
                            <asp:BoundField DataField="Dia" HeaderText="Dia"/>
                                              <asp:CommandField ButtonType="Image" DeleteImageUrl="~/ImagenesSistema/eliminar.png" ShowDeleteButton="True">
                                                  <ControlStyle Height="20px" Width="20px" />
                                                  </asp:CommandField>   
                                              </Columns>
                                              <EditRowStyle BorderColor="Black" BorderStyle="None" Font-Size="Small" />
                                              <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                              <HeaderStyle BackColor="#364E6F" Font-Bold="True" ForeColor="White" Height="30px" />
                                              <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                              <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="220px" />
                                              <SelectedRowStyle BackColor="#6A8BB7" Font-Bold="True" ForeColor="White" />
                                              <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                              <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                              <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                              <SortedDescendingHeaderStyle BackColor="#242121" />
                                          </asp:GridView>
                  
                  <!-- /.chart-responsive -->
                </div>
                <!-- /.col -->
                <div class="col-md-4">
                  <p class="text-center">
                    <strong>Editar ejercicio</strong>
                  </p>
                    <br />
                    <div class="form-group">
                                <label class="col-sm-2 control-label" for="inputEmail3" style="left: 0px; top: 0px; width: 114px">
                                Grupo Muscular:</label>
                                <div class="col-sm-10" style="left: 0px; top: 0px; width: 151px">
                                    <asp:DropDownList ID="ddlgrupomuscular" runat="server" CssClass="form-control" Height="32px" Width="128px" AutoPostBack="True" OnSelectedIndexChanged="ddlgrupomuscular_SelectedIndexChanged" >
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlgrupomuscular" Display="None" ErrorMessage="Seleccione un grupo" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator5_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator5_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator5">
                                    </ajaxToolkit:ValidatorCalloutExtender>
                                </div>
                            </div>
                     <br />
                    <br />
                  <div class="form-group">
                                <label class="col-sm-2 control-label" for="inputEmail3" style="left: 0px; top: 0px; width: 114px">
                                Ejercicio:</label>
                                <div class="col-sm-10" style="left: 0px; top: 0px; width: 165px">
                                    <asp:DropDownList ID="ddlejercicio" runat="server" CssClass="form-control" Height="32px" Width="128px">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlejercicio" Display="None" ErrorMessage="Seleccione un ejercicio" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                    <br />
                    <br />
                   <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top: 0px; width: 115px">Nº de Series:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 162px">
                      <asp:ListBox ID="lbseries" runat="server" Height="24px" Width="37px" Rows="1">
                          <asp:ListItem>1</asp:ListItem>
                          <asp:ListItem>2</asp:ListItem>
                          <asp:ListItem>3</asp:ListItem>
                          <asp:ListItem>4</asp:ListItem>
                          <asp:ListItem>5</asp:ListItem>
                          <asp:ListItem>6</asp:ListItem>
                          <asp:ListItem>7</asp:ListItem>
                          <asp:ListItem>8</asp:ListItem>
                          <asp:ListItem>9</asp:ListItem>
                          <asp:ListItem>10</asp:ListItem>
                          <asp:ListItem>11</asp:ListItem>
                          <asp:ListItem>12</asp:ListItem>
                      </asp:ListBox>
                  </div>
                </div>
                    <br />
                  <br />
                   <div class="form-group">
                  <label for="inputEmail3" class="col-sm-2 control-label" style="left: 0px; top:0px; width: 115px">Nº de Repeticiones:</label>

                  <div class="col-sm-10" style="left: 0px; top: 0px; width: 162px">
                      <asp:ListBox ID="lbrrepeticiones" runat="server" Height="24px" Width="37px" Rows="1">
                          <asp:ListItem>1</asp:ListItem>
                          <asp:ListItem>2</asp:ListItem>
                          <asp:ListItem>3</asp:ListItem>
                          <asp:ListItem>4</asp:ListItem>
                          <asp:ListItem>5</asp:ListItem>
                          <asp:ListItem>6</asp:ListItem>
                          <asp:ListItem>7</asp:ListItem>
                          <asp:ListItem>8</asp:ListItem>
                          <asp:ListItem>9</asp:ListItem>
                          <asp:ListItem>10</asp:ListItem>
                          <asp:ListItem>11</asp:ListItem>
                          <asp:ListItem>12</asp:ListItem>
                      </asp:ListBox>
                  </div>
                       <br />
                       <br />
                       <br />
                       <div class="form-group">
                           <label class="col-sm-2 control-label" for="inputEmail3" style="left: 0px; top: 0px; width: 114px">
                           Día:</label>
                           <div class="col-sm-10" style="left: 0px; top: 0px; width: 165px">
                               <asp:DropDownList ID="lbdias" runat="server">
                                   <asp:ListItem>Lunes</asp:ListItem>
                                   <asp:ListItem>Martes</asp:ListItem>
                                   <asp:ListItem>Miercoles</asp:ListItem>
                                   <asp:ListItem>Jueves</asp:ListItem>
                                   <asp:ListItem>Viernes</asp:ListItem>
                                   <asp:ListItem>Sabado</asp:ListItem>
                               </asp:DropDownList>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator48" runat="server" ControlToValidate="lbdias" Display="None" ErrorMessage="Seleccione un día" SetFocusOnError="True"></asp:RequiredFieldValidator>
                               <ajaxToolkit:ValidatorCalloutExtender ID="ValidatorCalloutExtender48" runat="server" BehaviorID="RequiredFieldValidator3_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator48">
                               </ajaxToolkit:ValidatorCalloutExtender>
                           </div>
                       </div>
                       <br />
                       <br />
                       &nbsp;&nbsp;<asp:Button ID="btneditarejercicio" runat="server" CssClass="btn btn-success" Text="Editar" OnClick="btneditarejercicio_Click" />
                <!-- /.col -->
              </div>





                </div>
              <!-- /.row -->
            </div>
            <!-- ./box-body -->
             <div class="box-footer">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btneditarRutina" runat="server" CssClass="btn btn-info" Text="Editar" OnClick="btneditarRutina_Click1" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btncancelar" runat="server" CausesValidation="False" CssClass="btn btn-default" Text="Cancelar" OnClick="btncancelar_Click" />
                </div>
            <!-- /.box-footer -->
          </div>
          <!-- /.box -->
          <!-- general form elements disabled -->
          <!-- /.box -->
                        </div>
        <!--/.col (right) -->
                    </div>
      <!-- /.row -->
                </section>
    <!-- /.content -->
  <!-- /.content-wrapper -->
            </asp:Panel>
            <asp:Panel ID="panelconsulta" runat="server">
                <%-- inicio contenedor busqueda--%>
                <div class="row">
                    <div class="col-md-12">
                        <div class="box">
                            <div class="box-header with-border" style="left: 0px; top: 0px; width: 607px;">
                                <h3 class="box-title">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Búsqueda de Rutina</h3>
                            </div>
                            <div class="box-body">
                                <div class="form-group">
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbcliente" runat="server" Height="21px" Width="371px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbcliente" Display="None" ErrorMessage="Indique Apellido" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator1_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator1">
                                    </ajaxToolkit:ValidatorCalloutExtender>
                  <br />
                                    <table class="nav-justified" style="height: 48px">
                                        <tr>
                                            <td class="modal-sm" style="width:408px">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnconsultar" runat="server" CssClass="btn btn-info" Text="Consultar" OnClick="btnconsultar_Click" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="lblerror" runat="server" CssClass="error-text"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            <%--fin de contenedor busqueda inicio contenedor gridview--%>

                      <div class="row">
                          <div class="col-md-12">
                              <div class="box">
                                  <div class="box-header with-border" style="left: 0px; top: 0px; width: 607px;">
                                      <h3 class="box-title">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Ficha de Rutina</h3>
                                  </div>
                                  <div class="box-body">
              <!-- Date -->
                                      <div class="form-group">
                                          &nbsp;
                                          <asp:GridView ID="gridfichaderutina" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Bottom" CellPadding="4" CellSpacing="1" Font-Size="Medium" ForeColor="Black" GridLines="Horizontal" Height="210px" HorizontalAlign="Justify" PageSize="6" ShowHeaderWhenEmpty="True" style="margin-left: 136px; margin-bottom: 9px;" Width="601px" OnSelectedIndexChanged="gridfichaderutina_SelectedIndexChanged" OnRowDeleting="gridfichaderutina_RowDeleting1" AllowPaging="True" OnPageIndexChanging="gridfichaderutina_PageIndexChanging">
                                              <Columns>
                                                  <asp:BoundField DataField="id" HeaderText="ID Rutina" />
                                                  <asp:BoundField DataField="cli" HeaderText="Cliente" />
                                                  <asp:BoundField DataField="nom" HeaderText="Nombre Rutina" />
                                                  <asp:BoundField DataField="emp" HeaderText="Nombre Empleado" />
                                                  <asp:BoundField DataField="fecha" HeaderText="Fecha Rutina" />
                                                  <asp:CommandField ButtonType="Image" SelectImageUrl="~/ImagenesSistema/editargrid.png" ShowSelectButton="True">
                                                  <ControlStyle Height="20px" Width="20px" />
                                                  </asp:CommandField>
                                                  <asp:CommandField ButtonType="Image" DeleteImageUrl="~/ImagenesSistema/eliminar.png" ShowDeleteButton="True">
                                                  <ControlStyle Height="20px" Width="20px" />
                                                  </asp:CommandField>
                                              </Columns>
                                              <EditRowStyle BorderColor="Black" BorderStyle="None" Font-Size="Small" />
                                              <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                              <HeaderStyle BackColor="#364E6F" Font-Bold="True" ForeColor="White" Height="30px" />
                                              <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                              <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="220px" />
                                              <SelectedRowStyle BackColor="#6A8BB7" Font-Bold="True" ForeColor="White" />
                                              <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                              <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                              <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                              <SortedDescendingHeaderStyle BackColor="#242121" />
                                          </asp:GridView>

                  <br />

                  <br />
                                      </div>
                  <!-- /.description-block -->
                <br />
                                  </div>
                              </div>
              <!-- /.row -->
                          </div>
                </div>
            <!-- /.box-footer -->
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
