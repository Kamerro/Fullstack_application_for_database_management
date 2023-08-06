namespace WinFormsSQLIDE
{
    partial class ConfigureWindow
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
            this.btnSearchServer = new System.Windows.Forms.Button();
            this.txtConnectionWithServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btnServerSave = new System.Windows.Forms.Button();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionWithDatabase = new System.Windows.Forms.TextBox();
            this.btnSearchForDB = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnectionWithTable = new System.Windows.Forms.TextBox();
            this.btnSearchForTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchServer
            // 
            this.btnSearchServer.Location = new System.Drawing.Point(12, 152);
            this.btnSearchServer.Name = "btnSearchServer";
            this.btnSearchServer.Size = new System.Drawing.Size(180, 23);
            this.btnSearchServer.TabIndex = 0;
            this.btnSearchServer.Text = "Search for server";
            this.btnSearchServer.UseVisualStyleBackColor = true;
            this.btnSearchServer.Click += new System.EventHandler(this.btnSearchServer_Click);
            // 
            // txtConnectionWithServer
            // 
            this.txtConnectionWithServer.Location = new System.Drawing.Point(12, 41);
            this.txtConnectionWithServer.Name = "txtConnectionWithServer";
            this.txtConnectionWithServer.Size = new System.Drawing.Size(180, 22);
            this.txtConnectionWithServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connected with server:";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(12, 181);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(180, 24);
            this.cbServer.TabIndex = 3;
            // 
            // btnServerSave
            // 
            this.btnServerSave.Location = new System.Drawing.Point(12, 211);
            this.btnServerSave.Name = "btnServerSave";
            this.btnServerSave.Size = new System.Drawing.Size(180, 23);
            this.btnServerSave.TabIndex = 4;
            this.btnServerSave.Text = "Save choice";
            this.btnServerSave.UseVisualStyleBackColor = true;
            this.btnServerSave.Click += new System.EventHandler(this.btnServerSave_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(309, 211);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(180, 23);
            this.btnSaveDB.TabIndex = 9;
            this.btnSaveDB.Text = "Save choice";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // cbBase
            // 
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(309, 181);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(180, 24);
            this.cbBase.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connected with database:";
            // 
            // txtConnectionWithBD
            // 
            this.txtConnectionWithDatabase.Location = new System.Drawing.Point(309, 41);
            this.txtConnectionWithDatabase.Name = "txtConnectionWithBD";
            this.txtConnectionWithDatabase.Size = new System.Drawing.Size(180, 22);
            this.txtConnectionWithDatabase.TabIndex = 6;
            // 
            // btnSearchForDB
            // 
            this.btnSearchForDB.Location = new System.Drawing.Point(309, 152);
            this.btnSearchForDB.Name = "btnSearchForDB";
            this.btnSearchForDB.Size = new System.Drawing.Size(180, 23);
            this.btnSearchForDB.TabIndex = 5;
            this.btnSearchForDB.Text = "Search for database";
            this.btnSearchForDB.UseVisualStyleBackColor = true;
            this.btnSearchForDB.Click += new System.EventHandler(this.btnSearchForDB_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Location = new System.Drawing.Point(623, 211);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(180, 23);
            this.btnSaveTable.TabIndex = 14;
            this.btnSaveTable.Text = "Save choice";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(623, 181);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(180, 24);
            this.cbTable.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Connected with table:";
            // 
            // txtConnectionWIthTable
            // 
            this.txtConnectionWithTable.Location = new System.Drawing.Point(623, 41);
            this.txtConnectionWithTable.Name = "txtConnectionWIthTable";
            this.txtConnectionWithTable.Size = new System.Drawing.Size(180, 22);
            this.txtConnectionWithTable.TabIndex = 11;
            // 
            // btnSearchForTable
            // 
            this.btnSearchForTable.Location = new System.Drawing.Point(623, 152);
            this.btnSearchForTable.Name = "btnSearchForTable";
            this.btnSearchForTable.Size = new System.Drawing.Size(180, 23);
            this.btnSearchForTable.TabIndex = 10;
            this.btnSearchForTable.Text = "Search for table";
            this.btnSearchForTable.UseVisualStyleBackColor = true;
            this.btnSearchForTable.Click += new System.EventHandler(this.btnSearchForTable_Click);
            // 
            // ConfigureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 271);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnectionWithTable);
            this.Controls.Add(this.btnSearchForTable);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnectionWithDatabase);
            this.Controls.Add(this.btnSearchForDB);
            this.Controls.Add(this.btnServerSave);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionWithServer);
            this.Controls.Add(this.btnSearchServer);
            this.Name = "ConfigureWindow";
            this.Text = "ConfigureWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchServer;
        private System.Windows.Forms.TextBox txtConnectionWithServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Button btnServerSave;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnectionWithDatabase;
        private System.Windows.Forms.Button btnSearchForDB;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnectionWithTable;
        private System.Windows.Forms.Button btnSearchForTable;
    }
}