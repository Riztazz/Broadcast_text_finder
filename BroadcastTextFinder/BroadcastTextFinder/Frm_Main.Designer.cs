namespace BroadcastTextFinder
{
    partial class FrmBroadcastTextFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBroadcastTextFinder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_FindLike = new System.Windows.Forms.ToolStripTextBox();
            this.btn_FindLike = new System.Windows.Forms.ToolStripButton();
            this.txt_FindID = new System.Windows.Forms.ToolStripTextBox();
            this.Btn_FindID = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_FindLike,
            this.btn_FindLike,
            this.toolStripSeparator1,
            this.txt_FindID,
            this.Btn_FindID});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(918, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_FindLike
            // 
            this.txt_FindLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FindLike.Name = "txt_FindLike";
            this.txt_FindLike.Size = new System.Drawing.Size(300, 25);
            // 
            // btn_FindLike
            // 
            this.btn_FindLike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_FindLike.Image = ((System.Drawing.Image)(resources.GetObject("btn_FindLike.Image")));
            this.btn_FindLike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FindLike.Name = "btn_FindLike";
            this.btn_FindLike.Size = new System.Drawing.Size(58, 22);
            this.btn_FindLike.Text = "Find Like";
            this.btn_FindLike.Click += new System.EventHandler(this.btn_FindLike_Click);
            // 
            // txt_FindID
            // 
            this.txt_FindID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FindID.Name = "txt_FindID";
            this.txt_FindID.Size = new System.Drawing.Size(100, 25);
            // 
            // Btn_FindID
            // 
            this.Btn_FindID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_FindID.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FindID.Image")));
            this.Btn_FindID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_FindID.Name = "Btn_FindID";
            this.Btn_FindID.Size = new System.Drawing.Size(48, 22);
            this.Btn_FindID.Text = "Find ID";
            this.Btn_FindID.Click += new System.EventHandler(this.Btn_FindID_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(16, 25);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(918, 527);
            this.dgv.TabIndex = 3;
            // 
            // FrmCreatureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 552);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBroadcastTextFinder";
            this.Text = "Broadcast Text Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBroadcastTextFinder_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txt_FindLike;
        private System.Windows.Forms.ToolStripButton btn_FindLike;
        private System.Windows.Forms.ToolStripTextBox txt_FindID;
        private System.Windows.Forms.ToolStripButton Btn_FindID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgv;
    }
}

