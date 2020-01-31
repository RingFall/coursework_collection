namespace Student_Contacts
{
    partial class Form_search
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
            this.b_search = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(522, 20);
            this.b_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(112, 34);
            this.b_search.TabIndex = 0;
            this.b_search.Text = "查找";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(662, 20);
            this.b_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(112, 34);
            this.b_close.TabIndex = 1;
            this.b_close.Text = "关闭";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 28);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学号",
            "姓名"});
            this.comboBox1.Location = new System.Drawing.Point(139, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "查找学生";
            // 
            // sdgv
            // 
            this.sdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgv.Location = new System.Drawing.Point(-2, 78);
            this.sdgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdgv.Name = "sdgv";
            this.sdgv.RowTemplate.Height = 23;
            this.sdgv.Size = new System.Drawing.Size(878, 465);
            this.sdgv.TabIndex = 5;
            this.sdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgv_CellContentClick);
            // 
            // Form_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 542);
            this.Controls.Add(this.sdgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_search);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_search";
            this.Text = "Form_search";
            this.Load += new System.EventHandler(this.Form_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sdgv;
    }
}