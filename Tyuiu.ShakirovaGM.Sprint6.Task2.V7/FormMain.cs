using Tyuiu.ShakirovaGM.Sprint6.Task2.V7.Lib;
namespace Tyuiu.ShakirovaGM.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_SGM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartStep_SGM.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_SGM.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewResult_SGM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                startStep++;
            }
        }
    }
}
