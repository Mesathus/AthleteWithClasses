using System;
using System.Windows.Forms;

namespace AthleteWithClasses
{
    public partial class AthleteEntry : Form
    {
        public AthleteEntry()
        {
            InitializeComponent();
        }

        public Athlete a { get; set; }        

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Athlete a;
            try
            {
                decimal salary;
                if(txtName.Text.Length < 1)
                {
                    MessageBox.Show("Please enter a name.");
                }
                else if(decimal.TryParse(txtSalary.Text, out salary) && salary < 10000m)
                {
                    MessageBox.Show("Please enter a valid salary.");
                }
                else
                {
                    string name = txtName.Text;
                    a = new Athlete(name, salary);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show(string.Format("{0}\nConfirmed.", a.ToString()));
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
            }
        }
    }
}
