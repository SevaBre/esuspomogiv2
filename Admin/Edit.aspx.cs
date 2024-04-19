using System;
using System.Collections.Generic;
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
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

            if (Panel1.Visible)
            {
                Panel1.Visible = false;
            }
            else
            {
                Panel1.Visible = true; ;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            ucitaj();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //update
            try
            {

                if (TextBox12.Text != "" && int.Parse(TextBox12.Text) > 0)
                {


                    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (con)
                    {
                        con.Open();
                        string query = "Update PROZIVODI SET Naziv=@Naziv,JedinicaMere=@JM,Kolicina=@Kol,Cena=@Cena,Slika=@Slika where ProizvodID=@ID";
                        SqlParameter p1 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@ID";
                        SqlParameter p2 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@Naziv";
                        SqlParameter p3 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@JM";
                        SqlParameter p4 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@Kol";
                        SqlParameter p5 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@Cena";
                        SqlParameter p6 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@Slika";
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
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                //del
                if (TextBox12.Text != "" && int.Parse(TextBox12.Text) > 0)
                {


                    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (con)
                    {
                        con.Open();
                        string query = "Delete from PROIZVODI where ProizvodID=@ID";
                        SqlParameter p1 = new SqlParameter();
                        p1.Value = int.Parse(TextBox12.Text);
                        p1.ParameterName = "@ID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(p1);

                        cmd.ExecuteNonQuery();


                    }
                    Del.Text = "";
                    TextBox12.Text = "";
                    ucitaj();
                }
                else
                {
                    Del.Text = "ID > 0 i da nije prazno";
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = "SERVER ERROR";
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }



        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox6.Text != "" && int.Parse(TextBox6.Text) > 0)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (con)
                    {
                        con.Open();

                        string query = "Select * from PROIZVODI Where ProizvodID=@ID";
                        SqlParameter p1 = new SqlParameter();
                        p1.Value = int.Parse(TextBox6.Text);
                        p1.ParameterName = "@ID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(p1);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            TextBox7.Text = reader[1].ToString();
                            TextBox8.Text = reader[2].ToString();
                            TextBox9.Text = reader[3].ToString();
                            TextBox10.Text = reader[4].ToString();
                            TextBox11.Text = reader[5].ToString();
                        }
                        reader.Close();
                    }
                }


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

       
  