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
            this.search_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menutab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ticketCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.housieDataSet = new housie.housieDataSet();
            this.ticket_CollectionTableAdapter = new housie.housieDataSetTableAdapters.Ticket_CollectionTableAdapter();
            this.ticketholdernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bumpernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minibumpernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.Menutab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOUSIE TICKET COLLECTION RECORD";
            // 
            // search_text
            // 
            this.search_text.CausesValidation = false;
            this.search_text.Location = new System.Drawing.Point(658, 3);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(163, 20);
            this.search_text.TabIndex = 1;
            this.search_text.Text = "Enter something to search for";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(821, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 29);
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
            this.Menutab.Size = new System.Drawing.Size(905, 422);
            this.Menutab.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.search_text);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(897, 396);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "View All Entry";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage1.Size = new System.Drawing.Size(897, 396);
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
            this.tabPage3.Size = new System.Drawing.Size(897, 396);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Accounting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(897, 396);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Donation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketholdernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.bumpernoDataGridViewTextBoxColumn,
            this.minibumpernoDataGridViewTextBoxColumn,
            this.paymentstatusDataGridViewCheckBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.sellernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketCollectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(875, 312);
            this.dataGridView1.TabIndex = 3;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(911, 25);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // ticketCollectionBindingSource
            // 
            this.ticketCollectionBindingSource.DataMember = "Ticket_Collection";
            this.ticketCollectionBindingSource.DataSource = this.housieDataSet;
            // 
            // housieDataSet
            // 
            this.housieDataSet.DataSetName = "housieDataSet";
            this.housieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticket_CollectionTableAdapter
            // 
            this.ticket_CollectionTableAdapter.ClearBeforeFill = true;
            // 
            // ticketholdernameDataGridViewTextBoxColumn
            // 
            this.ticketholdernameDataGridViewTextBoxColumn.DataPropertyName = "ticket_holder_name";
            this.ticketholdernameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ticketholdernameDataGridViewTextBoxColumn.Name = "ticketholdernameDataGridViewTextBoxColumn";
            this.ticketholdernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 120;
            // 
            // bumpernoDataGridViewTextBoxColumn
            // 
            this.bumpernoDataGridViewTextBoxColumn.DataPropertyName = "bumper_no";
            this.bumpernoDataGridViewTextBoxColumn.HeaderText = "Bumper Ticket No";
            this.bumpernoDataGridViewTextBoxColumn.Name = "bumpernoDataGridViewTextBoxColumn";
            // 
            // minibumpernoDataGridViewTextBoxColumn
            // 
            this.minibumpernoDataGridViewTextBoxColumn.DataPropertyName = "mini_bumper_no";
            this.minibumpernoDataGridViewTextBoxColumn.HeaderText = "Mini Bumper No.";
            this.minibumpernoDataGridViewTextBoxColumn.Name = "minibumpernoDataGridViewTextBoxColumn";
            // 
            // paymentstatusDataGridViewCheckBoxColumn
            // 
            this.paymentstatusDataGridViewCheckBoxColumn.DataPropertyName = "payment_status";
            this.paymentstatusDataGridViewCheckBoxColumn.HeaderText = "Payment Status";
            this.paymentstatusDataGridViewCheckBoxColumn.Name = "paymentstatusDataGridViewCheckBoxColumn";
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            // 
            // sellernameDataGridViewTextBoxColumn
            // 
            this.sellernameDataGridViewTextBoxColumn.DataPropertyName = "seller_name";
            this.sellernameDataGridViewTextBoxColumn.HeaderText = "Seller Name";
            this.sellernameDataGridViewTextBoxColumn.Name = "sellernameDataGridViewTextBoxColumn";
            this.sellernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 479);
            this.Controls.Add(this.fillByToolStrip);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private housieDataSet housieDataSet;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource;
        private housieDataSetTableAdapters.Ticket_CollectionTableAdapter ticket_CollectionTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketholdernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bumpernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minibumpernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellernameDataGridViewTextBoxColumn;
    }
}

