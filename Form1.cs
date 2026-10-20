using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalManagementSystem
{
    public partial class Form1 : Form
    {
        private AnimalFileHandler handler;
        private List<Animal> animals;
        public Form1()
        {
            InitializeComponent();

            handler = new AnimalFileHandler();
            animals = new List<Animal>();

            ConfigureAnimalGrid();
            RefreshAnimalGrid();

        }

        private void ConfigureAnimalGrid() //records can only be viewed and selected.
        {
            DGVanimals.ReadOnly = true;
            DGVanimals.AllowUserToAddRows = false;
            DGVanimals.AllowUserToDeleteRows = false;
            DGVanimals.MultiSelect = false;
            DGVanimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVanimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Adjusting the Column sizes 
            colAnimalID.FillWeight = 85;
            colName.FillWeight = 100;
            colSpecies.FillWeight = 100;
            colAge.FillWeight = 40;           
            colRecoveryScore.FillWeight = 95;  
            colStatus.FillWeight = 95;
            colHousingUnit.FillWeight = 160;

        }

        public void RefreshAnimalGrid()
        {
            int skippedLines;
            string errorMessage;

            animals = handler.LoadAnimals(
                out skippedLines,
                out errorMessage
            );

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DGVanimals.DataSource = null;
            DGVanimals.DataSource = animals;

            if (skippedLines > 0) //Shows the amount of lines skipped if the records were incorrect
            {
                MessageBox.Show(skippedLines + " malformed records were skipped.", "Loading Animals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Feature_3 f3 = new Feature_3();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            lblMode.Text = "Add Mode";
            lblMode.ForeColor = Color.Red;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSpecies.Text == "" || txtAge.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Fill in all fields before saving changes");
                return;
            }
            Animal a = new Animal();
            a.AnimalID = txtID.Text;
            a.Name = txtName.Text;
            a.Species = txtSpecies.Text;
            a.Age = int.Parse(txtAge.Text);
            a.RecoveryScore = int.Parse(txtScore.Text);

            a.Classification(a.RecoveryScore);// Calculates the status and Housing Unit based on the recovery score
            try
            {
                f3.UpdateData(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshAnimalGrid();
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
                // Makes the textboxes empty if no records are found
                txtID.Text = "";
                txtName.Text = "";
                txtSpecies.Text = "";
                txtAge.Text = "";
                txtScore.Text = "";
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
                txtSearch.Clear();
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
            string AnimalID = txtID.Text.Trim().ToUpper();
            string Name = txtName.Text.Trim();
            string Species = txtSpecies.Text.Trim();
            string Age = txtAge.Text.Trim();
            string Score = txtScore.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(AnimalID, @"^WR-\d{4}$"))
            {
                MessageBox.Show("Animal ID must follow the format of WR-0000");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }
            
            bool isDuplicate = false;

            foreach (Animal animal in animals)
            {
                if (animal.AnimalID.Equals(AnimalID, StringComparison.OrdinalIgnoreCase))
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                MessageBox.Show("Animal ID already exists");
                txtID.Focus();
                txtID.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(Name) || Name.Length > 30 || Name.Contains('|'))
            {
                MessageBox.Show("Name must contain atleast 1-30 characters");
                txtName.Focus();
                txtName.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(Species) || Species.Length > 30)
            {
                MessageBox.Show("Species must contain atleast 1-30 characters");
                txtSpecies.Focus();
                txtSpecies.SelectAll();
                return;
            }
            if (!int.TryParse(Age, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be between 0 and 100");
                txtAge.Focus();
                txtAge.SelectAll();
                return;
            }

            if (!int.TryParse(Score, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be between 0 and 100");
                txtScore.Focus();
                txtScore.SelectAll();
                return;
            }
            Animal a = new Animal();
            a.AnimalID = AnimalID;
            a.Name = Name;
            a.Species = Species;
            a.Age = int.Parse(Age);
            a.RecoveryScore = int.Parse(Score);

            a.Classification(a.RecoveryScore);

            Write.WriteToFile(a);

            txtID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();

            RefreshAnimalGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Checks if the Search method was executed
            if(DGVanimals.Rows.Count == 1) 
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please enter ID to Delete");
                    return;
                }
                Animal a = new Animal();
                a.AnimalID = txtID.Text;
                a.Name = txtName.Text;
                a.Species = txtSpecies.Text;
                a.Age = int.Parse(txtAge.Text);
                a.RecoveryScore = int.Parse(txtScore.Text);

                a.Classification(a.RecoveryScore);// Calculates the status and Housing Unit based on the recovery score

                DialogResult result1 = MessageBox.Show($"Delete {a.AnimalID} ({a.Name})? This cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result1 == DialogResult.Yes) 
                {
                    try
                    {
                        f3.DeleteData(txtID.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                RefreshAnimalGrid();
                ClearFormFields();
                return;// it wont need to continue becuase it was successfully Delete
            }/////////////////////////////

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

             Animal selectedAnimal = selectedRow.DataBoundItem as Animal;

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
                animals.Remove(selectedAnimal);

                 // Save updated list back to animals.txt (adjust property separator if your group uses a different format)
                 var lines = animals.Select(a => $"{a.AnimalID}|{a.Name}|{a.Species}|{a.Age}|{a.RecoveryScore}|{a.Status}|{a.HousingUnit}");
                 File.WriteAllLines("animals.txt", lines);

                // Refresh the grid
                RefreshAnimalGrid();

                //Enters Add Mode after deletion
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                txtID.ReadOnly = false;
                lblMode.Text = "Add Mode";
                lblMode.ForeColor = Color.Red;

                // Clear form fields if the deleted animal was currently loaded
                ClearFormFields();
                 
                 MessageBox.Show("Record successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void ClearFormFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSpecies.Text = "";
            txtAge.Text = "";
            txtScore.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Enters Add Mode when textboxes are cleared
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            txtID.ReadOnly = false;
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
