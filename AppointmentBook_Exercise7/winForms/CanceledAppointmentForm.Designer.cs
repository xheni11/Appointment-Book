namespace AppointmentBook_Exercise7.winForms
{
    partial class CanceledAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCanceled = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanceled)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of canceled appointments";
            // 
            // dataGridViewCanceled
            // 
            this.dataGridViewCanceled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanceled.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewCanceled.Name = "dataGridViewCanceled";
            this.dataGridViewCanceled.Size = new System.Drawing.Size(733, 360);
            this.dataGridViewCanceled.TabIndex = 1;
            // 
            // CanceledAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 436);
            this.Controls.Add(this.dataGridViewCanceled);
            this.Controls.Add(this.label1);
            this.Name = "CanceledAppointmentForm";
            this.Text = "Canceled";
            this.Load += new System.EventHandler(this.InvitationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanceled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCanceled;
    }
}