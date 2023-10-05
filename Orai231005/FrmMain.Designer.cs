
namespace Orai231005
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblTextfield = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.Color.Cyan;
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnClickMe.Location = new System.Drawing.Point(74, 152);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(147, 54);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click me!";
            this.btnClickMe.UseVisualStyleBackColor = false;
            // 
            // lblTextfield
            // 
            this.lblTextfield.AutoSize = true;
            this.lblTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTextfield.Location = new System.Drawing.Point(77, 37);
            this.lblTextfield.Name = "lblTextfield";
            this.lblTextfield.Size = new System.Drawing.Size(247, 31);
            this.lblTextfield.TabIndex = 1;
            this.lblTextfield.Text = "###Placeholder###";
            this.lblTextfield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextfield.Click += new System.EventHandler(this.lblTextfield_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTextfield);
            this.Controls.Add(this.btnClickMe);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblTextfield;
    }
}

