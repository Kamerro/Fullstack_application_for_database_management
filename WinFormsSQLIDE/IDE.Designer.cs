namespace WinFormsSQLIDE
{
    partial class IDE
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdswiez = new System.Windows.Forms.Button();
            this.dataGridDB = new System.Windows.Forms.DataGridView();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnZarzadzaj = new System.Windows.Forms.Button();
            this.btnZarzadzajTabelami = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.BackColor = System.Drawing.Color.SpringGreen;
            this.btnOdswiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdswiez.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdswiez.Location = new System.Drawing.Point(877, 369);
            this.btnOdswiez.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(201, 68);
            this.btnOdswiez.TabIndex = 14;
            this.btnOdswiez.Text = "Wyświetl dane z tabeli";
            this.btnOdswiez.UseVisualStyleBackColor = false;
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // dataGridDB
            // 
            this.dataGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDB.Location = new System.Drawing.Point(13, 16);
            this.dataGridDB.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDB.Name = "dataGridDB";
            this.dataGridDB.RowHeadersWidth = 51;
            this.dataGridDB.Size = new System.Drawing.Size(857, 421);
            this.dataGridDB.TabIndex = 13;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfig.Location = new System.Drawing.Point(877, 16);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(202, 70);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Otwórz konfigurator połączenia";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnZarzadzaj
            // 
            this.btnZarzadzaj.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnZarzadzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarzadzaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZarzadzaj.Location = new System.Drawing.Point(877, 92);
            this.btnZarzadzaj.Name = "btnZarzadzaj";
            this.btnZarzadzaj.Size = new System.Drawing.Size(202, 130);
            this.btnZarzadzaj.TabIndex = 20;
            this.btnZarzadzaj.Text = "Zarządzaj bazami danych";
            this.btnZarzadzaj.UseVisualStyleBackColor = false;
            this.btnZarzadzaj.Click += new System.EventHandler(this.btnZarzadzaj_Click);
            // 
            // btnZarzadzajTabelami
            // 
            this.btnZarzadzajTabelami.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnZarzadzajTabelami.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarzadzajTabelami.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZarzadzajTabelami.Location = new System.Drawing.Point(877, 228);
            this.btnZarzadzajTabelami.Name = "btnZarzadzajTabelami";
            this.btnZarzadzajTabelami.Size = new System.Drawing.Size(202, 130);
            this.btnZarzadzajTabelami.TabIndex = 21;
            this.btnZarzadzajTabelami.Text = "Zarządzaj tabelami bazy danych";
            this.btnZarzadzajTabelami.UseVisualStyleBackColor = false;
            this.btnZarzadzajTabelami.Click += new System.EventHandler(this.btnZarzadzajTabelami_Click);
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btnZarzadzajTabelami);
            this.Controls.Add(this.btnZarzadzaj);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnOdswiez);
            this.Controls.Add(this.dataGridDB);
            this.Name = "IDE";
            this.Text = "IDE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOdswiez;
        private System.Windows.Forms.DataGridView dataGridDB;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnZarzadzaj;
        private System.Windows.Forms.Button btnZarzadzajTabelami;
    }
}

