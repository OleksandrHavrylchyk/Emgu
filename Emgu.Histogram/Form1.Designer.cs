
namespace Emgu.Histogram
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.equalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageBox1.Location = new System.Drawing.Point(26, 63);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(446, 428);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(546, 63);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(469, 428);
            this.histogramBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem1,
            this.blueChannelToolStripMenuItem,
            this.greenChannelToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.histogramToolStripMenuItem1.Text = "Red Channel";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.histogramToolStripMenuItem1_Click);
            // 
            // blueChannelToolStripMenuItem
            // 
            this.blueChannelToolStripMenuItem.Name = "blueChannelToolStripMenuItem";
            this.blueChannelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueChannelToolStripMenuItem.Text = "Blue Channel";
            this.blueChannelToolStripMenuItem.Click += new System.EventHandler(this.blueChannelToolStripMenuItem_Click);
            // 
            // greenChannelToolStripMenuItem
            // 
            this.greenChannelToolStripMenuItem.Name = "greenChannelToolStripMenuItem";
            this.greenChannelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenChannelToolStripMenuItem.Text = "Green Channel";
            this.greenChannelToolStripMenuItem.Click += new System.EventHandler(this.greenChannelToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalizationToolStripMenuItem,
            this.normalizationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // equalizationToolStripMenuItem
            // 
            this.equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            this.equalizationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equalizationToolStripMenuItem.Text = "Equalization";
            this.equalizationToolStripMenuItem.Click += new System.EventHandler(this.equalizationToolStripMenuItem_Click);
            // 
            // normalizationToolStripMenuItem
            // 
            this.normalizationToolStripMenuItem.Name = "normalizationToolStripMenuItem";
            this.normalizationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalizationToolStripMenuItem.Text = "Normalization";
            this.normalizationToolStripMenuItem.Click += new System.EventHandler(this.normalizationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 755);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CV.UI.ImageBox imageBox1;
        private CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blueChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizationToolStripMenuItem;
    }
}

