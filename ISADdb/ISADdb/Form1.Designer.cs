namespace ISADdb
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnWorkplace = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.btnUniversities = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(87, 100);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(92, 36);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User Table";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(210, 100);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(92, 36);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Messages Table";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnWorkplace
            // 
            this.btnWorkplace.Location = new System.Drawing.Point(348, 100);
            this.btnWorkplace.Name = "btnWorkplace";
            this.btnWorkplace.Size = new System.Drawing.Size(92, 36);
            this.btnWorkplace.TabIndex = 2;
            this.btnWorkplace.Text = "Workplace Table";
            this.btnWorkplace.UseVisualStyleBackColor = true;
            this.btnWorkplace.Click += new System.EventHandler(this.btnWorkplace_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.Location = new System.Drawing.Point(477, 100);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(92, 36);
            this.btnFriend.TabIndex = 3;
            this.btnFriend.Text = "Friends Table";
            this.btnFriend.UseVisualStyleBackColor = true;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // btnUniversities
            // 
            this.btnUniversities.Location = new System.Drawing.Point(612, 100);
            this.btnUniversities.Name = "btnUniversities";
            this.btnUniversities.Size = new System.Drawing.Size(92, 36);
            this.btnUniversities.TabIndex = 4;
            this.btnUniversities.Text = "Universities Table";
            this.btnUniversities.UseVisualStyleBackColor = true;
            this.btnUniversities.Click += new System.EventHandler(this.btnUniversities_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facebook User Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUniversities);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.btnWorkplace);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnUser);
            this.Name = "Form1";
            this.Text = "Facebook Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnWorkplace;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.Button btnUniversities;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

