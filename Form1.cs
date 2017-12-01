using System;
using System.Numerics;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace BaconClicker
{
    public partial class Form1 : Form
    {
        //La 1ere upgrade est la pour m'aider à tester mes finctions on la supprmera à la fin

        //variable globale pour accèder plus bas
        UpgradeList list;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string save;

                // Read the file and display it line by line.  
                using (System.IO.StreamReader file = new System.IO.StreamReader("BaconClickerSave.dat"))
                {
                    save = file.ReadLine();
                }
                list = new UpgradeList(this, save);
            }
            catch
            {
                list = new UpgradeList(this);
            }
            this.startUpdateScore();
        }

        //On charge les valeurs au chargement de la fenetre
        private void Form1_Load(object sender, EventArgs e)
        {
            //Obligé de passer par cette forme bizarre sinon erreur car tente d'accèder à un thread auquel il ne fait partie
            this.scoreBacon.Invoke(new Action(() => this.scoreBacon.Text = Score.getBacon().ToString()));
            this.baconPerSecond.Invoke(new Action(() => this.baconPerSecond.Text = Score.getBaconParSec().ToString()));
            this.baconPerClick.Invoke(new Action(() => this.baconPerClick.Text = Score.getBaconParClick().ToString()));
        }

        //Compteur pour mettre à jour le label avec le score
        public void startUpdateScore()
        {
            System.Timers.Timer updateTimer;
            // Create a timer and set a one second interval.
            updateTimer = new System.Timers.Timer();
            updateTimer.Interval = 100;

            // Hook up the Elapsed event for the timer. 
            updateTimer.Elapsed += this.updateScore;

            // Have the timer fire repeated events (true is the default)
            updateTimer.AutoReset = true;

            // Start the timer
            updateTimer.Enabled = true;
        }

        private void updateScore(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.scoreBacon.Invoke(new Action(() => this.scoreBacon.Text = Score.getBacon().ToString()));
        }

        //Pas besoin de le mettre dans le compteur on l'appelle que quand on achète une upgrade
        public void updateProduction()
        {
            this.baconPerSecond.Invoke(new Action(() => this.baconPerSecond.Text = Score.getBaconParSec().ToString()));
            this.baconPerClick.Invoke(new Action(() => this.baconPerClick.Text = Score.getBaconParClick().ToString()));
        }

        //Quand on clique sur le gros bacon
        //on peut pas cliquer très vite, à voir si on a le temps
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Score.addBacon(Score.getBaconParClick());
            this.scoreBacon.Invoke(new Action(() => this.scoreBacon.Text = Score.getBacon().ToString()));
        }

        //
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(list.buyGrill());
            this.baconPerClick.Invoke(new Action(() => this.baconPerClick.Text = Score.getBaconParClick().ToString()));
        }

        private bool saveSession()
        {
            string save = "";
            save += "score:"+this.scoreBacon.Text+";";
            save += "grill:" + this.list.getGrillCount().ToString() + ";";
            save += "grillFactory:" + this.list.getGrillFactoryCount().ToString() + ";";
            save += "grillTree:" + this.list.getGrillTreeCount().ToString() + ";";
            save += "treeFactory:" + this.list.getTreeFactoryCount().ToString();

            // Write the string array to a new file named
            using (StreamWriter outputFile = new StreamWriter("BaconClickerSave.dat"))
            {
                outputFile.WriteLine(save);
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.saveSession();
        }

        private void manageFocus()
        {
            this.ActiveControl = removeFocus;
        }

        //this.label13.Click += new System.EventHandler(this.label13_Click);
    }
}
