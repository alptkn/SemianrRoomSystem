namespace Project_Test
{
    partial class ManageRooms
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxRoomStatus = new System.Windows.Forms.TextBox();
            this.buttonAddNewRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Status:";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(173, 126);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(180, 20);
            this.textBoxRoomID.TabIndex = 4;
            // 
            // textBoxRoomStatus
            // 
            this.textBoxRoomStatus.Location = new System.Drawing.Point(173, 216);
            this.textBoxRoomStatus.Name = "textBoxRoomStatus";
            this.textBoxRoomStatus.Size = new System.Drawing.Size(180, 20);
            this.textBoxRoomStatus.TabIndex = 5;
            // 
            // buttonAddNewRoom
            // 
            this.buttonAddNewRoom.Location = new System.Drawing.Point(42, 296);
            this.buttonAddNewRoom.Name = "buttonAddNewRoom";
            this.buttonAddNewRoom.Size = new System.Drawing.Size(94, 36);
            this.buttonAddNewRoom.TabIndex = 7;
            this.buttonAddNewRoom.Text = "AddNewRoom";
            this.buttonAddNewRoom.UseVisualStyleBackColor = true;
            this.buttonAddNewRoom.Click += new System.EventHandler(this.buttonAddNewRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Location = new System.Drawing.Point(173, 296);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(72, 36);
            this.buttonEditRoom.TabIndex = 8;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Location = new System.Drawing.Point(281, 296);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(72, 36);
            this.buttonRemoveRoom.TabIndex = 9;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(42, 354);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(311, 26);
            this.buttonClearFields.TabIndex = 10;
            this.buttonClearFields.Text = "ClearFields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 254);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(173, 171);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRoomType.TabIndex = 12;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonRemoveRoom);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonAddNewRoom);
            this.Controls.Add(this.textBoxRoomStatus);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxRoomStatus;
        private System.Windows.Forms.Button buttonAddNewRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
    }
}