using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_Form_Application
{
    public partial class ApplyForm : Form
    {
        public ApplyForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MU5I42SI;Initial Catalog=LoginDetails;Integrated Security=True; TrustServerCertificate=true");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ApplyForm_Load(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            
            String txt_name = namebox.Text;
            String txt_company = companybox.Text;
            String txt_contact = contactbox.Text;
            String txt_email = emailbox.Text;
            String txt_address = addressbox.Text;
            
            Chnull(txt_name, txt_company, txt_email, txt_contact, txt_address);

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            companybox.Clear();
            contactbox.Clear();
            addressbox.Clear();
            emailbox.Clear();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Chnull(String name, String company, String email, String contact, String address)
        {
            if (name.Length > 0 && company.Length > 0 && email.Length > 0 && contact.Length > 0 && address.Length > 0 && contact.Length == 10 && email.Contains('@'))
            {
                String cname = name;
                String ccompany = company;
                String cemail = email;
                String ccontact = contact;
                String caddress = address;
                Vaemco(cname, ccompany, cemail, ccontact, caddress);
            }
            else if (name.Length <= 0)
            {
                namelabel.Text = "This Field Is Required";
            }
            if (company.Length <= 0)
            {
                companylabel.Text = "This Field Is Required";
            }
            if (email.Length <= 0)
            {
                emaillabel.Text = "This Field Is Required";
            }
            if (!email.Contains('@') && email.Length > 0)
            {
                emaillabel.Text = "Invalid Email-Id";

            }
            if (contact.Length < 10 && contact.Length > 0)
            {
                contactlabel.Text = "Invaid Contact Number";
            }
            if (contact.Length <= 0)
            {
                contactlabel.Text = "This Field Is Required";
            }
            if (address.Length <= 0)
            {
                addresslabel.Text = "This Field Is Required";
            }
            if (name.Length > 0)
            {
                namelabel.Text = "";
            }
            if (company.Length > 0)
            {
                companylabel.Text = "";
            }
            if (email.Length > 0 && email.Contains('@'))
            {
                emaillabel.Text = "";
            }
            if (contact.Length == 10)
            {
                contactlabel.Text = "";
            }
            if (address.Length > 0)
            {
                addresslabel.Text = "";
            }
        }
        private void Vaemco(String name, String company, String email, String contact, String address)
        {
            String sname = name;
            String scompany = company;
            String semail = email;
            String scontact = contact;
            String saddress = address;
            namelabel.Text = "";
            companylabel.Text = "";
            emaillabel.Text = "";
            contactlabel.Text = "";
            addresslabel.Text = "";

            try
            {
                conn.Open();
               
                String querry = "SELECT * FROM registration WHERE email = '" + semail + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable eTable = new DataTable();
                

                String querry1 = "SELECT * FROM registration WHERE contact = '" + scontact + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn);

                DataTable cTable = new DataTable();
                sda.Fill(eTable);
                sda1.Fill(cTable);



                if (eTable.Rows.Count <= 0 && cTable.Rows.Count <=0 )
                {
                    string query = "INSERT INTO registration (Name, Company, Email, Contact, Address) VALUES (@Name, @Company, @Email, @Contact, @Address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Company", scompany);
                    cmd.Parameters.AddWithValue("@Email", semail);
                    cmd.Parameters.AddWithValue("@Contact", scontact);
                    cmd.Parameters.AddWithValue("@Address", saddress);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Submitted Successfully");
                    namebox.Clear();
                    companybox.Clear();
                    contactbox.Clear();
                    addressbox.Clear();
                    emailbox.Clear();

                    conn.Close();

                }


                else if (eTable.Rows.Count > 0)
                {
                    MessageBox.Show("Email-Id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
                if (cTable.Rows.Count > 0)
                {
                    MessageBox.Show("Contact Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
          

        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void companylabel_Click(object sender, EventArgs e)
        {

        }

        private void emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void contactlabel_Click(object sender, EventArgs e)
        {

        }

        private void addresslabel_Click(object sender, EventArgs e)
        {

        }

        private void contactbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
