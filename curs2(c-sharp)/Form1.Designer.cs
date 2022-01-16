
namespace curs2_c_sharp_
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
            this.doctor = new System.Windows.Forms.Button();
            this.patient = new System.Windows.Forms.Button();
            this.label1_mode = new System.Windows.Forms.Label();
            this.main_menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doctor.Location = new System.Drawing.Point(484, 249);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(150, 50);
            this.doctor.TabIndex = 7;
            this.doctor.Text = "Доктор";
            this.doctor.UseVisualStyleBackColor = false;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // patient
            // 
            this.patient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.patient.Location = new System.Drawing.Point(167, 249);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(150, 50);
            this.patient.TabIndex = 6;
            this.patient.Text = "Пациент";
            this.patient.UseVisualStyleBackColor = false;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // label1_mode
            // 
            this.label1_mode.AutoSize = true;
            this.label1_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_mode.Location = new System.Drawing.Point(283, 149);
            this.label1_mode.Name = "label1_mode";
            this.label1_mode.Size = new System.Drawing.Size(236, 24);
            this.label1_mode.TabIndex = 5;
            this.label1_mode.Text = "Выберите режим работы";
            // 
            // main_menu
            // 
            this.main_menu.AutoSize = true;
            this.main_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_menu.Location = new System.Drawing.Point(266, 75);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(268, 25);
            this.main_menu.TabIndex = 4;
            this.main_menu.Text = "Медицинский опросник";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label1_mode);
            this.Controls.Add(this.main_menu);
            this.Name = "Form1";
            this.Text = "Опросник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doctor;
        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Label label1_mode;
        private System.Windows.Forms.Label main_menu;
    }
}

