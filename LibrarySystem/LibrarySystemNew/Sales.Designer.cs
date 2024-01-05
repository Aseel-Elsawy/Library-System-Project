namespace LibrarySystemNew
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reciept = new System.Windows.Forms.MaskedTextBox();
            this.remain = new System.Windows.Forms.MaskedTextBox();
            this.payed = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelid = new System.Windows.Forms.Label();
            this.itmprice = new System.Windows.Forms.MaskedTextBox();
            this.quantity = new System.Windows.Forms.MaskedTextBox();
            this.total = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itmname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itmcategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.store = new System.Windows.Forms.ComboBox();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.clientname = new System.Windows.Forms.ComboBox();
            this.notestxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.ForeColor = System.Drawing.Color.Crimson;
            this.add.Location = new System.Drawing.Point(12, 349);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(1143, 39);
            this.add.TabIndex = 24;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reciept);
            this.groupBox4.Controls.Add(this.remain);
            this.groupBox4.Controls.Add(this.payed);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(12, 651);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1143, 92);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // reciept
            // 
            this.reciept.HidePromptOnLeave = true;
            this.reciept.Location = new System.Drawing.Point(137, 42);
            this.reciept.Mask = "00000000000000000000";
            this.reciept.Name = "reciept";
            this.reciept.Size = new System.Drawing.Size(178, 28);
            this.reciept.TabIndex = 18;
            this.reciept.Text = "0";
            // 
            // remain
            // 
            this.remain.HidePromptOnLeave = true;
            this.remain.Location = new System.Drawing.Point(920, 36);
            this.remain.Mask = "000000000000000000";
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(178, 28);
            this.remain.TabIndex = 17;
            this.remain.Text = "0";
            // 
            // payed
            // 
            this.payed.HidePromptOnLeave = true;
            this.payed.Location = new System.Drawing.Point(503, 39);
            this.payed.Mask = "00000000000000000";
            this.payed.Name = "payed";
            this.payed.Size = new System.Drawing.Size(178, 28);
            this.payed.TabIndex = 16;
            this.payed.Text = "0";
            this.payed.TextChanged += new System.EventHandler(this.payed_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(810, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Remain:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Reciept:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(402, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Payed:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelid);
            this.groupBox3.Controls.Add(this.itmprice);
            this.groupBox3.Controls.Add(this.quantity);
            this.groupBox3.Controls.Add(this.total);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.itmname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.itmcategory);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(597, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 320);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(532, 62);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(20, 22);
            this.labelid.TabIndex = 19;
            this.labelid.Text = "0";
            this.labelid.Visible = false;
            // 
            // itmprice
            // 
            this.itmprice.HidePromptOnLeave = true;
            this.itmprice.Location = new System.Drawing.Point(157, 153);
            this.itmprice.Mask = "00000000000000000000";
            this.itmprice.Name = "itmprice";
            this.itmprice.Size = new System.Drawing.Size(356, 28);
            this.itmprice.TabIndex = 18;
            this.itmprice.Text = "0";
            this.itmprice.TextChanged += new System.EventHandler(this.itmprice_TextChanged);
            // 
            // quantity
            // 
            this.quantity.HidePromptOnLeave = true;
            this.quantity.Location = new System.Drawing.Point(157, 212);
            this.quantity.Mask = "000000000000000000";
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(356, 28);
            this.quantity.TabIndex = 17;
            this.quantity.Text = "0";
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // total
            // 
            this.total.HidePromptOnLeave = true;
            this.total.Location = new System.Drawing.Point(157, 267);
            this.total.Mask = "00000000000000000";
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(356, 28);
            this.total.TabIndex = 16;
            this.total.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(22, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(14, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Item Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(14, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantity:";
            // 
            // itmname
            // 
            this.itmname.FormattingEnabled = true;
            this.itmname.Location = new System.Drawing.Point(157, 100);
            this.itmname.Name = "itmname";
            this.itmname.Size = new System.Drawing.Size(356, 30);
            this.itmname.TabIndex = 11;
            this.itmname.SelectedIndexChanged += new System.EventHandler(this.itmname_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(17, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Category:";
            // 
            // itmcategory
            // 
            this.itmcategory.FormattingEnabled = true;
            this.itmcategory.Location = new System.Drawing.Point(157, 39);
            this.itmcategory.Name = "itmcategory";
            this.itmcategory.Size = new System.Drawing.Size(356, 30);
            this.itmcategory.TabIndex = 2;
            this.itmcategory.SelectedIndexChanged += new System.EventHandler(this.itmcategory_SelectedIndexChanged);
            this.itmcategory.SelectedValueChanged += new System.EventHandler(this.itmcategory_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(372, 749);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 79);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(32, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(196, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.store);
            this.groupBox1.Controls.Add(this.datetxt);
            this.groupBox1.Controls.Add(this.clientname);
            this.groupBox1.Controls.Add(this.notestxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 320);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // store
            // 
            this.store.FormattingEnabled = true;
            this.store.Location = new System.Drawing.Point(145, 177);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(399, 30);
            this.store.TabIndex = 11;
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(145, 110);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(399, 28);
            this.datetxt.TabIndex = 10;
            // 
            // clientname
            // 
            this.clientname.FormattingEnabled = true;
            this.clientname.Location = new System.Drawing.Point(145, 39);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(399, 30);
            this.clientname.TabIndex = 9;
            this.clientname.SelectedIndexChanged += new System.EventHandler(this.clientname_SelectedIndexChanged);
            // 
            // notestxt
            // 
            this.notestxt.Location = new System.Drawing.Point(145, 237);
            this.notestxt.Name = "notestxt";
            this.notestxt.Size = new System.Drawing.Size(396, 28);
            this.notestxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(14, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Store:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 251);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "item_id";
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "category_id";
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "item_category";
            this.Column3.HeaderText = "Item Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "item_name";
            this.Column4.HeaderText = "Item Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "item_price";
            this.Column1.HeaderText = "Item Price";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "item_quantity";
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1181, 845);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox reciept;
        private System.Windows.Forms.MaskedTextBox remain;
        private System.Windows.Forms.MaskedTextBox payed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox itmprice;
        private System.Windows.Forms.MaskedTextBox quantity;
        private System.Windows.Forms.MaskedTextBox total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox itmname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itmcategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox store;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.ComboBox clientname;
        private System.Windows.Forms.TextBox notestxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labelid;
    }
}