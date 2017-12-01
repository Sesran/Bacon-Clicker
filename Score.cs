using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Timers;

namespace BaconClicker
{
    class Score
    {
        private static BigInteger Bacon;
        private static BigInteger BaconParSec;
        private static BigInteger BaconParClick;
        private Form1 form;

        public Score(Form1 form)
        {
            this.form = form;
            Score.Bacon = 0;
            Score.BaconParClick = 100;
            Score.BaconParSec = 10;
        }

        public Score(Form1 form, int b, int bps, int bpc)
        {
            Score.Bacon = new BigInteger(b);
            Score.BaconParSec = new BigInteger(bps);
            Score.BaconParClick = new BigInteger(bpc);
            this.form = form;
        }

        public static BigInteger addBacon(BigInteger nb)
        {
            Score.Bacon = BigInteger.Add(nb, Score.Bacon);
            return Score.Bacon;
        }

        public BigInteger buyWithBacon(BigInteger newBaconValue)
        {
            Score.Bacon = newBaconValue;
            return Score.Bacon;
        }

        public BigInteger addBaconParSec(BigInteger nb)
        {
            Score.BaconParSec = BigInteger.Add(nb, Score.BaconParSec);
            return Score.BaconParSec;
        }

        public BigInteger addBaconParClick(BigInteger nb)
        {
            Score.BaconParClick = BigInteger.Add(nb, Score.BaconParClick);
            return Score.BaconParClick;
        }

        public static BigInteger getBacon()
        {
            return Score.Bacon;
        }

        public void setScore(BigInteger score)
        {
            if (score == null)
                return;
            Bacon = score;
        }

        public static BigInteger getBaconParSec()
        {
            return Score.BaconParSec;
        }

        public static BigInteger getBaconParClick()
        {
            return Score.BaconParClick;
        }

        public void startCountingBacon()
        {
            Timer baconTimer;
            // Create a timer and set a one second interval.
            baconTimer = new Timer();
            baconTimer.Interval = 100;

            // Hook up the Elapsed event for the timer. 
            baconTimer.Elapsed += this.countBacon;

            // Have the timer fire repeated events (true is the default)
            baconTimer.AutoReset = true;

            // Start the timer
            baconTimer.Enabled = true;
        }

        private void countBacon(Object source, System.Timers.ElapsedEventArgs e)
        {
            Score.addBacon(Score.BaconParSec / 10);
            /*bool formAccess 
            this.form.updateScore(Bacon);*/
        }

    }
}
