
namespace ReginaMaria
{
    partial class FormPrescriptions
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
            this.loadPrescription = new System.Windows.Forms.Button();
            this.deletePrescription = new System.Windows.Forms.Button();
            this.updatePrescription = new System.Windows.Forms.Button();
            this.prescriptionID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addPrescription = new System.Windows.Forms.Button();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.number = new System.Windows.Forms.TextBox();
            this.series = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPrescription
            // 
            this.loadPrescription.Location = new System.Drawing.Point(212, 145);
            this.loadPrescription.Name = "loadPrescription";
            this.loadPrescription.Size = new System.Drawing.Size(98, 23);
            this.loadPrescription.TabIndex = 23;
            this.loadPrescription.Text = "Load Prescription";
            this.loadPrescription.UseVisualStyleBackColor = true;
            // 
            // deletePrescription
            // 
            this.deletePrescription.Location = new System.Drawing.Point(201, 174);
            this.deletePrescription.Name = "deletePrescription";
            this.deletePrescription.Size = new System.Drawing.Size(109, 23);
            this.deletePrescription.TabIndex = 22;
            this.deletePrescription.Text = "Delete Prescription";
            this.deletePrescription.UseVisualStyleBackColor = true;
            // 
            // updatePrescription
            // 
            this.updatePrescription.Location = new System.Drawing.Point(201, 116);
            this.updatePrescription.Name = "updatePrescription";
            this.updatePrescription.Size = new System.Drawing.Size(109, 23);
            this.updatePrescription.TabIndex = 21;
            this.updatePrescription.Text = "Update Prescription";
            this.updatePrescription.UseVisualStyleBackColor = true;
            this.updatePrescription.Click += new System.EventHandler(this.updatePrescription_Click);
            // 
            // prescriptionID
            // 
            this.prescriptionID.Location = new System.Drawing.Point(64, 32);
            this.prescriptionID.Name = "prescriptionID";
            this.prescriptionID.Size = new System.Drawing.Size(100, 20);
            this.prescriptionID.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 258);
            this.dataGridView1.TabIndex = 19;
            // 
            // addPrescription
            // 
            this.addPrescription.Location = new System.Drawing.Point(212, 82);
            this.addPrescription.Name = "addPrescription";
            this.addPrescription.Size = new System.Drawing.Size(98, 23);
            this.addPrescription.TabIndex = 18;
            this.addPrescription.Text = "Add Prescription";
            this.addPrescription.UseVisualStyleBackColor = true;
            this.addPrescription.Click += new System.EventHandler(this.addPrescription_Click);
            // 
            // releaseDate
            // 
            this.releaseDate.Location = new System.Drawing.Point(64, 197);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(115, 20);
            this.releaseDate.TabIndex = 17;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(64, 139);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 16;
            // 
            // series
            // 
            this.series.Location = new System.Drawing.Point(64, 82);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(100, 20);
            this.series.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(61, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Release Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(61, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(61, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prescription ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(61, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Patient ID";
            // 
            // patientID
            // 
            this.patientID.Location = new System.Drawing.Point(64, 258);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(100, 20);
            this.patientID.TabIndex = 25;
            // 
            // FormPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadPrescription);
            this.Controls.Add(this.deletePrescription);
            this.Controls.Add(this.updatePrescription);
            this.Controls.Add(this.prescriptionID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addPrescription);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.number);
            this.Controls.Add(this.series);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPrescriptions";
            this.Text = "Prescriptions";
            this.Load += new System.EventHandler(this.FormPrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadPrescription;
        private System.Windows.Forms.Button deletePrescription;
        private System.Windows.Forms.Button updatePrescription;
        private System.Windows.Forms.TextBox prescriptionID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPrescription;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox series;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientID;
    }
}