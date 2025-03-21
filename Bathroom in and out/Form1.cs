using System.Configuration;
using System.Diagnostics;

namespace Bathroom_in_and_out
{
    public partial class MainFromm : Form
    {
        string signouttimeperson1 = "00:00:00";
        string signouttimeperson2 = "00:00:00";

        private bool bathroomcheck = false;
        private bool watercheck = false;
        public bool _bathroomcheck
        {
            get
            {
                return this.bathroomcheck;

            }
            set
            {
                this.bathroomcheck = value;
            }
        }
        public bool _watercheck
        {
            get
            {
                return this.watercheck;
            }
            set
            {
                this.watercheck = value;
            }

        }


        string bathorwater2 = "";
        string bathorwater1 = "";


        public MainFromm()
        {
            InitializeComponent();

        }
        private void MainFormm(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),
                Convert.ToInt32(0.5 * workingRectangle.Height));

            this.Location = new System.Drawing.Point(20, 20);
        }


        private void BathroomWater_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (watercheck == true)
            {
                if (bathorwater1 != "")
                {
                    bathorwater2 = " went to go get water at: ";
                    watercheck = false;
                    bathroomcheck = false;
                }
                if (bathorwater1 == "")
                {
                    bathorwater1 = " went to go get water at: ";
                    watercheck = false;
                    bathroomcheck = false;

                }


            }
            if (bathroomcheck == true)
            {
                if (bathorwater1 != "")
                {
                    bathorwater2 = " went to the bathroom at: ";
                    watercheck = false;
                    bathroomcheck = false;
                }
                if (bathorwater1 == "")
                {
                    bathorwater1 = " went to the bathroom at: ";
                    watercheck = false;
                    bathroomcheck = false;
                }


            }
        }

        private void pmnamelist_Click(object sender, EventArgs e)
        {
            NamesListBox.Items.Clear();
            StreamReader inputFile;
            string theFile = "fakepm.txt";

            inputFile = File.OpenText(theFile);
            while (!inputFile.EndOfStream)
            {
                NamesListBox.Items.Add(inputFile.ReadLine());

            }
            inputFile.Close();


        }

        private void Amnamelist_Click(object sender, EventArgs e)
        {
            NamesListBox.Items.Clear();
            StreamReader inputFile;
            string theFile = "fakeam.txt";

            inputFile = File.OpenText(theFile);
            while (!inputFile.EndOfStream)
            {
                NamesListBox.Items.Add(inputFile.ReadLine());

            }
            inputFile.Close();
        }

        private void SignoutButton_Click(object sender, EventArgs e)
        {
            //pm
            if (DateTime.Now.TimeOfDay < new TimeSpan(12, 07, 0) && DateTime.Now.TimeOfDay > new TimeSpan(11, 40, 0))
            {
                MessageBox.Show("You can not sign out the first 10 minutes after class starts." + "\nYou must wait until 12:07 to sign out");
            }
            else if (DateTime.Now.TimeOfDay < new TimeSpan(13, 0, 0) && DateTime.Now.TimeOfDay > new TimeSpan(12, 50, 0))
            {
                MessageBox.Show("You can not sign out in the 10 minutes we have until break" + "\nYou must wait until break or 1:12 to sign out");
            }
            else if (DateTime.Now.TimeOfDay < new TimeSpan(13, 12, 0) && DateTime.Now.TimeOfDay > new TimeSpan(13, 22, 0))
            {
                MessageBox.Show("You can not sign out in the 10 minutes after break" + "\nYou must wait until 1:22 to sign out");
            }
            else if (DateTime.Now.TimeOfDay > new TimeSpan(14, 20, 0))
            {
                MessageBox.Show("You can not sign out anymore" + "\n please wait until class ends");
            }

            //am
            else if (DateTime.Now.TimeOfDay > new TimeSpan(7, 15, 0) && DateTime.Now.TimeOfDay < new TimeSpan(7, 25, 0))
            {
                MessageBox.Show("You can not sign out the first 10 minutes after class starts." + "\nYou must wait until 12:07 to sign out");
            }
            else if (DateTime.Now.TimeOfDay > new TimeSpan(8, 25, 0) && DateTime.Now.TimeOfDay < new TimeSpan(8, 35, 0))
            {
                MessageBox.Show("You can not sign out in the 10 minutes we have until break" + "\nYou must wait until break or 8:57 to sign out");
            }
            else if (DateTime.Now.TimeOfDay > new TimeSpan(8, 47, 0) && DateTime.Now.TimeOfDay < new TimeSpan(8, 57, 0))
            {
                MessageBox.Show("You can not sign out in the 10 minutes after break" + "\nYou must wait until 8:57 to sign out");
            }
            else if (DateTime.Now.TimeOfDay > new TimeSpan(9, 55, 0) && DateTime.Now.TimeOfDay < new TimeSpan(10, 10, 0))
            {
                MessageBox.Show("You can not sign out anymore" + "\n please wait until class ends");
            }

            else
            {
                string student = NamesListBox.SelectedItem?.ToString();
                if (persons1.Text == "" && NamesListBox.SelectedItem != null)
                {
                    bathroomWater bathroom_water = new bathroomWater(this);
                    bathroom_water.FormClosed += BathroomWater_FormClosed;
                    persons1.Text = student;
                    timelabel1.Text = DateTime.Now.ToString("hh:mm:ss");
                    signouttimeperson1 = DateTime.Now.ToString("hh:mm:ss");
                    bathroom_water.ShowDialog();

                }
                else if (persons2.Text == "" && persons1.Text != student && NamesListBox.SelectedItem != null)
                {
                    bathroomWater bathroom_water = new bathroomWater(this);
                    bathroom_water.FormClosed += BathroomWater_FormClosed;
                    persons2.Text = student;
                    timelabel2.Text = DateTime.Now.ToString("hh:mm:ss");
                    signouttimeperson2 = DateTime.Now.ToString("hh:mm:ss");
                    bathroom_water.ShowDialog();

                }
                else if (NamesListBox.SelectedItem == null)
                {
                    MessageBox.Show("Please pick a student to be signed out");
                }
                else if (persons1.Text == student)
                {
                    MessageBox.Show("That person is already signed out please choose somebody that isnt.");
                }

                else
                {
                    MessageBox.Show("Sorry there is too many people out of the room right now," + "\nplease wait until " + persons1.Text +
                        " or " + persons2.Text + " signs out." + "\nThankYou.");
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void persons2signin_Click(object sender, EventArgs e)
        {

            if (persons2.Text != "")
            {
                string day = DateTime.Now.ToString(" -MM-dd");
                string filetext = "day" + day + ".txt";
                string content = "Log entry: " + persons2.Text + bathorwater2 + signouttimeperson2 + " and signed in at" +
                                  DateTime.Now.ToString(" hh:mm:ss") + Environment.NewLine;
                File.AppendAllText(filetext, content);
                persons2.Text = "";
                timelabel2.Text = "";

            }
            else
            {
                MessageBox.Show("nobody is here to be signed out");
            }

        }

        private void persons1signin_Click(object sender, EventArgs e)
        {



            if (persons1.Text != "")
            {

                string day = DateTime.Now.ToString(" -MM-dd");
                string filetext = "day" + day + ".txt";
                string content = "Log entry: " + persons1.Text + bathorwater1 + signouttimeperson1 + " and signed in at" +
                                  DateTime.Now.ToString(" hh:mm:ss") + Environment.NewLine;
                File.AppendAllText(filetext, content);
                persons1.Text = "";
                timelabel1.Text = "";



            }
            else
            {
                MessageBox.Show("nobody is here to be signed out");
            }
            bathorwater1 = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.ToString(" -MM-dd");
            string filetext = "day" + day + ".txt";
            if (File.Exists(filetext))
            {
                Process.Start("notepad.exe", filetext);
            }
            else
            {
                Console.WriteLine("File not found!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainFromm_Load(object sender, EventArgs e)
        {

        }

        private void timelabel2_Click(object sender, EventArgs e)
        {

        }
    }
}