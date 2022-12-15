using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest
{
    public partial class APSMarc : System.Web.UI.Page
    {
        Dictionary<string, string> cumpleanyos = new Dictionary<string, string>()
        {
            {"30-05", "Marc"  },
            {"22-12", "Jordi"  },
            {"11-08" , "Sergi" },
            {"10-12" , "Michael" },
            {"16-01" , "Dana" }
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            DesplegableFechas();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            label2.Text = UserName.Text;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            ShowDate.Text = "You Selected: " + Calendar1.SelectedDate.ToString("D");
            int dia = Calendar1.SelectedDate.Day;
            int mes = Calendar1.SelectedDate.Month;
            string fecha = dia.ToString() +"-"+ mes.ToString();
            //ShowDate.Text = mes + ", " + dia;
            if(dia == 28 && mes == 12)
            {
                Especial.Text = "Es el dia de los santos inocentes!";
            }

            if(cumpleanyos.ContainsKey(fecha))
            {
                Especial.Text = "Hoy es el cumpleaños de " + cumpleanyos[fecha] + "!";
            }
        }

        protected void DesplegableFechas()
        {
            string ConString = "data source=MSI\\SQLEXPRESS; database=cumple;Integrated Security=SSPI";
            SqlConnection connection = new SqlConnection(ConString);
            SqlCommand cm = new SqlCommand("select * from cumpleaños", connection);
            connection.Open();
            SqlDataReader sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                //ListaFechas.Items.Add($"{sdr["nombre"]}, {sdr["fecha"]}");
                ListaFechas.Items.Add(sdr["nombre"].ToString());
            }
            connection.Close();
            
            
        }
    }
}