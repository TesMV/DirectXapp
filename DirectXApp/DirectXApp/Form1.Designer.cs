namespace DirectXApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxFVC = new System.Windows.Forms.CheckBox();
            this.checkBoxRF = new System.Windows.Forms.CheckBox();
            this.FNC = new System.Windows.Forms.CheckBox();
            this.checkBoxPassBand = new System.Windows.Forms.CheckBox();
            this.checkBoxFVCSOS = new System.Windows.Forms.CheckBox();
            this.labelDeviceStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(634, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(715, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBoxFVC
            // 
            this.checkBoxFVC.AutoSize = true;
            this.checkBoxFVC.Location = new System.Drawing.Point(53, 31);
            this.checkBoxFVC.Name = "checkBoxFVC";
            this.checkBoxFVC.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFVC.TabIndex = 2;
            this.checkBoxFVC.Text = "ФВЧ";
            this.checkBoxFVC.UseVisualStyleBackColor = true;
            // 
            // checkBoxRF
            // 
            this.checkBoxRF.AutoSize = true;
            this.checkBoxRF.Location = new System.Drawing.Point(111, 32);
            this.checkBoxRF.Name = "checkBoxRF";
            this.checkBoxRF.Size = new System.Drawing.Size(44, 17);
            this.checkBoxRF.TabIndex = 3;
            this.checkBoxRF.Text = "РФ";
            this.checkBoxRF.UseVisualStyleBackColor = true;
            // 
            // FNC
            // 
            this.FNC.AutoSize = true;
            this.FNC.Location = new System.Drawing.Point(161, 32);
            this.FNC.Name = "FNC";
            this.FNC.Size = new System.Drawing.Size(53, 17);
            this.FNC.TabIndex = 4;
            this.FNC.Text = "ФНЧ";
            this.FNC.UseVisualStyleBackColor = true;
            // 
            // checkBoxPassBand
            // 
            this.checkBoxPassBand.AutoSize = true;
            this.checkBoxPassBand.Location = new System.Drawing.Point(220, 31);
            this.checkBoxPassBand.Name = "checkBoxPassBand";
            this.checkBoxPassBand.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPassBand.TabIndex = 5;
            this.checkBoxPassBand.Text = "PassBand";
            this.checkBoxPassBand.UseVisualStyleBackColor = true;
            // 
            // checkBoxFVCSOS
            // 
            this.checkBoxFVCSOS.AutoSize = true;
            this.checkBoxFVCSOS.Location = new System.Drawing.Point(300, 31);
            this.checkBoxFVCSOS.Name = "checkBoxFVCSOS";
            this.checkBoxFVCSOS.Size = new System.Drawing.Size(77, 17);
            this.checkBoxFVCSOS.TabIndex = 6;
            this.checkBoxFVCSOS.Text = "ФВЧ SOS";
            this.checkBoxFVCSOS.UseVisualStyleBackColor = true;
            // 
            // labelDeviceStatus
            // 
            this.labelDeviceStatus.AutoSize = true;
            this.labelDeviceStatus.Location = new System.Drawing.Point(668, 356);
            this.labelDeviceStatus.Name = "labelDeviceStatus";
            this.labelDeviceStatus.Size = new System.Drawing.Size(122, 13);
            this.labelDeviceStatus.TabIndex = 7;
            this.labelDeviceStatus.Text = "USB device is detached";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 378);
            this.Controls.Add(this.labelDeviceStatus);
            this.Controls.Add(this.checkBoxFVCSOS);
            this.Controls.Add(this.checkBoxPassBand);
            this.Controls.Add(this.FNC);
            this.Controls.Add(this.checkBoxRF);
            this.Controls.Add(this.checkBoxFVC);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxFVC;
        private System.Windows.Forms.CheckBox checkBoxRF;
        private System.Windows.Forms.CheckBox FNC;
        private System.Windows.Forms.CheckBox checkBoxPassBand;
        private System.Windows.Forms.CheckBox checkBoxFVCSOS;
        private System.Windows.Forms.Label labelDeviceStatus;
    }
}

