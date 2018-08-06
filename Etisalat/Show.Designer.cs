namespace Etisalat
{
    partial class Show
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
            this.grid_ShaowData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShaowData)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ShaowData
            // 
            this.grid_ShaowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ShaowData.Location = new System.Drawing.Point(3, 36);
            this.grid_ShaowData.Name = "grid_ShaowData";
            this.grid_ShaowData.Size = new System.Drawing.Size(365, 215);
            this.grid_ShaowData.TabIndex = 0;
            this.grid_ShaowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 409);
            this.Controls.Add(this.grid_ShaowData);
            this.Name = "Show";
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShaowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ShaowData;
    }
}