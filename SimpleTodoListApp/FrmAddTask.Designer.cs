namespace SimpleTodoListApp
{
    partial class FrmAddTask
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
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
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
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaskDescription.Location = new System.Drawing.Point(116, 41);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(320, 23);
            this.txtTaskDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type :";
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
            this.cmbTaskType.TabIndex = 5;
            this.cmbTaskType.Text = "Daily Routine";
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(116, 100);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(320, 31);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTaskName.Location = new System.Drawing.Point(116, 12);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(320, 23);
            this.txtTaskName.TabIndex = 1;
            // 
            // FrmAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(447, 143);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cmbTaskType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTaskName;
    }
}