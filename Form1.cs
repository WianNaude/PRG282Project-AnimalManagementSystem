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
            List<Animal> currentAnimal = Read.ReadFromFile();
            bool isDuplicate = false;

            foreach (Animal animal in currentAnimal)
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

            Write.WriteToFile(txtID.Text.ToUpper(), txtName.Text, txtSpecies.Text, int.Parse(txtAge.Text), int.Parse(txtScore.Text));

            txtID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();

            List<Animal> animals = Read.ReadFromFile();
            DGVanimals.DataSource = animals;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Animal> animals = Read.ReadFromFile();
            DGVanimals.DataSource = animals;
        }
    }
}
