using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory_Game
{
    public partial class frmWelcomeScreen : Form
    {
        string path = @"E:\C#\Memory Game2\GameCache\savedGame.txt";
        string[] DataRetr = new string[6];
        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Hide();
            frmAboutGame fAbout = new frmAboutGame();
            fAbout.ShowDialog();
            frmInputNames fInput = new frmInputNames();
            fInput.ShowDialog();
            //frmGameEngine f = new frmGameEngine();
            //f.ShowDialog();
            Show();
        }

        private void btnResumeGame_Click(object sender, EventArgs e)
        {
                //Console.WriteLine(CountTextFileLines(path).ToString());
                ResumeGame();
                //foreach (string line in DataRetr)
                //    Console.WriteLine(line);
                frmGameEngine f = new frmGameEngine(DataRetr);
                f.ShowDialog();
                //Console.ReadLine();
        }
        #region Resume game function
        private void ResumeGame()
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                for (int i = 0; i < DataRetr.Length; i++)
                {

                    String line = sr.ReadLine();
                    string[] temp = line.Split(':');
                    DataRetr[i] = temp[1];
                }
                //foreach (string line in DataRetr)
                //    Console.WriteLine(line);
            }
            catch
            {
                MessageBox.Show("Resume file does not exist!");
                Close();
            }
            
        }
        #endregion
        private long CountTextFileLines(string file)
        {
            long count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
