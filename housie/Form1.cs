using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_response.Text = "";
            search_text.GotFocus += Search_text_GotFocus;
            search_text.LostFocus += Search_text_LostFocus;

            label_payment_date.Visible = false;
            date_of_payment.Visible = false;
            payment_no.Checked = true;
        }

        private void Search_text_LostFocus(object sender, EventArgs e)
        {
            if (search_text.Text.Trim() == "") {
                search_text.Text = "Enter something to search for";
            }
        }

        private void Search_text_GotFocus(object sender, EventArgs e)
        {
            search_text.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (validate()) {
                try
                {
                    
                    String str = ConfigurationManager.ConnectionStrings["housieConnectionString"].ConnectionString;

                    string bumper = bumper_no.Text.Trim()==""?"NULL": bumper_no.Text.Trim();
                    string mini_bumper = mini_bumper_no.Text.Trim()==""?"NULL": mini_bumper_no.Text.Trim();
                    string name = ticket_holder_name.Text;
                    string address = ticket_holder_address.Text;
                    string seller = seller_name.Text;
                    Boolean payment = payment_yes.Checked;

                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand cmd;
                    SqlDataReader reader;
                    // check for bumper_no
                    if (bumper!="NULL") {
                        String query = "select * from Ticket_Collection T where T.bumper_no = " + bumper;
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            MessageBox.Show("Bumper Serial number already exist.");
                            return;
                        }
                        reader.Close();
                    }

                    // check for mini_bumper_no
                    if (mini_bumper!= "NULL")
                    {
                        String qry2 = "select * from Ticket_Collection T where T.mini_bumper_no = " + mini_bumper;
                        cmd = new SqlCommand(qry2, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Mini Bumper Serial number already exist.");
                            return;
                        }
                        reader.Close();
                    }
                    
                    String qry3 = "";
                    DateTime payment_date; //= (payment)?new DateTime(date_of_payment.Text):null;
                    int payment_st = (payment) ? 1 : 0;
                    if (payment)
                    {
                        payment_date = Convert.ToDateTime(date_of_payment.Text);
                        qry3 = "insert into Ticket_Collection(ticket_holder_name,address,bumper_no,mini_bumper_no,payment_status,payment_date,seller_name)" +
                        "values('" + name + "','" + address + "'," + bumper + "," + mini_bumper + "," + payment_st + ",'" + payment_date + "','" + seller + "')";
                    }
                    else {
                        payment_date = new DateTime();
                        qry3 = "insert into Ticket_Collection(ticket_holder_name,address,bumper_no,mini_bumper_no,payment_status,seller_name)" +
                        "values('" + name + "','" + address + "'," + bumper + "," + mini_bumper + "," + payment_st + ",'" + seller + "')";
                    }    
                   
                    

                    SqlCommand insert_cmd = new SqlCommand(qry3,con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = insert_cmd;
                    adapter.InsertCommand.ExecuteNonQuery();
                    insert_cmd.Dispose();
                    MessageBox.Show("Record saved successfully.");
                    reset_data();
                    con.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }
        /*Reset the form*/
        private void clear_Click(object sender, EventArgs e)
        {
            reset_data();
        }

        public void reset_data() {
            ticket_holder_name.Text = "";
            ticket_holder_address.Text = "";
            bumper_no.Text = "";
            mini_bumper_no.Text = "";
            seller_name.Text = "";
            label_response.Text = "";
            payment_yes.Checked = false;
            payment_no.Checked = false;
            label_payment_date.Visible = false;
            date_of_payment.Visible = false;
            payment_no.Checked = true;
        }

        private Boolean validate() {
            Boolean flag = true;
            if (ticket_holder_name.Text.Trim() == "") {
                label_response.Text = "Please enter name of ticket holder.";
                flag = false;
            }
            if (seller_name.Text.Trim() == "")
            {
                label_response.Text = "Please enter name of ticket seller.";
                flag = false;
            }
            return flag;
        }

        private void payment_no_CheckedChanged(object sender, EventArgs e)
        {
            if (payment_no.Checked)
            {
                label_payment_date.Visible = false;
                date_of_payment.Visible = false;
            }
            else {
                date_of_payment.Visible = true;
                label_payment_date.Visible = true;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'housieDataSet.Ticket_Collection' table. You can move, or remove it, as needed.
            this.ticket_CollectionTableAdapter.Fill(this.housieDataSet.Ticket_Collection);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticket_CollectionTableAdapter.FillBy(this.housieDataSet.Ticket_Collection);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
