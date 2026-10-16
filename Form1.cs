using AnimalManagementSystem.DataLayer;

namespace AnimalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Write.WriteToFile(txtID.Text, txtName.Text, txtSpecies.Text, int.Parse(txtAge.Text), int.Parse(txtScore.Text));

            List<Animal> animals = Read.ReadFromFile();
            DGVanimals.DataSource = animals;
        }
    }
}
