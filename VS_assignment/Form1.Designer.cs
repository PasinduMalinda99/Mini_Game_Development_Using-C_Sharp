namespace VS_assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBPig = new System.Windows.Forms.PictureBox();
            this.PBFarm = new System.Windows.Forms.PictureBox();
            this.PBForest = new System.Windows.Forms.PictureBox();
            this.PBTiger = new System.Windows.Forms.PictureBox();
            this.MarksTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFinalMarks = new System.Windows.Forms.Label();
            this.lblYouWon = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.PBCow = new System.Windows.Forms.PictureBox();
            this.PBSheep = new System.Windows.Forms.PictureBox();
            this.PBCock = new System.Windows.Forms.PictureBox();
            this.PBCat = new System.Windows.Forms.PictureBox();
            this.PBBear = new System.Windows.Forms.PictureBox();
            this.PBDeer = new System.Windows.Forms.PictureBox();
            this.PBLion = new System.Windows.Forms.PictureBox();
            this.PBElephant = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBForest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTiger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBElephant)).BeginInit();
            this.SuspendLayout();
            // 
            // PBPig
            // 
            this.PBPig.BackColor = System.Drawing.Color.Transparent;
            this.PBPig.Image = global::VS_assignment.Properties.Resources.pig;
            this.PBPig.Location = new System.Drawing.Point(133, 114);
            this.PBPig.Name = "PBPig";
            this.PBPig.Size = new System.Drawing.Size(136, 143);
            this.PBPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPig.TabIndex = 0;
            this.PBPig.TabStop = false;
            this.PBPig.Click += new System.EventHandler(this.PBPig_Click);
            this.PBPig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBPig_MouseMove);
            // 
            // PBFarm
            // 
            this.PBFarm.Image = global::VS_assignment.Properties.Resources.farm;
            this.PBFarm.Location = new System.Drawing.Point(164, 542);
            this.PBFarm.Name = "PBFarm";
            this.PBFarm.Size = new System.Drawing.Size(460, 388);
            this.PBFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFarm.TabIndex = 1;
            this.PBFarm.TabStop = false;
            // 
            // PBForest
            // 
            this.PBForest.Image = global::VS_assignment.Properties.Resources.forest1;
            this.PBForest.Location = new System.Drawing.Point(1104, 542);
            this.PBForest.Name = "PBForest";
            this.PBForest.Size = new System.Drawing.Size(460, 388);
            this.PBForest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBForest.TabIndex = 2;
            this.PBForest.TabStop = false;
            // 
            // PBTiger
            // 
            this.PBTiger.Image = global::VS_assignment.Properties.Resources.tiger;
            this.PBTiger.Location = new System.Drawing.Point(285, 114);
            this.PBTiger.Name = "PBTiger";
            this.PBTiger.Size = new System.Drawing.Size(136, 143);
            this.PBTiger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTiger.TabIndex = 3;
            this.PBTiger.TabStop = false;
            this.PBTiger.Click += new System.EventHandler(this.PBTiger_Click);
            this.PBTiger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBTiger_MouseMove);
            // 
            // MarksTimer
            // 
            this.MarksTimer.Tick += new System.EventHandler(this.MarksTimer_Tick);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarks.Location = new System.Drawing.Point(814, 500);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(138, 69);
            this.lblMarks.TabIndex = 4;
            this.lblMarks.Text = "+10";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(667, 425);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(464, 75);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "You\'re wrong !";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Enabled = true;
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // lblFinalMarks
            // 
            this.lblFinalMarks.AutoSize = true;
            this.lblFinalMarks.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalMarks.Location = new System.Drawing.Point(768, 24);
            this.lblFinalMarks.Name = "lblFinalMarks";
            this.lblFinalMarks.Size = new System.Drawing.Size(250, 51);
            this.lblFinalMarks.TabIndex = 6;
            this.lblFinalMarks.Text = "Marks 00";
            this.lblFinalMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYouWon
            // 
            this.lblYouWon.AutoSize = true;
            this.lblYouWon.Font = new System.Drawing.Font("Cooper Black", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYouWon.ForeColor = System.Drawing.Color.Maroon;
            this.lblYouWon.Location = new System.Drawing.Point(540, 215);
            this.lblYouWon.Name = "lblYouWon";
            this.lblYouWon.Size = new System.Drawing.Size(707, 144);
            this.lblYouWon.TabIndex = 7;
            this.lblYouWon.Text = "You Won !";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Curlz MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(804, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 116);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PBCow
            // 
            this.PBCow.Image = global::VS_assignment.Properties.Resources.cow;
            this.PBCow.Location = new System.Drawing.Point(437, 114);
            this.PBCow.Name = "PBCow";
            this.PBCow.Size = new System.Drawing.Size(136, 143);
            this.PBCow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCow.TabIndex = 9;
            this.PBCow.TabStop = false;
            this.PBCow.Click += new System.EventHandler(this.PBCow_Click);
            this.PBCow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBCow_MouseMove);
            // 
            // PBSheep
            // 
            this.PBSheep.Image = global::VS_assignment.Properties.Resources.sheep;
            this.PBSheep.Location = new System.Drawing.Point(741, 114);
            this.PBSheep.Name = "PBSheep";
            this.PBSheep.Size = new System.Drawing.Size(136, 143);
            this.PBSheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSheep.TabIndex = 10;
            this.PBSheep.TabStop = false;
            this.PBSheep.Click += new System.EventHandler(this.PBSheep_Click);
            this.PBSheep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBSheep_MouseMove);
            // 
            // PBCock
            // 
            this.PBCock.Image = global::VS_assignment.Properties.Resources.cock;
            this.PBCock.Location = new System.Drawing.Point(893, 114);
            this.PBCock.Name = "PBCock";
            this.PBCock.Size = new System.Drawing.Size(136, 143);
            this.PBCock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCock.TabIndex = 11;
            this.PBCock.TabStop = false;
            this.PBCock.Click += new System.EventHandler(this.PBCock_Click);
            this.PBCock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBCock_MouseMove);
            // 
            // PBCat
            // 
            this.PBCat.Image = global::VS_assignment.Properties.Resources.cat;
            this.PBCat.Location = new System.Drawing.Point(1197, 114);
            this.PBCat.Name = "PBCat";
            this.PBCat.Size = new System.Drawing.Size(136, 143);
            this.PBCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCat.TabIndex = 12;
            this.PBCat.TabStop = false;
            this.PBCat.Click += new System.EventHandler(this.PBCat_Click);
            this.PBCat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBCat_MouseMove);
            // 
            // PBBear
            // 
            this.PBBear.Image = global::VS_assignment.Properties.Resources.bear;
            this.PBBear.Location = new System.Drawing.Point(589, 114);
            this.PBBear.Name = "PBBear";
            this.PBBear.Size = new System.Drawing.Size(136, 143);
            this.PBBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBBear.TabIndex = 13;
            this.PBBear.TabStop = false;
            this.PBBear.Click += new System.EventHandler(this.PBBear_Click);
            this.PBBear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBBear_MouseMove);
            // 
            // PBDeer
            // 
            this.PBDeer.Image = global::VS_assignment.Properties.Resources.deer;
            this.PBDeer.Location = new System.Drawing.Point(1045, 114);
            this.PBDeer.Name = "PBDeer";
            this.PBDeer.Size = new System.Drawing.Size(136, 143);
            this.PBDeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBDeer.TabIndex = 14;
            this.PBDeer.TabStop = false;
            this.PBDeer.Click += new System.EventHandler(this.PBDeer_Click);
            this.PBDeer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBDeer_MouseMove);
            // 
            // PBLion
            // 
            this.PBLion.Image = global::VS_assignment.Properties.Resources.Lion;
            this.PBLion.Location = new System.Drawing.Point(1349, 114);
            this.PBLion.Name = "PBLion";
            this.PBLion.Size = new System.Drawing.Size(136, 143);
            this.PBLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLion.TabIndex = 15;
            this.PBLion.TabStop = false;
            this.PBLion.Click += new System.EventHandler(this.PBLion_Click);
            this.PBLion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBLion_MouseMove);
            // 
            // PBElephant
            // 
            this.PBElephant.Image = global::VS_assignment.Properties.Resources.Elephant;
            this.PBElephant.Location = new System.Drawing.Point(1501, 114);
            this.PBElephant.Name = "PBElephant";
            this.PBElephant.Size = new System.Drawing.Size(136, 143);
            this.PBElephant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBElephant.TabIndex = 16;
            this.PBElephant.TabStop = false;
            this.PBElephant.Click += new System.EventHandler(this.PBElephant_Click);
            this.PBElephant.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBElephant_MouseMove);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Teal;
            this.btnPlayAgain.Font = new System.Drawing.Font("Curlz MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayAgain.Location = new System.Drawing.Point(692, 381);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(403, 113);
            this.btnPlayAgain.TabIndex = 17;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1787, 942);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.PBElephant);
            this.Controls.Add(this.PBLion);
            this.Controls.Add(this.PBDeer);
            this.Controls.Add(this.PBBear);
            this.Controls.Add(this.PBCat);
            this.Controls.Add(this.PBCock);
            this.Controls.Add(this.PBSheep);
            this.Controls.Add(this.PBCow);
            this.Controls.Add(this.PBPig);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblYouWon);
            this.Controls.Add(this.lblFinalMarks);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.PBTiger);
            this.Controls.Add(this.PBForest);
            this.Controls.Add(this.PBFarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBForest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTiger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBElephant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PBPig;
        private PictureBox PBFarm;
        private PictureBox PBForest;
        private PictureBox PBTiger;
        private System.Windows.Forms.Timer MarksTimer;
        private Label lblMarks;
        private Label lblError;
        private System.Windows.Forms.Timer ErrorTimer;
        private Label lblFinalMarks;
        private Label lblYouWon;
        private Button btnExit;
        private PictureBox PBCow;
        private PictureBox PBSheep;
        private PictureBox PBCock;
        private PictureBox PBCat;
        private PictureBox PBBear;
        private PictureBox PBDeer;
        private PictureBox PBLion;
        private PictureBox PBElephant;
        private Button btnPlayAgain;
    }
}