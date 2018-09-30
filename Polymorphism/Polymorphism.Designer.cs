namespace Polymorphism
{
    partial class Polymorphism
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_CurYear = new System.Windows.Forms.TextBox();
            this.TB_ProdYear = new System.Windows.Forms.TextBox();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.TB_Cost = new System.Windows.Forms.TextBox();
            this.But_Show_1 = new System.Windows.Forms.Button();
            this.But_Show_2 = new System.Windows.Forms.Button();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.But_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(12, 44);
            this.TB_Name.Multiline = true;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 23);
            this.TB_Name.TabIndex = 0;
            // 
            // TB_CurYear
            // 
            this.TB_CurYear.Location = new System.Drawing.Point(436, 44);
            this.TB_CurYear.Multiline = true;
            this.TB_CurYear.Name = "TB_CurYear";
            this.TB_CurYear.Size = new System.Drawing.Size(100, 23);
            this.TB_CurYear.TabIndex = 1;
            // 
            // TB_ProdYear
            // 
            this.TB_ProdYear.Location = new System.Drawing.Point(330, 44);
            this.TB_ProdYear.Multiline = true;
            this.TB_ProdYear.Name = "TB_ProdYear";
            this.TB_ProdYear.Size = new System.Drawing.Size(100, 23);
            this.TB_ProdYear.TabIndex = 2;
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(224, 44);
            this.TB_Count.Multiline = true;
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(100, 23);
            this.TB_Count.TabIndex = 3;
            // 
            // TB_Cost
            // 
            this.TB_Cost.Location = new System.Drawing.Point(118, 44);
            this.TB_Cost.Multiline = true;
            this.TB_Cost.Name = "TB_Cost";
            this.TB_Cost.Size = new System.Drawing.Size(100, 23);
            this.TB_Cost.TabIndex = 4;
            // 
            // But_Show_1
            // 
            this.But_Show_1.Location = new System.Drawing.Point(12, 73);
            this.But_Show_1.Name = "But_Show_1";
            this.But_Show_1.Size = new System.Drawing.Size(100, 23);
            this.But_Show_1.TabIndex = 5;
            this.But_Show_1.Text = "Show 1 class";
            this.But_Show_1.UseVisualStyleBackColor = true;
            this.But_Show_1.Click += new System.EventHandler(this.But_Show_1_Click);
            // 
            // But_Show_2
            // 
            this.But_Show_2.Location = new System.Drawing.Point(118, 74);
            this.But_Show_2.Name = "But_Show_2";
            this.But_Show_2.Size = new System.Drawing.Size(100, 23);
            this.But_Show_2.TabIndex = 6;
            this.But_Show_2.Text = "Show 2 class";
            this.But_Show_2.UseVisualStyleBackColor = true;
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(12, 102);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(206, 163);
            this.TB_Result.TabIndex = 7;
            // 
            // But_Add
            // 
            this.But_Add.Location = new System.Drawing.Point(436, 74);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(100, 23);
            this.But_Add.TabIndex = 8;
            this.But_Add.Text = "Add";
            this.But_Add.UseVisualStyleBackColor = true;
            this.But_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Production year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cost";
            // 
            // Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_Add);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.But_Show_2);
            this.Controls.Add(this.But_Show_1);
            this.Controls.Add(this.TB_Cost);
            this.Controls.Add(this.TB_Count);
            this.Controls.Add(this.TB_ProdYear);
            this.Controls.Add(this.TB_CurYear);
            this.Controls.Add(this.TB_Name);
            this.Name = "Polymorphism";
            this.Text = "Polymorphism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_CurYear;
        private System.Windows.Forms.TextBox TB_ProdYear;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.TextBox TB_Cost;
        private System.Windows.Forms.Button But_Show_1;
        private System.Windows.Forms.Button But_Show_2;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Button But_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

