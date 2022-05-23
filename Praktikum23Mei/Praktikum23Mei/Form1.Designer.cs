namespace Praktikum23Mei
{
    partial class FormPlayer
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
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbPlayerID = new System.Windows.Forms.TextBox();
            this.TbPlayerName = new System.Windows.Forms.TextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.NudTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.LblAvailibility = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbTeam = new System.Windows.Forms.ComboBox();
            this.CbNationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(12, 23);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(89, 30);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "<<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(117, 23);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(89, 30);
            this.BtnPrev.TabIndex = 1;
            this.BtnPrev.Text = "<";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(225, 23);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(89, 30);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(333, 23);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(89, 30);
            this.BtnLast.TabIndex = 2;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nationality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "BirthDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Team Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Team";
            // 
            // TbPlayerID
            // 
            this.TbPlayerID.Location = new System.Drawing.Point(137, 68);
            this.TbPlayerID.Name = "TbPlayerID";
            this.TbPlayerID.Size = new System.Drawing.Size(285, 22);
            this.TbPlayerID.TabIndex = 10;
            // 
            // TbPlayerName
            // 
            this.TbPlayerName.Location = new System.Drawing.Point(137, 102);
            this.TbPlayerName.Name = "TbPlayerName";
            this.TbPlayerName.Size = new System.Drawing.Size(285, 22);
            this.TbPlayerName.TabIndex = 11;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(137, 136);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(285, 22);
            this.DtpBirthDate.TabIndex = 12;
            // 
            // NudTeamNumber
            // 
            this.NudTeamNumber.Location = new System.Drawing.Point(137, 238);
            this.NudTeamNumber.Name = "NudTeamNumber";
            this.NudTeamNumber.Size = new System.Drawing.Size(121, 22);
            this.NudTeamNumber.TabIndex = 15;
            this.NudTeamNumber.ValueChanged += new System.EventHandler(this.NudTeamNumber_ValueChanged);
            // 
            // LblAvailibility
            // 
            this.LblAvailibility.AutoSize = true;
            this.LblAvailibility.Location = new System.Drawing.Point(315, 240);
            this.LblAvailibility.Name = "LblAvailibility";
            this.LblAvailibility.Size = new System.Drawing.Size(64, 16);
            this.LblAvailibility.TabIndex = 16;
            this.LblAvailibility.Text = "Available";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 273);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(191, 30);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(231, 273);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(191, 30);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbTeam
            // 
            this.CbTeam.FormattingEnabled = true;
            this.CbTeam.Location = new System.Drawing.Point(137, 204);
            this.CbTeam.Name = "CbTeam";
            this.CbTeam.Size = new System.Drawing.Size(285, 24);
            this.CbTeam.TabIndex = 14;
            // 
            // CbNationality
            // 
            this.CbNationality.FormattingEnabled = true;
            this.CbNationality.Location = new System.Drawing.Point(137, 170);
            this.CbNationality.Name = "CbNationality";
            this.CbNationality.Size = new System.Drawing.Size(285, 24);
            this.CbNationality.TabIndex = 13;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 331);
            this.Controls.Add(this.CbNationality);
            this.Controls.Add(this.CbTeam);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblAvailibility);
            this.Controls.Add(this.NudTeamNumber);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.TbPlayerName);
            this.Controls.Add(this.TbPlayerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbPlayerID;
        private System.Windows.Forms.TextBox TbPlayerName;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.NumericUpDown NudTeamNumber;
        private System.Windows.Forms.Label LblAvailibility;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbTeam;
        private System.Windows.Forms.ComboBox CbNationality;
    }
}

