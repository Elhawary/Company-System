namespace Etisalat
{
    partial class addEmployee
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
            this.employeeName = new System.Windows.Forms.Label();
            this.employeePhone = new System.Windows.Forms.Label();
            this.employeeAddress = new System.Windows.Forms.Label();
            this.Potion = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Label();
            this.com_department = new System.Windows.Forms.ComboBox();
            this.com_positions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.BackColor = System.Drawing.Color.White;
            this.employeeName.Location = new System.Drawing.Point(48, 19);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(35, 13);
            this.employeeName.TabIndex = 0;
            this.employeeName.Text = "Name";
            // 
            // employeePhone
            // 
            this.employeePhone.AutoSize = true;
            this.employeePhone.BackColor = System.Drawing.Color.White;
            this.employeePhone.Location = new System.Drawing.Point(47, 115);
            this.employeePhone.Name = "employeePhone";
            this.employeePhone.Size = new System.Drawing.Size(38, 13);
            this.employeePhone.TabIndex = 1;
            this.employeePhone.Text = "Phone";
            // 
            // employeeAddress
            // 
            this.employeeAddress.AutoSize = true;
            this.employeeAddress.BackColor = System.Drawing.Color.White;
            this.employeeAddress.Location = new System.Drawing.Point(40, 67);
            this.employeeAddress.Name = "employeeAddress";
            this.employeeAddress.Size = new System.Drawing.Size(45, 13);
            this.employeeAddress.TabIndex = 2;
            this.employeeAddress.Text = "Address";
            // 
            // Potion
            // 
            this.Potion.AutoSize = true;
            this.Potion.BackColor = System.Drawing.Color.White;
            this.Potion.Location = new System.Drawing.Point(41, 242);
            this.Potion.Name = "Potion";
            this.Potion.Size = new System.Drawing.Size(42, 13);
            this.Potion.TabIndex = 5;
            this.Potion.Text = "Postion";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(191, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(430, 20);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(191, 115);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(430, 20);
            this.txt_phone.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(191, 67);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(430, 20);
            this.txt_address.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.Color.White;
            this.Department.Location = new System.Drawing.Point(23, 182);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(62, 13);
            this.Department.TabIndex = 17;
            this.Department.Text = "Department";
            // 
            // com_department
            // 
            this.com_department.FormattingEnabled = true;
            this.com_department.Location = new System.Drawing.Point(191, 182);
            this.com_department.Name = "com_department";
            this.com_department.Size = new System.Drawing.Size(144, 21);
            this.com_department.TabIndex = 18;
            // 
            // com_positions
            // 
            this.com_positions.FormattingEnabled = true;
            this.com_positions.Items.AddRange(new object[] {
            "Junior",
            "Senior"});
            this.com_positions.Location = new System.Drawing.Point(191, 242);
            this.com_positions.Name = "com_positions";
            this.com_positions.Size = new System.Drawing.Size(144, 21);
            this.com_positions.TabIndex = 19;
            this.com_positions.SelectedIndexChanged += new System.EventHandler(this.com_position_SelectedIndexChanged);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(942, 518);
            this.Controls.Add(this.com_positions);
            this.Controls.Add(this.com_department);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Potion);
            this.Controls.Add(this.employeeAddress);
            this.Controls.Add(this.employeePhone);
            this.Controls.Add(this.employeeName);
            this.Name = "addEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label employeePhone;
        private System.Windows.Forms.Label employeeAddress;
        private System.Windows.Forms.Label Potion;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.ComboBox com_department;
        private System.Windows.Forms.ComboBox com_positions;
    }
}

