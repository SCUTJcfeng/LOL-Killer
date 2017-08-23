namespace FindProcess01
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
            this.components = new System.ComponentModel.Container();
            this.btnFind = new System.Windows.Forms.Button();
            this.lvwShowPrs = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrKill = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(331, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "KILL";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lvwShowPrs
            // 
            this.lvwShowPrs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.processID});
            this.lvwShowPrs.Location = new System.Drawing.Point(13, 13);
            this.lvwShowPrs.Name = "lvwShowPrs";
            this.lvwShowPrs.Size = new System.Drawing.Size(312, 316);
            this.lvwShowPrs.TabIndex = 1;
            this.lvwShowPrs.UseCompatibleStateImageBehavior = false;
            this.lvwShowPrs.View = System.Windows.Forms.View.Details;
            this.lvwShowPrs.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwShowPrs_ColumnClick);
            // 
            // processName
            // 
            this.processName.Text = "进程名";
            this.processName.Width = 120;
            // 
            // processID
            // 
            this.processID.Text = "processID";
            this.processID.Width = 120;
            // 
            // tmrKill
            // 
            this.tmrKill.Enabled = true;
            this.tmrKill.Tick += new System.EventHandler(this.tmrKill_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 341);
            this.Controls.Add(this.lvwShowPrs);
            this.Controls.Add(this.btnFind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView lvwShowPrs;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader processID;
        private System.Windows.Forms.Timer tmrKill;
    }
}

