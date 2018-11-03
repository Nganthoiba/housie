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
        
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["housieConnectionString"].ConnectionString);
        public static SqlDataAdapter adapter;
        DataTable dt = null;

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
                    
                    
                    con.Open();
                    string bumper = bumper_no.Text.Trim()=="" || bumper_no.Text.Trim() == "0" ? "NULL": bumper_no.Text.Trim();
                    string mini_bumper = mini_bumper_no.Text.Trim()=="" || mini_bumper_no.Text.Trim() == "0" ? "NULL": mini_bumper_no.Text.Trim();
                    string name = ticket_holder_name.Text;
                    string address = ticket_holder_address.Text;
                    string seller = seller_name.Text;
                    Boolean payment = payment_yes.Checked;

                    
                    SqlCommand cmd;
                    SqlDataReader reader;
                    // check for bumper_no
                    if (bumper!="NULL") {
                        String query = "select * from Ticket_Collection T where T.bumper_no = " + bumper;
                        cmd = new SqlCommand(query, con);
                        reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            MessageBox.Show("Bumper Serial number already exist.");
                            con.Close();
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
                            con.Close();
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
                    DisplayData();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }
        

        //Display Data in DataGridView  
        public static void DisplayData()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            String qry = "select * from Ticket_Collection";
            //checking all radio buttons
            if (paid.Checked == true)
            {
                qry += " WHERE payment_status = 1";
            }
            else if (unpaid.Checked == true)
            {
                qry += " WHERE payment_status = 0";
            }
            qry += " order by seller_name,ticket_holder_name";
            adapter = new SqlDataAdapter(qry, con);
            adapter.Fill(dataTable);
            housieDataGridView.DataSource = dataTable;
            no_of_record.Text = (housieDataGridView.RowCount).ToString();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static void RefreshData() {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["housieConnectionString"].ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            if (search_text.Text.ToString().Trim() != "" && search_text.Text.ToString().Trim() != "Enter something to search for")
            {
                search_and_display();
            }
            else
            {
                DisplayData();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        /*Reset the form*/
        private void clear_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        public void reset_data() {
            //ticket_holder_name.Text = "";
            //ticket_holder_address.Text = "";
            bumper_no.Text = "";
            mini_bumper_no.Text = "";
            //seller_name.Text = "";
            label_response.Text = "";
            payment_yes.Checked = false;
            payment_no.Checked = true;
            label_payment_date.Visible = false;
            date_of_payment.Visible = false;
        }

        public void clear_data()
        {
            ticket_holder_name.Text = "";
            ticket_holder_address.Text = "";
            bumper_no.Text = "";
            mini_bumper_no.Text = "";
            seller_name.Text = "";
            label_response.Text = "";
            payment_yes.Checked = false;
            payment_no.Checked = true;
            label_payment_date.Visible = false;
            date_of_payment.Visible = false;
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
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Edit";
            housieDataGridView.Columns.Add(btn);
            btn.UseColumnTextForButtonValue = true;
            housieDataGridView.Columns[0].Visible = false;
            DisplayData();

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

        
        public static Boolean isNum(String str_num) {
            int i = 0;
            bool result = int.TryParse(str_num, out i);
            return result;
        }
        /*
        private void search_button_Click(object sender, EventArgs e)
        {
            search_and_display();
        }
        */
        public  static void search_and_display() {
            String search = search_text.Text.Trim();
            if (search == "" || search_text.Text.ToString().Trim() == "Enter something to search for") { return; }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String qry = "select * from Ticket_Collection";
            if (isNum(search))
            {
                qry += " where (bumper_no=" + search + " or mini_bumper_no=" + search+") ";
                //checking all radio buttons
                if (paid.Checked == true)
                {
                    qry += " AND payment_status = 1";
                }
                else if (unpaid.Checked == true)
                {
                    qry += " AND payment_status = 0";
                }
            }
            else
            {
                qry += " where (UPPER(ticket_holder_name) like UPPER('%" + search + "%') or " +
                    " UPPER(address) like UPPER('%" + search + "%') or UPPER(seller_name) like UPPER('%" + search + "%'))";
                //checking all radio buttons
                if (paid.Checked == true)
                {
                    qry += " AND payment_status = 1";
                }
                else if (unpaid.Checked == true)
                {
                    qry += " AND payment_status = 0";
                }
            }
            
            qry += " order by seller_name,ticket_holder_name";

            //MessageBox.Show(qry);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(qry, con);
            adapter.Fill(dt);
            housieDataGridView.DataSource = dt;
            no_of_record.Text = (housieDataGridView.RowCount).ToString();
            //label_response.Text = qry;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void RefreshAll_Click(object sender, EventArgs e)
        {
            if (search_text.Text.ToString().Trim() != "" && search_text.Text.ToString().Trim()!= "Enter something to search for")
            {
                search_and_display();
            }
            else
            {
                DisplayData();
            }
        }
        
        private void housieDataGridView_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                MessageBox.Show(housieDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            }
            catch (Exception E)
            {
                MessageBox.Show(E.GetBaseException().ToString());
            }
        }
        
        private void housieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) { 
                foreach (DataGridViewCell cell in housieDataGridView.SelectedCells)
                {
                    if (cell.Value!=null && cell.Value.ToString() == "Edit") {
                        int Id = Convert.ToInt32(housieDataGridView.Rows[rowIndex].Cells[0].Value);
                        //MessageBox.Show("Row: "+rowIndex+" Id: "+Id);

                        Ticket ticket = new Ticket();
                        ticket.Id = Id;
                        ticket.ticket_holder_name = housieDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                        ticket.address = housieDataGridView.Rows[rowIndex].Cells[2].Value.ToString();

                        String bumper = housieDataGridView.Rows[rowIndex].Cells[3].Value.ToString().Trim();
                        String mimi_bumper = housieDataGridView.Rows[rowIndex].Cells[4].Value.ToString().Trim();

                        ticket.bumper_no = bumper == "" ? 0 : Convert.ToInt32(housieDataGridView.Rows[rowIndex].Cells[3].Value);
                        ticket.mini_bumper_no = mimi_bumper == "" ? 0 : Convert.ToInt32(housieDataGridView.Rows[rowIndex].Cells[4].Value);
                        ticket.payment_status = Convert.ToBoolean(housieDataGridView.Rows[rowIndex].Cells[5].Value);
                        
                        ticket.payment_date = (ticket.payment_status == true)?Convert.ToDateTime(housieDataGridView.Rows[rowIndex].Cells[6].Value) : new DateTime();
                        ticket.seller_name = housieDataGridView.Rows[rowIndex].Cells[7].Value.ToString().Trim();
                        EditForm form = new EditForm();
                        form.set_data(ticket);
                        form.ShowDialog();
                       
                    }
                }
            }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            search_and_display();
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void paid_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void unpaid_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
