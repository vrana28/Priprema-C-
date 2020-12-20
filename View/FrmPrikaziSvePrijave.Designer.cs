
namespace View
{
    partial class FrmPrikaziSvePrijave
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
            this.dgvPrijave = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrijave
            // 
            this.dgvPrijave.AllowUserToAddRows = false;
            this.dgvPrijave.AllowUserToDeleteRows = false;
            this.dgvPrijave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijave.Location = new System.Drawing.Point(144, 75);
            this.dgvPrijave.Name = "dgvPrijave";
            this.dgvPrijave.ReadOnly = true;
            this.dgvPrijave.Size = new System.Drawing.Size(505, 312);
            this.dgvPrijave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sve prijave";
            // 
            // FrmPrikaziSvePrijave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrijave);
            this.Name = "FrmPrikaziSvePrijave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikaziSvePrijave";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrijave;
        private System.Windows.Forms.Label label1;
    }
}