using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace _Parcial1_Ap2_JoseGonzalez_.UI.Consultas
{
    public partial class ConsultasPresupuestosWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Presupuestos presupu = new Presupuestos();
            ConsultaPresupuestosGridView.DataSource = PresupuestosBll.ListarTodo();
            ConsultaPresupuestosGridView.DataBind();
        }

        public List<Presupuestos> lista { get; set; }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            BuscarSelecCombo();
        }

        private void BuscarSelecCombo()
        {
            if (FiltroDropDownList.SelectedIndex == 0)
            {
                int Busqueda = Utilidades.ToInt(FiltroTextBox.Text);
                lista = PresupuestosBll.Listar(p => p.PresupuestoId == Busqueda);
                ConsultaPresupuestosGridView.DataSource = lista;
                ConsultaPresupuestosGridView.DataBind();
            }
            else if (FiltroDropDownList.SelectedIndex == 1)
            {
                DateTime desde = Convert.ToDateTime(desdeFecha.Text);
                DateTime hasta = Convert.ToDateTime(desdeFecha.Text);

                if (desdeFecha.Text != "" && hastaFecha.Text != "")
                {
                    if (desde <= hasta)
                    {
                        lista = PresupuestosBll.Listar(p => p.Fecha >= desde && p.Fecha <= hasta);
                        ConsultaPresupuestosGridView.DataSource = lista;
                        ConsultaPresupuestosGridView.DataBind();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('inserta la fecha');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Insertar el Intervalo de Fecha');</script>");
                }
            }

            else if (FiltroDropDownList.SelectedIndex == 2)
            {
                if (FiltroTextBox.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    lista = PresupuestosBll.Listar(p => p.Descripcion == FiltroTextBox.Text);
                    ConsultaPresupuestosGridView.DataSource = lista;
                    ConsultaPresupuestosGridView.DataBind();
                }
            }
            else if (FiltroDropDownList.SelectedIndex == 3)
            {
                if (FiltroTextBox.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar el Monto');</script>");
                }
                else
                {
                    lista = PresupuestosBll.Listar(p => p.Monto == Convert.ToDecimal(FiltroTextBox.Text));
                    ConsultaPresupuestosGridView.DataSource = lista;
                    ConsultaPresupuestosGridView.DataBind();
                }
            }


                    ConsultaPresupuestosGridView.DataSource = lista;
                    ConsultaPresupuestosGridView.DataBind();
                }
            }
        }
    
