﻿/*
* Created by:Tomas Nieto
* Created on: 2015-10-08
* Created for: ICS3U
* Daily Assignment – Unit #3-07
* This program changes the picture of a man to simulate it moving
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for pause
using System.Threading;

namespace WalkingMan
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            int loopCounter = 0;

            do
            {
                if (loopCounter == 0)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk2;
                }
                else if (loopCounter == 1)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk3;
                }
                else if (loopCounter == 2)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk4;
                }
                else if (loopCounter == 3)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk5;
                }
                else if (loopCounter == 4)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk6;
                }
                else if (loopCounter == 5)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk7;
                }
                else if (loopCounter == 6)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk8;
                }
                else if (loopCounter == 7)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk9;
                }
                else if (loopCounter == 8)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk10;
                }
                else if (loopCounter == 9)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk1;
                }

                loopCounter = loopCounter + 1;

                // pause
                this.Refresh();
                Thread.Sleep(100);

            } while (loopCounter < 10);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
