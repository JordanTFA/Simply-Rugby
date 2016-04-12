using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace SimplyRugby
{

	public class Board : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components = null;
        private PlayerData playerData;
        private LevelSet levelSet;
        private Label lblPassComments;
        private TextBox passingCommentsTextBox;
        private Label lblPop;
        private Label lblSpin;
        private Label lblTacklingComments;
        private TextBox tacklingCommentsTextBox;
        private Label lblSide;
        private Label lblRear;
        private Label lblFront;
        private Label lblKickingComments;
        private TextBox KickingCommentsTextBox;
        private Label lblScrabble;
        private Label lblGoal;
        private Label lblGrubber;
        private Label lblPunt;
        private Label lblDrop;
        private Label lblStandard;
        private Button btnSave;
        private GroupBox grpPassing;
        private GroupBox grpTackling;
        private GroupBox grpKicking;
        private NumericUpDown udPassStan;
        private Button btnBack;
        private Label lblSkillsPage;
        private NumericUpDown udPassSpin;
        private NumericUpDown udPassPop;
        private NumericUpDown udTackFront;
        private NumericUpDown udTackRear;
        private NumericUpDown udTackSide;
        private NumericUpDown udTackScrabble;
        private NumericUpDown udKickDrop;
        private NumericUpDown udKickPunt;
        private NumericUpDown udKickGrubber;
        private NumericUpDown udKickGoal;

		public Board()
		{
			InitializeComponent();            
            InitializeGame();
        }
        

        private void InitializeGame()
        {
            levelSet = new LevelSet();
			FormPlayers formPlayers = new FormPlayers();
			formPlayers.ShowDialog();
			playerData = new PlayerData(formPlayers.PlayerName, formPlayers.Range);

            playerData.LoadPlayerInfo(levelSet);

            // Loads the player's skills into the respective updown numeric boxes
            playerData.LoadData();
            udPassStan.Text = playerData.Standard;
            udTackFront.Text = playerData.Drop;
            udPassSpin.Text = playerData.Spin;
            udPassPop.Text = playerData.Pop;
            passingCommentsTextBox.Text = playerData.PassingComments;
            udKickPunt.Text = playerData.Front;
            udTackRear.Text = playerData.Rear;
            udTackSide.Text = playerData.Scrabble;
            udTackScrabble.Text = playerData.Side;
            tacklingCommentsTextBox.Text = playerData.TacklingComments;
            udKickGoal.Text = playerData.Goal;
            udKickGrubber.Text = playerData.Grubber;
            udKickDrop.Text = playerData.Punt;
            KickingCommentsTextBox.Text = playerData.KickingComments;

		}
		#region Windows Form Designer generated code
		
        [STAThread]
        static void Main() 
        {
            Application.Run(new Board());
        }
        
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblPassComments = new System.Windows.Forms.Label();
            this.passingCommentsTextBox = new System.Windows.Forms.TextBox();
            this.lblPop = new System.Windows.Forms.Label();
            this.lblSpin = new System.Windows.Forms.Label();
            this.lblScrabble = new System.Windows.Forms.Label();
            this.lblTacklingComments = new System.Windows.Forms.Label();
            this.tacklingCommentsTextBox = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblRear = new System.Windows.Forms.Label();
            this.lblFront = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGrubber = new System.Windows.Forms.Label();
            this.lblPunt = new System.Windows.Forms.Label();
            this.lblDrop = new System.Windows.Forms.Label();
            this.lblKickingComments = new System.Windows.Forms.Label();
            this.KickingCommentsTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPassing = new System.Windows.Forms.GroupBox();
            this.udPassPop = new System.Windows.Forms.NumericUpDown();
            this.udPassSpin = new System.Windows.Forms.NumericUpDown();
            this.udPassStan = new System.Windows.Forms.NumericUpDown();
            this.grpTackling = new System.Windows.Forms.GroupBox();
            this.udTackScrabble = new System.Windows.Forms.NumericUpDown();
            this.udTackSide = new System.Windows.Forms.NumericUpDown();
            this.udTackRear = new System.Windows.Forms.NumericUpDown();
            this.udTackFront = new System.Windows.Forms.NumericUpDown();
            this.grpKicking = new System.Windows.Forms.GroupBox();
            this.udKickGoal = new System.Windows.Forms.NumericUpDown();
            this.udKickGrubber = new System.Windows.Forms.NumericUpDown();
            this.udKickPunt = new System.Windows.Forms.NumericUpDown();
            this.udKickDrop = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSkillsPage = new System.Windows.Forms.Label();
            this.grpPassing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPassPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPassSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPassStan)).BeginInit();
            this.grpTackling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTackScrabble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackRear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackFront)).BeginInit();
            this.grpKicking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udKickGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickGrubber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickPunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(24, 39);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(50, 13);
            this.lblStandard.TabIndex = 8;
            this.lblStandard.Text = "Standard";
            // 
            // lblPassComments
            // 
            this.lblPassComments.AutoSize = true;
            this.lblPassComments.Location = new System.Drawing.Point(6, 188);
            this.lblPassComments.Name = "lblPassComments";
            this.lblPassComments.Size = new System.Drawing.Size(56, 13);
            this.lblPassComments.TabIndex = 7;
            this.lblPassComments.Text = "Comments";
            // 
            // passingCommentsTextBox
            // 
            this.passingCommentsTextBox.Location = new System.Drawing.Point(9, 213);
            this.passingCommentsTextBox.Multiline = true;
            this.passingCommentsTextBox.Name = "passingCommentsTextBox";
            this.passingCommentsTextBox.Size = new System.Drawing.Size(193, 111);
            this.passingCommentsTextBox.TabIndex = 6;
            // 
            // lblPop
            // 
            this.lblPop.AutoSize = true;
            this.lblPop.Location = new System.Drawing.Point(24, 150);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(26, 13);
            this.lblPop.TabIndex = 5;
            this.lblPop.Text = "Pop";
            // 
            // lblSpin
            // 
            this.lblSpin.AutoSize = true;
            this.lblSpin.Location = new System.Drawing.Point(24, 89);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(28, 13);
            this.lblSpin.TabIndex = 4;
            this.lblSpin.Text = "Spin";
            // 
            // lblScrabble
            // 
            this.lblScrabble.AutoSize = true;
            this.lblScrabble.Location = new System.Drawing.Point(14, 139);
            this.lblScrabble.Name = "lblScrabble";
            this.lblScrabble.Size = new System.Drawing.Size(49, 13);
            this.lblScrabble.TabIndex = 17;
            this.lblScrabble.Text = "Scrabble";
            // 
            // lblTacklingComments
            // 
            this.lblTacklingComments.AutoSize = true;
            this.lblTacklingComments.Location = new System.Drawing.Point(14, 188);
            this.lblTacklingComments.Name = "lblTacklingComments";
            this.lblTacklingComments.Size = new System.Drawing.Size(56, 13);
            this.lblTacklingComments.TabIndex = 15;
            this.lblTacklingComments.Text = "Comments";
            // 
            // tacklingCommentsTextBox
            // 
            this.tacklingCommentsTextBox.Location = new System.Drawing.Point(17, 213);
            this.tacklingCommentsTextBox.Multiline = true;
            this.tacklingCommentsTextBox.Name = "tacklingCommentsTextBox";
            this.tacklingCommentsTextBox.Size = new System.Drawing.Size(193, 111);
            this.tacklingCommentsTextBox.TabIndex = 14;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(14, 105);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(28, 13);
            this.lblSide.TabIndex = 13;
            this.lblSide.Text = "Side";
            // 
            // lblRear
            // 
            this.lblRear.AutoSize = true;
            this.lblRear.Location = new System.Drawing.Point(14, 75);
            this.lblRear.Name = "lblRear";
            this.lblRear.Size = new System.Drawing.Size(30, 13);
            this.lblRear.TabIndex = 12;
            this.lblRear.Text = "Rear";
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(14, 43);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(31, 13);
            this.lblFront.TabIndex = 11;
            this.lblFront.Text = "Front";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(37, 144);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(29, 13);
            this.lblGoal.TabIndex = 25;
            this.lblGoal.Text = "Goal";
            // 
            // lblGrubber
            // 
            this.lblGrubber.AutoSize = true;
            this.lblGrubber.Location = new System.Drawing.Point(34, 105);
            this.lblGrubber.Name = "lblGrubber";
            this.lblGrubber.Size = new System.Drawing.Size(45, 13);
            this.lblGrubber.TabIndex = 23;
            this.lblGrubber.Text = "Grubber";
            // 
            // lblPunt
            // 
            this.lblPunt.AutoSize = true;
            this.lblPunt.Location = new System.Drawing.Point(33, 75);
            this.lblPunt.Name = "lblPunt";
            this.lblPunt.Size = new System.Drawing.Size(29, 13);
            this.lblPunt.TabIndex = 22;
            this.lblPunt.Text = "Punt";
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.Location = new System.Drawing.Point(33, 42);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(30, 13);
            this.lblDrop.TabIndex = 21;
            this.lblDrop.Text = "Drop";
            // 
            // lblKickingComments
            // 
            this.lblKickingComments.AutoSize = true;
            this.lblKickingComments.Location = new System.Drawing.Point(37, 188);
            this.lblKickingComments.Name = "lblKickingComments";
            this.lblKickingComments.Size = new System.Drawing.Size(56, 13);
            this.lblKickingComments.TabIndex = 15;
            this.lblKickingComments.Text = "Comments";
            // 
            // KickingCommentsTextBox
            // 
            this.KickingCommentsTextBox.Location = new System.Drawing.Point(36, 213);
            this.KickingCommentsTextBox.Multiline = true;
            this.KickingCommentsTextBox.Name = "KickingCommentsTextBox";
            this.KickingCommentsTextBox.Size = new System.Drawing.Size(193, 111);
            this.KickingCommentsTextBox.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(790, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpPassing
            // 
            this.grpPassing.Controls.Add(this.udPassPop);
            this.grpPassing.Controls.Add(this.udPassSpin);
            this.grpPassing.Controls.Add(this.udPassStan);
            this.grpPassing.Controls.Add(this.lblSpin);
            this.grpPassing.Controls.Add(this.passingCommentsTextBox);
            this.grpPassing.Controls.Add(this.lblStandard);
            this.grpPassing.Controls.Add(this.lblPop);
            this.grpPassing.Controls.Add(this.lblPassComments);
            this.grpPassing.Location = new System.Drawing.Point(37, 124);
            this.grpPassing.Name = "grpPassing";
            this.grpPassing.Size = new System.Drawing.Size(233, 330);
            this.grpPassing.TabIndex = 26;
            this.grpPassing.TabStop = false;
            this.grpPassing.Text = "Passing";
            // 
            // udPassPop
            // 
            this.udPassPop.Location = new System.Drawing.Point(109, 150);
            this.udPassPop.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPassPop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPassPop.Name = "udPassPop";
            this.udPassPop.Size = new System.Drawing.Size(54, 20);
            this.udPassPop.TabIndex = 31;
            this.udPassPop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udPassSpin
            // 
            this.udPassSpin.Location = new System.Drawing.Point(109, 87);
            this.udPassSpin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPassSpin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPassSpin.Name = "udPassSpin";
            this.udPassSpin.Size = new System.Drawing.Size(54, 20);
            this.udPassSpin.TabIndex = 30;
            this.udPassSpin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udPassStan
            // 
            this.udPassStan.Location = new System.Drawing.Point(109, 39);
            this.udPassStan.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPassStan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPassStan.Name = "udPassStan";
            this.udPassStan.Size = new System.Drawing.Size(54, 20);
            this.udPassStan.TabIndex = 29;
            this.udPassStan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTackling
            // 
            this.grpTackling.Controls.Add(this.udTackScrabble);
            this.grpTackling.Controls.Add(this.udTackSide);
            this.grpTackling.Controls.Add(this.udTackRear);
            this.grpTackling.Controls.Add(this.udTackFront);
            this.grpTackling.Controls.Add(this.lblFront);
            this.grpTackling.Controls.Add(this.lblScrabble);
            this.grpTackling.Controls.Add(this.lblRear);
            this.grpTackling.Controls.Add(this.tacklingCommentsTextBox);
            this.grpTackling.Controls.Add(this.lblSide);
            this.grpTackling.Controls.Add(this.lblTacklingComments);
            this.grpTackling.Location = new System.Drawing.Point(309, 124);
            this.grpTackling.Name = "grpTackling";
            this.grpTackling.Size = new System.Drawing.Size(262, 330);
            this.grpTackling.TabIndex = 27;
            this.grpTackling.TabStop = false;
            this.grpTackling.Text = "Tackling";
            // 
            // udTackScrabble
            // 
            this.udTackScrabble.Location = new System.Drawing.Point(87, 137);
            this.udTackScrabble.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udTackScrabble.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTackScrabble.Name = "udTackScrabble";
            this.udTackScrabble.Size = new System.Drawing.Size(52, 20);
            this.udTackScrabble.TabIndex = 21;
            this.udTackScrabble.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udTackSide
            // 
            this.udTackSide.Location = new System.Drawing.Point(87, 104);
            this.udTackSide.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udTackSide.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTackSide.Name = "udTackSide";
            this.udTackSide.Size = new System.Drawing.Size(52, 20);
            this.udTackSide.TabIndex = 20;
            this.udTackSide.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udTackRear
            // 
            this.udTackRear.Location = new System.Drawing.Point(87, 75);
            this.udTackRear.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udTackRear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTackRear.Name = "udTackRear";
            this.udTackRear.Size = new System.Drawing.Size(52, 20);
            this.udTackRear.TabIndex = 19;
            this.udTackRear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udTackFront
            // 
            this.udTackFront.Location = new System.Drawing.Point(87, 39);
            this.udTackFront.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udTackFront.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udTackFront.Name = "udTackFront";
            this.udTackFront.Size = new System.Drawing.Size(52, 20);
            this.udTackFront.TabIndex = 18;
            this.udTackFront.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpKicking
            // 
            this.grpKicking.Controls.Add(this.udKickGoal);
            this.grpKicking.Controls.Add(this.udKickGrubber);
            this.grpKicking.Controls.Add(this.udKickPunt);
            this.grpKicking.Controls.Add(this.udKickDrop);
            this.grpKicking.Controls.Add(this.lblDrop);
            this.grpKicking.Controls.Add(this.lblKickingComments);
            this.grpKicking.Controls.Add(this.KickingCommentsTextBox);
            this.grpKicking.Controls.Add(this.lblGoal);
            this.grpKicking.Controls.Add(this.lblPunt);
            this.grpKicking.Controls.Add(this.lblGrubber);
            this.grpKicking.Location = new System.Drawing.Point(608, 124);
            this.grpKicking.Name = "grpKicking";
            this.grpKicking.Size = new System.Drawing.Size(257, 330);
            this.grpKicking.TabIndex = 28;
            this.grpKicking.TabStop = false;
            this.grpKicking.Text = "Kicking";
            // 
            // udKickGoal
            // 
            this.udKickGoal.Location = new System.Drawing.Point(88, 136);
            this.udKickGoal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udKickGoal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udKickGoal.Name = "udKickGoal";
            this.udKickGoal.Size = new System.Drawing.Size(51, 20);
            this.udKickGoal.TabIndex = 29;
            this.udKickGoal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udKickGrubber
            // 
            this.udKickGrubber.Location = new System.Drawing.Point(88, 105);
            this.udKickGrubber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udKickGrubber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udKickGrubber.Name = "udKickGrubber";
            this.udKickGrubber.Size = new System.Drawing.Size(51, 20);
            this.udKickGrubber.TabIndex = 28;
            this.udKickGrubber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udKickPunt
            // 
            this.udKickPunt.Location = new System.Drawing.Point(88, 73);
            this.udKickPunt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udKickPunt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udKickPunt.Name = "udKickPunt";
            this.udKickPunt.Size = new System.Drawing.Size(51, 20);
            this.udKickPunt.TabIndex = 27;
            this.udKickPunt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udKickDrop
            // 
            this.udKickDrop.Location = new System.Drawing.Point(88, 41);
            this.udKickDrop.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udKickDrop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udKickDrop.Name = "udKickDrop";
            this.udKickDrop.Size = new System.Drawing.Size(51, 20);
            this.udKickDrop.TabIndex = 26;
            this.udKickDrop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(37, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSkillsPage
            // 
            this.lblSkillsPage.AutoSize = true;
            this.lblSkillsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillsPage.Location = new System.Drawing.Point(336, 32);
            this.lblSkillsPage.Name = "lblSkillsPage";
            this.lblSkillsPage.Size = new System.Drawing.Size(174, 37);
            this.lblSkillsPage.TabIndex = 31;
            this.lblSkillsPage.Text = "Skills Page";
            // 
            // Board
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(948, 475);
            this.Controls.Add(this.lblSkillsPage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpKicking);
            this.Controls.Add(this.grpTackling);
            this.Controls.Add(this.grpPassing);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpPassing.ResumeLayout(false);
            this.grpPassing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPassPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPassSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPassStan)).EndInit();
            this.grpTackling.ResumeLayout(false);
            this.grpTackling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTackScrabble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackRear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTackFront)).EndInit();
            this.grpKicking.ResumeLayout(false);
            this.grpKicking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udKickGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickGrubber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickPunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udKickDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }
        
		#endregion

        public void btnSave_Click(object sender, EventArgs e)
        {
            // Passes the new values for the player's skills to be saved
            playerData.SaveLevel(
                udPassStan.Text,
                udTackFront.Text,
                udPassSpin.Text,
                udPassPop.Text,
                passingCommentsTextBox.Text,
                udKickPunt.Text,
                udTackRear.Text,
                udTackSide.Text,
                udTackScrabble.Text,
                tacklingCommentsTextBox.Text,
                udKickGoal.Text,
                udKickGrubber.Text,
                udKickDrop.Text,
                KickingCommentsTextBox.Text);

            // Displays a message to show the user that the data is saved
            MessageBox.Show("Saved");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) // If yes, the program will save the changes and exit the form
            {
                playerData.SaveLevel(
                udPassStan.Text,
                udTackFront.Text,
                udPassSpin.Text,
                udPassPop.Text,
                passingCommentsTextBox.Text,
                udKickPunt.Text,
                udTackRear.Text,
                udTackSide.Text,
                udTackScrabble.Text,
                tacklingCommentsTextBox.Text,
                udKickGoal.Text,
                udKickGrubber.Text,
                udKickDrop.Text,
                KickingCommentsTextBox.Text);

                MessageBox.Show("Saved");

                InitializeGame();
            }
            if (result == DialogResult.No)  // If no, the program will exit the form without saving
            {
                InitializeGame();
            }
            this.Close();
        }

	}
}
