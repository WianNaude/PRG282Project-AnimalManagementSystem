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
            dgvAnimals = new DataGridView();
            txtID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtScore = new TextBox();
            txtStatus = new TextBox();
            txtHousing = new TextBox();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSummary = new Button();
            btnSearch = new Button();
            colAnimalID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colSpecies = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colRecoveryScore = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colHousingUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(568, 30);
            label1.TabIndex = 1;
            label1.Text = "Baobab Ridge Wildlife Rehabilitation Records System ";
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { colAnimalID, colName, colSpecies, colAge, colRecoveryScore, colStatus, colHousingUnit });
            dgvAnimals.Location = new Point(244, 91);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersVisible = false;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(430, 195);
            dgvAnimals.TabIndex = 2;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 91);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(128, 135);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(100, 23);
            txtSpecies.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 178);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 6;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(128, 178);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(12, 222);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(216, 23);
            txtStatus.TabIndex = 8;
            // 
            // txtHousing
            // 
            txtHousing.Location = new Point(12, 263);
            txtHousing.Name = "txtHousing";
            txtHousing.Size = new Size(216, 23);
            txtHousing.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(484, 62);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(109, 23);
            txtSearch.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 13;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 14;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 161);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 15;
            label6.Text = "Score";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 248);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 17;
            label8.Text = "Housing Unit";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(128, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(244, 292);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(430, 32);
            btnSummary.TabIndex = 22;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(599, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // colAnimalID
            // 
            colAnimalID.HeaderText = "Animal ID\n";
            colAnimalID.Name = "colAnimalID";
            colAnimalID.ReadOnly = true;
            colAnimalID.DataPropertyName = "AnimalID";
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.DataPropertyName = "Name";
            // 
            // colSpecies
            // 
            colSpecies.HeaderText = "Species";
            colSpecies.Name = "colSpecies";
            colSpecies.ReadOnly = true;
            colSpecies.DataPropertyName = "Species";
            // 
            // colAge
            // 
            colAge.HeaderText = "Age";
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            colAge.DataPropertyName = "Age";
            // 
            // colRecoveryScore
            // 
            colRecoveryScore.HeaderText = "RecoveryScore";
            colRecoveryScore.Name = "colRecoveryScore";
            colRecoveryScore.ReadOnly = true;
            colRecoveryScore.DataPropertyName = "RecoveryScore";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.DataPropertyName = "Status";
            // 
            // colHousingUnit
            // 
            colHousingUnit.HeaderText = "HousingUnit";
            colHousingUnit.Name = "colHousingUnit";
            colHousingUnit.ReadOnly = true;
            colHousingUnit.DataPropertyName = "HousingUnit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 387);
            Controls.Add(btnSearch);
            Controls.Add(btnSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(txtHousing);
            Controls.Add(txtStatus);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(dgvAnimals);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvAnimals;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtScore;
        private TextBox txtStatus;
        private TextBox txtHousing;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSummary;
        private Button btnSearch;
        private DataGridViewTextBoxColumn colAnimalID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSpecies;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colRecoveryScore;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colHousingUnit;
    }
}
