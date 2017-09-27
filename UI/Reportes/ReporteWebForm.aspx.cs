using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

namespace _Parcial1_Ap2_JoseGonzalez_.UI.Reportes
{
    public partial class ReporteWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //indicando que es local
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                ReportViewer1.Reset();

                //ruta servidor
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~UI\Reportes\ListadosUsuarios.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();

                //agregar fuentes de datos
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Presupuestos", PresupuestosBll.Listar("1=1")));

                //refrescar datos mostrados
                ReportViewer1.LocalReport.Refresh();

            }
        }

        //public static DataTable ObtenerDatos(string Condicion)
        //{
        //    Parcial1_Ap2_JoseGonzalezDb oData = new Parcial1_Ap2_JoseGonzalezDb();
        //    DataTable dt = new DataTable();

        //    dt = oData.ObtenerDatos("Select * from Usuarios where " + Condicion);

        //    return dt;
        //}
    }
}