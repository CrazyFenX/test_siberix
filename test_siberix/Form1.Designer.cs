
namespace test_siberix
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
            this.GetInfo_button = new System.Windows.Forms.Button();
            this.InitialData_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Location = new System.Drawing.Point(658, 255);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(130, 51);
            this.GetInfo_button.TabIndex = 0;
            this.GetInfo_button.Text = "Get Info";
            this.GetInfo_button.UseVisualStyleBackColor = true;
            this.GetInfo_button.Click += new System.EventHandler(this.GetRepositoryInfo_Button_Click);
            // 
            // InitialData_Button
            // 
            this.InitialData_Button.Location = new System.Drawing.Point(658, 34);
            this.InitialData_Button.Name = "InitialData_Button";
            this.InitialData_Button.Size = new System.Drawing.Size(130, 51);
            this.InitialData_Button.TabIndex = 1;
            this.InitialData_Button.Text = "Initial Data";
            this.InitialData_Button.UseVisualStyleBackColor = true;
            this.InitialData_Button.Click += new System.EventHandler(this.InitialData_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InitialData_Button);
            this.Controls.Add(this.GetInfo_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.Button InitialData_Button;
    }
}

