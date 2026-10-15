namespace AnimalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Feature_3 f3 = new Feature_3();
        private void Form1_Load(object sender, EventArgs e)
        {
            Animals a = new Animals();
            a.AnimalID = txtID.Text;
            a.Name = txtName.Text;
            a.Species = txtSpecies.Text;
            a.Age = int.Parse(txtAge.Text);
            a.RecoveryScore = int.Parse(txtScore.Text);
            //a.Status = txtStatus.Text;// Placeholder for housing unit calculation
            //a.HousingUnit = "Calculated Method"; // Placeholder for housing unit calculation
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSpecies.Text == "" || txtAge.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Fill in all fields before saving changes");
                return;
            }
            Animals a = new Animals();
            a.AnimalID = txtID.Text;
            a.Name = txtName.Text;
            a.Species = txtSpecies.Text;
            a.Age = int.Parse(txtAge.Text);
            a.RecoveryScore = int.Parse(txtScore.Text);
            //a.Status = txtStatus.Text;// Placeholder for housing unit calculation
            //a.HousingUnit = "Calculated Method"; // Placeholder for housing unit calculation
            try
            {
                f3.UpdateData(a);
                MessageBox.Show("Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search bar is empty, Please enter ID");
                return;
            }
            DGVanimals.DataSource = f3.SearchID(txtSearch.Text);


        }

        private void DGVanimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indexrow = e.RowIndex;
            if (Indexrow == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DGVanimals.Rows[Indexrow];

            txtID.Text = selectedRow.Cells[0].Value.ToString();
            txtName.Text = selectedRow.Cells[1].Value.ToString();
            txtSpecies.Text = selectedRow.Cells[2].Value.ToString();
            txtScore.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSpecies.Text == "" || txtAge.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Fill in all fields before saving changes");
                return;
            }
            Animals a = new Animals();
            a.AnimalID = txtID.Text;
            a.Name = txtName.Text;
            a.Species = txtSpecies.Text;
            a.Age = int.Parse(txtAge.Text);
            a.RecoveryScore = int.Parse(txtScore.Text);
            //a.Status = txtStatus.Text;// Placeholder for housing unit calculation
            //a.HousingUnit = "Calculated Method"; // Placeholder for housing unit calculation
            try
            {
                f3.AddData(a);
                MessageBox.Show("Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSpecies.Text = "";
            txtAge.Text = "";
            txtScore.Text = "";
            
        }
    }
}
