
namespace Bilet
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.cmbGidis = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(354, 337);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Bilet Al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cmbGidis
            // 
            this.cmbGidis.FormattingEnabled = true;
            this.cmbGidis.Location = new System.Drawing.Point(180, 187);
            this.cmbGidis.Name = "cmbGidis";
            this.cmbGidis.Size = new System.Drawing.Size(121, 21);
            this.cmbGidis.TabIndex = 1;
            this.cmbGidis.SelectedValueChanged += new System.EventHandler(this.cmbGidis_SelectedValueChanged);
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Location = new System.Drawing.Point(555, 187);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(121, 21);
            this.cmbVaris.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gidiş Noktası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varış Noktası";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbGidis);
            this.Controls.Add(this.btnBuy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox cmbGidis;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

