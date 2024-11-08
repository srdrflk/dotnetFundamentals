namespace WindowsFormsApp
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
            this.btnMain = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(333, 169);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(126, 86);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Press me :)";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(92, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Please write yout name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(287, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 26);
            this.txtName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

