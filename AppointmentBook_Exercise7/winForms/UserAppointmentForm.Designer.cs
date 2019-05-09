namespace AppointmentBook_Exercise7.winForms
{
    partial class UserAppointmentForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.bindingSourceLocation = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAttendees = new System.Windows.Forms.ListBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.LocationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(378, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 34);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(256, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(116, 34);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(514, 56);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.Size = new System.Drawing.Size(720, 379);
            this.dataGridViewAppointment.TabIndex = 3;
            this.dataGridViewAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewAppointment.DoubleClick += new System.EventHandler(this.dataGridViewAppointment_DoubleClick);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DataSource = this.bindingSourceLocation;
            this.comboBoxLocation.DisplayMember = "Name";
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(104, 191);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(162, 21);
            this.comboBoxLocation.TabIndex = 62;
            this.comboBoxLocation.ValueMember = "Id";
            // 
            // bindingSourceLocation
            // 
            this.bindingSourceLocation.DataSource = typeof(AppointmentBook_Exercise7.LOCATION);
            // 
            // listBoxAttendees
            // 
            this.listBoxAttendees.DataSource = this.bindingSourceUser;
            this.listBoxAttendees.DisplayMember = "FirstName";
            this.listBoxAttendees.FormattingEnabled = true;
            this.listBoxAttendees.Location = new System.Drawing.Point(104, 352);
            this.listBoxAttendees.Name = "listBoxAttendees";
            this.listBoxAttendees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAttendees.Size = new System.Drawing.Size(404, 56);
            this.listBoxAttendees.TabIndex = 61;
            this.listBoxAttendees.ValueMember = "Id";
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(AppointmentBook_Exercise7.USER);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(16, 194);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(65, 18);
            this.LocationLabel.TabIndex = 60;
            this.LocationLabel.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Attendees";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(22, 249);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(48, 18);
            this.NotesLabel.TabIndex = 58;
            this.NotesLabel.Text = "Notes ";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(16, 144);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(54, 18);
            this.SubjectLabel.TabIndex = 57;
            this.SubjectLabel.Text = "Subject";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(16, 106);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(71, 18);
            this.EndDateLabel.TabIndex = 56;
            this.EndDateLabel.Text = "End Date";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(16, 72);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(74, 18);
            this.StartDateLabel.TabIndex = 55;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDatePicker.Location = new System.Drawing.Point(104, 106);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(162, 20);
            this.EndDatePicker.TabIndex = 54;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.StartDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDatePicker.Location = new System.Drawing.Point(104, 72);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(162, 20);
            this.StartDatePicker.TabIndex = 53;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesTextBox.Location = new System.Drawing.Point(104, 249);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(404, 82);
            this.NotesTextBox.TabIndex = 52;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectTextBox.Location = new System.Drawing.Point(104, 146);
            this.SubjectTextBox.Multiline = true;
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(404, 23);
            this.SubjectTextBox.TabIndex = 51;
            // 
            // buttonReminder
            // 
            this.buttonReminder.Location = new System.Drawing.Point(134, 12);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(116, 34);
            this.buttonReminder.TabIndex = 63;
            this.buttonReminder.Text = "Add reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "List of appointments organised by me:";
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Location = new System.Drawing.Point(104, 431);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(122, 17);
            this.checkBoxAccept.TabIndex = 65;
            this.checkBoxAccept.Text = "Accept Appointment";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // UserAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 515);
            this.Controls.Add(this.checkBoxAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReminder);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.listBoxAttendees);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.dataGridViewAppointment);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "UserAppointmentForm";
            this.Text = "My Appointments";
            this.Load += new System.EventHandler(this.UserAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ListBox listBoxAttendees;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.BindingSource bindingSourceLocation;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAccept;
    }
}