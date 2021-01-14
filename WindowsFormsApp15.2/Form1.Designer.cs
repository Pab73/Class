
namespace WindowsFormsApp15._2
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
            this.btnVermeerder = new System.Windows.Forms.Button();
            this.btnVerminder = new System.Windows.Forms.Button();
            this.labelResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVermeerder
            // 
            this.btnVermeerder.Location = new System.Drawing.Point(305, 178);
            this.btnVermeerder.Name = "btnVermeerder";
            this.btnVermeerder.Size = new System.Drawing.Size(167, 67);
            this.btnVermeerder.TabIndex = 0;
            this.btnVermeerder.Text = "Vermeerder";
            this.btnVermeerder.UseVisualStyleBackColor = true;
            this.btnVermeerder.Click += new System.EventHandler(this.btnVermeerder_Click);
            // 
            // btnVerminder
            // 
            this.btnVerminder.Location = new System.Drawing.Point(305, 251);
            this.btnVerminder.Name = "btnVerminder";
            this.btnVerminder.Size = new System.Drawing.Size(167, 67);
            this.btnVerminder.TabIndex = 1;
            this.btnVerminder.Text = "Verminder";
            this.btnVerminder.UseVisualStyleBackColor = true;
            this.btnVerminder.Click += new System.EventHandler(this.btnVerminder_Click);
            // 
            // labelResultaat
            // 
            this.labelResultaat.AutoSize = true;
            this.labelResultaat.Location = new System.Drawing.Point(305, 91);
            this.labelResultaat.Name = "labelResultaat";
            this.labelResultaat.Size = new System.Drawing.Size(0, 17);
            this.labelResultaat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultaat);
            this.Controls.Add(this.btnVerminder);
            this.Controls.Add(this.btnVermeerder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVermeerder;
        private System.Windows.Forms.Button btnVerminder;
        private System.Windows.Forms.Label labelResultaat;
    }
}

