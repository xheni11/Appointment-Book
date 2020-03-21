namespace AppointmentBook_Exercise7.winForms
{
    partial class ManagerAppointments
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
            this.dataGridViewAppointmens = new System.Windows.Forms.DataGridView();
            this.bindingSourceAppointment = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxStatistics = new System.Windows.Forms.ComboBox();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonGeneric = new System.Windows.Forms.Button();
            this.labelShowStatistic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAppointmens
            // 
            this.dataGridViewAppointmens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmens.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewAppointmens.Name = "dataGridViewAppointmens";
            this.dataGridViewAppointmens.Size = new System.Drawing.Size(884, 321);
            this.dataGridViewAppointmens.TabIndex = 0;
            // 
            // comboBoxStatistics
            // 
            this.comboBoxStatistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatistics.FormattingEnabled = true;
            this.comboBoxStatistics.Location = new System.Drawing.Point(12, 21);
            this.comboBoxStatistics.Name = "comboBoxStatistics";
            this.comboBoxStatistics.Size = new System.Drawing.Size(250, 21);
            this.comboBoxStatistics.TabIndex = 1;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(296, 21);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(142, 21);
            this.comboBoxUsers.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(494, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker.TabIndex = 9;
            // 
            // buttonGeneric
            // 
            this.buttonGeneric.Location = new System.Drawing.Point(767, 23);
            this.buttonGeneric.Name = "buttonGeneric";
            this.buttonGeneric.Size = new System.Drawing.Size(108, 23);
            this.buttonGeneric.TabIndex = 10;
            this.buttonGeneric.Text = "Generate";
            this.buttonGeneric.UseVisualStyleBackColor = true;
            this.buttonGeneric.Click += new System.EventHandler(this.buttonGeneric_Click);
            // 
            // labelShowStatistic
            // 
            this.labelShowStatistic.AutoSize = true;
            this.labelShowStatistic.Location = new System.Drawing.Point(21, 66);
            this.labelShowStatistic.Name = "labelShowStatistic";
            this.labelShowStatistic.Size = new System.Drawing.Size(0, 13);
            this.labelShowStatistic.TabIndex = 11;
            // 
            // ManagerAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.labelShowStatistic);
            this.Controls.Add(this.buttonGeneric);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.comboBoxStatistics);
            this.Controls.Add(this.dataGridViewAppointmens);
            this.Name = "ManagerAppointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.ManagerAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointmens;
        private System.Windows.Forms.BindingSource bindingSourceAppointment;
        private System.Windows.Forms.ComboBox comboBoxStatistics;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonGeneric;
        private System.Windows.Forms.Label labelShowStatistic;
    }
}