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
            btnSave.Enabled = false;
            DGVanimals.ReadOnly = true;
            lblMode.Text = "Add Mode";
            lblMode.ForeColor = Color.Red;

            Animals a = new Animals();
            a.AnimalID = txtID.Text;
            a.Name = txtName.Text;
            a.Species = txtSpecies.Text;
            a.Age = int.Parse(txtAge.Text);
            a.RecoveryScore = int.Parse(txtScore.Text);

            a.Classification(a.RecoveryScore);// Calculates the status and Housing Unit based on the recovery score
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

            a.Classification(a.RecoveryScore);
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

            if (DGVanimals.Rows.Count == 0)
            {
                MessageBox.Show("No records found for the given ID");
            }
            else
            {
                txtID.ReadOnly = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                lblMode.Text = "Edit Mode";
                lblMode.ForeColor = Color.Green;

                //Populates the textboxes with the data from the first row of the DataGridView
                txtID.Text = DGVanimals.Rows[0].Cells[0].Value.ToString();
                txtName.Text = DGVanimals.Rows[0].Cells[1].Value.ToString();
                txtSpecies.Text = DGVanimals.Rows[0].Cells[2].Value.ToString();
                txtAge.Text = DGVanimals.Rows[0].Cells[3].Value.ToString();
                txtScore.Text = DGVanimals.Rows[0].Cells[4].Value.ToString();
            }


        }

        private void DGVanimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Enters Edit Mode when a row is clicked
            txtID.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            lblMode.Text = "Edit Mode";
            lblMode.ForeColor = Color.Green;

            int Indexrow = e.RowIndex;
            if (Indexrow == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DGVanimals.Rows[Indexrow];

            txtID.Text = selectedRow.Cells[0].Value.ToString();
            txtName.Text = selectedRow.Cells[1].Value.ToString();
            txtSpecies.Text = selectedRow.Cells[2].Value.ToString();
            txtAge.Text = selectedRow.Cells[3].Value.ToString();
            txtScore.Text = selectedRow.Cells[4].Value.ToString();

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

            a.Classification(a.RecoveryScore);
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
 private void btnDelete_Click(object sender, EventArgs e)
 {
     List<Animals> animallist = new List<Animals>();
     // 1. Check if a row is selected in the grid
     if (DGVanimals.SelectedRows.Count == 0 && DGVanimals.CurrentRow == null)
     {
         MessageBox.Show("Please select a row in the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         return;
     }

     // Get the selected row and its data-bound animal object
     var selectedRow = DGVanimals.SelectedRows.Count > 0 ? DGVanimals.SelectedRows[0] : DGVanimals.CurrentRow;

     if (selectedRow == null || selectedRow.DataBoundItem == null)
     {
         MessageBox.Show("Please select a valid animal row.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         return;
     }

     Animals selectedAnimal = selectedRow.DataBoundItem as Animals;

     if (selectedAnimal == null)
     {
         MessageBox.Show("Could not retrieve the selected animal data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         return;
     }

     // 2. Show Yes/No confirmation showing the animal's ID and name
     string message = $"Delete {selectedAnimal.AnimalID} ({selectedAnimal.Name})? This cannot be undone.";
     DialogResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

     // Choosing No changes nothing
     if (result == DialogResult.Yes)
     {
         // Remove from the active list
         animallist.Remove(selectedAnimal);

         // Save updated list back to animals.txt (adjust property separator if your group uses a different format)
         var lines = animallist.Select(a => $"{a.AnimalID},{a.Name},{a.Age},{a.RecoveryScore},{a.Status}");
         File.WriteAllLines("animals.txt", lines);

         // Refresh the grid
         DGVanimals.DataSource = null;
         DGVanimals.DataSource = animallist;

         // Clear form fields if the deleted animal was currently loaded
         ClearFormFields();

         MessageBox.Show("Record successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
     }
 }

 private void ClearFormFields()
 {
     // Clear your input textboxes here if needed (e.g., txtId.Clear(); txtName.Clear();)
 }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            lblMode.Text = "Add Mode";
            lblMode.ForeColor = Color.Red;

            txtID.Text = "";
            txtName.Text = "";
            txtSpecies.Text = "";
            txtAge.Text = "";
            txtScore.Text = "";

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                Feature_5 f5 = new Feature_5();
                lblsummary.Text = f5.GenerateSummary(); 
                MessageBox.Show("Summary generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
