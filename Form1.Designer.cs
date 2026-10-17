namespace AnimalManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DGVanimals = new DataGridView();
            txtID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSummary = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVanimals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(62, 12);
            label1.Name = "label1";
            label1.Size = new Size(709, 37);
            label1.TabIndex = 1;
            label1.Text = "Baobab Ridge Wildlife Rehabilitation Records System ";
            // 
            // DGVanimals
            // 
            DGVanimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVanimals.Location = new Point(279, 121);
            DGVanimals.Margin = new Padding(3, 4, 3, 4);
            DGVanimals.Name = "DGVanimals";
            DGVanimals.RowHeadersWidth = 51;
            DGVanimals.Size = new Size(491, 260);
            DGVanimals.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 149);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 232);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 4;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(146, 232);
            txtSpecies.Margin = new Padding(3, 4, 3, 4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(114, 27);
            txtSpecies.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(14, 312);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(114, 27);
            txtAge.TabIndex = 6;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(146, 312);
            txtScore.Margin = new Padding(3, 4, 3, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(114, 27);
            txtScore.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(553, 83);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(124, 27);
            txtSearch.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 124);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 208);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 208);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 13;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 290);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 14;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 290);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "Score";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 389);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 43);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(146, 389);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 43);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(14, 440);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 43);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(146, 440);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 43);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(279, 389);
            btnSummary.Margin = new Padding(3, 4, 3, 4);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(491, 43);
            btnSummary.TabIndex = 22;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(685, 83);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(btnSearch);
            Controls.Add(btnSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(DGVanimals);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVanimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView DGVanimals;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtScore;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSummary;
        private Button btnSearch;
    }
}
