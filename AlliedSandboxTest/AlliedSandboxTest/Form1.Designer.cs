namespace AlliedSandboxTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Source = new System.Windows.Forms.ToolStripStatusLabel();
            this.suitsSource = new System.Windows.Forms.ToolStripTextBox();
            this.Reload = new System.Windows.Forms.ToolStripButton();
            this.tests = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.runRequest = new System.Windows.Forms.ToolStripButton();
            this.cases = new System.Windows.Forms.TreeView();
            this.casesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.response = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.casesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.tests);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(992, 269);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Source,
            this.suitsSource,
            this.Reload});
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(219, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Source
            // 
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(44, 17);
            this.Source.Text = "Source:";
            // 
            // suitsSource
            // 
            this.suitsSource.Name = "suitsSource";
            this.suitsSource.Size = new System.Drawing.Size(100, 22);
            this.suitsSource.Text = "testdata.xml";
            // 
            // Reload
            // 
            this.Reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Reload.Image = ((System.Drawing.Image)(resources.GetObject("Reload.Image")));
            this.Reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(44, 20);
            this.Reload.Text = "Reload";
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // tests
            // 
            this.tests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tests.FormattingEnabled = true;
            this.tests.Location = new System.Drawing.Point(0, 0);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(219, 269);
            this.tests.TabIndex = 2;
            this.tests.SelectedIndexChanged += new System.EventHandler(this.tests_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip2);
            this.splitContainer2.Panel1.Controls.Add(this.cases);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.response);
            this.splitContainer2.Size = new System.Drawing.Size(769, 269);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runRequest});
            this.statusStrip2.Location = new System.Drawing.Point(0, 247);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(400, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // runRequest
            // 
            this.runRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runRequest.Image = ((System.Drawing.Image)(resources.GetObject("runRequest.Image")));
            this.runRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runRequest.Name = "runRequest";
            this.runRequest.Size = new System.Drawing.Size(128, 20);
            this.runRequest.Text = "Run All Cases in this Suit";
            this.runRequest.Click += new System.EventHandler(this.runRequest_Click);
            // 
            // cases
            // 
            this.cases.ContextMenuStrip = this.casesMenu;
            this.cases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cases.HideSelection = false;
            this.cases.Location = new System.Drawing.Point(0, 0);
            this.cases.Name = "cases";
            this.cases.Size = new System.Drawing.Size(400, 269);
            this.cases.TabIndex = 1;
            this.cases.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cases_AfterSelect);
            // 
            // casesMenu
            // 
            this.casesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.casesMenu.Name = "casesMenu";
            this.casesMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // response
            // 
            this.response.Dock = System.Windows.Forms.DockStyle.Fill;
            this.response.Location = new System.Drawing.Point(0, 0);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(365, 269);
            this.response.TabIndex = 0;
            this.response.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.response_NodeMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 269);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "AlliedTesting SANDBOX Testing Tool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.casesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox tests;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView cases;
        private System.Windows.Forms.TreeView response;
        private System.Windows.Forms.ContextMenuStrip casesMenu;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Source;
        private System.Windows.Forms.ToolStripTextBox suitsSource;
        private System.Windows.Forms.ToolStripButton Reload;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripButton runRequest;
    }
}

