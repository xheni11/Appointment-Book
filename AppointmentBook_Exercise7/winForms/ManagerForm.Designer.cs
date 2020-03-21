namespace AppointmentBook_Exercise7.winForms
{
    partial class ManagerForm
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.buttonLocations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(21, 25);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(250, 37);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.Location = new System.Drawing.Point(21, 89);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Size = new System.Drawing.Size(250, 37);
            this.buttonAppointments.TabIndex = 1;
            this.buttonAppointments.Text = "Appointments";
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // buttonLocations
            // 
            this.buttonLocations.Location = new System.Drawing.Point(21, 157);
            this.buttonLocations.Name = "buttonLocations";
            this.buttonLocations.Size = new System.Drawing.Size(250, 37);
            this.buttonLocations.TabIndex = 2;
            this.buttonLocations.Text = "Locations";
            this.buttonLocations.UseVisualStyleBackColor = true;
            this.buttonLocations.Click += new System.EventHandler(this.buttonLocations_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 235);
            this.Controls.Add(this.buttonLocations);
            this.Controls.Add(this.buttonAppointments);
            this.Controls.Add(this.buttonUsers);
            this.Name = "ManagerForm";
            this.Text = "Manager Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonAppointments;
        private System.Windows.Forms.Button buttonLocations;
    }
}