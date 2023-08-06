namespace WinFormsSQLIDE
{
    partial class MaintainTables
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
            this.btnAddtable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetCreatedTableAsSelectedTable = new System.Windows.Forms.Button();
            this.btnRemoveColumnFromTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddtable
            // 
            this.btnAddtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddtable.Location = new System.Drawing.Point(12, 61);
            this.btnAddtable.Name = "btnAddtable";
            this.btnAddtable.Size = new System.Drawing.Size(234, 70);
            this.btnAddtable.TabIndex = 0;
            this.btnAddtable.Text = "Add table to database";
            this.btnAddtable.UseVisualStyleBackColor = true;
            this.btnAddtable.Click += new System.EventHandler(this.btnAddtable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(12, 33);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(234, 22);
            this.txtTableName.TabIndex = 1;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.Lime;
            this.btnAddColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddColumn.Location = new System.Drawing.Point(590, 61);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(198, 72);
            this.btnAddColumn.TabIndex = 2;
            this.btnAddColumn.Text = "Add column to table";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(590, 33);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(198, 22);
            this.txtColumnName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adding table to the selected database:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(587, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adding column to selected table:";
            // 
            // btnSetCreatedTableAsSelectedTable
            // 
            this.btnSetCreatedTableAsSelectedTable.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSetCreatedTableAsSelectedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetCreatedTableAsSelectedTable.Location = new System.Drawing.Point(12, 137);
            this.btnSetCreatedTableAsSelectedTable.Name = "btnSetCreatedTableAsSelectedTable";
            this.btnSetCreatedTableAsSelectedTable.Size = new System.Drawing.Size(234, 70);
            this.btnSetCreatedTableAsSelectedTable.TabIndex = 6;
            this.btnSetCreatedTableAsSelectedTable.Text = "Set created table as selected table";
            this.btnSetCreatedTableAsSelectedTable.UseVisualStyleBackColor = false;
            this.btnSetCreatedTableAsSelectedTable.Click += new System.EventHandler(this.btnSetCreatedTableAsSelectedTable_Click);
            // 
            // btnRemoveColumnFromTable
            // 
            this.btnRemoveColumnFromTable.BackColor = System.Drawing.Color.DeepPink;
            this.btnRemoveColumnFromTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveColumnFromTable.Location = new System.Drawing.Point(590, 139);
            this.btnRemoveColumnFromTable.Name = "btnRemoveColumnFromTable";
            this.btnRemoveColumnFromTable.Size = new System.Drawing.Size(198, 72);
            this.btnRemoveColumnFromTable.TabIndex = 7;
            this.btnRemoveColumnFromTable.Text = "Remove column from table";
            this.btnRemoveColumnFromTable.UseVisualStyleBackColor = false;
            this.btnRemoveColumnFromTable.Click += new System.EventHandler(this.btnRemoveColumnFromTable_Click);
            // 
            // MaintainTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 212);
            this.Controls.Add(this.btnRemoveColumnFromTable);
            this.Controls.Add(this.btnSetCreatedTableAsSelectedTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColumnName);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnAddtable);
            this.Name = "MaintainTables";
            this.Text = "MaintainTables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddtable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetCreatedTableAsSelectedTable;
        private System.Windows.Forms.Button btnRemoveColumnFromTable;
    }
}