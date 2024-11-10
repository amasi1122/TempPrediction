namespace TempEarthPrediction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Year =(float) Convert.ToDouble(textBoxYear.Text),
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            textBoxResult.Text = result.Score.ToString();
        }
    }
}
