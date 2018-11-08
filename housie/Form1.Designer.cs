namespace housie
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            search_text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menutab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            btnExportPdf = new System.Windows.Forms.Button();
            unpaid = new System.Windows.Forms.RadioButton();
            paid = new System.Windows.Forms.RadioButton();
            all = new System.Windows.Forms.RadioButton();
            housieDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketholdernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bumpernoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minibumpernoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatusDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketCollectionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.housieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housieDataSet = new housie.housieDataSet();
            no_of_record = new System.Windows.Forms.Label();
            this.label_no_of_record = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.date_of_payment = new System.Windows.Forms.DateTimePicker();
            this.label_payment_date = new System.Windows.Forms.Label();
            this.seller_name = new System.Windows.Forms.TextBox();
            this.label_seller_name = new System.Windows.Forms.Label();
            this.label_response = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.ticket_holder_address = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.payment_no = new System.Windows.Forms.RadioButton();
            this.payment_yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.mini_bumper_no = new System.Windows.Forms.TextBox();
            this.bumper_no = new System.Windows.Forms.TextBox();
            this.label_mini_bumper_ticket_no = new System.Windows.Forms.Label();
            this.label_bumper_ticket_no = new System.Windows.Forms.Label();
            this.ticket_holder_name = new System.Windows.Forms.TextBox();
            this.ticketGrid = new System.Windows.Forms.TableLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            tot_exp = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            total_record_expenditure = new System.Windows.Forms.Label();
            this.expenditre_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoftxnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expDataSet = new housie.expDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.action_code = new System.Windows.Forms.TextBox();
            this.exp_id = new System.Windows.Forms.TextBox();
            this.reset_expenditure = new System.Windows.Forms.Button();
            this.submit_exp = new System.Windows.Forms.Button();
            this.exp_amt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.expenditure_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.expenditure_purpose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.total_donated_amt = new System.Windows.Forms.Label();
            this.donorGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationDataSet = new housie.donationDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reset_donation = new System.Windows.Forms.Button();
            this.donation_action_code = new System.Windows.Forms.TextBox();
            this.donation_id = new System.Windows.Forms.TextBox();
            this.submit_donor = new System.Windows.Forms.Button();
            this.donation_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amount = new System.Windows.Forms.TextBox();
            this.donor_address = new System.Windows.Forms.TextBox();
            this.donor_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            tot_exp_amt = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            current_bal = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            tot_coll_amt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            total_housie_amt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ticketCollectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_CollectionTableAdapter = new housie.housieDataSetTableAdapters.Ticket_CollectionTableAdapter();
            this.ticketCollectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new housie.housieDataSetTableAdapters.TableAdapterManager();
            this.expenditureDataSet = new housie.expenditureDataSet();
            this.expenditureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenditureTableAdapter = new housie.expenditureDataSetTableAdapters.expenditureTableAdapter();
            this.expenditureDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenditureTableAdapter1 = new housie.expDataSetTableAdapters.expenditureTableAdapter();
            this.donationTableAdapter = new housie.donationDataSetTableAdapters.donationTableAdapter();
            total_donation_amt = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Menutab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(housieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenditre_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOUSIE TICKET COLLECTION RECORD";
            // 
            // search_text
            // 
            search_text.CausesValidation = false;
            search_text.Location = new System.Drawing.Point(890, 13);
            search_text.Name = "search_text";
            search_text.Size = new System.Drawing.Size(163, 20);
            search_text.TabIndex = 1;
            search_text.Text = "Enter something to search for";
            search_text.TextChanged += new System.EventHandler(search_text_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 29);
            this.panel2.TabIndex = 4;
            // 
            // Menutab
            // 
            this.Menutab.Controls.Add(this.tabPage2);
            this.Menutab.Controls.Add(this.tabPage1);
            this.Menutab.Controls.Add(this.tabPage3);
            this.Menutab.Controls.Add(this.tabPage4);
            this.Menutab.Controls.Add(this.tabPage5);
            this.Menutab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menutab.Location = new System.Drawing.Point(0, 0);
            this.Menutab.Name = "Menutab";
            this.Menutab.SelectedIndex = 0;
            this.Menutab.Size = new System.Drawing.Size(1125, 583);
            this.Menutab.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(btnExportPdf);
            this.tabPage2.Controls.Add(unpaid);
            this.tabPage2.Controls.Add(paid);
            this.tabPage2.Controls.Add(all);
            this.tabPage2.Controls.Add(housieDataGridView);
            this.tabPage2.Controls.Add(no_of_record);
            this.tabPage2.Controls.Add(this.label_no_of_record);
            this.tabPage2.Controls.Add(this.Refresh);
            this.tabPage2.Controls.Add(search_text);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1117, 557);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "View All Entry";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new System.Drawing.Point(959, 465);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new System.Drawing.Size(94, 22);
            btnExportPdf.TabIndex = 6;
            btnExportPdf.Text = "Generate report";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += new System.EventHandler(btnExportPdf_Click);
            // 
            // unpaid
            // 
            unpaid.AutoSize = true;
            unpaid.Location = new System.Drawing.Point(267, 16);
            unpaid.Name = "unpaid";
            unpaid.Size = new System.Drawing.Size(59, 17);
            unpaid.TabIndex = 10;
            unpaid.Text = "Unpaid";
            unpaid.UseVisualStyleBackColor = true;
            unpaid.CheckedChanged += new System.EventHandler(unpaid_CheckedChanged);
            // 
            // paid
            // 
            paid.AutoSize = true;
            paid.Location = new System.Drawing.Point(215, 16);
            paid.Name = "paid";
            paid.Size = new System.Drawing.Size(46, 17);
            paid.TabIndex = 9;
            paid.Text = "Paid";
            paid.UseVisualStyleBackColor = true;
            paid.CheckedChanged += new System.EventHandler(paid_CheckedChanged);
            // 
            // all
            // 
            all.AutoSize = true;
            all.Checked = true;
            all.Location = new System.Drawing.Point(173, 16);
            all.Name = "all";
            all.Size = new System.Drawing.Size(36, 17);
            all.TabIndex = 8;
            all.TabStop = true;
            all.Text = "All";
            all.UseVisualStyleBackColor = true;
            all.CheckedChanged += new System.EventHandler(all_CheckedChanged);
            // 
            // housieDataGridView
            // 
            housieDataGridView.AllowUserToAddRows = false;
            housieDataGridView.AllowUserToDeleteRows = false;
            housieDataGridView.AllowUserToOrderColumns = true;
            housieDataGridView.AutoGenerateColumns = false;
            housieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            housieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ticketholdernameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.bumpernoDataGridViewTextBoxColumn1,
            this.minibumpernoDataGridViewTextBoxColumn1,
            this.paymentstatusDataGridViewCheckBoxColumn1,
            this.paymentdateDataGridViewTextBoxColumn1,
            this.sellernameDataGridViewTextBoxColumn1});
            housieDataGridView.DataSource = this.ticketCollectionBindingSource3;
            housieDataGridView.Location = new System.Drawing.Point(6, 46);
            housieDataGridView.Name = "housieDataGridView";
            housieDataGridView.ReadOnly = true;
            housieDataGridView.Size = new System.Drawing.Size(1047, 407);
            housieDataGridView.TabIndex = 7;
            housieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(housieDataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketholdernameDataGridViewTextBoxColumn1
            // 
            this.ticketholdernameDataGridViewTextBoxColumn1.DataPropertyName = "ticket_holder_name";
            this.ticketholdernameDataGridViewTextBoxColumn1.HeaderText = "Name of Ticker Holder";
            this.ticketholdernameDataGridViewTextBoxColumn1.Name = "ticketholdernameDataGridViewTextBoxColumn1";
            this.ticketholdernameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ticketholdernameDataGridViewTextBoxColumn1.Width = 190;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn1.Width = 220;
            // 
            // bumpernoDataGridViewTextBoxColumn1
            // 
            this.bumpernoDataGridViewTextBoxColumn1.DataPropertyName = "bumper_no";
            this.bumpernoDataGridViewTextBoxColumn1.HeaderText = "Bumper Ticket No";
            this.bumpernoDataGridViewTextBoxColumn1.Name = "bumpernoDataGridViewTextBoxColumn1";
            this.bumpernoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bumpernoDataGridViewTextBoxColumn1.Width = 80;
            // 
            // minibumpernoDataGridViewTextBoxColumn1
            // 
            this.minibumpernoDataGridViewTextBoxColumn1.DataPropertyName = "mini_bumper_no";
            this.minibumpernoDataGridViewTextBoxColumn1.HeaderText = "Mini Bumper Ticket No";
            this.minibumpernoDataGridViewTextBoxColumn1.Name = "minibumpernoDataGridViewTextBoxColumn1";
            this.minibumpernoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.minibumpernoDataGridViewTextBoxColumn1.Width = 80;
            // 
            // paymentstatusDataGridViewCheckBoxColumn1
            // 
            this.paymentstatusDataGridViewCheckBoxColumn1.DataPropertyName = "payment_status";
            this.paymentstatusDataGridViewCheckBoxColumn1.HeaderText = "Payment Status";
            this.paymentstatusDataGridViewCheckBoxColumn1.Name = "paymentstatusDataGridViewCheckBoxColumn1";
            this.paymentstatusDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.paymentstatusDataGridViewCheckBoxColumn1.Width = 60;
            // 
            // paymentdateDataGridViewTextBoxColumn1
            // 
            this.paymentdateDataGridViewTextBoxColumn1.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn1.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn1.Name = "paymentdateDataGridViewTextBoxColumn1";
            this.paymentdateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentdateDataGridViewTextBoxColumn1.Width = 70;
            // 
            // sellernameDataGridViewTextBoxColumn1
            // 
            this.sellernameDataGridViewTextBoxColumn1.DataPropertyName = "seller_name";
            this.sellernameDataGridViewTextBoxColumn1.HeaderText = "Seller Name";
            this.sellernameDataGridViewTextBoxColumn1.Name = "sellernameDataGridViewTextBoxColumn1";
            this.sellernameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sellernameDataGridViewTextBoxColumn1.Width = 180;
            // 
            // ticketCollectionBindingSource3
            // 
            this.ticketCollectionBindingSource3.DataMember = "Ticket_Collection";
            this.ticketCollectionBindingSource3.DataSource = this.housieDataSetBindingSource;
            // 
            // housieDataSetBindingSource
            // 
            this.housieDataSetBindingSource.DataSource = this.housieDataSet;
            this.housieDataSetBindingSource.Position = 0;
            // 
            // housieDataSet
            // 
            this.housieDataSet.DataSetName = "housieDataSet";
            this.housieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // no_of_record
            // 
            no_of_record.AutoSize = true;
            no_of_record.Location = new System.Drawing.Point(114, 16);
            no_of_record.Name = "no_of_record";
            no_of_record.Size = new System.Drawing.Size(13, 13);
            no_of_record.TabIndex = 6;
            no_of_record.Text = "0";
            // 
            // label_no_of_record
            // 
            this.label_no_of_record.AutoSize = true;
            this.label_no_of_record.BackColor = System.Drawing.Color.Transparent;
            this.label_no_of_record.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_no_of_record.Location = new System.Drawing.Point(6, 16);
            this.label_no_of_record.Name = "label_no_of_record";
            this.label_no_of_record.Size = new System.Drawing.Size(102, 13);
            this.label_no_of_record.TabIndex = 5;
            this.label_no_of_record.Text = "Total no. of records:";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(832, 13);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(52, 20);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.RefreshAll_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.date_of_payment);
            this.tabPage1.Controls.Add(this.label_payment_date);
            this.tabPage1.Controls.Add(this.seller_name);
            this.tabPage1.Controls.Add(this.label_seller_name);
            this.tabPage1.Controls.Add(this.label_response);
            this.tabPage1.Controls.Add(this.submit);
            this.tabPage1.Controls.Add(this.clear);
            this.tabPage1.Controls.Add(this.ticket_holder_address);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.payment_no);
            this.tabPage1.Controls.Add(this.payment_yes);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.mini_bumper_no);
            this.tabPage1.Controls.Add(this.bumper_no);
            this.tabPage1.Controls.Add(this.label_mini_bumper_ticket_no);
            this.tabPage1.Controls.Add(this.label_bumper_ticket_no);
            this.tabPage1.Controls.Add(this.ticket_holder_name);
            this.tabPage1.Controls.Add(this.ticketGrid);
            this.tabPage1.Controls.Add(this.name_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1117, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // date_of_payment
            // 
            this.date_of_payment.Location = new System.Drawing.Point(152, 175);
            this.date_of_payment.Name = "date_of_payment";
            this.date_of_payment.Size = new System.Drawing.Size(200, 20);
            this.date_of_payment.TabIndex = 17;
            // 
            // label_payment_date
            // 
            this.label_payment_date.AutoSize = true;
            this.label_payment_date.Location = new System.Drawing.Point(17, 178);
            this.label_payment_date.Name = "label_payment_date";
            this.label_payment_date.Size = new System.Drawing.Size(91, 13);
            this.label_payment_date.TabIndex = 16;
            this.label_payment_date.Text = "Date of payment :";
            // 
            // seller_name
            // 
            this.seller_name.Location = new System.Drawing.Point(329, 145);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(173, 20);
            this.seller_name.TabIndex = 15;
            // 
            // label_seller_name
            // 
            this.label_seller_name.AutoSize = true;
            this.label_seller_name.Location = new System.Drawing.Point(253, 147);
            this.label_seller_name.Name = "label_seller_name";
            this.label_seller_name.Size = new System.Drawing.Size(70, 13);
            this.label_seller_name.TabIndex = 14;
            this.label_seller_name.Text = "Seller Name :";
            // 
            // label_response
            // 
            this.label_response.AutoSize = true;
            this.label_response.Location = new System.Drawing.Point(152, 252);
            this.label_response.Name = "label_response";
            this.label_response.Size = new System.Drawing.Size(101, 13);
            this.label_response.TabIndex = 13;
            this.label_response.Text = "Response Message";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(247, 204);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(152, 204);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ticket_holder_address
            // 
            this.ticket_holder_address.Location = new System.Drawing.Point(152, 70);
            this.ticket_holder_address.Name = "ticket_holder_address";
            this.ticket_holder_address.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_address.TabIndex = 10;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(17, 74);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(51, 13);
            this.address.TabIndex = 9;
            this.address.Text = "Address :";
            // 
            // payment_no
            // 
            this.payment_no.AutoSize = true;
            this.payment_no.Location = new System.Drawing.Point(208, 145);
            this.payment_no.Name = "payment_no";
            this.payment_no.Size = new System.Drawing.Size(39, 17);
            this.payment_no.TabIndex = 8;
            this.payment_no.TabStop = true;
            this.payment_no.Text = "No";
            this.payment_no.UseVisualStyleBackColor = true;
            this.payment_no.CheckedChanged += new System.EventHandler(this.payment_no_CheckedChanged);
            // 
            // payment_yes
            // 
            this.payment_yes.AutoSize = true;
            this.payment_yes.Location = new System.Drawing.Point(152, 145);
            this.payment_yes.Name = "payment_yes";
            this.payment_yes.Size = new System.Drawing.Size(43, 17);
            this.payment_yes.TabIndex = 7;
            this.payment_yes.TabStop = true;
            this.payment_yes.Text = "Yes";
            this.payment_yes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment Done :";
            // 
            // mini_bumper_no
            // 
            this.mini_bumper_no.Location = new System.Drawing.Point(424, 104);
            this.mini_bumper_no.Name = "mini_bumper_no";
            this.mini_bumper_no.Size = new System.Drawing.Size(78, 20);
            this.mini_bumper_no.TabIndex = 5;
            // 
            // bumper_no
            // 
            this.bumper_no.Location = new System.Drawing.Point(152, 104);
            this.bumper_no.Name = "bumper_no";
            this.bumper_no.Size = new System.Drawing.Size(101, 20);
            this.bumper_no.TabIndex = 4;
            // 
            // label_mini_bumper_ticket_no
            // 
            this.label_mini_bumper_ticket_no.AutoSize = true;
            this.label_mini_bumper_ticket_no.Location = new System.Drawing.Point(271, 107);
            this.label_mini_bumper_ticket_no.Name = "label_mini_bumper_ticket_no";
            this.label_mini_bumper_ticket_no.Size = new System.Drawing.Size(139, 13);
            this.label_mini_bumper_ticket_no.TabIndex = 3;
            this.label_mini_bumper_ticket_no.Text = "Mini Bumper Ticket Sl. No. :";
            // 
            // label_bumper_ticket_no
            // 
            this.label_bumper_ticket_no.AutoSize = true;
            this.label_bumper_ticket_no.Location = new System.Drawing.Point(17, 107);
            this.label_bumper_ticket_no.Name = "label_bumper_ticket_no";
            this.label_bumper_ticket_no.Size = new System.Drawing.Size(117, 13);
            this.label_bumper_ticket_no.TabIndex = 2;
            this.label_bumper_ticket_no.Text = "Bumper Ticket Sl. No. :";
            // 
            // ticket_holder_name
            // 
            this.ticket_holder_name.Location = new System.Drawing.Point(152, 35);
            this.ticket_holder_name.Name = "ticket_holder_name";
            this.ticket_holder_name.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_name.TabIndex = 1;
            // 
            // ticketGrid
            // 
            this.ticketGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 564F));
            this.ticketGrid.Location = new System.Drawing.Point(508, 35);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.Size = new System.Drawing.Size(564, 350);
            this.ticketGrid.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(17, 38);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(129, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name of the ticket holder:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(tot_exp);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(total_record_expenditure);
            this.tabPage3.Controls.Add(this.expenditre_dataGridView);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1117, 557);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Expenditure";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tot_exp
            // 
            tot_exp.AutoSize = true;
            tot_exp.Location = new System.Drawing.Point(839, 252);
            tot_exp.Name = "tot_exp";
            tot_exp.Size = new System.Drawing.Size(52, 13);
            tot_exp.TabIndex = 4;
            tot_exp.Text = "00000.00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(714, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Total Amount:";
            // 
            // total_record_expenditure
            // 
            total_record_expenditure.AutoSize = true;
            total_record_expenditure.Location = new System.Drawing.Point(399, 252);
            total_record_expenditure.Name = "total_record_expenditure";
            total_record_expenditure.Size = new System.Drawing.Size(81, 13);
            total_record_expenditure.TabIndex = 2;
            total_record_expenditure.Text = "No. of record: 0";
            // 
            // expenditre_dataGridView
            // 
            this.expenditre_dataGridView.AllowUserToAddRows = false;
            this.expenditre_dataGridView.AutoGenerateColumns = false;
            this.expenditre_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenditre_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.transactionnameDataGridViewTextBoxColumn,
            this.dateoftxnDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.expenditre_dataGridView.DataSource = this.expenditureBindingSource1;
            this.expenditre_dataGridView.Location = new System.Drawing.Point(403, 34);
            this.expenditre_dataGridView.Name = "expenditre_dataGridView";
            this.expenditre_dataGridView.Size = new System.Drawing.Size(656, 205);
            this.expenditre_dataGridView.TabIndex = 1;
            this.expenditre_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenditre_dataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // transactionnameDataGridViewTextBoxColumn
            // 
            this.transactionnameDataGridViewTextBoxColumn.DataPropertyName = "transaction_name";
            this.transactionnameDataGridViewTextBoxColumn.HeaderText = "Purpose of Expenditure";
            this.transactionnameDataGridViewTextBoxColumn.Name = "transactionnameDataGridViewTextBoxColumn";
            this.transactionnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateoftxnDataGridViewTextBoxColumn
            // 
            this.dateoftxnDataGridViewTextBoxColumn.DataPropertyName = "date_of_txn";
            this.dateoftxnDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateoftxnDataGridViewTextBoxColumn.Name = "dateoftxnDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // expenditureBindingSource1
            // 
            this.expenditureBindingSource1.DataMember = "expenditure";
            this.expenditureBindingSource1.DataSource = this.expDataSet;
            // 
            // expDataSet
            // 
            this.expDataSet.DataSetName = "expDataSet";
            this.expDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.action_code);
            this.groupBox2.Controls.Add(this.exp_id);
            this.groupBox2.Controls.Add(this.reset_expenditure);
            this.groupBox2.Controls.Add(this.submit_exp);
            this.groupBox2.Controls.Add(this.exp_amt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.expenditure_date);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.expenditure_purpose);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 199);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expenditure Entry";
            // 
            // action_code
            // 
            this.action_code.Location = new System.Drawing.Point(141, 131);
            this.action_code.Name = "action_code";
            this.action_code.Size = new System.Drawing.Size(52, 20);
            this.action_code.TabIndex = 25;
            // 
            // exp_id
            // 
            this.exp_id.Location = new System.Drawing.Point(83, 131);
            this.exp_id.Name = "exp_id";
            this.exp_id.Size = new System.Drawing.Size(52, 20);
            this.exp_id.TabIndex = 24;
            // 
            // reset_expenditure
            // 
            this.reset_expenditure.Location = new System.Drawing.Point(226, 131);
            this.reset_expenditure.Name = "reset_expenditure";
            this.reset_expenditure.Size = new System.Drawing.Size(57, 21);
            this.reset_expenditure.TabIndex = 23;
            this.reset_expenditure.Text = "Reset";
            this.reset_expenditure.UseVisualStyleBackColor = true;
            this.reset_expenditure.Click += new System.EventHandler(this.reset_expenditure_Click);
            // 
            // submit_exp
            // 
            this.submit_exp.Location = new System.Drawing.Point(289, 131);
            this.submit_exp.Name = "submit_exp";
            this.submit_exp.Size = new System.Drawing.Size(60, 21);
            this.submit_exp.TabIndex = 22;
            this.submit_exp.Text = "Submit";
            this.submit_exp.UseVisualStyleBackColor = true;
            this.submit_exp.Click += new System.EventHandler(this.submit_exp_Click);
            // 
            // exp_amt
            // 
            this.exp_amt.Location = new System.Drawing.Point(83, 96);
            this.exp_amt.Name = "exp_amt";
            this.exp_amt.Size = new System.Drawing.Size(267, 20);
            this.exp_amt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Amount:";
            // 
            // expenditure_date
            // 
            this.expenditure_date.Location = new System.Drawing.Point(83, 64);
            this.expenditure_date.Name = "expenditure_date";
            this.expenditure_date.Size = new System.Drawing.Size(267, 20);
            this.expenditure_date.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date:";
            // 
            // expenditure_purpose
            // 
            this.expenditure_purpose.Location = new System.Drawing.Point(83, 33);
            this.expenditure_purpose.Name = "expenditure_purpose";
            this.expenditure_purpose.Size = new System.Drawing.Size(267, 20);
            this.expenditure_purpose.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purpose:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.total_donated_amt);
            this.tabPage4.Controls.Add(this.donorGridView);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1117, 557);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Donation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // total_donated_amt
            // 
            this.total_donated_amt.AutoSize = true;
            this.total_donated_amt.Location = new System.Drawing.Point(429, 375);
            this.total_donated_amt.Name = "total_donated_amt";
            this.total_donated_amt.Size = new System.Drawing.Size(123, 13);
            this.total_donated_amt.TabIndex = 2;
            this.total_donated_amt.Text = "Total donated amount: 0";
            // 
            // donorGridView
            // 
            this.donorGridView.AllowUserToAddRows = false;
            this.donorGridView.AutoGenerateColumns = false;
            this.donorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.donernameDataGridViewTextBoxColumn,
            this.doneraddressDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.donationdateDataGridViewTextBoxColumn});
            this.donorGridView.DataSource = this.donationBindingSource;
            this.donorGridView.Location = new System.Drawing.Point(432, 39);
            this.donorGridView.Name = "donorGridView";
            this.donorGridView.Size = new System.Drawing.Size(677, 320);
            this.donorGridView.TabIndex = 1;
            this.donorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donorGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // donernameDataGridViewTextBoxColumn
            // 
            this.donernameDataGridViewTextBoxColumn.DataPropertyName = "doner_name";
            this.donernameDataGridViewTextBoxColumn.HeaderText = "Doner Name";
            this.donernameDataGridViewTextBoxColumn.Name = "donernameDataGridViewTextBoxColumn";
            this.donernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // doneraddressDataGridViewTextBoxColumn
            // 
            this.doneraddressDataGridViewTextBoxColumn.DataPropertyName = "doner_address";
            this.doneraddressDataGridViewTextBoxColumn.HeaderText = "Donor Address";
            this.doneraddressDataGridViewTextBoxColumn.Name = "doneraddressDataGridViewTextBoxColumn";
            this.doneraddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // donationdateDataGridViewTextBoxColumn
            // 
            this.donationdateDataGridViewTextBoxColumn.DataPropertyName = "donation_date";
            this.donationdateDataGridViewTextBoxColumn.HeaderText = "Donation Date";
            this.donationdateDataGridViewTextBoxColumn.Name = "donationdateDataGridViewTextBoxColumn";
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "donation";
            this.donationBindingSource.DataSource = this.donationDataSet;
            // 
            // donationDataSet
            // 
            this.donationDataSet.DataSetName = "donationDataSet";
            this.donationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reset_donation);
            this.groupBox1.Controls.Add(this.donation_action_code);
            this.groupBox1.Controls.Add(this.donation_id);
            this.groupBox1.Controls.Add(this.submit_donor);
            this.groupBox1.Controls.Add(this.donation_dateTimePicker);
            this.groupBox1.Controls.Add(this.amount);
            this.groupBox1.Controls.Add(this.donor_address);
            this.groupBox1.Controls.Add(this.donor_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donation Entry";
            // 
            // Reset_donation
            // 
            this.Reset_donation.Location = new System.Drawing.Point(263, 143);
            this.Reset_donation.Name = "Reset_donation";
            this.Reset_donation.Size = new System.Drawing.Size(56, 25);
            this.Reset_donation.TabIndex = 21;
            this.Reset_donation.Text = "Reset";
            this.Reset_donation.UseVisualStyleBackColor = true;
            this.Reset_donation.Click += new System.EventHandler(this.Reset_donation_Click);
            // 
            // donation_action_code
            // 
            this.donation_action_code.Location = new System.Drawing.Point(148, 148);
            this.donation_action_code.Name = "donation_action_code";
            this.donation_action_code.Size = new System.Drawing.Size(70, 20);
            this.donation_action_code.TabIndex = 20;
            // 
            // donation_id
            // 
            this.donation_id.Location = new System.Drawing.Point(72, 148);
            this.donation_id.Name = "donation_id";
            this.donation_id.Size = new System.Drawing.Size(70, 20);
            this.donation_id.TabIndex = 3;
            // 
            // submit_donor
            // 
            this.submit_donor.Location = new System.Drawing.Point(336, 143);
            this.submit_donor.Name = "submit_donor";
            this.submit_donor.Size = new System.Drawing.Size(56, 25);
            this.submit_donor.TabIndex = 19;
            this.submit_donor.Text = "Submit";
            this.submit_donor.UseVisualStyleBackColor = true;
            this.submit_donor.Click += new System.EventHandler(this.submit_donor_Click);
            // 
            // donation_dateTimePicker
            // 
            this.donation_dateTimePicker.Location = new System.Drawing.Point(190, 103);
            this.donation_dateTimePicker.Name = "donation_dateTimePicker";
            this.donation_dateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.donation_dateTimePicker.TabIndex = 18;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(72, 103);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(76, 20);
            this.amount.TabIndex = 6;
            // 
            // donor_address
            // 
            this.donor_address.Location = new System.Drawing.Point(72, 71);
            this.donor_address.Name = "donor_address";
            this.donor_address.Size = new System.Drawing.Size(320, 20);
            this.donor_address.TabIndex = 5;
            // 
            // donor_name
            // 
            this.donor_name.Location = new System.Drawing.Point(72, 36);
            this.donor_name.Name = "donor_name";
            this.donor_name.Size = new System.Drawing.Size(320, 20);
            this.donor_name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(total_donation_amt);
            this.tabPage5.Controls.Add(tot_exp_amt);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(current_bal);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(tot_coll_amt);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(total_housie_amt);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1117, 557);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Accounting";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tot_exp_amt
            // 
            tot_exp_amt.AutoSize = true;
            tot_exp_amt.Location = new System.Drawing.Point(474, 200);
            tot_exp_amt.Name = "tot_exp_amt";
            tot_exp_amt.Size = new System.Drawing.Size(54, 13);
            tot_exp_amt.TabIndex = 20;
            tot_exp_amt.Text = "000000 /-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(407, 243);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Rs";
            // 
            // current_bal
            // 
            current_bal.AutoSize = true;
            current_bal.Location = new System.Drawing.Point(474, 243);
            current_bal.Name = "current_bal";
            current_bal.Size = new System.Drawing.Size(54, 13);
            current_bal.TabIndex = 17;
            current_bal.Text = "000000 /-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(195, 243);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Current Balance:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(180, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(370, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(407, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Rs";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(195, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Total expenditure amount:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(405, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "( - )";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(407, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "( + )";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(407, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Rs";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(407, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Rs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Rs";
            // 
            // tot_coll_amt
            // 
            tot_coll_amt.AutoSize = true;
            tot_coll_amt.Location = new System.Drawing.Point(474, 151);
            tot_coll_amt.Name = "tot_coll_amt";
            tot_coll_amt.Size = new System.Drawing.Size(54, 13);
            tot_coll_amt.TabIndex = 6;
            tot_coll_amt.Text = "000000 /-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total collected amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(180, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(370, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total donation amount:";
            // 
            // total_housie_amt
            // 
            total_housie_amt.AutoSize = true;
            total_housie_amt.Location = new System.Drawing.Point(474, 66);
            total_housie_amt.Name = "total_housie_amt";
            total_housie_amt.Size = new System.Drawing.Size(54, 13);
            total_housie_amt.TabIndex = 19;
            total_housie_amt.Text = "000000 /-";
            total_housie_amt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total amount collected from housie tickets:";
            // 
            // ticketCollectionBindingSource1
            // 
            this.ticketCollectionBindingSource1.DataMember = "Ticket_Collection";
            this.ticketCollectionBindingSource1.DataSource = this.housieDataSet;
            // 
            // ticketCollectionBindingSource
            // 
            this.ticketCollectionBindingSource.DataMember = "Ticket_Collection";
            this.ticketCollectionBindingSource.DataSource = this.housieDataSet;
            // 
            // ticket_CollectionTableAdapter
            // 
            this.ticket_CollectionTableAdapter.ClearBeforeFill = true;
            // 
            // ticketCollectionBindingSource2
            // 
            this.ticketCollectionBindingSource2.DataMember = "Ticket_Collection";
            this.ticketCollectionBindingSource2.DataSource = this.housieDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Ticket_CollectionTableAdapter = this.ticket_CollectionTableAdapter;
            this.tableAdapterManager1.UpdateOrder = housie.housieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // expenditureDataSet
            // 
            this.expenditureDataSet.DataSetName = "expenditureDataSet";
            this.expenditureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenditureBindingSource
            // 
            this.expenditureBindingSource.DataMember = "expenditure";
            this.expenditureBindingSource.DataSource = this.expenditureDataSet;
            // 
            // expenditureTableAdapter
            // 
            this.expenditureTableAdapter.ClearBeforeFill = true;
            // 
            // expenditureDataSetBindingSource
            // 
            this.expenditureDataSetBindingSource.DataSource = this.expenditureDataSet;
            this.expenditureDataSetBindingSource.Position = 0;
            // 
            // expenditureTableAdapter1
            // 
            this.expenditureTableAdapter1.ClearBeforeFill = true;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // total_donation_amt
            // 
            total_donation_amt.AutoSize = true;
            total_donation_amt.Location = new System.Drawing.Point(474, 111);
            total_donation_amt.Name = "total_donation_amt";
            total_donation_amt.Size = new System.Drawing.Size(54, 13);
            total_donation_amt.TabIndex = 21;
            total_donation_amt.Text = "000000 /-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1125, 583);
            this.Controls.Add(this.Menutab);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Housie Ticket Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Menutab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(housieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenditre_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl Menutab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox mini_bumper_no;
        private System.Windows.Forms.TextBox bumper_no;
        private System.Windows.Forms.Label label_mini_bumper_ticket_no;
        private System.Windows.Forms.Label label_bumper_ticket_no;
        private System.Windows.Forms.TextBox ticket_holder_name;
        private System.Windows.Forms.TableLayoutPanel ticketGrid;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox ticket_holder_address;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.RadioButton payment_no;
        private System.Windows.Forms.RadioButton payment_yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_response;
        private System.Windows.Forms.TextBox seller_name;
        private System.Windows.Forms.Label label_seller_name;
        private System.Windows.Forms.DateTimePicker date_of_payment;
        private System.Windows.Forms.Label label_payment_date;
        private housieDataSet housieDataSet;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource;
        private housieDataSetTableAdapters.Ticket_CollectionTableAdapter ticket_CollectionTableAdapter;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource1;
        private System.Windows.Forms.Label label_no_of_record;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource2;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource3;
        private System.Windows.Forms.BindingSource housieDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketholdernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bumpernoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minibumpernoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentstatusDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellernameDataGridViewTextBoxColumn1;
        private housieDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView donorGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submit_donor;
        private System.Windows.Forms.DateTimePicker donation_dateTimePicker;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox donor_address;
        private System.Windows.Forms.TextBox donor_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox expenditure_purpose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expenditure_date;
        private System.Windows.Forms.Button submit_exp;
        private System.Windows.Forms.TextBox exp_amt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView expenditre_dataGridView;
        private System.Windows.Forms.Label total_donated_amt;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label24;
        
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button reset_expenditure;
        private System.Windows.Forms.TextBox action_code;
        private System.Windows.Forms.TextBox exp_id;
        private expenditureDataSet expenditureDataSet;
        private System.Windows.Forms.BindingSource expenditureBindingSource;
        private expenditureDataSetTableAdapters.expenditureTableAdapter expenditureTableAdapter;
        private System.Windows.Forms.BindingSource expenditureDataSetBindingSource;
        private expDataSet expDataSet;
        private System.Windows.Forms.BindingSource expenditureBindingSource1;
        private expDataSetTableAdapters.expenditureTableAdapter expenditureTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoftxnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Reset_donation;
        private System.Windows.Forms.TextBox donation_action_code;
        private System.Windows.Forms.TextBox donation_id;
        private donationDataSet donationDataSet;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private donationDataSetTableAdapters.donationTableAdapter donationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn donernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationdateDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.Label label23;
       
        public static System.Windows.Forms.Label tot_exp;
        public static System.Windows.Forms.Label total_record_expenditure;
        public static System.Windows.Forms.TextBox search_text;
        public static System.Windows.Forms.RadioButton unpaid;
        public static System.Windows.Forms.RadioButton paid;
        public static System.Windows.Forms.RadioButton all;
        public static System.Windows.Forms.Label no_of_record;
        public static System.Windows.Forms.DataGridView housieDataGridView;
        public static System.Windows.Forms.Button btnExportPdf;
        public static System.Windows.Forms.Label tot_exp_amt;
        public static System.Windows.Forms.Label total_housie_amt;
        public static System.Windows.Forms.Label tot_coll_amt;
        public static System.Windows.Forms.Label current_bal;
        public static System.Windows.Forms.Label total_donation_amt;
    }
}

