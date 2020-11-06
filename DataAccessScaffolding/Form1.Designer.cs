namespace DataAccessScaffolding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnExecuteScaffoldSQLSP = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtScaffoldSQLSPTable = new System.Windows.Forms.TextBox();
            this.txtScaffoldSQLSPOutput = new System.Windows.Forms.TextBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.chkScaffoldModelEntireDB = new System.Windows.Forms.CheckBox();
            this.txtScaffoldModelNS = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtScaffoldModelsTable = new System.Windows.Forms.TextBox();
            this.btnExecuteScaffoldModel = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.chkScaffoldDataAccessEntireDB = new System.Windows.Forms.CheckBox();
            this.txtScaffoldDataAccessNS = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtScaffoldDataAccessTable = new System.Windows.Forms.TextBox();
            this.btnExecuteScaffodDataAccess = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabControl3.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(800, 604);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.tableLayoutPanel17);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(792, 578);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "SQL SP";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel18, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.txtScaffoldSQLSPTable, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.txtScaffoldSQLSPOutput, 0, 3);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 4;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.19048F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(786, 572);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel18.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.btnExecuteScaffoldSQLSP, 2, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(780, 48);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(3, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "SQL SP Scaffolding:";
            // 
            // btnExecuteScaffoldSQLSP
            // 
            this.btnExecuteScaffoldSQLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExecuteScaffoldSQLSP.Location = new System.Drawing.Point(592, 5);
            this.btnExecuteScaffoldSQLSP.Name = "btnExecuteScaffoldSQLSP";
            this.btnExecuteScaffoldSQLSP.Size = new System.Drawing.Size(102, 37);
            this.btnExecuteScaffoldSQLSP.TabIndex = 1;
            this.btnExecuteScaffoldSQLSP.Text = "Execute";
            this.btnExecuteScaffoldSQLSP.UseVisualStyleBackColor = true;
            this.btnExecuteScaffoldSQLSP.Click += new System.EventHandler(this.btnExecuteScaffoldSQLSP_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(3, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Table:";
            // 
            // txtScaffoldSQLSPTable
            // 
            this.txtScaffoldSQLSPTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScaffoldSQLSPTable.Location = new System.Drawing.Point(3, 30);
            this.txtScaffoldSQLSPTable.Name = "txtScaffoldSQLSPTable";
            this.txtScaffoldSQLSPTable.Size = new System.Drawing.Size(780, 20);
            this.txtScaffoldSQLSPTable.TabIndex = 2;
            this.txtScaffoldSQLSPTable.Text = "company";
            // 
            // txtScaffoldSQLSPOutput
            // 
            this.txtScaffoldSQLSPOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScaffoldSQLSPOutput.Location = new System.Drawing.Point(3, 138);
            this.txtScaffoldSQLSPOutput.Multiline = true;
            this.txtScaffoldSQLSPOutput.Name = "txtScaffoldSQLSPOutput";
            this.txtScaffoldSQLSPOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScaffoldSQLSPOutput.Size = new System.Drawing.Size(780, 431);
            this.txtScaffoldSQLSPOutput.TabIndex = 3;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.tableLayoutPanel19);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(792, 578);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Models";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel20, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(786, 572);
            this.tableLayoutPanel19.TabIndex = 2;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Controls.Add(this.chkScaffoldModelEntireDB, 0, 2);
            this.tableLayoutPanel20.Controls.Add(this.txtScaffoldModelNS, 1, 1);
            this.tableLayoutPanel20.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.txtScaffoldModelsTable, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.btnExecuteScaffoldModel, 1, 2);
            this.tableLayoutPanel20.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(780, 351);
            this.tableLayoutPanel20.TabIndex = 0;
            // 
            // chkScaffoldModelEntireDB
            // 
            this.chkScaffoldModelEntireDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkScaffoldModelEntireDB.AutoSize = true;
            this.chkScaffoldModelEntireDB.Checked = true;
            this.chkScaffoldModelEntireDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScaffoldModelEntireDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkScaffoldModelEntireDB.Location = new System.Drawing.Point(138, 282);
            this.chkScaffoldModelEntireDB.Name = "chkScaffoldModelEntireDB";
            this.chkScaffoldModelEntireDB.Size = new System.Drawing.Size(114, 19);
            this.chkScaffoldModelEntireDB.TabIndex = 3;
            this.chkScaffoldModelEntireDB.Text = "Entire Database";
            this.chkScaffoldModelEntireDB.UseVisualStyleBackColor = true;
            // 
            // txtScaffoldModelNS
            // 
            this.txtScaffoldModelNS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtScaffoldModelNS.Location = new System.Drawing.Point(493, 209);
            this.txtScaffoldModelNS.Name = "txtScaffoldModelNS";
            this.txtScaffoldModelNS.Size = new System.Drawing.Size(184, 20);
            this.txtScaffoldModelNS.TabIndex = 7;
            this.txtScaffoldModelNS.Text = "ReplaceMe123";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label22.Location = new System.Drawing.Point(159, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 26);
            this.label22.TabIndex = 0;
            this.label22.Text = "Table:";
            // 
            // txtScaffoldModelsTable
            // 
            this.txtScaffoldModelsTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtScaffoldModelsTable.Location = new System.Drawing.Point(491, 93);
            this.txtScaffoldModelsTable.Name = "txtScaffoldModelsTable";
            this.txtScaffoldModelsTable.Size = new System.Drawing.Size(187, 20);
            this.txtScaffoldModelsTable.TabIndex = 1;
            // 
            // btnExecuteScaffoldModel
            // 
            this.btnExecuteScaffoldModel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecuteScaffoldModel.Location = new System.Drawing.Point(527, 311);
            this.btnExecuteScaffoldModel.Name = "btnExecuteScaffoldModel";
            this.btnExecuteScaffoldModel.Size = new System.Drawing.Size(116, 37);
            this.btnExecuteScaffoldModel.TabIndex = 2;
            this.btnExecuteScaffoldModel.Text = "Execute";
            this.btnExecuteScaffoldModel.UseVisualStyleBackColor = true;
            this.btnExecuteScaffoldModel.Click += new System.EventHandler(this.btnExecuteScaffoldModel_Click);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label24.Location = new System.Drawing.Point(127, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 26);
            this.label24.TabIndex = 5;
            this.label24.Text = "Namespace:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 464);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 1;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.tableLayoutPanel21);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(792, 578);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Data Access";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel21.Controls.Add(this.tableLayoutPanel22, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 3;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(792, 578);
            this.tableLayoutPanel21.TabIndex = 3;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Controls.Add(this.chkScaffoldDataAccessEntireDB, 0, 2);
            this.tableLayoutPanel22.Controls.Add(this.txtScaffoldDataAccessNS, 1, 1);
            this.tableLayoutPanel22.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.txtScaffoldDataAccessTable, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.btnExecuteScaffodDataAccess, 1, 2);
            this.tableLayoutPanel22.Controls.Add(this.label28, 0, 1);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 3;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(786, 355);
            this.tableLayoutPanel22.TabIndex = 0;
            // 
            // chkScaffoldDataAccessEntireDB
            // 
            this.chkScaffoldDataAccessEntireDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkScaffoldDataAccessEntireDB.AutoSize = true;
            this.chkScaffoldDataAccessEntireDB.Checked = true;
            this.chkScaffoldDataAccessEntireDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScaffoldDataAccessEntireDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkScaffoldDataAccessEntireDB.Location = new System.Drawing.Point(139, 286);
            this.chkScaffoldDataAccessEntireDB.Name = "chkScaffoldDataAccessEntireDB";
            this.chkScaffoldDataAccessEntireDB.Size = new System.Drawing.Size(114, 19);
            this.chkScaffoldDataAccessEntireDB.TabIndex = 3;
            this.chkScaffoldDataAccessEntireDB.Text = "Entire Database";
            this.chkScaffoldDataAccessEntireDB.UseVisualStyleBackColor = true;
            // 
            // txtScaffoldDataAccessNS
            // 
            this.txtScaffoldDataAccessNS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtScaffoldDataAccessNS.Location = new System.Drawing.Point(497, 213);
            this.txtScaffoldDataAccessNS.Name = "txtScaffoldDataAccessNS";
            this.txtScaffoldDataAccessNS.Size = new System.Drawing.Size(184, 20);
            this.txtScaffoldDataAccessNS.TabIndex = 7;
            this.txtScaffoldDataAccessNS.Text = "ReplaceMe123";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label26.Location = new System.Drawing.Point(161, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 26);
            this.label26.TabIndex = 0;
            this.label26.Text = "Table:";
            // 
            // txtScaffoldDataAccessTable
            // 
            this.txtScaffoldDataAccessTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtScaffoldDataAccessTable.Location = new System.Drawing.Point(496, 95);
            this.txtScaffoldDataAccessTable.Name = "txtScaffoldDataAccessTable";
            this.txtScaffoldDataAccessTable.Size = new System.Drawing.Size(187, 20);
            this.txtScaffoldDataAccessTable.TabIndex = 1;
            // 
            // btnExecuteScaffodDataAccess
            // 
            this.btnExecuteScaffodDataAccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecuteScaffodDataAccess.Location = new System.Drawing.Point(531, 315);
            this.btnExecuteScaffodDataAccess.Name = "btnExecuteScaffodDataAccess";
            this.btnExecuteScaffodDataAccess.Size = new System.Drawing.Size(116, 37);
            this.btnExecuteScaffodDataAccess.TabIndex = 2;
            this.btnExecuteScaffodDataAccess.Text = "Execute";
            this.btnExecuteScaffodDataAccess.UseVisualStyleBackColor = true;
            this.btnExecuteScaffodDataAccess.Click += new System.EventHandler(this.btnExecuteScaffodDataAccess_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label28.Location = new System.Drawing.Point(129, 210);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(135, 26);
            this.label28.TabIndex = 5;
            this.label28.Text = "Namespace:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 469);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 13);
            this.label29.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.tabControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Data Access Scaffolding";
            this.tabControl3.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnExecuteScaffoldSQLSP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtScaffoldSQLSPTable;
        private System.Windows.Forms.TextBox txtScaffoldSQLSPOutput;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.CheckBox chkScaffoldModelEntireDB;
        private System.Windows.Forms.TextBox txtScaffoldModelNS;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtScaffoldModelsTable;
        private System.Windows.Forms.Button btnExecuteScaffoldModel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.CheckBox chkScaffoldDataAccessEntireDB;
        private System.Windows.Forms.TextBox txtScaffoldDataAccessNS;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtScaffoldDataAccessTable;
        private System.Windows.Forms.Button btnExecuteScaffodDataAccess;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}

