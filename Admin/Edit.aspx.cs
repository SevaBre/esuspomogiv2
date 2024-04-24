using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace esuspomogiv2.Admin
{
    public partial class Edit : System.Web.UI.Page
    {
        List<Proizvod> proizvodi = new List<Proizvod>();
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ucitaj();
        }


        void ucitaj()
        {
            try
            {
                proizvodi.Clear();
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    con.Open();

                    string query = "Select Naziv,JedinicaMere,Kolicina,Cena,Slika,ProizvodID from PROIZVODI";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proizvod p = new Proizvod(reader[0].ToString(), reader[1].ToString(),reader[2].ToString(), reader[3].ToString(), "~/Pictures/" + reader[4].ToString(), reader[5].ToString());
                        proizvodi.Add(p);
                    }
                    reader.Close();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //insert
            try
            {
                SqlConnection con = new SqlConnection(cs);
                
                string query = "Insert into PROIZVODI (Naziv,JedinicaMere,Kolicina,Cena,Slika) values(@Naziv,@JM,@K,@C,@S)";
                string naziv = TextBox2.Text;
                string Jmere = TextBox3.Text;
                int kolicina = int.Parse(TextBox4.Text);
                float cena = float.Parse(TextBox5.Text);
                string slika = TextBox6.Text;

                using (con)
                {
                    con.Open();

                    SqlParameter p1 = new SqlParameter();
                    p1.Value = naziv; p1.ParameterName = "@Naziv";
                    SqlParameter p2 = new SqlParameter();
                    p2.Value = Jmere; p2.ParameterName = "@JM";
                    SqlParameter p3 = new SqlParameter();
                    p3.Value = kolicina; p3.ParameterName = "@K";
                    SqlParameter p4 = new SqlParameter();
                    p4.Value = cena; p4.ParameterName = "@C";
                    SqlParameter p5 = new SqlParameter();
                    p5.Value = slika; p5.ParameterName = "@S";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);


                    cmd.ExecuteNonQuery();
                }

                ucitaj();
                cl();

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //edit

            try
            {
                SqlConnection con = new SqlConnection(cs);

                string query = "Update PROIZVODI Set Naziv=@Naziv,JedinicaMere=@JM,Kolicina=@K,Cena=@C,Slika=@S where ProizvodID=@ID;";
                string naziv = TextBox2.Text;
                string Jmere = TextBox3.Text;
                int kolicina = int.Parse(TextBox4.Text);
                float cena = float.Parse(TextBox5.Text);
                string slika = TextBox6.Text;
                int ID = int.Parse(TextBox1.Text);

                using (con)
                {
                    con.Open();

                    SqlParameter p1 = new SqlParameter();
                    p1.Value = naziv; p1.ParameterName = "@Naziv";
                    SqlParameter p2 = new SqlParameter();
                    p2.Value = Jmere; p2.ParameterName = "@JM";
                    SqlParameter p3 = new SqlParameter();
                    p3.Value = kolicina; p3.ParameterName = "@K";
                    SqlParameter p4 = new SqlParameter();
                    p4.Value = cena; p4.ParameterName = "@C";
                    SqlParameter p5 = new SqlParameter();
                    p5.Value = slika; p5.ParameterName = "@S";
                    SqlParameter p6 = new SqlParameter();
                    p6.Value = ID; p6.ParameterName = "@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);


                    cmd.ExecuteNonQuery();
                }

                ucitaj();
                cl();

            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //delete
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "Delete from PROIZVODI where ProizvodID=@ID";
                int ID = int.Parse(TextBox1.Text);
                using (con)
                {
                    con.Open();

                    SqlParameter p1 = new SqlParameter();
                    p1.Value = ID; p1.ParameterName = "@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(p1);

                    cmd.ExecuteNonQuery();

                }
                ucitaj();
                cl();



            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }

        }


        public void cl()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            cl();
        }
    }
}

       
  