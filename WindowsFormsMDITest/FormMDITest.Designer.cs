
namespace WindowsFormsMDITest
{
    partial class FormMDITest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFormToolStripMenuItem,
            this.addRelationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFormToolStripMenuItem
            // 
            this.addFormToolStripMenuItem.Name = "addFormToolStripMenuItem";
            this.addFormToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.addFormToolStripMenuItem.Text = "Add Form";
            this.addFormToolStripMenuItem.Click += new System.EventHandler(this.addFormToolStripMenuItem_Click);
            // 
            // addRelationToolStripMenuItem
            // 
            this.addRelationToolStripMenuItem.Name = "addRelationToolStripMenuItem";
            this.addRelationToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.addRelationToolStripMenuItem.Text = "Add Relation";
            this.addRelationToolStripMenuItem.Click += new System.EventHandler(this.addRelationToolStripMenuItem_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(1138, 869);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "";
            this.lineShape1.X1 = 481;
            this.lineShape1.X2 = 406;
            this.lineShape1.Y1 = 14;
            this.lineShape1.Y2 = -9;
            // 
            // FormMDITest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 869);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDITest";
            this.Text = "MDI Form Relation Sample";
            this.MdiChildActivate += new System.EventHandler(this.ParentForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRelationToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

