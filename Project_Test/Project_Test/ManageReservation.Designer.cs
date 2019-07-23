namespace Project_Test
{
    partial class ManageReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReservID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNewReservation = new System.Windows.Forms.Button();
            this.buttonEditReservation = new System.Windows.Forms.Button();
            this.buttonRemoveReservation = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ManageReservation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReservID
            // 
            this.textBoxReservID.Location = new System.Drawing.Point(162, 104);
            this.textBoxReservID.Name = "textBoxReservID";
            this.textBoxReservID.Size = new System.Drawing.Size(168, 20);
            this.textBoxReservID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reserv ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date In:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Out:";
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(162, 219);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(168, 21);
            this.comboBoxRoomID.TabIndex = 8;
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(162, 141);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(168, 21);
            this.comboBoxClientName.TabIndex = 9;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(162, 175);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxRoomType.TabIndex = 10;
            
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(162, 293);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerDateOut.TabIndex = 11;
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(162, 258);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerDateIn.TabIndex = 12;
            // 
            // buttonAddNewReservation
            // 
            this.buttonAddNewReservation.Location = new System.Drawing.Point(26, 343);
            this.buttonAddNewReservation.Name = "buttonAddNewReservation";
            this.buttonAddNewReservation.Size = new System.Drawing.Size(113, 23);
            this.buttonAddNewReservation.TabIndex = 13;
            this.buttonAddNewReservation.Text = "New Reservation";
            this.buttonAddNewReservation.UseVisualStyleBackColor = true;
            this.buttonAddNewReservation.Click += new System.EventHandler(this.buttonAddNewReservation_Click);
            // 
            // buttonEditReservation
            // 
            this.buttonEditReservation.Location = new System.Drawing.Point(162, 343);
            this.buttonEditReservation.Name = "buttonEditReservation";
            this.buttonEditReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonEditReservation.TabIndex = 14;
            this.buttonEditReservation.Text = "Edit";
            this.buttonEditReservation.UseVisualStyleBackColor = true;
            this.buttonEditReservation.Click += new System.EventHandler(this.buttonEditReservation_Click);
            // 
            // buttonRemoveReservation
            // 
            this.buttonRemoveReservation.Location = new System.Drawing.Point(255, 343);
            this.buttonRemoveReservation.Name = "buttonRemoveReservation";
            this.buttonRemoveReservation.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveReservation.TabIndex = 15;
            this.buttonRemoveReservation.Text = "Remove";
            this.buttonRemoveReservation.UseVisualStyleBackColor = true;
            this.buttonRemoveReservation.Click += new System.EventHandler(this.buttonRemoveReservation_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(26, 381);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(304, 23);
            this.buttonClearFields.TabIndex = 16;
            this.buttonClearFields.Text = "ClearFields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 300);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonRemoveReservation);
            this.Controls.Add(this.buttonEditReservation);
            this.Controls.Add(this.buttonAddNewReservation);
            this.Controls.Add(this.dateTimePickerDateIn);
            this.Controls.Add(this.dateTimePickerDateOut);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.comboBoxClientName);
            this.Controls.Add(this.comboBoxRoomID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReservID);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservation";
            this.Text = "ManageReservation";
            this.Load += new System.EventHandler(this.ManageReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReservID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.Button buttonAddNewReservation;
        private System.Windows.Forms.Button buttonEditReservation;
        private System.Windows.Forms.Button buttonRemoveReservation;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}