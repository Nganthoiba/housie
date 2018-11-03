namespace housie
{
    partial class EditForm
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
            this.housieDataSet = new housie.housieDataSet();
            this.ticketCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_CollectionTableAdapter = new housie.housieDataSetTableAdapters.Ticket_CollectionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.date_of_payment = new System.Windows.Forms.DateTimePicker();
            this.label_payment_date = new System.Windows.Forms.Label();
            this.seller_name = new System.Windows.Forms.TextBox();
            this.label_seller_name = new System.Windows.Forms.Label();
            this.label_response = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // housieDataSet
            // 
            this.housieDataSet.DataSetName = "housieDataSet";
            this.housieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.date_of_payment);
            this.groupBox1.Controls.Add(this.label_payment_date);
            this.groupBox1.Controls.Add(this.seller_name);
            this.groupBox1.Controls.Add(this.label_seller_name);
            this.groupBox1.Controls.Add(this.label_response);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.ticket_holder_address);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.payment_no);
            this.groupBox1.Controls.Add(this.payment_yes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mini_bumper_no);
            this.groupBox1.Controls.Add(this.bumper_no);
            this.groupBox1.Controls.Add(this.label_mini_bumper_ticket_no);
            this.groupBox1.Controls.Add(this.label_bumper_ticket_no);
            this.groupBox1.Controls.Add(this.ticket_holder_name);
            this.groupBox1.Controls.Add(this.name_label);
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Details Here";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(62, 191);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 36;
            // 
            // date_of_payment
            // 
            this.date_of_payment.Location = new System.Drawing.Point(194, 162);
            this.date_of_payment.Name = "date_of_payment";
            this.date_of_payment.Size = new System.Drawing.Size(200, 20);
            this.date_of_payment.TabIndex = 35;
            // 
            // label_payment_date
            // 
            this.label_payment_date.AutoSize = true;
            this.label_payment_date.Location = new System.Drawing.Point(59, 165);
            this.label_payment_date.Name = "label_payment_date";
            this.label_payment_date.Size = new System.Drawing.Size(91, 13);
            this.label_payment_date.TabIndex = 34;
            this.label_payment_date.Text = "Date of payment :";
            // 
            // seller_name
            // 
            this.seller_name.Location = new System.Drawing.Point(371, 132);
            this.seller_name.Name = "seller_name";
            this.seller_name.Size = new System.Drawing.Size(173, 20);
            this.seller_name.TabIndex = 33;
            // 
            // label_seller_name
            // 
            this.label_seller_name.AutoSize = true;
            this.label_seller_name.Location = new System.Drawing.Point(295, 134);
            this.label_seller_name.Name = "label_seller_name";
            this.label_seller_name.Size = new System.Drawing.Size(70, 13);
            this.label_seller_name.TabIndex = 32;
            this.label_seller_name.Text = "Seller Name :";
            // 
            // label_response
            // 
            this.label_response.AutoSize = true;
            this.label_response.Location = new System.Drawing.Point(194, 239);
            this.label_response.Name = "label_response";
            this.label_response.Size = new System.Drawing.Size(101, 13);
            this.label_response.TabIndex = 31;
            this.label_response.Text = "Response Message";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(194, 191);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 30;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ticket_holder_address
            // 
            this.ticket_holder_address.Location = new System.Drawing.Point(194, 57);
            this.ticket_holder_address.Name = "ticket_holder_address";
            this.ticket_holder_address.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_address.TabIndex = 28;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(59, 61);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(51, 13);
            this.address.TabIndex = 27;
            this.address.Text = "Address :";
            // 
            // payment_no
            // 
            this.payment_no.AutoSize = true;
            this.payment_no.Location = new System.Drawing.Point(250, 132);
            this.payment_no.Name = "payment_no";
            this.payment_no.Size = new System.Drawing.Size(39, 17);
            this.payment_no.TabIndex = 26;
            this.payment_no.TabStop = true;
            this.payment_no.Text = "No";
            this.payment_no.UseVisualStyleBackColor = true;
            this.payment_no.CheckedChanged += new System.EventHandler(this.payment_no_CheckedChanged);
            // 
            // payment_yes
            // 
            this.payment_yes.AutoSize = true;
            this.payment_yes.Location = new System.Drawing.Point(194, 132);
            this.payment_yes.Name = "payment_yes";
            this.payment_yes.Size = new System.Drawing.Size(43, 17);
            this.payment_yes.TabIndex = 25;
            this.payment_yes.TabStop = true;
            this.payment_yes.Text = "Yes";
            this.payment_yes.UseVisualStyleBackColor = true;
            this.payment_yes.CheckedChanged += new System.EventHandler(this.payment_yes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Payment Done :";
            // 
            // mini_bumper_no
            // 
            this.mini_bumper_no.Location = new System.Drawing.Point(466, 91);
            this.mini_bumper_no.Name = "mini_bumper_no";
            this.mini_bumper_no.Size = new System.Drawing.Size(78, 20);
            this.mini_bumper_no.TabIndex = 23;
            // 
            // bumper_no
            // 
            this.bumper_no.Location = new System.Drawing.Point(194, 91);
            this.bumper_no.Name = "bumper_no";
            this.bumper_no.Size = new System.Drawing.Size(101, 20);
            this.bumper_no.TabIndex = 22;
            // 
            // label_mini_bumper_ticket_no
            // 
            this.label_mini_bumper_ticket_no.AutoSize = true;
            this.label_mini_bumper_ticket_no.Location = new System.Drawing.Point(313, 94);
            this.label_mini_bumper_ticket_no.Name = "label_mini_bumper_ticket_no";
            this.label_mini_bumper_ticket_no.Size = new System.Drawing.Size(139, 13);
            this.label_mini_bumper_ticket_no.TabIndex = 21;
            this.label_mini_bumper_ticket_no.Text = "Mini Bumper Ticket Sl. No. :";
            // 
            // label_bumper_ticket_no
            // 
            this.label_bumper_ticket_no.AutoSize = true;
            this.label_bumper_ticket_no.Location = new System.Drawing.Point(59, 94);
            this.label_bumper_ticket_no.Name = "label_bumper_ticket_no";
            this.label_bumper_ticket_no.Size = new System.Drawing.Size(117, 13);
            this.label_bumper_ticket_no.TabIndex = 20;
            this.label_bumper_ticket_no.Text = "Bumper Ticket Sl. No. :";
            // 
            // ticket_holder_name
            // 
            this.ticket_holder_name.Location = new System.Drawing.Point(194, 30);
            this.ticket_holder_name.Name = "ticket_holder_name";
            this.ticket_holder_name.Size = new System.Drawing.Size(350, 20);
            this.ticket_holder_name.TabIndex = 19;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(59, 33);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(129, 13);
            this.name_label.TabIndex = 18;
            this.name_label.Text = "Name of the ticket holder:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.housieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCollectionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private housieDataSet housieDataSet;
        private System.Windows.Forms.BindingSource ticketCollectionBindingSource;
        private housieDataSetTableAdapters.Ticket_CollectionTableAdapter ticket_CollectionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_of_payment;
        private System.Windows.Forms.Label label_payment_date;
        private System.Windows.Forms.TextBox seller_name;
        private System.Windows.Forms.Label label_seller_name;
        private System.Windows.Forms.Label label_response;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox ticket_holder_address;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.RadioButton payment_no;
        private System.Windows.Forms.RadioButton payment_yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mini_bumper_no;
        private System.Windows.Forms.TextBox bumper_no;
        private System.Windows.Forms.Label label_mini_bumper_ticket_no;
        private System.Windows.Forms.Label label_bumper_ticket_no;
        private System.Windows.Forms.TextBox ticket_holder_name;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox Id;
    }
}