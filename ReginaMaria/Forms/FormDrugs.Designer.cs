
namespace ReginaMaria
{
    partial class FormDrugs
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
            this.label5 = new System.Windows.Forms.Label();
            this.prescriptionID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteDrug = new System.Windows.Forms.Button();
            this.updateDrugs = new System.Windows.Forms.Button();
            this.drugID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addDrugs = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.drugName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dosage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(17, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Prescription ID";
            // 
            // prescriptionID
            // 
            this.prescriptionID.Location = new System.Drawing.Point(20, 268);
            this.prescriptionID.Name = "prescriptionID";
            this.prescriptionID.Size = new System.Drawing.Size(100, 20);
            this.prescriptionID.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Drug ID";
            // 
            // deleteDrug
            // 
            this.deleteDrug.Location = new System.Drawing.Point(157, 155);
            this.deleteDrug.Name = "deleteDrug";
            this.deleteDrug.Size = new System.Drawing.Size(109, 23);
            this.deleteDrug.TabIndex = 37;
            this.deleteDrug.Text = "Delete Drug";
            this.deleteDrug.UseVisualStyleBackColor = true;
            // 
            // updateDrugs
            // 
            this.updateDrugs.Location = new System.Drawing.Point(157, 126);
            this.updateDrugs.Name = "updateDrugs";
            this.updateDrugs.Size = new System.Drawing.Size(109, 23);
            this.updateDrugs.TabIndex = 36;
            this.updateDrugs.Text = "Update Drugs";
            this.updateDrugs.UseVisualStyleBackColor = true;
            // 
            // drugID
            // 
            this.drugID.Location = new System.Drawing.Point(20, 42);
            this.drugID.Name = "drugID";
            this.drugID.Size = new System.Drawing.Size(100, 20);
            this.drugID.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 291);
            this.dataGridView1.TabIndex = 34;
            // 
            // addDrugs
            // 
            this.addDrugs.Location = new System.Drawing.Point(168, 92);
            this.addDrugs.Name = "addDrugs";
            this.addDrugs.Size = new System.Drawing.Size(98, 23);
            this.addDrugs.TabIndex = 33;
            this.addDrugs.Text = "Add Drugs";
            this.addDrugs.UseVisualStyleBackColor = true;
            this.addDrugs.Click += new System.EventHandler(this.addDrugs_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(20, 149);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 31;
            // 
            // drugName
            // 
            this.drugName.Location = new System.Drawing.Point(20, 92);
            this.drugName.Name = "drugName";
            this.drugName.Size = new System.Drawing.Size(100, 20);
            this.drugName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(17, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Dosage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(17, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Drug Name";
            // 
            // dosage
            // 
            this.dosage.Location = new System.Drawing.Point(20, 207);
            this.dosage.Name = "dosage";
            this.dosage.Size = new System.Drawing.Size(100, 20);
            this.dosage.TabIndex = 41;
            // 
            // FormDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(937, 533);
            this.Controls.Add(this.dosage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prescriptionID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteDrug);
            this.Controls.Add(this.updateDrugs);
            this.Controls.Add(this.drugID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addDrugs);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.drugName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDrugs";
            this.Text = "Drugs";
            this.Load += new System.EventHandler(this.FormDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prescriptionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteDrug;
        private System.Windows.Forms.Button updateDrugs;
        private System.Windows.Forms.TextBox drugID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addDrugs;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox drugName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dosage;
    }
}