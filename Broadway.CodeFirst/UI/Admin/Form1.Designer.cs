﻿
namespace Broadway.CodeFirst
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelClassTeacher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxClass = new System.Windows.Forms.ComboBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelId = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.GridStudent = new System.Windows.Forms.DataGridView();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TextConfirmPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextPassword);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.TextUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LabelClassTeacher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BoxClass);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Controls.Add(this.LabelId);
            this.groupBox1.Controls.Add(this.ButtonCreate);
            this.groupBox1.Controls.Add(this.TextAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonEdit);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(740, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // LabelClassTeacher
            // 
            this.LabelClassTeacher.AutoSize = true;
            this.LabelClassTeacher.Location = new System.Drawing.Point(20, 142);
            this.LabelClassTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelClassTeacher.Name = "LabelClassTeacher";
            this.LabelClassTeacher.Size = new System.Drawing.Size(75, 13);
            this.LabelClassTeacher.TabIndex = 12;
            this.LabelClassTeacher.Text = "Class Teacher";
            this.LabelClassTeacher.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class";
            // 
            // BoxClass
            // 
            this.BoxClass.FormattingEnabled = true;
            this.BoxClass.Location = new System.Drawing.Point(581, 32);
            this.BoxClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxClass.Name = "BoxClass";
            this.BoxClass.Size = new System.Drawing.Size(140, 21);
            this.BoxClass.TabIndex = 10;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(512, 107);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(98, 35);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Visible = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(52, 15);
            this.LabelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(0, 13);
            this.LabelId.TabIndex = 7;
            this.LabelId.Visible = false;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(623, 107);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(98, 35);
            this.ButtonCreate.TabIndex = 6;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(326, 32);
            this.TextAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(140, 20);
            this.TextAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(91, 32);
            this.TextName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(140, 20);
            this.TextName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(623, 106);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(98, 35);
            this.ButtonEdit.TabIndex = 9;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Visible = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // GridStudent
            // 
            this.GridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudent.Location = new System.Drawing.Point(20, 226);
            this.GridStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridStudent.Name = "GridStudent";
            this.GridStudent.RowHeadersWidth = 51;
            this.GridStudent.RowTemplate.Height = 24;
            this.GridStudent.Size = new System.Drawing.Size(736, 228);
            this.GridStudent.TabIndex = 1;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(326, 65);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(140, 20);
            this.TextPassword.TabIndex = 16;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(255, 68);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(42, 10);
            this.Password.TabIndex = 15;
            this.Password.Text = "Password";
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(91, 65);
            this.TextUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(140, 20);
            this.TextUserName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 10);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username";
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.Location = new System.Drawing.Point(581, 65);
            this.TextConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.PasswordChar = '*';
            this.TextConfirmPassword.Size = new System.Drawing.Size(140, 20);
            this.TextConfirmPassword.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 10);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm Password";
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(91, 104);
            this.TextEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(140, 20);
            this.TextEmail.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 10);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 483);
            this.Controls.Add(this.GridStudent);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridStudent;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxClass;
        private System.Windows.Forms.Label LabelClassTeacher;
        private System.Windows.Forms.TextBox TextConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Label label6;
    }
}

