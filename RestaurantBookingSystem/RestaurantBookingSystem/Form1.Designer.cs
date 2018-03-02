namespace RestaurantBookingSystem
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
            this.BtnCreateTable = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnListTables = new System.Windows.Forms.Button();
            this.lbShowTables = new System.Windows.Forms.ListBox();
            this.pnlShowTables = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBookTable = new System.Windows.Forms.Button();
            this.pnlShowTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCreateTable
            // 
            this.BtnCreateTable.Location = new System.Drawing.Point(12, 12);
            this.BtnCreateTable.Name = "BtnCreateTable";
            this.BtnCreateTable.Size = new System.Drawing.Size(141, 78);
            this.BtnCreateTable.TabIndex = 0;
            this.BtnCreateTable.Text = "Define Restaurant";
            this.BtnCreateTable.UseVisualStyleBackColor = true;
            this.BtnCreateTable.Click += new System.EventHandler(this.BtnDefine_restaurant_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1063, 524);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(141, 78);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnListTables
            // 
            this.BtnListTables.Location = new System.Drawing.Point(12, 239);
            this.BtnListTables.Name = "BtnListTables";
            this.BtnListTables.Size = new System.Drawing.Size(141, 78);
            this.BtnListTables.TabIndex = 2;
            this.BtnListTables.Text = "List Tables";
            this.BtnListTables.UseVisualStyleBackColor = true;
            this.BtnListTables.Click += new System.EventHandler(this.BtnListTables_Click);
            // 
            // lbShowTables
            // 
            this.lbShowTables.FormattingEnabled = true;
            this.lbShowTables.Location = new System.Drawing.Point(26, 40);
            this.lbShowTables.Name = "lbShowTables";
            this.lbShowTables.Size = new System.Drawing.Size(232, 173);
            this.lbShowTables.TabIndex = 3;
            // 
            // pnlShowTables
            // 
            this.pnlShowTables.Controls.Add(this.label2);
            this.pnlShowTables.Controls.Add(this.label1);
            this.pnlShowTables.Controls.Add(this.lbShowTables);
            this.pnlShowTables.Location = new System.Drawing.Point(-5, 323);
            this.pnlShowTables.Name = "pnlShowTables";
            this.pnlShowTables.Size = new System.Drawing.Size(280, 300);
            this.pnlShowTables.TabIndex = 4;
            this.pnlShowTables.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seats";
            // 
            // BtnBookTable
            // 
            this.BtnBookTable.Location = new System.Drawing.Point(10, 96);
            this.BtnBookTable.Name = "BtnBookTable";
            this.BtnBookTable.Size = new System.Drawing.Size(141, 78);
            this.BtnBookTable.TabIndex = 5;
            this.BtnBookTable.Text = "Book a Table";
            this.BtnBookTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 614);
            this.Controls.Add(this.BtnBookTable);
            this.Controls.Add(this.BtnListTables);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCreateTable);
            this.Controls.Add(this.pnlShowTables);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlShowTables.ResumeLayout(false);
            this.pnlShowTables.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateTable;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnListTables;
        private System.Windows.Forms.ListBox lbShowTables;
        private System.Windows.Forms.Panel pnlShowTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBookTable;
    }
}

