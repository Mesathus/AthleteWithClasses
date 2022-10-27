using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AthleteWithClasses
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ResetForm();
        }

        private Athlete ath;

        public bool CreateAthlete()
        {
            try
            {
                using (var athForm = new AthleteEntry())
                {
                    do
                    {
                        athForm.ShowDialog();
                    } while (athForm.DialogResult != DialogResult.OK);
                    ath = athForm.a;
                    lblAthName.Text = ath.Name;
                    AthUpdate(ath.Owed);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                return false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;                
                string job = GetJob();
                decimal salary = ath.Salary;
                if(name.Length < 1)  //checked a name was entered
                {
                    MessageBox.Show("You must enter a name for this hire.");
                    return;
                }
                if(job == null)  //check a radio button was selected
                {
                    MessageBox.Show(string.Format("You must pick a job for {0}",name));
                    return;
                }
                Professional newProf = new Professional(name, job, salary);
                ath.Hire(newProf);  //update athlete salary
                lboxProfs.Items.Add(newProf);  //update list box display
                AthUpdate(ath.Owed);  //update group box tracking athlete salary
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
            }
            txtName.Clear();
            rbtnAgent.Checked = false;
            rbtnLawyer.Checked = false;
            rbtnPA.Checked = false;
            rbtnTrainer.Checked = false;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lboxProfs.SelectedIndex;
            try
            {
                if(index == -1)
                {
                    MessageBox.Show("Please choose a professional from the list to remove.");
                    return;
                }
                Professional prof = (Professional)lboxProfs.SelectedItem;
                lboxProfs.Items.Remove(lboxProfs.SelectedItem);
                ath.Fire(prof);
                AthUpdate(ath.Owed);
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open dialog to SavedAthletes directory
            //let user choose file
            //ath = new Athlete
            try
            {
                ath = null;
                Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                DirectoryInfo importPath = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Athletes"));
                using (OpenFileDialog ofDialog = new OpenFileDialog())
                {
                    ofDialog.InitialDirectory = importPath.ToString();
                    ofDialog.Filter = "Text Files (*.txt) | *.txt";
                    if(ofDialog.ShowDialog() == DialogResult.OK)
                    {
                        lboxProfs.Items.Clear();
                        Stream filePath = ofDialog.OpenFile();
                        using(StreamReader inputFile = new StreamReader(filePath))
                        {
                            string[] athlete = inputFile.ReadLine().Split(',');
                            ath = new Athlete(athlete[0], decimal.Parse(athlete[1]));
                            Professional p;
                            string[] profData;
                            while (!inputFile.EndOfStream)
                            {
                                profData = inputFile.ReadLine().Split(',');
                                p = new Professional(profData[0], profData[1], ath.Salary);
                                lboxProfs.Items.Add(p);
                                ath.Hire(p);
                            }
                        }
                        AthUpdate(ath.Owed);
                        UnlockForm();
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                MessageBox.Show("An exception occured while trying to read the file.");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)  //update to handle identical athlete names
        {
            //create a list/array of professionals
            //export the athlete on the first line
            //export professionals line by line as csv
            try
            {
                Professional[] professionals = ath.Professionals;
                Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                DirectoryInfo exportPath = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Athletes"));
                if (!exportPath.Exists) Directory.CreateDirectory(exportPath.ToString());
                string logName = exportPath.ToString() + "\\" + ath.Name + ".txt";
                using (StreamWriter outputFile = new StreamWriter(logName))
                {
                    outputFile.WriteLine(string.Format("{0}, {1}", ath.Name, ath.Salary.ToString()));
                    foreach (Professional s in professionals)
                    {
                        outputFile.WriteLine(string.Format("{0},{1}",s.Name,s.Job));
                    }
                    MessageBox.Show("File written successfully.");
                }
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                MessageBox.Show("An exception occured while attempting to write the file.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Exit the program?", "Exit?", MessageBoxButtons.YesNo);
            if(exit == DialogResult.Yes) this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ath = null;
            ResetForm();
            if (CreateAthlete())
            {
                UnlockForm();
            }
            else
            {
                MessageBox.Show("An error has occured, check logs for details.");
            }
        }

        private void ResetForm()
        {
            txtName.Clear();
            txtName.Enabled = false;
            rbtnAgent.Checked = false;
            rbtnLawyer.Checked = false;
            rbtnPA.Checked = false;
            rbtnAgent.Checked = false;
            rbtnTrainer.Enabled = false;
            rbtnLawyer.Enabled = false;
            rbtnPA.Enabled = false;
            rbtnAgent.Enabled = false;
            exportToolStripMenuItem.Enabled = false;
            //btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = false;
        }

        private void UnlockForm()
        {
            txtName.Enabled = true;
            rbtnAgent.Checked = true;
            rbtnLawyer.Checked = true;
            rbtnPA.Checked = true;
            rbtnAgent.Checked = true;
            rbtnTrainer.Enabled = true;
            rbtnLawyer.Enabled = true;
            rbtnPA.Enabled = true;
            rbtnAgent.Enabled = true;
            exportToolStripMenuItem.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;
            txtName.Focus();
        }

        private void AthUpdate(decimal gross)
        {
            lblGross.Text = string.Format("Current total paid to professionals: {0}",gross.ToString("c"));
            lblTotal.Text = ath.Salary >= ath.Owed ? string.Format("Remainder of {0}'s salary: {1}",ath.Name,(ath.Salary - gross).ToString("c")) : 
                string.Format("{0} is in the red this season and will owe {1}", ath.Name, Math.Abs(ath.Salary - gross).ToString("c"));
        }

        private string GetJob()
        {
            try
            {
                if (rbtnAgent.Checked) return "Agent";
                else if (rbtnLawyer.Checked) return "Lawyer";
                else if (rbtnPA.Checked) return "Personal Assistant";
                else if (rbtnTrainer.Checked) return "Trainer";
                else
                {
                    throw new WarningException();
                }
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                return null;
            }
        }
    }
}
