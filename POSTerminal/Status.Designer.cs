
namespace POSTerminal
{
    partial class Status
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStatusSet = new System.Windows.Forms.Button();
            this.btnStatusBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(242, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 0;
            // 
            // btnStatusSet
            // 
            this.btnStatusSet.Location = new System.Drawing.Point(99, 152);
            this.btnStatusSet.Name = "btnStatusSet";
            this.btnStatusSet.Size = new System.Drawing.Size(122, 46);
            this.btnStatusSet.TabIndex = 1;
            this.btnStatusSet.Text = "Set to:";
            this.btnStatusSet.UseVisualStyleBackColor = true;
            this.btnStatusSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStatusBack
            // 
            this.btnStatusBack.Location = new System.Drawing.Point(351, 152);
            this.btnStatusBack.Name = "btnStatusBack";
            this.btnStatusBack.Size = new System.Drawing.Size(75, 36);
            this.btnStatusBack.TabIndex = 2;
            this.btnStatusBack.Text = "Back";
            this.btnStatusBack.UseVisualStyleBackColor = true;
            this.btnStatusBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatusBack);
            this.Controls.Add(this.btnStatusSet);
            this.Controls.Add(this.lblStatus);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStatusSet;
        private System.Windows.Forms.Button btnStatusBack;
    }
}