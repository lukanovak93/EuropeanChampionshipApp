namespace EuropeanChampionship
{
    partial class frmViewGroupGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameList = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TeamHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamHomeScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAwayScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gameList)).BeginInit();
            this.SuspendLayout();
            // 
            // gameList
            // 
            this.gameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamHome,
            this.TeamHomeScore,
            this.TeamAwayScore,
            this.TeamAway});
            this.gameList.Location = new System.Drawing.Point(27, 46);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(560, 219);
            this.gameList.TabIndex = 0;
            this.gameList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameList_CellEndEdit);
            this.gameList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameList_CellEndEdit);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(110, 317);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(158, 34);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Game";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeamHome
            // 
            this.TeamHome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamHome.FillWeight = 154.4224F;
            this.TeamHome.HeaderText = "Team Home";
            this.TeamHome.Name = "TeamHome";
            this.TeamHome.ReadOnly = true;
            // 
            // TeamHomeScore
            // 
            this.TeamHomeScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamHomeScore.FillWeight = 51.1558F;
            this.TeamHomeScore.HeaderText = "Home Score";
            this.TeamHomeScore.Name = "TeamHomeScore";
            // 
            // TeamAwayScore
            // 
            this.TeamAwayScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamAwayScore.FillWeight = 50.76142F;
            this.TeamAwayScore.HeaderText = "Away Score";
            this.TeamAwayScore.Name = "TeamAwayScore";
            // 
            // TeamAway
            // 
            this.TeamAway.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamAway.FillWeight = 163.9903F;
            this.TeamAway.HeaderText = "Team Away";
            this.TeamAway.Name = "TeamAway";
            this.TeamAway.ReadOnly = true;
            // 
            // frmViewGroupGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.gameList);
            this.Name = "frmViewGroupGames";
            this.Text = "frmViewTeams";
            ((System.ComponentModel.ISupportInitialize)(this.gameList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameList;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamHomeScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAwayScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAway;
    }
}