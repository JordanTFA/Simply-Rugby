using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimplyRugby
{
	public class FormPlayers : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnEdit;
		private System.ComponentModel.Container components = null;

        private string playerName = string.Empty;
        
        
        // Displays the interface
        private Label lblSimplyRugby;
        private ListBox lstPlayers;
        private GroupBox grpSquad;
        private RadioButton radioSenior;
        private RadioButton radioNonPlayer;
        private RadioButton radioJunior;
        private string squad = "";
        private Button btnExit;

        private string aSquad;
        /// <summary>
        /// Constructor
        /// </summary>
		public FormPlayers()
		{
			InitializeComponent();
		}


        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            // Displays an error if the user has not selected a squad
            if (!radioJunior.Checked && !radioNonPlayer.Checked && !radioSenior.Checked)
            {
                MessageBox.Show("Please select a squad");
            }
            else
            {
                playerName = lstPlayers.SelectedItem.ToString();
                // Sets the player's squad
                squad = aSquad;
                this.Close();
            }
        }		
		// Properties

        public string PlayerName
        {
            get
            {
                return playerName;
            }
        }
        
        public string Range
        {
            get
            {
                return squad;
            }
        }

		#region Windows Form Designer generated code
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSimplyRugby = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.grpSquad = new System.Windows.Forms.GroupBox();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.radioNonPlayer = new System.Windows.Forms.RadioButton();
            this.radioJunior = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSquad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(313, 285);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Player";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSimplyRugby
            // 
            this.lblSimplyRugby.AutoSize = true;
            this.lblSimplyRugby.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimplyRugby.Location = new System.Drawing.Point(199, 42);
            this.lblSimplyRugby.Name = "lblSimplyRugby";
            this.lblSimplyRugby.Size = new System.Drawing.Size(212, 37);
            this.lblSimplyRugby.TabIndex = 4;
            this.lblSimplyRugby.Text = "Simply Rugby";
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(313, 148);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(266, 108);
            this.lstPlayers.TabIndex = 5;
            // 
            // grpSquad
            // 
            this.grpSquad.Controls.Add(this.radioSenior);
            this.grpSquad.Controls.Add(this.radioNonPlayer);
            this.grpSquad.Controls.Add(this.radioJunior);
            this.grpSquad.Location = new System.Drawing.Point(58, 148);
            this.grpSquad.Name = "grpSquad";
            this.grpSquad.Size = new System.Drawing.Size(157, 108);
            this.grpSquad.TabIndex = 6;
            this.grpSquad.TabStop = false;
            this.grpSquad.Text = "Select a Squad";
            // 
            // radioSenior
            // 
            this.radioSenior.AutoSize = true;
            this.radioSenior.Location = new System.Drawing.Point(17, 68);
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.Size = new System.Drawing.Size(55, 17);
            this.radioSenior.TabIndex = 2;
            this.radioSenior.TabStop = true;
            this.radioSenior.Text = "Senior";
            this.radioSenior.UseVisualStyleBackColor = true;
            this.radioSenior.CheckedChanged += new System.EventHandler(this.radioSenior_CheckedChanged);
            // 
            // radioNonPlayer
            // 
            this.radioNonPlayer.AutoSize = true;
            this.radioNonPlayer.Location = new System.Drawing.Point(17, 44);
            this.radioNonPlayer.Name = "radioNonPlayer";
            this.radioNonPlayer.Size = new System.Drawing.Size(77, 17);
            this.radioNonPlayer.TabIndex = 1;
            this.radioNonPlayer.TabStop = true;
            this.radioNonPlayer.Text = "Non-Player";
            this.radioNonPlayer.UseVisualStyleBackColor = true;
            this.radioNonPlayer.CheckedChanged += new System.EventHandler(this.radioNonPlayer_CheckedChanged);
            // 
            // radioJunior
            // 
            this.radioJunior.AutoSize = true;
            this.radioJunior.Location = new System.Drawing.Point(17, 20);
            this.radioJunior.Name = "radioJunior";
            this.radioJunior.Size = new System.Drawing.Size(53, 17);
            this.radioJunior.TabIndex = 0;
            this.radioJunior.TabStop = true;
            this.radioJunior.Text = "Junior";
            this.radioJunior.UseVisualStyleBackColor = true;
            this.radioJunior.CheckedChanged += new System.EventHandler(this.radioJunior_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormPlayers
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(645, 338);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSimplyRugby);
            this.Controls.Add(this.grpSquad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            this.grpSquad.ResumeLayout(false);
            this.grpSquad.PerformLayout();
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
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }
        
		#endregion

        private void radioJunior_CheckedChanged(object sender, EventArgs e)
        {
            // If the Junior radio button is checked, the program will the player's squad as "Junior"
            // It also prepares to read from the Junior players
            if (radioJunior.Checked)
            {
                aSquad = "Junior";
                ArrayList Juniorplayers = PlayerData.JuniorPlayerList();
                lstPlayers.DataSource = Juniorplayers;  // Displays the Junior players in the listbox
            }
        }

        private void radioNonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            // If the NonPlayer radio button is checked, the program will the player's squad as "NonPlayer"
            // It also prepares to read from the NonPlayer players
            if (radioNonPlayer.Checked)
            {
                aSquad = "NonPlayer";
                ArrayList NonPlayer = PlayerData.NonPlayerList();
                lstPlayers.DataSource = NonPlayer;  // Displays the NonPlayers in the listbox
            }
        }

        private void radioSenior_CheckedChanged(object sender, EventArgs e)
        {
            // If the Senior radio button is checked, the program will the player's squad as "Senior"
            // It also prepares to read from the Senior players
            if (radioSenior.Checked)
            {
                aSquad = "Senior";
                ArrayList Seniorplayers = PlayerData.SeniorPlayerList();
                lstPlayers.DataSource = Seniorplayers;  // Displays the Senior players in the listbox
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the program
            Process.GetCurrentProcess().Kill();
        }

	}
}
