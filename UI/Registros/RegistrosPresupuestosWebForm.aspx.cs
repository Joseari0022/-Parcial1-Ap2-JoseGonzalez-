using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;

namespace _Parcial1_Ap2_JoseGonzalez_.UI.Registros
{
    public partial class RegistrosPresupuestosWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            ScriptResourceDefinition myscrypResDefer = new ScriptResourceDefinition();
            myscrypResDefer.Path = "~/Scripts/jquery-1.4.2.min.js";
            myscrypResDefer.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myscrypResDefer.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myscrypResDefer.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myscrypResDefer);
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdTextBox.Text);
            Presupuestos presupu = PresupuestosBll.Buscar(p => p.PresupuestoId == id);
            if (presupu != null)
            {
                FechaTextBox.Text = presupu.Fecha.ToString();
                DescripcionTextBox.Text = presupu.Descripcion;
                MontoTextBox.Text = presupu.Monto.ToString();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe el Usuario');</script>");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            MontoTextBox.Text = "";
            RequiredFieldValidator1.Text = "";
            RequiredFieldValidator2.Text = "";
            RequiredFieldValidator3.Text = "";
            RequiredFieldValidator4.Text = "";
        }


        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Presupuestos presupu = new Presupuestos();
            if (IsValid)
            {
                if (presupu.PresupuestoId != 0)
                {
                    PresupuestosBll.Modificar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('El Usuario se ha Modificado');</script>");
                }
                else
                {
                    presupu = Llenar();
                    PresupuestosBll.Guardar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto Guardado');</script>");

                }
            }
        }

        private Presupuestos Llenar()
        {
            Presupuestos presupu = new Presupuestos();
            presupu.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            presupu.Descripcion = DescripcionTextBox.Text;
            presupu.Monto = Convert.ToInt32(MontoTextBox.Text);
            return presupu;
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.ToInt(IdTextBox.Text);
            Presupuestos presupu = PresupuestosBll.Buscar(p => p.PresupuestoId == id);
            if (presupu != null)
            {
                if (presupu.PresupuestoId != 1)
                {
                    PresupuestosBll.Eliminar(presupu);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Presupuesto Eliminado');</script>");
                    Limpiar();
                }
            }
        }


    }
}