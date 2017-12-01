using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;

namespace BaconClicker
{
    class Upgrade
    {
        public enum Type
        {
            click,
            time
        };

        private int count;
        private int price;
        private readonly int multiplier;
        //C'est la meme valeur que dans UpgradeList dans buy...
        //this.score.addBaconParClick(1 * grill.getCount());
        //Pour pouvoir afficher l'effet qu'aura la prochaine upgrade
        private int value;

        private int p;
        private Type type;
        private UpgradeList list;

        //GUI
        private Image thumbnail;
        private string name;
        private Form1 form;
        private Panel panel;


        public Upgrade(int multiplier, int value, Image thumbnail, string name, Form1 form, Type type, UpgradeList list)
        {
            this.multiplier = multiplier;
            this.count = 0;
            this.price = 10;
            this.thumbnail = thumbnail;
            this.name = name;
            this.form = form;
            this.type = type;
            this.list = list;
            this.value = value;

            this.createUpgradeButton();
        }

        //Créée l'objet graphique de l'upgrade
        private void createUpgradeButton()
        {
            this.panel = new Panel();
            PictureBox picture = new PictureBox();
            Label name = new Label();
            Label lvl = new Label();
            Label lvlmultiplier = new Label();
            Label price = new Label();
            Label production = new Label();

            picture.Image = this.thumbnail;
            //On ajoute tous les évènements
            picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            picture.MouseEnter += new System.EventHandler(this.MouseEnter);
            picture.MouseLeave += new System.EventHandler(this.MouseLeave);
            picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            //Ecriture différente parce que besoin d'un prototype de fonction différent
            picture.Click += (sender, e) => this.list.buyUpgrade(this.name);
            picture.Click += (sender, e) => this.form.updateProduction();
            picture.Click += (sender, e) => this.updateText();

            name.Text = this.name;
            name.Font = new Font(FontFamily.GenericSansSerif, 24.0f, FontStyle.Regular);

            lvl.Text = "LVL : ";
            lvl.Font = new Font(FontFamily.GenericSansSerif, 15.0f, FontStyle.Regular);

            lvlmultiplier.Text = this.count.ToString();
            lvlmultiplier.Font = new Font(FontFamily.GenericSansSerif, 15.0f, FontStyle.Regular);
            lvlmultiplier.Name = "lvlmultiplier";

            price.Text = this.price.ToString();
            price.Font = new Font(FontFamily.GenericSansSerif, 18.0f, FontStyle.Regular);
            price.Name = "price";

            if (this.type == Type.time)
                production.Text = "+" + (this.value * this.count + 1).ToString() + " Bacon/s";
            else
                production.Text = "+" + (this.value * this.count + 1).ToString() + " Bacon/click";
            production.Name = "production";
            production.Font = new Font(FontFamily.GenericSansSerif, 24.0f, FontStyle.Regular);

            this.panel.Size = new Size(625, 100);

            this.panel.Controls.Add(picture);
            picture.Size = new Size(100, 100);
            picture.BackgroundImageLayout = ImageLayout.Tile;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(0, 0);
            picture.Dock = DockStyle.Left;

            this.panel.Controls.Add(name);
            name.AutoSize = true;
            name.Location = new Point(109, 4);
            name.Size = new Size(268, 46);

            this.panel.Controls.Add(lvl);
            lvl.AutoSize = true;
            lvl.Location = new Point(383, 17);
            lvl.Size = new Size(72, 29);

            this.panel.Controls.Add(lvlmultiplier);
            lvlmultiplier.AutoSize = true;
            lvlmultiplier.Location = new Point(461, 17);
            lvlmultiplier.Size = new Size(27, 29);

            this.panel.Controls.Add(price);
            price.AutoSize = true;
            price.Location = new Point(528, 30);
            price.Size = new Size(83, 36);

            this.panel.Controls.Add(production);
            production.AutoSize = true;
            production.Location = new Point(139, 50);
            production.Size = new Size(182, 36);

            form.UpgradeFlowLayout.Controls.Add(this.panel);
        }

        public BigInteger buyUpgrade(BigInteger bacon)
        {


            if (bacon > price)
            {
                bacon -= price;
                this.price = (int)Math.Pow(2.71, Convert.ToDouble(this.count) * (0.15 + multiplier * 0.05)) * (multiplier * 10);
                this.count++;
            }

            return bacon;
        }

        public int getCount()
        {
            return this.count;
        }

        public void setCount(int count)
        {
            this.count = count;
            this.price = (int)Math.Pow(2.71, Convert.ToDouble(this.count-1) * (0.15 + multiplier * 0.05)) * (multiplier * 10);
        }

        public int getPrice()
        {
            return this.price;
        }

        private void MouseEnter(object sender, EventArgs e)
        {

            PictureBox pic = sender as PictureBox;
            pic.Image = Properties.Resources.plus;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = Properties.Resources.Bacon_icon;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = Properties.Resources.plus_click;
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Image = Properties.Resources.plus;
        }

        //update les valeurs affichées sur l'upgrade quand on achète
        public void updateText()
        {
            Label lvlmultiplier = this.panel.Controls.Find("lvlmultiplier", false)[0] as Label;
            Label price = this.panel.Controls.Find("price", false)[0] as Label;
            Label production = this.panel.Controls.Find("production", false)[0] as Label;

            lvlmultiplier.Text = this.count.ToString();
            price.Text = this.price.ToString();
            if (this.type == Type.time)
                production.Text = "+" + (this.value * (this.count + 1)).ToString() + " Bacon/s";
            else
                production.Text = "+" + (this.value * (this.count + 1)).ToString() + " Bacon/click";
        }
    }
}
