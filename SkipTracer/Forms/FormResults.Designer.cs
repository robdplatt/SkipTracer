namespace EFR.SkipTracer.Forms
{
    partial class FormResults
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
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader6 = new ColumnHeader();
            listView4 = new ListView();
            columnHeader7 = new ColumnHeader();
            linkLabel1 = new LinkLabel();
            contextMenuStripNames = new ContextMenuStrip(components);
            contextMenuStripPhoneNumbers = new ContextMenuStrip(components);
            contextMenuStripAddresses = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(1039, 147);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Source";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Results";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(listView4);
            groupBox1.Controls.Add(listView3);
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(12, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1039, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results: 0";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listView2.ContextMenuStrip = contextMenuStripNames;
            listView2.Location = new Point(16, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(331, 131);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Names";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Aliases";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader6 });
            listView3.ContextMenuStrip = contextMenuStripPhoneNumbers;
            listView3.Location = new Point(387, 22);
            listView3.Name = "listView3";
            listView3.Size = new Size(178, 131);
            listView3.TabIndex = 4;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phones";
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader7 });
            listView4.ContextMenuStrip = contextMenuStripAddresses;
            listView4.Location = new Point(571, 22);
            listView4.Name = "listView4";
            listView4.Size = new Size(462, 131);
            listView4.TabIndex = 5;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Addresses";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(860, 187);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.moreinfo.com/";
            // 
            // contextMenuStripNames
            // 
            contextMenuStripNames.Name = "contextMenuStripNames";
            contextMenuStripNames.Size = new Size(61, 4);
            // 
            // contextMenuStripPhoneNumbers
            // 
            contextMenuStripPhoneNumbers.Name = "contextMenuStrip1";
            contextMenuStripPhoneNumbers.Size = new Size(61, 4);
            // 
            // contextMenuStripAddresses
            // 
            contextMenuStripAddresses.Name = "contextMenuStrip1";
            contextMenuStripAddresses.Size = new Size(61, 4);
            // 
            // FormResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 561);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "FormResults";
            Text = "EFR.SkipTracer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private ListView listView4;
        private ColumnHeader columnHeader7;
        private ListView listView3;
        private ColumnHeader columnHeader6;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ContextMenuStrip contextMenuStripAddresses;
        private ContextMenuStrip contextMenuStripPhoneNumbers;
        private ContextMenuStrip contextMenuStripNames;
    }
}