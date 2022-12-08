namespace Sprint_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Car emptyCar = new Car();
            Car carOne = new Car("Mercedes", "AMG One");
            Car carTwo = new Car("Toyota", "Supra MK4");
            Car carThree = new Car("Rimac", "Concept Two");

            TestBox.Items.Clear();

            TestBox.Items.Add(emptyCar.ToString());
            TestBox.Items.Add(carOne.ToString());
            TestBox.Items.Add(carTwo.ToString());
            TestBox.Items.Add(carThree.ToString());

        }
    }
}