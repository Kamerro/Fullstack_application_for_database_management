namespace WinFormsSQLIDE
{
    partial class MaintainWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.createDB = new System.Windows.Forms.Button();
            this.deleteDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Database name:";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(108, 33);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(180, 22);
            this.txtDatabaseName.TabIndex = 11;
            // 
            // createDB
            // 
            this.createDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createDB.Location = new System.Drawing.Point(12, 61);
            this.createDB.Name = "createDB";
            this.createDB.Size = new System.Drawing.Size(180, 31);
            this.createDB.TabIndex = 10;
            this.createDB.Text = "Create database";
            this.createDB.UseVisualStyleBackColor = true;
            this.createDB.Click += new System.EventHandler(this.createDB_Click);
            // 
            // deleteDB
            // 
            this.deleteDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteDB.Location = new System.Drawing.Point(198, 61);
            this.deleteDB.Name = "deleteDB";
            this.deleteDB.Size = new System.Drawing.Size(186, 31);
            this.deleteDB.TabIndex = 13;
            this.deleteDB.Text = "Delete database";
            this.deleteDB.UseVisualStyleBackColor = true;
            this.deleteDB.Click += new System.EventHandler(this.deleteDB_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(108, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Connect with created database";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaintainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.createDB);
            this.Name = "MaintainWindow";
            this.Text = "MaintainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button createDB;
        private System.Windows.Forms.Button deleteDB;
        private System.Windows.Forms.Button button2;
    }
}