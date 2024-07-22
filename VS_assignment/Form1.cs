namespace VS_assignment
{
    public partial class Form1 : Form
    {
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }


        //Move the picturebox without jumps
        private void PBPig_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                // PBPig.Left relative to the form
                //  e.X  relative to the picture box
                PBPig.Left += e.X;
                PBPig.Top += e.Y;
            }
          
        }
        
        private void PBPig_Click(object sender, EventArgs e)
        {
            // When pig hit the farm
            if (PBPig.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                // make pig invisible
                PBPig.Visible = false;
                // +10 visible
                lblMarks.Visible = true;

                //start the Marks timer
                MarksTimer.Enabled = true;
            }

            // when pig hit the forest
            if(PBPig.Bounds.IntersectsWith(PBForest.Bounds))
            {
                // Return to the initial position
                PBPig.Location = new Point(133, 114);

                // show "You are wrong" label
                lblError.Visible = true;

                // start the Error timer
                ErrorTimer.Enabled = true;
            }
        }

        private void PBTiger_Click(object sender, EventArgs e)
        {
            // when tiger hit the forest
            if (PBTiger.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBTiger.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }

            // when tiger hit the farm
            if (PBTiger.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBTiger.Location = new Point(285, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBTiger_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBTiger.Left += e.X;
                PBTiger.Top += e.Y;
            }
        }


        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMarks.Visible = false;
            lblError.Visible = false;
            lblYouWon.Visible = false;
            btnExit.Visible = false;
            btnPlayAgain.Visible = false;
        }

        private void MarksTimer_Tick(object sender, EventArgs e)
        {
            // hold the label for 200ms
            Thread.Sleep(200);

            // hide label
            lblMarks.Visible = false;

            // add marks
            sum += 10;

            // show the marks in the top label
            lblFinalMarks.Text = "Marks " + sum.ToString();

            // stop the timer
            MarksTimer.Enabled = false;

            // when sum reach 100
            if (sum == 100)
            {
               // Show Won label
                lblYouWon.Visible = true;
                
                // show the Exit button
                btnExit.Visible = true;

                // show "play again" label
                btnPlayAgain.Visible = true;
            }

        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
           // hold the "you are wrong" label for 500ms
            Thread.Sleep(500);

            // Hide the "you are wrong" label
            lblError.Visible = false;

            // Stop Error timer 
            ErrorTimer.Enabled = false;
        }


        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBCow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBCow.Left += e.X;
                PBCow.Top += e.Y;
            }
        }

        private void PBCow_Click(object sender, EventArgs e)
        {
            if (PBCow.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBCow.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBCow.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBCow.Location = new Point(437, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBSheep_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBSheep.Left += e.X;
                PBSheep.Top += e.Y;
            }
        }

        private void PBSheep_Click(object sender, EventArgs e)
        {
            if (PBSheep.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBSheep.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBSheep.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBSheep.Location = new Point(741, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBCock_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBCock.Left += e.X;
                PBCock.Top += e.Y;
            }
        }

        private void PBCock_Click(object sender, EventArgs e)
        {
            if (PBCock.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBCock.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBCock.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBCock.Location = new Point(893, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBCat_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBCat.Left += e.X;
                PBCat.Top += e.Y;
            }
        }

        private void PBCat_Click(object sender, EventArgs e)
        {
            if (PBCat.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBCat.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBCat.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBCat.Location = new Point(1197, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBBear_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBBear.Left += e.X;
                PBBear.Top += e.Y;
            }
        }

        private void PBBear_Click(object sender, EventArgs e)
        {
            if (PBBear.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBBear.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBBear.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBBear.Location = new Point(589, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBDeer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBDeer.Left += e.X;
                PBDeer.Top += e.Y;
            }
        }

        private void PBDeer_Click(object sender, EventArgs e)
        {
            if (PBDeer.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBDeer.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBDeer.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBDeer.Location = new Point(1045, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBLion_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBLion.Left += e.X;
                PBLion.Top += e.Y;
            }
        }

        private void PBLion_Click(object sender, EventArgs e)
        {
            if (PBLion.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBLion.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBLion.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBLion.Location = new Point(1349, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void PBElephant_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PBElephant.Left += e.X;
                PBElephant.Top += e.Y;
            }
        }

        private void PBElephant_Click(object sender, EventArgs e)
        {
            if (PBElephant.Bounds.IntersectsWith(PBForest.Bounds))
            {
                PBElephant.Visible = false;
                lblMarks.Visible = true;
                MarksTimer.Enabled = true;
            }
            if (PBElephant.Bounds.IntersectsWith(PBFarm.Bounds))
            {
                PBElephant.Location = new Point(1501, 114);
                lblError.Visible = true;
                ErrorTimer.Enabled = true;
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}