namespace Ukr_TourOp
{
    partial class Author_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author_form));
            this.panelAuthor1 = new System.Windows.Forms.Panel();
            this.panelAuthor3 = new System.Windows.Forms.Panel();
            this.panelAuthor2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAuthor1.SuspendLayout();
            this.panelAuthor3.SuspendLayout();
            this.panelAuthor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAuthor1
            // 
            this.panelAuthor1.Controls.Add(this.label1);
            this.panelAuthor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthor1.Location = new System.Drawing.Point(0, 0);
            this.panelAuthor1.Name = "panelAuthor1";
            this.panelAuthor1.Size = new System.Drawing.Size(800, 100);
            this.panelAuthor1.TabIndex = 0;
            // 
            // panelAuthor3
            // 
            this.panelAuthor3.Controls.Add(this.label3);
            this.panelAuthor3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAuthor3.Location = new System.Drawing.Point(0, 350);
            this.panelAuthor3.Name = "panelAuthor3";
            this.panelAuthor3.Size = new System.Drawing.Size(800, 100);
            this.panelAuthor3.TabIndex = 1;
            // 
            // panelAuthor2
            // 
            this.panelAuthor2.Controls.Add(this.label2);
            this.panelAuthor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthor2.Location = new System.Drawing.Point(0, 100);
            this.panelAuthor2.Name = "panelAuthor2";
            this.panelAuthor2.Size = new System.Drawing.Size(800, 250);
            this.panelAuthor2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Система управління турістичними послугами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Інфа про те який автор чудовий і програма класна";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "power by Українець Дмитро Сергійович СП-436Б";
            // 
            // Author_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAuthor2);
            this.Controls.Add(this.panelAuthor3);
            this.Controls.Add(this.panelAuthor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Author_form";
            this.Text = "Про автора";
            this.panelAuthor1.ResumeLayout(false);
            this.panelAuthor1.PerformLayout();
            this.panelAuthor3.ResumeLayout(false);
            this.panelAuthor3.PerformLayout();
            this.panelAuthor2.ResumeLayout(false);
            this.panelAuthor2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAuthor1;
        private System.Windows.Forms.Panel panelAuthor3;
        private System.Windows.Forms.Panel panelAuthor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}