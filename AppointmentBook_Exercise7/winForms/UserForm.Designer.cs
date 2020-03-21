namespace AppointmentBook_Exercise7
{
    partial class UserForm
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
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonInvitation = new System.Windows.Forms.Button();
            this.buttonCanceled = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.Location = new System.Drawing.Point(12, 22);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(282, 40);
            this.buttonAppointment.TabIndex = 0;
            this.buttonAppointment.Text = "Appointments";
            this.buttonAppointment.UseVisualStyleBackColor = true;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonInvitation
            // 
            this.buttonInvitation.Location = new System.Drawing.Point(12, 91);
            this.buttonInvitation.Name = "buttonInvitation";
            this.buttonInvitation.Size = new System.Drawing.Size(282, 38);
            this.buttonInvitation.TabIndex = 1;
            this.buttonInvitation.Text = "Invitations";
            this.buttonInvitation.UseVisualStyleBackColor = true;
            this.buttonInvitation.Click += new System.EventHandler(this.buttonInvitation_Click);
            // 
            // buttonCanceled
            // 
            this.buttonCanceled.Location = new System.Drawing.Point(12, 156);
            this.buttonCanceled.Name = "buttonCanceled";
            this.buttonCanceled.Size = new System.Drawing.Size(282, 42);
            this.buttonCanceled.TabIndex = 2;
            this.buttonCanceled.Text = "Canceled";
            this.buttonCanceled.UseVisualStyleBackColor = true;
            this.buttonCanceled.Click += new System.EventHandler(this.buttonCanceled_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 210);
            this.Controls.Add(this.buttonCanceled);
            this.Controls.Add(this.buttonInvitation);
            this.Controls.Add(this.buttonAppointment);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonInvitation;
        private System.Windows.Forms.Button buttonCanceled;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}