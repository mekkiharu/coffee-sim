namespace coffeeshop_sim
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openTimeSec = new System.Windows.Forms.TextBox();
            this.operationTimer = new System.Windows.Forms.Timer(this.components);
            this.waitingTimer = new System.Windows.Forms.Timer(this.components);
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.prepTimer = new System.Windows.Forms.Timer(this.components);
            this.openTimeMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openTimeHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.waitTimeMin = new System.Windows.Forms.TextBox();
            this.waitTimeSec = new System.Windows.Forms.TextBox();
            this.pendOrd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.orderTimeMin = new System.Windows.Forms.TextBox();
            this.orderTimeSec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prepTimeMin = new System.Windows.Forms.TextBox();
            this.prepTimeSec = new System.Windows.Forms.TextBox();
            this.customerNumBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customerTimer = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 316);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(346, 316);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waiting Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pending Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preparation Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operation Time";
            // 
            // openTimeSec
            // 
            this.openTimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTimeSec.Location = new System.Drawing.Point(275, 204);
            this.openTimeSec.Name = "openTimeSec";
            this.openTimeSec.ReadOnly = true;
            this.openTimeSec.Size = new System.Drawing.Size(51, 38);
            this.openTimeSec.TabIndex = 15;
            this.openTimeSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operationTimer
            // 
            this.operationTimer.Tick += new System.EventHandler(this.operationTimer_Tick);
            // 
            // waitingTimer
            // 
            this.waitingTimer.Tick += new System.EventHandler(this.waitingTimer_Tick);
            // 
            // orderTimer
            // 
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // prepTimer
            // 
            this.prepTimer.Tick += new System.EventHandler(this.prepTimer_Tick);
            // 
            // openTimeMin
            // 
            this.openTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTimeMin.Location = new System.Drawing.Point(190, 204);
            this.openTimeMin.Name = "openTimeMin";
            this.openTimeMin.ReadOnly = true;
            this.openTimeMin.Size = new System.Drawing.Size(51, 38);
            this.openTimeMin.TabIndex = 16;
            this.openTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // openTimeHour
            // 
            this.openTimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTimeHour.Location = new System.Drawing.Point(97, 204);
            this.openTimeHour.Name = "openTimeHour";
            this.openTimeHour.ReadOnly = true;
            this.openTimeHour.Size = new System.Drawing.Size(51, 38);
            this.openTimeHour.TabIndex = 18;
            this.openTimeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = ":";
            // 
            // waitTimeMin
            // 
            this.waitTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitTimeMin.Location = new System.Drawing.Point(12, 45);
            this.waitTimeMin.Name = "waitTimeMin";
            this.waitTimeMin.ReadOnly = true;
            this.waitTimeMin.Size = new System.Drawing.Size(51, 38);
            this.waitTimeMin.TabIndex = 21;
            this.waitTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // waitTimeSec
            // 
            this.waitTimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitTimeSec.Location = new System.Drawing.Point(97, 45);
            this.waitTimeSec.Name = "waitTimeSec";
            this.waitTimeSec.ReadOnly = true;
            this.waitTimeSec.Size = new System.Drawing.Size(51, 38);
            this.waitTimeSec.TabIndex = 20;
            this.waitTimeSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pendOrd
            // 
            this.pendOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendOrd.Location = new System.Drawing.Point(346, 45);
            this.pendOrd.Name = "pendOrd";
            this.pendOrd.ReadOnly = true;
            this.pendOrd.Size = new System.Drawing.Size(51, 38);
            this.pendOrd.TabIndex = 24;
            this.pendOrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 31);
            this.label10.TabIndex = 28;
            this.label10.Text = ":";
            // 
            // orderTimeMin
            // 
            this.orderTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTimeMin.Location = new System.Drawing.Point(12, 130);
            this.orderTimeMin.Name = "orderTimeMin";
            this.orderTimeMin.ReadOnly = true;
            this.orderTimeMin.Size = new System.Drawing.Size(51, 38);
            this.orderTimeMin.TabIndex = 27;
            this.orderTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderTimeSec
            // 
            this.orderTimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTimeSec.Location = new System.Drawing.Point(97, 130);
            this.orderTimeSec.Name = "orderTimeSec";
            this.orderTimeSec.ReadOnly = true;
            this.orderTimeSec.Size = new System.Drawing.Size(51, 38);
            this.orderTimeSec.TabIndex = 26;
            this.orderTimeSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = ":";
            // 
            // prepTimeMin
            // 
            this.prepTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeMin.Location = new System.Drawing.Point(266, 133);
            this.prepTimeMin.Name = "prepTimeMin";
            this.prepTimeMin.ReadOnly = true;
            this.prepTimeMin.Size = new System.Drawing.Size(51, 38);
            this.prepTimeMin.TabIndex = 30;
            this.prepTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prepTimeSec
            // 
            this.prepTimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeSec.Location = new System.Drawing.Point(351, 133);
            this.prepTimeSec.Name = "prepTimeSec";
            this.prepTimeSec.ReadOnly = true;
            this.prepTimeSec.Size = new System.Drawing.Size(51, 38);
            this.prepTimeSec.TabIndex = 29;
            this.prepTimeSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customerNumBox
            // 
            this.customerNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumBox.Location = new System.Drawing.Point(253, 45);
            this.customerNumBox.Name = "customerNumBox";
            this.customerNumBox.ReadOnly = true;
            this.customerNumBox.Size = new System.Drawing.Size(51, 38);
            this.customerNumBox.TabIndex = 33;
            this.customerNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Customer Count";
            // 
            // customerTimer
            // 
            this.customerTimer.Tick += new System.EventHandler(this.pendTimer_Tick);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(140, 316);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(101, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop Simulation";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 363);
            this.Controls.Add(this.customerNumBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prepTimeMin);
            this.Controls.Add(this.prepTimeSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.orderTimeMin);
            this.Controls.Add(this.orderTimeSec);
            this.Controls.Add(this.pendOrd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.waitTimeMin);
            this.Controls.Add(this.waitTimeSec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.openTimeHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.openTimeMin);
            this.Controls.Add(this.openTimeSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Coffee-Sim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox openTimeSec;
        private System.Windows.Forms.Timer operationTimer;
        private System.Windows.Forms.Timer waitingTimer;
        private System.Windows.Forms.Timer pendingTimer;
        private System.Windows.Forms.Timer orderTImer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.Timer prepTimer;
        private System.Windows.Forms.TextBox openTimeMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox openTimeHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox waitTimeMin;
        private System.Windows.Forms.TextBox waitTimeSec;
        private System.Windows.Forms.TextBox pendOrd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox orderTimeMin;
        private System.Windows.Forms.TextBox orderTimeSec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox prepTimeMin;
        private System.Windows.Forms.TextBox prepTimeSec;
        private System.Windows.Forms.TextBox customerNumBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer customerTimer;
        private System.Windows.Forms.Button stopButton;
    }
}

