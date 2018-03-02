namespace BugReportingDB
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
            this.button1 = new System.Windows.Forms.Button();
            this.bugReportingDatabaseDataSet = new BugReportingDB.BugReportingDatabaseDataSet();
            this.bugReportingDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProjectTableAdapter = new BugReportingDB.BugReportingDatabaseDataSetTableAdapters.tblProjectTableAdapter();
            this.tblProjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnListProjects = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProjectId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportingDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportingDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bugReportingDatabaseDataSet
            // 
            this.bugReportingDatabaseDataSet.DataSetName = "BugReportingDatabaseDataSet";
            this.bugReportingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugReportingDatabaseDataSetBindingSource
            // 
            this.bugReportingDatabaseDataSetBindingSource.DataSource = this.bugReportingDatabaseDataSet;
            this.bugReportingDatabaseDataSetBindingSource.Position = 0;
            // 
            // tblProjectBindingSource
            // 
            this.tblProjectBindingSource.DataMember = "tblProject";
            this.tblProjectBindingSource.DataSource = this.bugReportingDatabaseDataSetBindingSource;
            // 
            // tblProjectTableAdapter
            // 
            this.tblProjectTableAdapter.ClearBeforeFill = true;
            // 
            // tblProjectBindingSource1
            // 
            this.tblProjectBindingSource1.DataMember = "tblProject";
            this.tblProjectBindingSource1.DataSource = this.bugReportingDatabaseDataSetBindingSource;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(12, 13);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(94, 49);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnListProjects
            // 
            this.btnListProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListProjects.Location = new System.Drawing.Point(12, 68);
            this.btnListProjects.Name = "btnListProjects";
            this.btnListProjects.Size = new System.Drawing.Size(94, 49);
            this.btnListProjects.TabIndex = 4;
            this.btnListProjects.Text = "List Projects";
            this.btnListProjects.UseVisualStyleBackColor = true;
            this.btnListProjects.Click += new System.EventHandler(this.btnListProjects_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(88, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView2.Size = new System.Drawing.Size(353, 94);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project iD";
            // 
            // txtSearchProjectId
            // 
            this.txtSearchProjectId.Location = new System.Drawing.Point(115, 14);
            this.txtSearchProjectId.Name = "txtSearchProjectId";
            this.txtSearchProjectId.Size = new System.Drawing.Size(111, 26);
            this.txtSearchProjectId.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.txtSearchProjectId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(112, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 232);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(112, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 178);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnListProjects);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugReportingDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugReportingDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bugReportingDatabaseDataSetBindingSource;
        private BugReportingDatabaseDataSet bugReportingDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblProjectBindingSource;
        private BugReportingDatabaseDataSetTableAdapters.tblProjectTableAdapter tblProjectTableAdapter;
        private System.Windows.Forms.BindingSource tblProjectBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnListProjects;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchProjectId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}

