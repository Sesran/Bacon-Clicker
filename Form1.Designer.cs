namespace BaconClicker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.scoreBacon = new System.Windows.Forms.Label();
            this.baconPerSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpgradeFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baconPerClick = new System.Windows.Forms.Label();
            this.removeFocus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bacon : ";
            // 
            // scoreBacon
            // 
            this.scoreBacon.AccessibleName = "";
            this.scoreBacon.AutoSize = true;
            this.scoreBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBacon.Location = new System.Drawing.Point(156, 3);
            this.scoreBacon.Name = "scoreBacon";
            this.scoreBacon.Size = new System.Drawing.Size(27, 29);
            this.scoreBacon.TabIndex = 2;
            this.scoreBacon.Text = "0";
            this.scoreBacon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baconPerSecond
            // 
            this.baconPerSecond.AutoSize = true;
            this.baconPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baconPerSecond.Location = new System.Drawing.Point(57, 64);
            this.baconPerSecond.Name = "baconPerSecond";
            this.baconPerSecond.Size = new System.Drawing.Size(27, 29);
            this.baconPerSecond.TabIndex = 4;
            this.baconPerSecond.Text = "0";
            this.baconPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Production par seconde : ";
            // 
            // UpgradeFlowLayout
            // 
            this.UpgradeFlowLayout.AutoScroll = true;
            this.UpgradeFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpgradeFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.UpgradeFlowLayout.MinimumSize = new System.Drawing.Size(678, 563);
            this.UpgradeFlowLayout.Name = "UpgradeFlowLayout";
            this.UpgradeFlowLayout.Size = new System.Drawing.Size(678, 563);
            this.UpgradeFlowLayout.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1262, 563);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.GotFocus += (sender, e) => this.manageFocus();
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UpgradeFlowLayout);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 563);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BaconClicker.Properties.Resources.Bacon_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Production par clic : ";
            // 
            // baconPerClick
            // 
            this.baconPerClick.AccessibleName = "";
            this.baconPerClick.AutoSize = true;
            this.baconPerClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baconPerClick.Location = new System.Drawing.Point(589, 64);
            this.baconPerClick.Name = "baconPerClick";
            this.baconPerClick.Size = new System.Drawing.Size(27, 29);
            this.baconPerClick.TabIndex = 9;
            this.baconPerClick.Text = "0";
            this.baconPerClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // removeFocus
            // 
            this.removeFocus.AutoSize = true;
            this.removeFocus.Location = new System.Drawing.Point(13, 46);
            this.removeFocus.Name = "removeFocus";
            this.removeFocus.Size = new System.Drawing.Size(0, 17);
            this.removeFocus.TabIndex = 10;
            this.removeFocus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.removeFocus);
            this.Controls.Add(this.baconPerClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.baconPerSecond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scoreBacon);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacon Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreBacon;
        private System.Windows.Forms.Label baconPerSecond;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.FlowLayoutPanel UpgradeFlowLayout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label baconPerClick;
        private System.Windows.Forms.Label removeFocus;
    }
}

