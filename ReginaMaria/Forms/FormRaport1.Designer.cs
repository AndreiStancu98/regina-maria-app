
namespace ReginaMaria
{
    partial class FormRaport1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(67, 166);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(115, 20);
            this.endDate.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(63, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Start Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(67, 92);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 20);
            this.startDate.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(63, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "End Date";
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(78, 209);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(75, 23);
            this.List.TabIndex = 37;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // FormRaport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRaport1";
            this.Text = "FormRaport1";
            this.Load += new System.EventHandler(this.FormRaport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button List;
    }
}