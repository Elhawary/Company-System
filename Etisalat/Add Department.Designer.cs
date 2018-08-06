namespace Etisalat
{
    partial class Add_Department
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
            this.addDepartment = new System.Windows.Forms.Button();
            this.addDeparment = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addDepartment
            // 
            this.addDepartment.BackColor = System.Drawing.Color.Gray;
            this.addDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartment.Location = new System.Drawing.Point(108, 111);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(74, 40);
            this.addDepartment.TabIndex = 0;
            this.addDepartment.Text = "ADD";
            this.addDepartment.UseVisualStyleBackColor = false;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // addDeparment
            // 
            this.addDeparment.AutoSize = true;
            this.addDeparment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeparment.Location = new System.Drawing.Point(23, 66);
            this.addDeparment.Name = "addDeparment";
            this.addDeparment.Size = new System.Drawing.Size(49, 16);
            this.addDeparment.TabIndex = 1;
            this.addDeparment.Text = "Name";
            // 
            // departmentName
            // 
            this.departmentName.Location = new System.Drawing.Point(98, 65);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(161, 20);
            this.departmentName.TabIndex = 2;
            // 
            // Add_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.addDeparment);
            this.Controls.Add(this.addDepartment);
            this.Name = "Add_Department";
            this.Text = "Add_Department";
            this.Load += new System.EventHandler(this.Add_Department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Label addDeparment;
        private System.Windows.Forms.TextBox departmentName;
    }
}