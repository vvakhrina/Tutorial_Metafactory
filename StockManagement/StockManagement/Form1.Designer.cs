namespace StockManagement
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_bSearch = new System.Windows.Forms.Button();
            this.m_bClearCriteria = new System.Windows.Forms.Button();
            this.m_ckIncludingCancelledCnt = new System.Windows.Forms.CheckBox();
            this.m_dtValidTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.m_dtValidFrom = new System.Windows.Forms.DateTimePicker();
            this.m_cbLocation = new System.Windows.Forms.ComboBox();
            this.m_tbTankName = new System.Windows.Forms.TextBox();
            this.m_tbStockNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_bSearch);
            this.groupBox1.Controls.Add(this.m_bClearCriteria);
            this.groupBox1.Controls.Add(this.m_ckIncludingCancelledCnt);
            this.groupBox1.Controls.Add(this.m_dtValidTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_dtValidFrom);
            this.groupBox1.Controls.Add(this.m_cbLocation);
            this.groupBox1.Controls.Add(this.m_tbTankName);
            this.groupBox1.Controls.Add(this.m_tbStockNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // m_bSearch
            // 
            this.m_bSearch.Location = new System.Drawing.Point(689, 40);
            this.m_bSearch.Name = "m_bSearch";
            this.m_bSearch.Size = new System.Drawing.Size(75, 23);
            this.m_bSearch.TabIndex = 12;
            this.m_bSearch.Text = "Search";
            this.m_bSearch.UseVisualStyleBackColor = true;
            // 
            // m_bClearCriteria
            // 
            this.m_bClearCriteria.Location = new System.Drawing.Point(598, 41);
            this.m_bClearCriteria.Name = "m_bClearCriteria";
            this.m_bClearCriteria.Size = new System.Drawing.Size(75, 23);
            this.m_bClearCriteria.TabIndex = 11;
            this.m_bClearCriteria.Text = "Clear criteria";
            this.m_bClearCriteria.UseVisualStyleBackColor = true;
            this.m_bClearCriteria.Click += new System.EventHandler(this.m_bClearCriteria_Click);
            // 
            // m_ckIncludingCancelledCnt
            // 
            this.m_ckIncludingCancelledCnt.AutoSize = true;
            this.m_ckIncludingCancelledCnt.Location = new System.Drawing.Point(598, 15);
            this.m_ckIncludingCancelledCnt.Name = "m_ckIncludingCancelledCnt";
            this.m_ckIncludingCancelledCnt.Size = new System.Drawing.Size(163, 17);
            this.m_ckIncludingCancelledCnt.TabIndex = 10;
            this.m_ckIncludingCancelledCnt.Text = "Including canceled contracts";
            this.m_ckIncludingCancelledCnt.UseVisualStyleBackColor = true;
            // 
            // m_dtValidTo
            // 
            this.m_dtValidTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dtValidTo.Location = new System.Drawing.Point(435, 40);
            this.m_dtValidTo.Name = "m_dtValidTo";
            this.m_dtValidTo.Size = new System.Drawing.Size(79, 20);
            this.m_dtValidTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // m_dtValidFrom
            // 
            this.m_dtValidFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dtValidFrom.Location = new System.Drawing.Point(312, 40);
            this.m_dtValidFrom.Name = "m_dtValidFrom";
            this.m_dtValidFrom.Size = new System.Drawing.Size(82, 20);
            this.m_dtValidFrom.TabIndex = 7;
            this.m_dtValidFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // m_cbLocation
            // 
            this.m_cbLocation.FormattingEnabled = true;
            this.m_cbLocation.Location = new System.Drawing.Point(312, 13);
            this.m_cbLocation.Name = "m_cbLocation";
            this.m_cbLocation.Size = new System.Drawing.Size(202, 21);
            this.m_cbLocation.TabIndex = 6;
            // 
            // m_tbTankName
            // 
            this.m_tbTankName.Location = new System.Drawing.Point(75, 40);
            this.m_tbTankName.Name = "m_tbTankName";
            this.m_tbTankName.Size = new System.Drawing.Size(100, 20);
            this.m_tbTankName.TabIndex = 5;
            // 
            // m_tbStockNumber
            // 
            this.m_tbStockNumber.Location = new System.Drawing.Point(75, 13);
            this.m_tbStockNumber.Name = "m_tbStockNumber";
            this.m_tbStockNumber.Size = new System.Drawing.Size(100, 20);
            this.m_tbStockNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valid from";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tank name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock#";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stock management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker m_dtValidFrom;
        private System.Windows.Forms.ComboBox m_cbLocation;
        private System.Windows.Forms.TextBox m_tbTankName;
        private System.Windows.Forms.TextBox m_tbStockNumber;
        private System.Windows.Forms.DateTimePicker m_dtValidTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button m_bSearch;
        private System.Windows.Forms.Button m_bClearCriteria;
        private System.Windows.Forms.CheckBox m_ckIncludingCancelledCnt;

    }
}

