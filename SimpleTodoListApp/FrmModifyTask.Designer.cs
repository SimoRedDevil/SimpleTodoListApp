namespace SimpleTodoListApp
{
    partial class FrmModifyTask
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbComplete = new System.Windows.Forms.RadioButton();
            this.btnModifyTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name :";
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaskName.Location = new System.Drawing.Point(116, 12);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(320, 23);
            this.txtTaskName.TabIndex = 2;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaskDescription.Location = new System.Drawing.Point(116, 41);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(320, 23);
            this.txtTaskDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description :";
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cmbTaskType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Items.AddRange(new object[] {
            "Daily Routine",
            "Sports",
            "Job",
            "Education",
            "Shopping",
            "Others"});
            this.cmbTaskType.Location = new System.Drawing.Point(116, 70);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(320, 24);
            this.cmbTaskType.TabIndex = 7;
            this.cmbTaskType.Text = "Daily Routine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status :";
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Location = new System.Drawing.Point(116, 100);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(74, 20);
            this.rbPending.TabIndex = 9;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // rbComplete
            // 
            this.rbComplete.AutoSize = true;
            this.rbComplete.Location = new System.Drawing.Point(196, 100);
            this.rbComplete.Name = "rbComplete";
            this.rbComplete.Size = new System.Drawing.Size(81, 20);
            this.rbComplete.TabIndex = 10;
            this.rbComplete.TabStop = true;
            this.rbComplete.Text = "Complete";
            this.rbComplete.UseVisualStyleBackColor = true;
            // 
            // btnModifyTask
            // 
            this.btnModifyTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnModifyTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyTask.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTask.Location = new System.Drawing.Point(116, 126);
            this.btnModifyTask.Name = "btnModifyTask";
            this.btnModifyTask.Size = new System.Drawing.Size(320, 31);
            this.btnModifyTask.TabIndex = 11;
            this.btnModifyTask.Text = "Modify Task";
            this.btnModifyTask.UseVisualStyleBackColor = true;
            this.btnModifyTask.Click += new System.EventHandler(this.btnModifyTask_Click);
            // 
            // FrmModifyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(447, 168);
            this.Controls.Add(this.btnModifyTask);
            this.Controls.Add(this.rbComplete);
            this.Controls.Add(this.rbPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTaskType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmModifyTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModifyTask";
            this.Load += new System.EventHandler(this.FrmModifyTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbComplete;
        private System.Windows.Forms.Button btnModifyTask;
    }
}