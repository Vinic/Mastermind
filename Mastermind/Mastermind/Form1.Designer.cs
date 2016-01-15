namespace Mastermind
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
            this.button1 = new Mastermind.Form1.RoundButton();
            this.button2 = new Mastermind.Form1.RoundButton();
            this.button3 = new Mastermind.Form1.RoundButton();
            this.button4 = new Mastermind.Form1.RoundButton();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userscoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastermindDataSet = new Mastermind.MastermindDataSet();
            this.user_scoreTableAdapter = new Mastermind.MastermindDataSetTableAdapters.user_scoreTableAdapter();
            this.roundButton1 = new Mastermind.Form1.RoundButton();
            this.roundButton2 = new Mastermind.Form1.RoundButton();
            this.roundButton3 = new Mastermind.Form1.RoundButton();
            this.roundButton4 = new Mastermind.Form1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userscoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastermindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(11, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(55, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 36);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(99, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 36);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(143, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 36);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Check";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.userscoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userscoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(170, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 84;
            // 
            // userscoreDataGridViewTextBoxColumn
            // 
            this.userscoreDataGridViewTextBoxColumn.DataPropertyName = "user_score";
            this.userscoreDataGridViewTextBoxColumn.HeaderText = "user_score";
            this.userscoreDataGridViewTextBoxColumn.Name = "userscoreDataGridViewTextBoxColumn";
            this.userscoreDataGridViewTextBoxColumn.Width = 84;
            // 
            // userscoreBindingSource
            // 
            this.userscoreBindingSource.DataMember = "user_score";
            this.userscoreBindingSource.DataSource = this.mastermindDataSet;
            // 
            // mastermindDataSet
            // 
            this.mastermindDataSet.DataSetName = "MastermindDataSet";
            this.mastermindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_scoreTableAdapter
            // 
            this.user_scoreTableAdapter.ClearBeforeFill = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton1.Location = new System.Drawing.Point(187, 348);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(15, 15);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton2.Location = new System.Drawing.Point(201, 348);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(15, 15);
            this.roundButton2.TabIndex = 7;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton3.Location = new System.Drawing.Point(187, 361);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(15, 15);
            this.roundButton3.TabIndex = 8;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundButton4.Location = new System.Drawing.Point(201, 361);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(15, 15);
            this.roundButton4.TabIndex = 9;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 390);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userscoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastermindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Form1.RoundButton button1;
        private Form1.RoundButton button2;
        private Form1.RoundButton button3;
        private Form1.RoundButton button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MastermindDataSet mastermindDataSet;
        private System.Windows.Forms.BindingSource userscoreBindingSource;
        private MastermindDataSetTableAdapters.user_scoreTableAdapter user_scoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userscoreDataGridViewTextBoxColumn;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
    }
}

