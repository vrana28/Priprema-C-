
namespace View
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unesiPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziSvePredmeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPrijavuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priakaziSvePrijaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblKorisnik1 = new System.Windows.Forms.Label();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPredmetToolStripMenuItem,
            this.unesiPrijavuToolStripMenuItem,
            this.promeniKorisnikaToolStripMenuItem,
            this.priakaziSvePrijaveToolStripMenuItem,
            this.studentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unesiPredmetToolStripMenuItem
            // 
            this.unesiPredmetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSvePredmeteToolStripMenuItem});
            this.unesiPredmetToolStripMenuItem.Name = "unesiPredmetToolStripMenuItem";
            this.unesiPredmetToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.unesiPredmetToolStripMenuItem.Text = "Unesi predmet";
            this.unesiPredmetToolStripMenuItem.Click += new System.EventHandler(this.unesiPredmetToolStripMenuItem_Click);
            // 
            // prikaziSvePredmeteToolStripMenuItem
            // 
            this.prikaziSvePredmeteToolStripMenuItem.Name = "prikaziSvePredmeteToolStripMenuItem";
            this.prikaziSvePredmeteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prikaziSvePredmeteToolStripMenuItem.Text = "Prikazi sve predmete";
            this.prikaziSvePredmeteToolStripMenuItem.Click += new System.EventHandler(this.prikaziSvePredmeteToolStripMenuItem_Click);
            // 
            // unesiPrijavuToolStripMenuItem
            // 
            this.unesiPrijavuToolStripMenuItem.Name = "unesiPrijavuToolStripMenuItem";
            this.unesiPrijavuToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.unesiPrijavuToolStripMenuItem.Text = "Unesi prijavu";
            this.unesiPrijavuToolStripMenuItem.Click += new System.EventHandler(this.unesiPrijavuToolStripMenuItem_Click);
            // 
            // promeniKorisnikaToolStripMenuItem
            // 
            this.promeniKorisnikaToolStripMenuItem.Name = "promeniKorisnikaToolStripMenuItem";
            this.promeniKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.promeniKorisnikaToolStripMenuItem.Text = "Promeni korisnika";
            this.promeniKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.promeniKorisnikaToolStripMenuItem_Click);
            // 
            // priakaziSvePrijaveToolStripMenuItem
            // 
            this.priakaziSvePrijaveToolStripMenuItem.Name = "priakaziSvePrijaveToolStripMenuItem";
            this.priakaziSvePrijaveToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.priakaziSvePrijaveToolStripMenuItem.Text = "Priakazi sve prijave";
            this.priakaziSvePrijaveToolStripMenuItem.Click += new System.EventHandler(this.priakaziSvePrijaveToolStripMenuItem_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(521, 406);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(0, 13);
            this.lblKorisnik.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblKorisnik1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 426);
            this.pnlMain.TabIndex = 2;
            // 
            // lblKorisnik1
            // 
            this.lblKorisnik1.AutoSize = true;
            this.lblKorisnik1.Location = new System.Drawing.Point(658, 382);
            this.lblKorisnik1.Name = "lblKorisnik1";
            this.lblKorisnik1.Size = new System.Drawing.Size(0, 13);
            this.lblKorisnik1.TabIndex = 0;
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.ToolStripMenuItem unesiPredmetToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblKorisnik1;
        private System.Windows.Forms.ToolStripMenuItem unesiPrijavuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priakaziSvePrijaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziSvePredmeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
    }
}