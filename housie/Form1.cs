using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        public string generateRandomString(int length)
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            string characters = numbers + alphabets + small_alphabets + numbers;
            string otp = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }
            return otp;
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
                    search_and_display();
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
            // TODO: This line of code loads data into the 'donationDataSet.donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.donationDataSet.donation);
            // TODO: This line of code loads data into the 'expDataSet.expenditure' table. You can move, or remove it, as needed.
            this.expenditureTableAdapter1.Fill(this.expDataSet.expenditure);
            // TODO: This line of code loads data into the 'expenditureDataSet.expenditure' table. You can move, or remove it, as needed.
            this.expenditureTableAdapter.Fill(this.expenditureDataSet.expenditure);
            // TODO: This line of code loads data into the 'housieDataSet.Ticket_Collection' table. You can move, or remove it, as needed.
            this.ticket_CollectionTableAdapter.Fill(this.housieDataSet.Ticket_Collection);
            /* Edit Button */
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.HeaderText = "";
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            

            housieDataGridView.Columns.Add(editBtn); 
            housieDataGridView.Columns[0].Visible = false;
            //housieDataGridView.Width = tabPage2.Width;
            search_and_display();

            /******************************************** DONATION ******************************************/
            /* Action Buttons for Donation GridView */
            /* Edit Donation */
            DataGridViewButtonColumn editDonation = new DataGridViewButtonColumn();
            editDonation.HeaderText = "";
            editDonation.Text = "Edit";
            editDonation.UseColumnTextForButtonValue = true;
            donorGridView.Columns.Add(editDonation);
            /* Delete Donation */
            DataGridViewButtonColumn deleteDonation = new DataGridViewButtonColumn();
            deleteDonation.HeaderText = "";
            deleteDonation.Text = "Delete";
            deleteDonation.UseColumnTextForButtonValue = true;
            donorGridView.Columns.Add(deleteDonation);
            /***********************************************************************************************/



            /****************************************** EXPENDITURE ****************************************/

            action_code.Text = "new_entry";
            action_code.Visible = false;
            exp_id.Text = "";
            exp_id.Visible = false;
            expenditre_dataGridView.Columns[0].Visible = false;
            expenditre_dataGridView.Columns[1].Width += 40;
            expenditre_dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            expenditre_dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            /* Action Buttons for Expenditure GridView */

            /* Edit Expenditure */
            DataGridViewButtonColumn editExpenditure = new DataGridViewButtonColumn();
            editExpenditure.HeaderText = "";
            editExpenditure.Text = "Edit";
            editExpenditure.UseColumnTextForButtonValue = true;
            expenditre_dataGridView.Columns.Add(editExpenditure);
            expenditre_dataGridView.Columns[4].Width = 60;
            
            /* Delete Expenditure */
            DataGridViewButtonColumn deleteExpenditure = new DataGridViewButtonColumn();
            deleteExpenditure.HeaderText = "";
            deleteExpenditure.Text = "Delete";
            deleteExpenditure.UseColumnTextForButtonValue = true;
            expenditre_dataGridView.Columns.Add(deleteExpenditure);
            expenditre_dataGridView.Columns[5].Width = 60;

            refresh_ExpenditureGrid();
            /**********************************************************************************************/

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
            decimal d = 0;
            bool isInt = int.TryParse(str_num, out i);
            bool isdecimal = decimal.TryParse(str_num, out d);
            return (isInt || isdecimal);
        }

        
        public  static void search_and_display() {
            String search = search_text.Text.Trim();
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String qry = "select * from Ticket_Collection";

            if (search != "" && search_text.Text.ToString().Trim() != "Enter something to search for")
            {
                if (isNum(search))
                {
                    qry += " where (bumper_no=" + search + " or mini_bumper_no=" + search + ") ";
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
            }
            else {
                if (paid.Checked == true)
                {
                    qry += " WHERE payment_status = 1";
                }
                else if (unpaid.Checked == true)
                {
                    qry += " WHERE payment_status = 0";
                }
            }
            qry += " order by seller_name,ticket_holder_name";

            //MessageBox.Show(qry);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(qry, con);
            adapter.Fill(dt);
            housieDataGridView.DataSource = dt;
            housieDataGridView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            btnExportPdf.Enabled = (housieDataGridView.RowCount > 0);
            
            no_of_record.Text = (housieDataGridView.RowCount).ToString();
            //label_response.Text = qry;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void RefreshAll_Click(object sender, EventArgs e)
        {
            search_and_display();
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
            search_and_display();
        }

        private void paid_CheckedChanged(object sender, EventArgs e)
        {
            search_and_display();
        }

        private void unpaid_CheckedChanged(object sender, EventArgs e)
        {
            search_and_display();
        }


        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(housieDataGridView.ColumnCount-2);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            float[] widths = new float[] { 50,60,25,25,20,25,50 };
            pdfTable.SetWidths(widths);
            //Adding Header row
            foreach (DataGridViewColumn column in housieDataGridView.Columns)
            {
                if(column.HeaderText.Trim()!="" && column.HeaderText != "Id")
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }
                
            }

            //Adding DataRow
            foreach (DataGridViewRow row in housieDataGridView.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(i!=0 && i != row.Cells.Count - 1)
                    {
                        if (i == 5)
                        {
                            if (cell.Value.ToString() == "True")
                            {
                                pdfTable.AddCell("Paid");
                            }
                            else
                            {
                                pdfTable.AddCell("Not Paid");
                            }
                        }
                        else if (i == 6) {
                            String dateTime = cell.Value.ToString().Trim();
                            if (dateTime != "")
                            {
                                String[] dateTimeArray = dateTime.Split(new Char[] { ' ' });
                                String[] dateArray = dateTimeArray[0].Split(new Char[] { '/' });
                                pdfTable.AddCell((dateArray[1] + "/" + dateArray[0] + "/" + dateArray[2]).Trim());
                            }
                            else {
                                pdfTable.AddCell("");
                            }
                            
                        }
                        else
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        
                    }
                    i++;
                }
            }

            //Opening Save Dialog to get the path where the exported report will be stored
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF Document|*.pdf";
            saveFileDialog1.Title = "Export a report in PDF";
            saveFileDialog1.ShowDialog();
            //Exporting to PDF

            if (saveFileDialog1.FileName != "")
            {
                
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    Paragraph paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f, BaseColor.DARK_GRAY);
                    paragraph.Add("HOUSIE TICKET SALE RECORD");
                    pdfDoc.Add(paragraph);

                    Paragraph record = new Paragraph();
                    record.Alignment = Element.ALIGN_CENTER;
                    record.Add(pdfTable);
                    pdfDoc.Add(record);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Report generation completed.","Message");
                }
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
        }

        /*Onclick event for expenditure */
        private void submit_exp_Click(object sender, EventArgs e)
        {
            if (expenditure_purpose.Text.Trim() == "") {
                MessageBox.Show("Please mention the purpose of the expenditure.", "Validation");
            } else if (expenditure_date.Text.Trim()=="") {
                MessageBox.Show("Please select date.", "Validation");
            }
            else if (exp_amt.Text.Trim() == "")
            {
                MessageBox.Show("Please select date.", "Validation");
            }
            else if (!isNum(exp_amt.Text.Trim()))
            {
                MessageBox.Show("Please enter valid amount.", "Validation");
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (action_code.Text.Trim() == "new_entry")
                {

                    String id = generateRandomString(10);
                    String qry = "insert into expenditure(Id,transaction_name,date_of_txn,amount) " +
                        "values(@Id,@transaction_name,@date_of_txn,@amount)";


                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@transaction_name", expenditure_purpose.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_of_txn", Convert.ToDateTime(expenditure_date.Text.Trim()));
                    cmd.Parameters.AddWithValue("@amount", exp_amt.Text.Trim());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction record saved successfully", "Result");
                        refresh_ExpenditureGrid();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error in saving. " + exception.GetBaseException().ToString(), "Saving Error");
                    }
                }
                else if (action_code.Text.Trim() == "update_entry") {
                    String id = exp_id.Text.Trim();
                    String qry = "update expenditure "+
                        "set transaction_name = @transaction_name, "+
                        "date_of_txn = @date_of_txn, "+
                        "amount=@amount " +
                        "where Id=@Id";


                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@transaction_name", expenditure_purpose.Text.Trim());
                    cmd.Parameters.AddWithValue("@date_of_txn", Convert.ToDateTime(expenditure_date.Text.Trim()));
                    cmd.Parameters.AddWithValue("@amount", exp_amt.Text.Trim());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Transaction record updated successfully", "Result");
                        refresh_ExpenditureGrid();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error in saving. " + exception.GetBaseException().ToString(), "Saving Error");
                    }
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        /* Reset expenditure */
        private void reset_expenditure_Click(object sender, EventArgs e)
        {
            expenditure_purpose.Text = "";
            exp_amt.Text = "";
            exp_amt.Text = "";
            action_code.Text = "new_entry";
            exp_id.Text = "";
            submit_exp.Text = "Submit";
        }
        public void refresh_ExpenditureGrid() {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String qry = "select * from expenditure order by date_of_txn desc";
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter(qry, con);
            adapter.Fill(dt);
            expenditre_dataGridView.DataSource = dt;
            total_record_expenditure.Text = "No. of record(s): " + expenditre_dataGridView.RowCount.ToString();

            /* Sum of expenditures */
            decimal sum_exp = 0;
            foreach (DataGridViewRow row in expenditre_dataGridView.Rows) {
                sum_exp += Convert.ToDecimal(row.Cells[3].Value);
            }
            tot_exp.Text = sum_exp.ToString();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void expenditre_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String id;
            if (rowIndex >= 0)
            {
                foreach (DataGridViewCell cell in expenditre_dataGridView.SelectedCells)
                {
                    if (cell.Value.ToString() == "Edit")
                    {
                        id = expenditre_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                        exp_id.Text = id;
                        action_code.Text = "update_entry";

                        /* Filling up data for edit */
                        expenditure_purpose.Text = expenditre_dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                        expenditure_date.Text = expenditre_dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                        exp_amt.Text = expenditre_dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                        submit_exp.Text = "Update";
                    }
                    else if (cell.Value.ToString() == "Delete") {
                        id = expenditre_dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                        DialogResult conf = MessageBox.Show("Are you sure to delete?",
                        "Warning",
                        MessageBoxButtons.YesNo);

                        if (conf == DialogResult.Yes) {
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            //delete task
                            String qry = "DELETE FROM EXPENDITURE WHERE Id = @Id";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            cmd.Parameters.AddWithValue("@Id", id);
                            try
                            {
                                cmd.ExecuteNonQuery();
                                refresh_ExpenditureGrid();
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Error in deleting. " + exception.GetBaseException().ToString(), "Delete Error");
                            }

                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                        }
                        /* Otherwise do nothing */
                    }
                    
                }
            }
        }

        /* Onclick event for donation */
        private void submit_donor_Click(object sender, EventArgs e)
        {

        }

        

        private void donorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reset_donation_Click(object sender, EventArgs e)
        {

        }

        
    }
}
