using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Microsoft.Owin;
using System.Data;

namespace esuspomogiv2
{
    public partial class _Default : Page
    {

        List<Proizvod> proizvodi = new List<Proizvod>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ucitaj();
        }

        void ucitaj()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                using (con)
                {
                    con.Open();

                    string query = "Select Naziv,JedinicaMere,Kolicina,Cena,Slika from PROIZVODI";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proizvod p = new Proizvod(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), float.Parse(reader[3].ToString()), "~/Pictures/" + reader[4].ToString());
                        proizvodi.Add(p);
                    }
                }
                GridView1.DataSource = proizvodi;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }
    }


}