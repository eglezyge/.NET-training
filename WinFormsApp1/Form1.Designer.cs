namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_np = new System.Windows.Forms.Button();
            this.txtbox_ProjectName = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_np
            // 
            this.btn_np.Location = new System.Drawing.Point(161, 162);
            this.btn_np.Name = "btn_np";
            this.btn_np.Size = new System.Drawing.Size(155, 54);
            this.btn_np.TabIndex = 3;
            this.btn_np.Text = "button1";
            this.btn_np.UseVisualStyleBackColor = true;
            this.btn_np.Click += new System.EventHandler(this.btn_np_Click);
            // 
            // txtbox_ProjectName
            // 
            this.txtbox_ProjectName.Location = new System.Drawing.Point(129, 133);
            this.txtbox_ProjectName.Name = "txtbox_ProjectName";
            this.txtbox_ProjectName.Size = new System.Drawing.Size(214, 23);
            this.txtbox_ProjectName.TabIndex = 4;
            // 
            // lbl_error
            // 
            this.lbl_error.Location = new System.Drawing.Point(129, 103);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(214, 27);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "Enter project name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 371);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.txtbox_ProjectName);
            this.Controls.Add(this.btn_np);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_np;
        private TextBox txtbox_ProjectName;
        private Label lbl_error;
    }
}