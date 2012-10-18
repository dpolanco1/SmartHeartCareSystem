namespace aPresentationLayer
{
    partial class Frm_Agenda
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(179, 445);
            this.dateNavigator1.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(179, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(707, 445);
            this.schedulerControl1.Start = new System.DateTime(2012, 10, 11, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 1;
            this.schedulerControl1.Text = "schedulerControl1";
            timeRuler1.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00");
            timeRuler1.TimeZone.DaylightDate = new System.DateTime(1, 3, 2, 2, 0, 0, 0);
            timeRuler1.TimeZone.DaylightZoneName = "Hora de verano del Atlántico";
            timeRuler1.TimeZone.DisplayName = "(UTC-04:00) Hora del Atlántico (Canadá)";
            timeRuler1.TimeZone.StandardDate = new System.DateTime(1, 11, 1, 2, 0, 0, 0);
            timeRuler1.TimeZone.StandardZoneName = "Hora estándar del Atlántico";
            timeRuler1.TimeZone.UtcOffset = System.TimeSpan.Parse("-04:00:00");
            timeRuler1.UseClientTimeZone = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            timeRuler2.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00");
            timeRuler2.TimeZone.DaylightDate = new System.DateTime(1, 3, 2, 2, 0, 0, 0);
            timeRuler2.TimeZone.DaylightZoneName = "Hora de verano del Atlántico";
            timeRuler2.TimeZone.DisplayName = "(UTC-04:00) Hora del Atlántico (Canadá)";
            timeRuler2.TimeZone.StandardDate = new System.DateTime(1, 11, 1, 2, 0, 0, 0);
            timeRuler2.TimeZone.StandardZoneName = "Hora estándar del Atlántico";
            timeRuler2.TimeZone.UtcOffset = System.TimeSpan.Parse("-04:00:00");
            timeRuler2.UseClientTimeZone = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // Frm_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 445);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Name = "Frm_Agenda";
            this.Text = "Agenda Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}