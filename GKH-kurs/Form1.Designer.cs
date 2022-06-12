namespace GKH_kurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Save = new System.Windows.Forms.Button();
            this.HouseGrid = new System.Windows.Forms.DataGridView();
            this.ApartGrip = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddHouse = new System.Windows.Forms.Button();
            this.DeleteHouse = new System.Windows.Forms.Button();
            this.HouseNum = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApartNum = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.TextBox();
            this.DelApar = new System.Windows.Forms.Button();
            this.AddApar = new System.Windows.Forms.Button();
            this.Load1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HouseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartGrip)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 340);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(346, 28);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // HouseGrid
            // 
            this.HouseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HouseGrid.Location = new System.Drawing.Point(12, 36);
            this.HouseGrid.Name = "HouseGrid";
            this.HouseGrid.RowTemplate.Height = 25;
            this.HouseGrid.Size = new System.Drawing.Size(346, 298);
            this.HouseGrid.TabIndex = 1;
            this.HouseGrid.Click += new System.EventHandler(this.HouseGrid_Click);
            // 
            // ApartGrip
            // 
            this.ApartGrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApartGrip.Location = new System.Drawing.Point(364, 36);
            this.ApartGrip.Name = "ApartGrip";
            this.ApartGrip.RowTemplate.Height = 25;
            this.ApartGrip.Size = new System.Drawing.Size(346, 298);
            this.ApartGrip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(491, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Квартиры";
            // 
            // AddHouse
            // 
            this.AddHouse.Location = new System.Drawing.Point(12, 432);
            this.AddHouse.Name = "AddHouse";
            this.AddHouse.Size = new System.Drawing.Size(164, 30);
            this.AddHouse.TabIndex = 5;
            this.AddHouse.Text = "Добавить дом";
            this.AddHouse.UseVisualStyleBackColor = true;
            this.AddHouse.Click += new System.EventHandler(this.AddHouse_Click);
            // 
            // DeleteHouse
            // 
            this.DeleteHouse.Location = new System.Drawing.Point(182, 432);
            this.DeleteHouse.Name = "DeleteHouse";
            this.DeleteHouse.Size = new System.Drawing.Size(176, 30);
            this.DeleteHouse.TabIndex = 6;
            this.DeleteHouse.Text = "Удалить дом";
            this.DeleteHouse.UseVisualStyleBackColor = true;
            this.DeleteHouse.Click += new System.EventHandler(this.DeleteHouse_Click);
            // 
            // HouseNum
            // 
            this.HouseNum.Location = new System.Drawing.Point(63, 403);
            this.HouseNum.Name = "HouseNum";
            this.HouseNum.Size = new System.Drawing.Size(295, 23);
            this.HouseNum.TabIndex = 7;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(63, 374);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(295, 23);
            this.Street.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Улица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Оплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер";
            // 
            // ApartNum
            // 
            this.ApartNum.Location = new System.Drawing.Point(417, 374);
            this.ApartNum.Name = "ApartNum";
            this.ApartNum.Size = new System.Drawing.Size(290, 23);
            this.ApartNum.TabIndex = 12;
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(417, 403);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(290, 23);
            this.Payment.TabIndex = 11;
            // 
            // DelApar
            // 
            this.DelApar.Location = new System.Drawing.Point(534, 432);
            this.DelApar.Name = "DelApar";
            this.DelApar.Size = new System.Drawing.Size(176, 30);
            this.DelApar.TabIndex = 16;
            this.DelApar.Text = "Удалить квартиру";
            this.DelApar.UseVisualStyleBackColor = true;
            this.DelApar.Click += new System.EventHandler(this.DelApar_Click);
            // 
            // AddApar
            // 
            this.AddApar.Location = new System.Drawing.Point(364, 432);
            this.AddApar.Name = "AddApar";
            this.AddApar.Size = new System.Drawing.Size(164, 30);
            this.AddApar.TabIndex = 15;
            this.AddApar.Text = "Добавить квартиру";
            this.AddApar.UseVisualStyleBackColor = true;
            this.AddApar.Click += new System.EventHandler(this.AddApar_Click);
            // 
            // Load1
            // 
            this.Load1.Location = new System.Drawing.Point(364, 340);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(346, 28);
            this.Load1.TabIndex = 17;
            this.Load1.Text = "Загрузить";
            this.Load1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 470);
            this.Controls.Add(this.Load1);
            this.Controls.Add(this.DelApar);
            this.Controls.Add(this.AddApar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ApartNum);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.HouseNum);
            this.Controls.Add(this.DeleteHouse);
            this.Controls.Add(this.AddHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApartGrip);
            this.Controls.Add(this.HouseGrid);
            this.Controls.Add(this.Save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartGrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView HouseGrid;
        private System.Windows.Forms.DataGridView ApartGrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddHouse;
        private System.Windows.Forms.Button DeleteHouse;
        private System.Windows.Forms.TextBox HouseNum;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ApartNum;
        private System.Windows.Forms.TextBox Payment;
        private System.Windows.Forms.Button DelApar;
        private System.Windows.Forms.Button AddApar;
        private System.Windows.Forms.Button Load1;
    }
}
