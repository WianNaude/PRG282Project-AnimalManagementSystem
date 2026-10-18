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
            dgvAnimals.ReadOnly = true;
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.MultiSelect = false;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            if (skippedLines > 0) //Shows the amount of lines skipped if the records were incorrect
            {
                MessageBox.Show(skippedLines + " malformed records were skipped.", "Loading Animals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
