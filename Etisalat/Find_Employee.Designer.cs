namespace Etisalat
{
    partial class Find_Employee
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
            this.find = new System.Windows.Forms.Button();
            this.employeeID = new System.Windows.Forms.Label();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.lb_error = new System.Windows.Forms.Label();
            this.find_gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.find_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.Gray;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(311, 9);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(88, 26);
            this.find.TabIndex = 0;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Location = new System.Drawing.Point(1, 12);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(98, 13);
            this.employeeID.TabIndex = 1;
            this.employeeID.Text = "Enter Employee ID ";
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Location = new System.Drawing.Point(105, 9);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(145, 20);
            this.txt_employeeID.TabIndex = 4;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(256, 11);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(17, 24);
            this.lb_error.TabIndex = 6;
            this.lb_error.Text = "*";
            // 
            // find_gridView
            // 
            this.find_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.find_gridView.Location = new System.Drawing.Point(4, 85);
            this.find_gridView.Name = "find_gridView";
            this.find_gridView.Size = new System.Drawing.Size(891, 190);
            this.find_gridView.TabIndex = 5;
            this.find_gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.find_gridView_CellContentClick);
            // 
            // Find_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 312);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.find_gridView);
            this.Controls.Add(this.txt_employeeID);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.find);
            this.Name = "Find_Employee";
            this.Text = "Find_Employee";
            this.Load += new System.EventHandler(this.Find_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.find_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.DataGridView find_gridView;
    }
}