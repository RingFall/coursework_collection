namespace Student_Contacts
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("计算机科学与技术");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("信息安全");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("信息科学与技术");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("专业", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.edit = new System.Windows.Forms.ToolStripButton();
            this.del = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.ToolStripButton();
            this.backup = new System.Windows.Forms.ToolStripButton();
            this.recover = new System.Windows.Forms.ToolStripButton();
            this.update = new System.Windows.Forms.ToolStripButton();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.ts1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // ts1
            // 
            this.ts1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ts1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ts1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.edit,
            this.del,
            this.search,
            this.backup,
            this.recover,
            this.update});
            this.ts1.Location = new System.Drawing.Point(0, 0);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts1.Size = new System.Drawing.Size(982, 91);
            this.ts1.TabIndex = 0;
            this.ts1.Text = "工具栏";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(70, 88);
            this.add.Text = "ADD";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 88);
            this.edit.Text = "EDIT";
            this.edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold);
            this.del.ForeColor = System.Drawing.Color.Black;
            this.del.Image = ((System.Drawing.Image)(resources.GetObject("del.Image")));
            this.del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(111, 88);
            this.del.Text = "DELETE";
            this.del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(118, 88);
            this.search.Text = "SEARCH";
            this.search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // backup
            // 
            this.backup.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.Image = ((System.Drawing.Image)(resources.GetObject("backup.Image")));
            this.backup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(118, 88);
            this.backup.Text = "BACKUP";
            this.backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // recover
            // 
            this.recover.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recover.Image = ((System.Drawing.Image)(resources.GetObject("recover.Image")));
            this.recover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(133, 88);
            this.recover.Text = "RESTORE";
            this.recover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 88);
            this.update.Text = "REFRESH";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv1.Location = new System.Drawing.Point(251, 91);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(731, 466);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 91);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "计算机科学与技术";
            treeNode1.Text = "计算机科学与技术";
            treeNode2.Name = "信息安全";
            treeNode2.Text = "信息安全";
            treeNode3.Name = "信息科学与技术";
            treeNode3.Text = "信息科学与技术";
            treeNode4.Name = "major";
            treeNode4.Text = "专业";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(243, 466);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(884, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ringfall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.ts1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Students Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton add;
        private System.Windows.Forms.ToolStripButton edit;
        private System.Windows.Forms.ToolStripButton del;
        private System.Windows.Forms.ToolStripButton search;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripButton update;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton backup;
        private System.Windows.Forms.ToolStripButton recover;
        private System.Windows.Forms.Label label1;
    }
}

