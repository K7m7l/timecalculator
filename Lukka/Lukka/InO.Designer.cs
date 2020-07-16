namespace Aika
{
    partial class InO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InO));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TTT = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.Button();
            this.STime = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.xl = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shortNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.TTT);
            this.splitContainer1.Panel1.Controls.Add(this.TT);
            this.splitContainer1.Panel1.Controls.Add(this.STime);
            this.splitContainer1.Panel1.Controls.Add(this.StartTime);
            this.splitContainer1.Panel1.Controls.Add(this.xl);
            this.splitContainer1.Panel1.Controls.Add(this.In);
            this.splitContainer1.Panel1.Controls.Add(this.Out);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1471, 805);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 0;
            // 
            // TTT
            // 
            this.TTT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTT.Location = new System.Drawing.Point(15, 128);
            this.TTT.Name = "TTT";
            this.TTT.Size = new System.Drawing.Size(149, 23);
            this.TTT.TabIndex = 9;
            this.TTT.Text = "Total Out-Time";
            this.TTT.UseVisualStyleBackColor = false;
            this.TTT.Click += new System.EventHandler(this.TTT_Click);
            // 
            // TT
            // 
            this.TT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TT.Location = new System.Drawing.Point(15, 99);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(149, 23);
            this.TT.TabIndex = 8;
            this.TT.Text = "Total In-Time";
            this.TT.UseVisualStyleBackColor = false;
            this.TT.Click += new System.EventHandler(this.TT_Click);
            // 
            // STime
            // 
            this.STime.AutoSize = true;
            this.STime.Location = new System.Drawing.Point(75, 9);
            this.STime.Name = "STime";
            this.STime.Size = new System.Drawing.Size(0, 13);
            this.STime.TabIndex = 6;
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(12, 9);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(52, 13);
            this.StartTime.TabIndex = 5;
            this.StartTime.Text = "StartTime";
            // 
            // xl
            // 
            this.xl.BackColor = System.Drawing.Color.Teal;
            this.xl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.xl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xl.Location = new System.Drawing.Point(15, 157);
            this.xl.Name = "xl";
            this.xl.Size = new System.Drawing.Size(149, 23);
            this.xl.TabIndex = 3;
            this.xl.Text = "Pull Excel";
            this.xl.UseVisualStyleBackColor = false;
            this.xl.Click += new System.EventHandler(this.xl_Click);
            // 
            // In
            // 
            this.In.BackColor = System.Drawing.Color.LightSteelBlue;
            this.In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.In.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.In.Location = new System.Drawing.Point(15, 72);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(149, 23);
            this.In.TabIndex = 1;
            this.In.Text = "Came In";
            this.In.UseVisualStyleBackColor = false;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.SteelBlue;
            this.Out.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Out.Location = new System.Drawing.Point(15, 43);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(149, 23);
            this.Out.TabIndex = 0;
            this.Out.Text = "Going Out";
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 805);
            this.dataGridView1.TabIndex = 0;
            // 
            // shortNotify
            // 
            this.shortNotify.BalloonTipText = "Aika is Here";
            this.shortNotify.BalloonTipTitle = "Aika";
            this.shortNotify.ContextMenuStrip = this.contextMenuStrip1;
            this.shortNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("shortNotify.Icon")));
            this.shortNotify.Text = "Aika";
            this.shortNotify.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "Maximize";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "Exit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(15, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Yourself !!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 805);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InO";
            this.Text = "Aika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Minimizing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button xl;
        private System.Windows.Forms.Label STime;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Button TT;
        private System.Windows.Forms.Button TTT;
        private System.Windows.Forms.NotifyIcon shortNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
    }
}

