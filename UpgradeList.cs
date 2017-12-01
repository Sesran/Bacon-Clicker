using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BaconClicker
{
    class UpgradeList
    {
        private Upgrade grill;
        private Upgrade grillFactory;
        private Upgrade grillTree;
        private Upgrade treeFactory;
        private Score score;

        public UpgradeList(Form1 form)
        {
            this.grill = new Upgrade(1, 1, Properties.Resources.Bacon_icon, "Grill", form, Upgrade.Type.click, this);
            this.grillFactory = new Upgrade(2, 1, Properties.Resources.Bacon_icon, "Grill Factory", form, Upgrade.Type.time, this);
            this.grillTree = new Upgrade(3, 10, Properties.Resources.Bacon_icon, "Grill Tree", form, Upgrade.Type.click, this);
            this.treeFactory = new Upgrade(4, 10, Properties.Resources.Bacon_icon, "Tree Factory", form, Upgrade.Type.time, this);
            this.score = new Score(form);
            this.score.startCountingBacon();
        }

        public UpgradeList(Form1 form, string save) : this(form)
        {
            try
            {
                string[] substrings = save.Split(';');
                string[] buff = substrings[0].Split(':');
                BigInteger savedScore;
                bool success = BigInteger.TryParse(buff[1], out savedScore);
                if (!success)
                {
                    Console.WriteLine("Erreur lors de la converison en Bigint");
                    return;
                }
                this.score.setScore(savedScore);

                buff = substrings[1].Split(':');
                int lvl = Int32.Parse(buff[1]);
                this.grill.setCount(lvl);
                for (int i = 0; i <= lvl; i++)
                    this.score.addBaconParClick(1 * (i));
                this.grill.updateText();

                buff = substrings[2].Split(':');
                lvl = Int32.Parse(buff[1]);
                this.grillFactory.setCount(lvl);
                for (int i = 0; i <= lvl; i++)
                    this.score.addBaconParSec(1 * (i));
                this.grillFactory.updateText();

                buff = substrings[3].Split(':');
                lvl = Int32.Parse(buff[1]);
                this.grillTree.setCount(lvl);
                for (int i = 0; i <= lvl; i++)
                    this.score.addBaconParClick(10 * (i));
                this.grillTree.updateText();

                buff = substrings[4].Split(':');
                lvl = Int32.Parse(buff[1]);
                this.treeFactory.setCount(lvl);
                for (int i = 0; i <= lvl; i++)
                    this.score.addBaconParSec(10 * (i));
                this.treeFactory.updateText();
            }
            catch
            {
                Console.WriteLine("Erreur lors du chargement de la sauvegarge");
            }
            
        }


        //Obligé de passer par la car impossible de différentier les 4 depuis la classe upgrade
        public int buyUpgrade(string name)
        {
            switch (name)
            {
                case "Grill":
                    return this.buyGrill();
                case "Grill Factory":
                    return this.buyGrillFactory();
                case "Grill Tree":
                    return this.buyGrillTree();
                case "Tree Factory":
                    return this.buyTreeFactory();
                default:
                    return 0;
            }
        }

        public int buyGrill()
        {
            this.score.buyWithBacon(this.grill.buyUpgrade(Score.getBacon()));
            this.score.addBaconParClick(1 * grill.getCount());
            return grill.getCount();
        }

        public int buyGrillFactory()
        {
            this.score.buyWithBacon(this.grillFactory.buyUpgrade(Score.getBacon()));
            this.score.addBaconParSec(1 * grillFactory.getCount());
            return grillFactory.getCount();
        }

        public int buyGrillTree()
        {
            this.score.buyWithBacon(this.grillTree.buyUpgrade(Score.getBacon()));
            this.score.addBaconParClick(10 * grillTree.getCount());
            return grillTree.getCount();
        }

        public int buyTreeFactory()
        {
            this.score.buyWithBacon(this.treeFactory.buyUpgrade(Score.getBacon()));
            this.score.addBaconParSec(10 * treeFactory.getCount());
            return treeFactory.getCount();
        }

        public int getGrillCount()
        {
            return grill.getCount();
        }

        public int getGrillFactoryCount()
        {
            return grillFactory.getCount();
        }

        public int getGrillTreeCount()
        {
            return grillTree.getCount();
        }

        public int getTreeFactoryCount()
        {
            return treeFactory.getCount();
        }

        public int getGrillPrice()
        {
            return grill.getPrice();
        }

        public int getGrillFactoryPrice()
        {
            return grillFactory.getPrice();
        }

        public int getGrillTreePrice()
        {
            return grillTree.getPrice();
        }

        public int getTreeFactoryPrice()
        {
            return treeFactory.getPrice();
        }


    }
}
