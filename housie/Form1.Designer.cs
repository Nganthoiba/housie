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
            this.name_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ticketCollectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_CollectionTableAdapter = new housie.housieDataSetTableAdapters.Ticket_CollectionTableAdapter();
            this.ticketCollectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.Menutab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(housieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource2)).BeginInit();
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
            this.Menutab.Location = new System.Drawing.Point(2, 54);
            this.Menutab.Name = "Menutab";
            this.Menutab.SelectedIndex = 0;
            this.Menutab.Size = new System.Drawing.Size(1064, 479);
            this.Menutab.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
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
            this.tabPage2.Size = new System.Drawing.Size(1056, 453);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "View All Entry";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            housieDataGridView.Size = new System.Drawing.Size(1047, 387);
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
            this.Refresh.Location = new System.Drawing.Point(832, 9);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(52, 26);
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
            this.tabPage1.Controls.Add(this.name_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1056, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // date_of_payment
            // 
            this.date_of_payment.Location = new System.Drawing.Point(307, 171);
            this.date_of_payment.Name = "date_of_payment";
            this.date_of_payment.Size = new System.Drawing.Size(200, 20);
            this.date_of_payment.TabIndex = 17;
            // 
            // label_payment_date
            // 
            this.label_payment_date.AutoSize = true;
            this.label_payment_date.Location = new System.Drawing.Point(172, 174);
            this.label_payment_date.Name = "label_payment_date";
            this.label_payment_date.Size = new System.Drawing.Size(91, 13);
            this.label_payment_date.TabIndex = 16;
            this.label_payment_date.Text = "Date of payment :";
            // 
            // seller_name
            // 
            this.seller_name.Location = new System.Drawing.Point(484, 141);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(173, 20);
            this.seller_name.TabIndex = 15;
            // 
            // label_seller_name
            // 
            this.label_seller_name.AutoSize = true;
            this.label_seller_name.Location = new System.Drawing.Point(408, 143);
            this.label_seller_name.Name = "label_seller_name";
            this.label_seller_name.Size = new System.Drawing.Size(70, 13);
            this.label_seller_name.TabIndex = 14;
            this.label_seller_name.Text = "Seller Name :";
            // 
            // label_response
            // 
            this.label_response.AutoSize = true;
            this.label_response.Location = new System.Drawing.Point(307, 248);
            this.label_response.Name = "label_response";
            this.label_response.Size = new System.Drawing.Size(101, 13);
            this.label_response.TabIndex = 13;
            this.label_response.Text = "Response Message";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(402, 200);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(307, 200);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ticket_holder_address
            // 
            this.ticket_holder_address.Location = new System.Drawing.Point(307, 66);
            this.ticket_holder_address.Name = "ticket_holder_address";
            this.ticket_holder_address.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_address.TabIndex = 10;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(172, 70);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(51, 13);
            this.address.TabIndex = 9;
            this.address.Text = "Address :";
            // 
            // payment_no
            // 
            this.payment_no.AutoSize = true;
            this.payment_no.Location = new System.Drawing.Point(363, 141);
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
            this.payment_yes.Location = new System.Drawing.Point(307, 141);
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
            this.label2.Location = new System.Drawing.Point(172, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment Done :";
            // 
            // mini_bumper_no
            // 
            this.mini_bumper_no.Location = new System.Drawing.Point(579, 100);
            this.mini_bumper_no.Name = "mini_bumper_no";
            this.mini_bumper_no.Size = new System.Drawing.Size(78, 20);
            this.mini_bumper_no.TabIndex = 5;
            // 
            // bumper_no
            // 
            this.bumper_no.Location = new System.Drawing.Point(307, 100);
            this.bumper_no.Name = "bumper_no";
            this.bumper_no.Size = new System.Drawing.Size(101, 20);
            this.bumper_no.TabIndex = 4;
            // 
            // label_mini_bumper_ticket_no
            // 
            this.label_mini_bumper_ticket_no.AutoSize = true;
            this.label_mini_bumper_ticket_no.Location = new System.Drawing.Point(426, 103);
            this.label_mini_bumper_ticket_no.Name = "label_mini_bumper_ticket_no";
            this.label_mini_bumper_ticket_no.Size = new System.Drawing.Size(139, 13);
            this.label_mini_bumper_ticket_no.TabIndex = 3;
            this.label_mini_bumper_ticket_no.Text = "Mini Bumper Ticket Sl. No. :";
            // 
            // label_bumper_ticket_no
            // 
            this.label_bumper_ticket_no.AutoSize = true;
            this.label_bumper_ticket_no.Location = new System.Drawing.Point(172, 103);
            this.label_bumper_ticket_no.Name = "label_bumper_ticket_no";
            this.label_bumper_ticket_no.Size = new System.Drawing.Size(117, 13);
            this.label_bumper_ticket_no.TabIndex = 2;
            this.label_bumper_ticket_no.Text = "Bumper Ticket Sl. No. :";
            // 
            // ticket_holder_name
            // 
            this.ticket_holder_name.Location = new System.Drawing.Point(307, 31);
            this.ticket_holder_name.Name = "ticket_holder_name";
            this.ticket_holder_name.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_name.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(172, 34);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(129, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name of the ticket holder:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1056, 453);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Accounting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1056, 453);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Donation";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 557);
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
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource2)).EndInit();
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
        public static System.Windows.Forms.TextBox search_text;
        public static System.Windows.Forms.RadioButton unpaid;
        public static System.Windows.Forms.RadioButton paid;
        public static System.Windows.Forms.RadioButton all;
        public static System.Windows.Forms.Label no_of_record;
        public static System.Windows.Forms.DataGridView housieDataGridView;
    }
}

