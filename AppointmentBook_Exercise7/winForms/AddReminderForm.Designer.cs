namespace AppointmentBook_Exercise7.winForms
{
    partial class AddReminderForm
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
            this.comboBoxReminderTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSnooze = new System.Windows.Forms.ComboBox();
            this.checkBoxHasSound = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxReminderTime
            // 
            this.comboBoxReminderTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReminderTime.FormattingEnabled = true;
            this.comboBoxReminderTime.Location = new System.Drawing.Point(114, 19);
            this.comboBoxReminderTime.Name = "comboBoxReminderTime";
            this.comboBoxReminderTime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReminderTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reminder Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Snooze";
            // 
            // comboBoxSnooze
            // 
            this.comboBoxSnooze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSnooze.FormattingEnabled = true;
            this.comboBoxSnooze.Location = new System.Drawing.Point(114, 58);
            this.comboBoxSnooze.Name = "comboBoxSnooze";
            this.comboBoxSnooze.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSnooze.TabIndex = 2;
            // 
            // checkBoxHasSound
            // 
            this.checkBoxHasSound.AutoSize = true;
            this.checkBoxHasSound.Location = new System.Drawing.Point(114, 97);
            this.checkBoxHasSound.Name = "checkBoxHasSound";
            this.checkBoxHasSound.Size = new System.Drawing.Size(79, 17);
            this.checkBoxHasSound.TabIndex = 4;
            this.checkBoxHasSound.Text = "Has Sound";
            this.checkBoxHasSound.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(114, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxHasSound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSnooze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxReminderTime);
            this.Name = "AddReminderForm";
            this.Text = "Add Reminder";
            this.Load += new System.EventHandler(this.AddReminderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReminderTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSnooze;
        private System.Windows.Forms.CheckBox checkBoxHasSound;
        private System.Windows.Forms.Button buttonSave;
    }
}