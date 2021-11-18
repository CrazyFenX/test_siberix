
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.targetCityIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IdSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.IdFirstNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isStockCheckBox = new System.Windows.Forms.CheckBox();
            this.GetOptimalRouteOptimal_button = new System.Windows.Forms.Button();
            this.newRoadButton = new System.Windows.Forms.Button();
            this.newCityButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetCityIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdSecondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdFirstNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GetInfo_button
            // 
            this.GetInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetInfo_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetInfo_button.Location = new System.Drawing.Point(40, 500);
            this.GetInfo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetInfo_button.Name = "GetInfo_button";
            this.GetInfo_button.Size = new System.Drawing.Size(130, 38);
            this.GetInfo_button.TabIndex = 0;
            this.GetInfo_button.Text = "Get Info";
            this.GetInfo_button.UseVisualStyleBackColor = true;
            this.GetInfo_button.Click += new System.EventHandler(this.GetRepositoryInfo_Button_Click);
            // 
            // InitialData_Button
            // 
            this.InitialData_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialData_Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialData_Button.Location = new System.Drawing.Point(40, 11);
            this.InitialData_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InitialData_Button.Name = "InitialData_Button";
            this.InitialData_Button.Size = new System.Drawing.Size(130, 38);
            this.InitialData_Button.TabIndex = 1;
            this.InitialData_Button.Text = "Initial Data";
            this.InitialData_Button.UseVisualStyleBackColor = true;
            this.InitialData_Button.Click += new System.EventHandler(this.InitialData_Button_Click);
            // 
            // GetOptimalRoute_button
            // 
            this.GetOptimalRoute_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetOptimalRoute_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetOptimalRoute_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetOptimalRoute_button.Location = new System.Drawing.Point(29, 405);
            this.GetOptimalRoute_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOptimalRoute_button.Name = "GetOptimalRoute_button";
            this.GetOptimalRoute_button.Size = new System.Drawing.Size(158, 64);
            this.GetOptimalRoute_button.TabIndex = 2;
            this.GetOptimalRoute_button.Text = "Get Optimal Route (Brute Force)";
            this.GetOptimalRoute_button.UseVisualStyleBackColor = false;
            this.GetOptimalRoute_button.Click += new System.EventHandler(this.GetOptimalRoute_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target city Id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 721);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.graphPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1241, 721);
            this.panel3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 687);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(439, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Программа выполнена в качестве тестового задания для компании Сибирикс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(611, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Get Optimal Route (Brute Force) - запускает рекурсивный поиск оптимального маршру" +
    "та полным перебором";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 639);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Get Optimal Route - запускает рекурсивный поиск оптимального маршрута";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Отображение свойства IsStock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 613);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "New Road - добавляет новую дорогу для указанных ниже городов с указанной дистанци" +
    "ей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "New City - позволяет добавить новый город кликом по Picture Box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Initial Data - наполняет репозиторий заготовленными данными";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(271, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Is not Stock";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(193, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Is Stock";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.graphPictureBox.Location = new System.Drawing.Point(12, 12);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(997, 526);
            this.graphPictureBox.TabIndex = 6;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphPictureBox_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.distanceNumericUpDown);
            this.panel2.Controls.Add(this.targetCityIdNumericUpDown);
            this.panel2.Controls.Add(this.IdSecondNumericUpDown);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IdFirstNumericUpDown);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.isStockCheckBox);
            this.panel2.Controls.Add(this.GetOptimalRouteOptimal_button);
            this.panel2.Controls.Add(this.newRoadButton);
            this.panel2.Controls.Add(this.newCityButton);
            this.panel2.Controls.Add(this.InitialData_Button);
            this.panel2.Controls.Add(this.GetOptimalRoute_button);
            this.panel2.Controls.Add(this.GetInfo_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1024, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 721);
            this.panel2.TabIndex = 7;
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distanceNumericUpDown.Location = new System.Drawing.Point(124, 222);
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(46, 27);
            this.distanceNumericUpDown.TabIndex = 17;
            // 
            // targetCityIdNumericUpDown
            // 
            this.targetCityIdNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetCityIdNumericUpDown.Location = new System.Drawing.Point(141, 302);
            this.targetCityIdNumericUpDown.Name = "targetCityIdNumericUpDown";
            this.targetCityIdNumericUpDown.Size = new System.Drawing.Size(46, 27);
            this.targetCityIdNumericUpDown.TabIndex = 16;
            // 
            // IdSecondNumericUpDown
            // 
            this.IdSecondNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdSecondNumericUpDown.Location = new System.Drawing.Point(124, 189);
            this.IdSecondNumericUpDown.Name = "IdSecondNumericUpDown";
            this.IdSecondNumericUpDown.Size = new System.Drawing.Size(46, 27);
            this.IdSecondNumericUpDown.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id 2nd city";
            // 
            // IdFirstNumericUpDown
            // 
            this.IdFirstNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdFirstNumericUpDown.Location = new System.Drawing.Point(124, 160);
            this.IdFirstNumericUpDown.Name = "IdFirstNumericUpDown";
            this.IdFirstNumericUpDown.Size = new System.Drawing.Size(46, 27);
            this.IdFirstNumericUpDown.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id 1st city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Distance";
            // 
            // isStockCheckBox
            // 
            this.isStockCheckBox.AutoSize = true;
            this.isStockCheckBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isStockCheckBox.Location = new System.Drawing.Point(76, 89);
            this.isStockCheckBox.Name = "isStockCheckBox";
            this.isStockCheckBox.Size = new System.Drawing.Size(76, 24);
            this.isStockCheckBox.TabIndex = 8;
            this.isStockCheckBox.Text = "Is stock";
            this.isStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // GetOptimalRouteOptimal_button
            // 
            this.GetOptimalRouteOptimal_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetOptimalRouteOptimal_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetOptimalRouteOptimal_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetOptimalRouteOptimal_button.Location = new System.Drawing.Point(29, 334);
            this.GetOptimalRouteOptimal_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOptimalRouteOptimal_button.Name = "GetOptimalRouteOptimal_button";
            this.GetOptimalRouteOptimal_button.Size = new System.Drawing.Size(158, 67);
            this.GetOptimalRouteOptimal_button.TabIndex = 7;
            this.GetOptimalRouteOptimal_button.Text = "Get Optimal Route";
            this.GetOptimalRouteOptimal_button.UseVisualStyleBackColor = false;
            this.GetOptimalRouteOptimal_button.Click += new System.EventHandler(this.GetOptimalRouteOptimal_button_Click);
            // 
            // newRoadButton
            // 
            this.newRoadButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRoadButton.Location = new System.Drawing.Point(40, 119);
            this.newRoadButton.Name = "newRoadButton";
            this.newRoadButton.Size = new System.Drawing.Size(130, 31);
            this.newRoadButton.TabIndex = 6;
            this.newRoadButton.Text = "New Road";
            this.newRoadButton.UseVisualStyleBackColor = true;
            this.newRoadButton.Click += new System.EventHandler(this.newRoadButton_Click);
            // 
            // newCityButton
            // 
            this.newCityButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newCityButton.Location = new System.Drawing.Point(40, 54);
            this.newCityButton.Name = "newCityButton";
            this.newCityButton.Size = new System.Drawing.Size(130, 29);
            this.newCityButton.TabIndex = 5;
            this.newCityButton.Text = "New City";
            this.newCityButton.UseVisualStyleBackColor = true;
            this.newCityButton.Click += new System.EventHandler(this.newCityButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetCityIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdSecondNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdFirstNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetInfo_button;
        private System.Windows.Forms.Button InitialData_Button;
        private System.Windows.Forms.Button GetOptimalRoute_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Button newRoadButton;
        private System.Windows.Forms.Button newCityButton;
        private System.Windows.Forms.Button GetOptimalRouteOptimal_button;
        private System.Windows.Forms.CheckBox isStockCheckBox;
        private System.Windows.Forms.NumericUpDown IdSecondNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdFirstNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown targetCityIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

