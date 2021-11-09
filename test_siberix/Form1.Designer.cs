
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
            this.GetOptimalRoute_button = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Location = new System.Drawing.Point(576, 289);
            this.GetInfo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(114, 38);
            this.GetInfo_button.TabIndex = 0;
            this.GetInfo_button.Text = "Get Info";
            this.GetInfo_button.UseVisualStyleBackColor = true;
            this.GetInfo_button.Click += new System.EventHandler(this.GetRepositoryInfo_Button_Click);
            // 
            // InitialData_Button
            // 
            this.InitialData_Button.Location = new System.Drawing.Point(576, 26);
            this.InitialData_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InitialData_Button.Name = "InitialData_Button";
            this.InitialData_Button.Size = new System.Drawing.Size(114, 38);
            this.InitialData_Button.TabIndex = 1;
            this.InitialData_Button.Text = "Initial Data";
            this.InitialData_Button.UseVisualStyleBackColor = true;
            this.InitialData_Button.Click += new System.EventHandler(this.InitialData_Button_Click);
            // 
            // GetOptimalRoute_button
            // 
            this.GetOptimalRoute_button.Location = new System.Drawing.Point(576, 68);
            this.GetOptimalRoute_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOptimalRoute_button.Name = "GetOptimalRoute_button";
            this.GetOptimalRoute_button.Size = new System.Drawing.Size(114, 38);
            this.GetOptimalRoute_button.TabIndex = 2;
            this.GetOptimalRoute_button.Text = "Get Optimal Route";
            this.GetOptimalRoute_button.UseVisualStyleBackColor = true;
            this.GetOptimalRoute_button.Click += new System.EventHandler(this.GetOptimalRoute_button_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.Location = new System.Drawing.Point(474, 68);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(82, 32);
            this.IdTextBox.TabIndex = 3;
            this.IdTextBox.Text = "1";
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(440, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.GetOptimalRoute_button);
            this.Controls.Add(this.InitialData_Button);
            this.Controls.Add(this.GetInfo_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.Button InitialData_Button;
        private System.Windows.Forms.Button GetOptimalRoute_button;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
    }
}

