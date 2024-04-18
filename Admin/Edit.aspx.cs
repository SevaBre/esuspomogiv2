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
            Button1.Enabled = true;
            ucitaj();
            if (GridView1.SelectedRow != null)
            {
                Panel2.Visible = true;
                TextBox1.Text = GridView1.SelectedRow.Cells[3].Text;
                TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
                TextBox3.Text = GridView1.SelectedRow.Cells[6].Text;
                TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
                int x = -1 + int.Parse(GridView1.SelectedRow.Cells[1].Text);
                TextBox5.Text = proizvodi[x].Slika;
                Button1.Enabled = false;
            }


        }


        void ucitaj()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                using (con)
                {
                    con.Open();

                    string query = "Select Naziv,JedinicaMere,Kolicina,Cena,Slika,ProizvodID from PROIZVODI";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proizvod p = new Proizvod(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()), float.Parse(reader[3].ToString()), "~/Pictures/" + reader[4].ToString(), int.Parse(reader[5].ToString()));
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            //insert
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HalalDelights;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                using (con)
                {
                    con.Open();

                    SqlParameter p1 = new SqlParameter();
                    p1.Value = GridView1.SelectedRow.Cells[1].Text;
                    p1.ParameterName = "@ID";
                    SqlParameter p2 = new SqlParameter();
                    p2.Value = TextBox1.Text;
                    p2.ParameterName = "@Naziv";
                    SqlParameter p3 = new SqlParameter();
                    p3.Value = GridView1.SelectedRow.Cells[1].Text;
                    p3.ParameterName = "@JedMere";
                    SqlParameter p4 = new SqlParameter();
                    p4.Value = GridView1.SelectedRow.Cells[1].Text;
                    p4.ParameterName = "@Kol";
                    SqlParameter p5 = new SqlParameter();
                    p5.Value = GridView1.SelectedRow.Cells[1].Text;
                    p5.ParameterName = "@Cena";
                    SqlParameter p6 = new SqlParameter();
                    p6.Value = GridView1.SelectedRow.Cells[1].Text;
                    p6.ParameterName = "@Slika";

                    string query = "Update PROIZVODI SET Naziv=@Naziv,JedinicaMere=@JedMere,Kolicina=@Kol,Cena=@Cena,Slika=@Slika WHERE ProizvodID=@ID";
                    
                    SqlCommand cmd=new SqlCommand(query, con);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    cmd.ExecuteNonQuery();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    Panel2.Visible = false;
                    Button1.Enabled = true;
                    ucitaj();


                }
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
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Panel2.Visible = false;
            Button1.Enabled = true;
        }
    }
}