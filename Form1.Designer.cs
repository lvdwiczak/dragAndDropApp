namespace jlDragAndDropApp
{
    partial class dragDropApp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Capital = new System.Windows.Forms.ListBox();
            this.Country = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.Capital);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Country);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // Capital
            // 
            this.Capital.AllowDrop = true;
            this.Capital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Capital.FormattingEnabled = true;
            this.Capital.Items.AddRange(new object[] {
            "Warsaw",
            "Berlin",
            "Paris",
            "London",
            "Roma",
            "Praha",
            "Budapest",
            "Vienna",
            "Athens",
            "Reykjavik"});
            this.Capital.Location = new System.Drawing.Point(0, 0);
            this.Capital.Name = "Capital";
            this.Capital.Size = new System.Drawing.Size(400, 450);
            this.Capital.TabIndex = 0;
            this.Capital.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop_DragDrop);
            this.Capital.DragOver += new System.Windows.Forms.DragEventHandler(this.DragDrop_DragOver);
            this.Capital.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragDrop_MouseDown);
            // 
            // Country
            // 
            this.Country.AllowDrop = true;
            this.Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Poland",
            "Germany",
            "Frane",
            "United Kingdom",
            "Italy",
            "Czech Republic",
            "Hungary",
            "Austria",
            "Greece",
            "Iceland"});
            this.Country.Location = new System.Drawing.Point(0, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(396, 450);
            this.Country.TabIndex = 0;
            this.Country.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop_DragDrop);
            this.Country.DragOver += new System.Windows.Forms.DragEventHandler(this.DragDrop_DragOver);
            this.Country.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragDrop_MouseDown);
            // 
            // dragDropApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "dragDropApp";
            this.Text = "Drag & Drop by JL";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox Capital;
        private System.Windows.Forms.ListBox Country;
    }
}

