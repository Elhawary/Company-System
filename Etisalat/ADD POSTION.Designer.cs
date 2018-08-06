namespace Etisalat
{
    partial class ADD_POSTION
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
            this.AddPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_depart = new System.Windows.Forms.ComboBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPosition
            // 
            this.AddPosition.BackColor = System.Drawing.Color.Gray;
            this.AddPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPosition.Location = new System.Drawing.Point(128, 150);
            this.AddPosition.Name = "AddPosition";
            this.AddPosition.Size = new System.Drawing.Size(80, 38);
            this.AddPosition.TabIndex = 0;
            this.AddPosition.Text = "Add";
            this.AddPosition.UseVisualStyleBackColor = false;
            this.AddPosition.Click += new System.EventHandler(this.AddPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "salary";
            // 
            // com_depart
            // 
            this.com_depart.FormattingEnabled = true;
            this.com_depart.Location = new System.Drawing.Point(105, 93);
            this.com_depart.Name = "com_depart";
            this.com_depart.Size = new System.Drawing.Size(145, 21);
            this.com_depart.TabIndex = 21;
            this.com_depart.SelectedIndexChanged += new System.EventHandler(this.com_depart_SelectedIndexChanged);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(105, 54);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(145, 20);
            this.txt_salary.TabIndex = 20;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(105, 19);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(145, 20);
            this.txt_position.TabIndex = 19;
            // 
            // ADD_POSTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(388, 336);
            this.Controls.Add(this.com_depart);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPosition);
            this.Name = "ADD_POSTION";
            this.Text = "ADD_POSTION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_depart;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_position;
    }
}