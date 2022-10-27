namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDesconect = new System.Windows.Forms.Button();
            this.buttonConect = new System.Windows.Forms.Button();
            this.comboBoxBAUD = new System.Windows.Forms.ComboBox();
            this.comboBoxPORT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.pictureBoxCelcius = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_TempValue = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelcius)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBarStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonDesconect);
            this.panel1.Controls.Add(this.buttonConect);
            this.panel1.Controls.Add(this.comboBoxBAUD);
            this.panel1.Controls.Add(this.comboBoxPORT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 530);
            this.panel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Red;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(188, 266);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(13, 13);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port status";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(19, 469);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(255, 23);
            this.progressBarStatus.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conexion Arduino";
            // 
            // buttonDesconect
            // 
            this.buttonDesconect.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDesconect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesconect.Location = new System.Drawing.Point(69, 382);
            this.buttonDesconect.Name = "buttonDesconect";
            this.buttonDesconect.Size = new System.Drawing.Size(155, 53);
            this.buttonDesconect.TabIndex = 6;
            this.buttonDesconect.TabStop = false;
            this.buttonDesconect.Text = "DESCONECTAR";
            this.buttonDesconect.UseVisualStyleBackColor = false;
            this.buttonDesconect.Click += new System.EventHandler(this.buttonDesconect_Click);
            // 
            // buttonConect
            // 
            this.buttonConect.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.buttonConect.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConect.Location = new System.Drawing.Point(69, 317);
            this.buttonConect.Name = "buttonConect";
            this.buttonConect.Size = new System.Drawing.Size(155, 51);
            this.buttonConect.TabIndex = 5;
            this.buttonConect.Text = "CONECTAR";
            this.buttonConect.UseVisualStyleBackColor = false;
            this.buttonConect.Click += new System.EventHandler(this.buttonConect_Click);
            // 
            // comboBoxBAUD
            // 
            this.comboBoxBAUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxBAUD.FormattingEnabled = true;
            this.comboBoxBAUD.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBAUD.Location = new System.Drawing.Point(132, 201);
            this.comboBoxBAUD.Name = "comboBoxBAUD";
            this.comboBoxBAUD.Size = new System.Drawing.Size(142, 28);
            this.comboBoxBAUD.TabIndex = 4;
            // 
            // comboBoxPORT
            // 
            this.comboBoxPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxPORT.FormattingEnabled = true;
            this.comboBoxPORT.Location = new System.Drawing.Point(132, 145);
            this.comboBoxPORT.Name = "comboBoxPORT";
            this.comboBoxPORT.Size = new System.Drawing.Size(142, 28);
            this.comboBoxPORT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.chartTemp);
            this.panel2.Location = new System.Drawing.Point(301, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 391);
            this.panel2.TabIndex = 1;
            // 
            // chartTemp
            // 
            this.chartTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(20, 20);
            this.chartTemp.Name = "chartTemp";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(505, 347);
            this.chartTemp.TabIndex = 0;
            this.chartTemp.Text = "chart1";
            this.chartTemp.Click += new System.EventHandler(this.chartTemp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.labelUnidad);
            this.panel3.Controls.Add(this.label_TempValue);
            this.panel3.Controls.Add(this.labelTemp);
            this.panel3.Controls.Add(this.pictureBoxCelcius);
            this.panel3.Location = new System.Drawing.Point(301, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 133);
            this.panel3.TabIndex = 2;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(107, 38);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(279, 47);
            this.labelTemp.TabIndex = 11;
            this.labelTemp.Text = "Temperatura:";
            // 
            // pictureBoxCelcius
            // 
            this.pictureBoxCelcius.Image = global::App.Properties.Resources.celcius;
            this.pictureBoxCelcius.Location = new System.Drawing.Point(34, 26);
            this.pictureBoxCelcius.Name = "pictureBoxCelcius";
            this.pictureBoxCelcius.Size = new System.Drawing.Size(71, 72);
            this.pictureBoxCelcius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCelcius.TabIndex = 0;
            this.pictureBoxCelcius.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label_TempValue
            // 
            this.label_TempValue.AutoSize = true;
            this.label_TempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.label_TempValue.ForeColor = System.Drawing.Color.White;
            this.label_TempValue.Location = new System.Drawing.Point(403, 38);
            this.label_TempValue.Name = "label_TempValue";
            this.label_TempValue.Size = new System.Drawing.Size(35, 47);
            this.label_TempValue.TabIndex = 12;
            this.label_TempValue.Text = "-";
            this.label_TempValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.labelUnidad.ForeColor = System.Drawing.Color.White;
            this.labelUnidad.Location = new System.Drawing.Point(457, 38);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(68, 47);
            this.labelUnidad.TabIndex = 13;
            this.labelUnidad.Text = "°C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(857, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelcius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDesconect;
        private System.Windows.Forms.Button buttonConect;
        private System.Windows.Forms.ComboBox comboBoxBAUD;
        private System.Windows.Forms.ComboBox comboBoxPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxCelcius;
        private System.Windows.Forms.Label labelTemp;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_TempValue;
        private System.Windows.Forms.Label labelUnidad;
    }
}

