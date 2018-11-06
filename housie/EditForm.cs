using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace housie
{
    public partial class EditForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["housieConnectionString"].ConnectionString);
        public EditForm()
        {
            InitializeComponent();
            Id.Visible = false;
            label_response.Visible = false;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'housieDataSet.Ticket_Collection' table. You can move, or remove it, as needed.
            this.ticket_CollectionTableAdapter.Fill(this.housieDataSet.Ticket_Collection);

        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id.Text.ToString());
            String name = ticket_holder_name.Text.ToString();
            String address = ticket_holder_address.Text.ToString().Trim();
            String bumper_ticket_no = bumper_no.Text.ToString().Trim();
            String mini_bumper_ticket_no = mini_bumper_no.Text.ToString().Trim();
            if (isTicketExist(bumper_ticket_no, "bumper")) { return; }
            if (isTicketExist(mini_bumper_ticket_no, "mini_bumper")) { return; }
            if (!isValidate()) { return; }

            String qry = "";
            Boolean payment = payment_yes.Checked;
            int payment_st = (payment) ? 1 : 0;
            if (payment_yes.Checked == true)
            {

                qry = "update Ticket_Collection set ticket_holder_name=@ticket_holder_name," +
                "address=@address,bumper_no=@bumper_no,mini_bumper_no=@mini_bumper_no," +
                "payment_date=@payment_date,payment_status=@payment_status,seller_name=@seller_name" +
                "  where Id=@Id";
            }
            else {
                qry = "update Ticket_Collection set ticket_holder_name=@ticket_holder_name," +
                "address=@address,bumper_no=@bumper_no,mini_bumper_no=@mini_bumper_no," +
                "payment_date=@payment_date,payment_status=@payment_status,seller_name=@seller_name" +
                "  where Id=@id";
            }
            SqlCommand cmd = new SqlCommand(qry,con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ticket_holder_name", name);
            cmd.Parameters.AddWithValue("@address", address);

            //Bumper Ticket Number
            if (bumper_ticket_no != "" && isNum(bumper_ticket_no)==true)
            {
                cmd.Parameters.AddWithValue("@bumper_no", bumper_ticket_no);
            }
            else
            {
                cmd.Parameters.AddWithValue("@bumper_no", DBNull.Value);
            }

            //Mini Bumper Ticket Number
            if(mini_bumper_ticket_no!="" && isNum(mini_bumper_ticket_no)==true)
            {
                cmd.Parameters.AddWithValue("@mini_bumper_no", mini_bumper_ticket_no);
            }
            else
            {
                cmd.Parameters.AddWithValue("@mini_bumper_no", DBNull.Value);
            }
            
            cmd.Parameters.AddWithValue("@payment_status", payment_st);
            cmd.Parameters.AddWithValue("@seller_name", seller_name.Text);
            if (payment_st == 1) {
                cmd.Parameters.AddWithValue("@payment_date", Convert.ToDateTime(date_of_payment.Text));
            }
            else
            {
                cmd.Parameters.AddWithValue("@payment_date", DBNull.Value);
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully","Save result");
            }
            catch(Exception excpt)
            {
                MessageBox.Show(excpt.GetBaseException().ToString());
            }
            Form1.search_and_display();
            con.Close();
            this.Close();
        }

        public void set_data(Ticket ticket) {
            Id.Text = ticket.Id.ToString();
            ticket_holder_name.Text = ticket.ticket_holder_name;
            ticket_holder_address.Text = ticket.address;
            bumper_no.Text = ticket.bumper_no==0? "":ticket.bumper_no.ToString();
            mini_bumper_no.Text = ticket.mini_bumper_no==0?"":ticket.mini_bumper_no.ToString();
            seller_name.Text = ticket.seller_name;
            if (ticket.payment_status == true)
            {
                payment_yes.Checked = true;
                payment_no.Checked = false;
                label_payment_date.Visible = true;
                date_of_payment.Visible = true;
                date_of_payment.Text = ticket.payment_date.ToString();
            }
            else {
                payment_yes.Checked = false;
                payment_no.Checked = true;
                label_payment_date.Visible = false;
                date_of_payment.Visible = false;
            }
        }

        private void payment_yes_CheckedChanged(object sender, EventArgs e)
        {
            label_payment_date.Visible = true;
            date_of_payment.Visible = true;
        }

        private void payment_no_CheckedChanged(object sender, EventArgs e)
        {
            label_payment_date.Visible = false;
            date_of_payment.Visible = false;
        }

        public Boolean isNum(String str_num)
        {
            int i = 0;
            bool result = int.TryParse(str_num, out i);
            return result;
        }

        private Boolean isTicketExist(string ticket_no, string housie_type) {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd;
            SqlDataReader reader;
            String query = (housie_type=="bumper")?"select * from Ticket_Collection T where T.bumper_no = " + ticket_no + "and Id!=" + Id.Text:
                "select * from Ticket_Collection T where T.mini_bumper_no = " + ticket_no + "and Id!=" + Id.Text;
            if (ticket_no.Trim() != "")
            {
                cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (housie_type == "bumper")
                    {
                        MessageBox.Show("Bumper Serial number already exist.");
                    } 
                    else
                    {
                        MessageBox.Show("Mini Bumper Serial number already exist.");
                    }
                    con.Close();
                    return true;
                }
                reader.Close();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return false;    
        }
        public Boolean isValidate() {
            Boolean flag = false;
            String bumper_ticket_no = bumper_no.Text.ToString().Trim();
            String mini_bumper_ticket_no = mini_bumper_no.Text.ToString().Trim();
            if (bumper_ticket_no=="" || (isNum(bumper_ticket_no) && Convert.ToInt32(bumper_ticket_no) <= 600))
            {
                /*if (isTicketExist(bumper_ticket_no, "bumper"))
                {
                    flag = false;
                }
                else
                {
                   
                }*/
                flag = true;
            }
            else {
                flag = false;
                MessageBox.Show("Invalid ticket number for Bumper Housie");
            }

            if (mini_bumper_ticket_no=="" || (isNum(mini_bumper_ticket_no) && Convert.ToInt32(mini_bumper_ticket_no) <= 600))
            {
                /*if (isTicketExist(mini_bumper_ticket_no, "mini_bumper")) {
                    flag = false;
                }
                else
                {
                    flag = flag == true ? true : false;
                }*/
                flag = flag == true ? true : false;
            }
            else
            {
                flag = false;
                MessageBox.Show("Invalid ticket number for Mini Bumper Housie");
            }
            return flag;
        }
    }
}
