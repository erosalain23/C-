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
    public partial class frmWelcome : Form
    {
        string path = @"E:\C#\Memory Game\Game cache\savedGame.txt";
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmGameEngine f = new frmGameEngine();
            f.ShowDialog();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CountTextFileLines(path).ToString());
            ResumeGame();
        }
        #region Resume game function
        private void ResumeGame()
        {
            
            StreamReader sr = new StreamReader(path);
            long count = CountTextFileLines(path);
            string[] lines = new string[5];
            for (long i = count - 5; i < count; i++)
            {
                String line = sr.ReadLine();
                Console.WriteLine(line);
                //lines = line.Split(':');
            }
            foreach (string line in lines)
                Console.WriteLine(line);
            Console.ReadLine();
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
 
    }
}
