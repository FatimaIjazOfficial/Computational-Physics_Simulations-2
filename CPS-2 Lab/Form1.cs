using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS_2_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        //Potiential Field
        private void potientialFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PotentialField pf = new PotentialField(this, 10, 10); // Pass form reference
            pf.Run();
        }

        private RandomFunctions rf = new RandomFunctions();

        // 0 - 32
        private void randomNoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = rf.Random0To32();
            MessageBox.Show(x.ToString());
        }

        // Only 50
        private void only50RandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = rf.Only50Random();
            MessageBox.Show(x.ToString());
        }

        // 0 - 99
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int x = rf.Random0To99();
            MessageBox.Show(x.ToString());
        }

        // 0 - 0.9999
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            double x = rf.Random0To1();
            MessageBox.Show(x.ToString());
        }

        // 10 - 19
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int x = rf.Random10To19();
            MessageBox.Show(x.ToString());
        }

        // 10 - 19 (Float)
        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = rf.RandomFloat10To19();
            MessageBox.Show(x.ToString());
        }

        // Plot
        private void plotToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            rf.Plot(this);
        }

        // Correctness
        private void correctnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rf.CorrectnessCheck();
        }

        private void dRWFor1WalkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomWalkSimulator sim = new RandomWalkSimulator(this);
            sim.Run1DWalker();
        }

        private void dRWFor15WalkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomWalkSimulator sim = new RandomWalkSimulator(this);
            sim.Run1DMultipleWalkers();
        }

        private void dRWFor100WalkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomWalkSimulator sim = new RandomWalkSimulator(this);
            sim.Run2DWalker();
        }

        private void dRWFor500WalkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomWalkSimulator sim = new RandomWalkSimulator(this);
            sim.Run2DMultipleWalkers();
        }

        //self Avoiding random Walk
        private void selfAvoidingWalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfAvoidingWalk walk = new SelfAvoidingWalk();
            walk.Start(this.CreateGraphics());
        }             
    }
}