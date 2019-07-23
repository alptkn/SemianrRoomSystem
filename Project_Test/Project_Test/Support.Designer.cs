namespace Project_Test
{
    partial class Support
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
            this.textBoxSupportID = new System.Windows.Forms.TextBox();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddNewSupport = new System.Windows.Forms.Button();
            this.buttonRemoveSupport = new System.Windows.Forms.Button();
            this.buttonEditSupport = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technical Support";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSupportID
            // 
            this.textBoxSupportID.Location = new System.Drawing.Point(185, 129);
            this.textBoxSupportID.Name = "textBoxSupportID";
            this.textBoxSupportID.Size = new System.Drawing.Size(216, 20);
            this.textBoxSupportID.TabIndex = 1;
            // 
            // textBoxIssue
            // 
            this.textBoxIssue.Location = new System.Drawing.Point(185, 207);
            this.textBoxIssue.Name = "textBoxIssue";
            this.textBoxIssue.Size = new System.Drawing.Size(216, 20);
            this.textBoxIssue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Support ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Issue:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddNewSupport
            // 
            this.buttonAddNewSupport.Location = new System.Drawing.Point(46, 297);
            this.buttonAddNewSupport.Name = "buttonAddNewSupport";
            this.buttonAddNewSupport.Size = new System.Drawing.Size(114, 31);
            this.buttonAddNewSupport.TabIndex = 9;
            this.buttonAddNewSupport.Text = "Add New Support";
            this.buttonAddNewSupport.UseVisualStyleBackColor = true;
            this.buttonAddNewSupport.Click += new System.EventHandler(this.buttonAddNewSupport_Click);
            // 
            // buttonRemoveSupport
            // 
            this.buttonRemoveSupport.Location = new System.Drawing.Point(287, 297);
            this.buttonRemoveSupport.Name = "buttonRemoveSupport";
            this.buttonRemoveSupport.Size = new System.Drawing.Size(114, 31);
            this.buttonRemoveSupport.TabIndex = 10;
            this.buttonRemoveSupport.Text = "Remove";
            this.buttonRemoveSupport.UseVisualStyleBackColor = true;
            this.buttonRemoveSupport.Click += new System.EventHandler(this.buttonRemoveSupport_Click);
            // 
            // buttonEditSupport
            // 
            this.buttonEditSupport.Location = new System.Drawing.Point(188, 297);
            this.buttonEditSupport.Name = "buttonEditSupport";
            this.buttonEditSupport.Size = new System.Drawing.Size(77, 31);
            this.buttonEditSupport.TabIndex = 12;
            this.buttonEditSupport.Text = "Edit";
            this.buttonEditSupport.UseVisualStyleBackColor = true;
            this.buttonEditSupport.Click += new System.EventHandler(this.buttonEditSupport_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(46, 343);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(355, 25);
            this.buttonClearFields.TabIndex = 13;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 296);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(185, 168);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(216, 21);
            this.comboBoxRoomID.TabIndex = 15;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.comboBoxRoomID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonEditSupport);
            this.Controls.Add(this.buttonRemoveSupport);
            this.Controls.Add(this.buttonAddNewSupport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIssue);
            this.Controls.Add(this.textBoxSupportID);
            this.Controls.Add(this.panel1);
            this.Name = "Support";
            this.Text = "Support";
            this.Load += new System.EventHandler(this.Support_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSupportID;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddNewSupport;
        private System.Windows.Forms.Button buttonRemoveSupport;
        private System.Windows.Forms.Button buttonEditSupport;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
    }
}