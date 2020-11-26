using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamsunRocketTeam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            graphics1.Visible = false;
            home1.Visible = true;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnHome.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            graphics1.Visible = false;
            home1.Visible = false;
            simCam1.Visible = true;
            telemetries1.Visible = false;
            BtnSimCam.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            graphics1.Visible = true;
            home1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnGraphhics.BackColor = Color.Gold;
            BtnSimCam.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            overview1.Visible = true;
            graphics1.Visible = false;
            home1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnOverview.BackColor = Color.Gold;
            BtnHome.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            BtnMap.BackColor = Color.Gold;
            BtnHome.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            home1.Visible = true;
            BtnHome.BackColor = Color.Gold;
        }

        private void BtnTelemetries_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            graphics1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = true;
            home1.Visible = false;
            BtnTelemetries.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
