using Tyuiu.ShakirovaGM.Sprint6.Task1.V8.Lib;
namespace Tyuiu.ShakirovaGM.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_SGM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartStep_SGM.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_SGM.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            textBoxResult_SGM.Text = "";
            textBoxResult_SGM.AppendText("+---------+----------+" + Environment.NewLine); // переход на новую строку
            textBoxResult_SGM.AppendText("+    X    +    Y     +" + Environment.NewLine);
            textBoxResult_SGM.AppendText("+---------+----------+" + Environment.NewLine);

            string strLine;
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5:d}   |  {1, 5:f2}   | ", startStep, valueArray[i]);
                textBoxResult_SGM.AppendText(strLine + Environment.NewLine);
                startStep++;
            }

            textBoxResult_SGM.AppendText("+---------+----------+" + Environment.NewLine);
        }

        private void buttonExample_SGM_Click(object sender, EventArgs e)
        {
         
        }
    }
}
