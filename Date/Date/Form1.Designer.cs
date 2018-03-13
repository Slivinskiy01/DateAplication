namespace Date
{
    partial class Form1
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
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.yRes = new System.Windows.Forms.TextBox();
            this.mRes = new System.Windows.Forms.TextBox();
            this.dRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(51, 31);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 20);
            this.day.TabIndex = 0;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(173, 31);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 20);
            this.month.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(294, 31);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "День";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(319, 162);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 23);
            this.Result.TabIndex = 6;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // yRes
            // 
            this.yRes.Enabled = false;
            this.yRes.Location = new System.Drawing.Point(294, 74);
            this.yRes.Name = "yRes";
            this.yRes.Size = new System.Drawing.Size(100, 20);
            this.yRes.TabIndex = 9;
            // 
            // mRes
            // 
            this.mRes.Enabled = false;
            this.mRes.Location = new System.Drawing.Point(173, 74);
            this.mRes.Name = "mRes";
            this.mRes.Size = new System.Drawing.Size(100, 20);
            this.mRes.TabIndex = 8;
            // 
            // dRes
            // 
            this.dRes.Enabled = false;
            this.dRes.Location = new System.Drawing.Point(51, 74);
            this.dRes.Name = "dRes";
            this.dRes.Size = new System.Drawing.Size(100, 20);
            this.dRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.yRes);
            this.Controls.Add(this.mRes);
            this.Controls.Add(this.dRes);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DateApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.TextBox yRes;
        private System.Windows.Forms.TextBox mRes;
        private System.Windows.Forms.TextBox dRes;
    }
}

