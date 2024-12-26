using Tyuiu.ShakirovaGM.Sprint6.Task0.V2.Lib;

namespace Tyuiu.ShakirovaGM.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void textBoxResult_SGM_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            textBoxResult_SGM.Text = Convert.ToString(ds.Calculate(x));
        }
    }
}
