using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum23Mei
{
    public partial class FormPlayer : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand = new MySqlCommand();
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtPemain;
        int index = 0;

        void updateTable()
        {
            dtPemain = new DataTable();
            sqlQuery = "SELECT p.player_id AS 'PlayerID', p.player_name AS 'PlayerName', p.birthdate AS 'BirthDate', p.nationality_id AS 'Nationality', p.team_id AS 'Team', p.team_number AS 'Number' FROM `player` p;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
        }

        void isiDataPemain(int indexPemain)
        {
            TbPlayerID.Text = dtPemain.Rows[indexPemain]["PlayerID"].ToString();
            TbPlayerName.Text = dtPemain.Rows[indexPemain]["PlayerName"].ToString();
            DtpBirthDate.Value = Convert.ToDateTime(dtPemain.Rows[indexPemain]["BirthDate"]);
            CbNationality.SelectedValue = dtPemain.Rows[indexPemain]["Nationality"].ToString();
            CbTeam.SelectedValue = dtPemain.Rows[indexPemain]["Team"].ToString();
            NudTeamNumber.Value = Convert.ToDecimal(dtPemain.Rows[indexPemain]["Number"].ToString());
        }

        public FormPlayer()
        {
            InitializeComponent();
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {
            DataTable teamList = new DataTable();
            dtPemain = new DataTable();
            sqlQuery = "SELECT * FROM `team`;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamList);
            CbTeam.DataSource = teamList;
            CbTeam.DisplayMember = "team_name";
            CbTeam.ValueMember = "team_id";

            DataTable nationalityList = new DataTable();
            sqlQuery = "SELECT * FROM nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(nationalityList);
            CbNationality.DataSource = nationalityList;
            CbNationality.DisplayMember = "nation";
            CbNationality.ValueMember = "nationality_id";

            updateTable();
            isiDataPemain(0);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                index = 0;
                isiDataPemain(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index--;
                    isiDataPemain(index);
                }
                else MessageBox.Show("Sudah data pertama");
                isiDataPemain(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < dtPemain.Rows.Count - 1)
                {
                    index++;
                    isiDataPemain(index);
                }
                else MessageBox.Show("Sudah data terakhir");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            try
            {
                index = dtPemain.Rows.Count - 1;
                isiDataPemain(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string prevID = dtPemain.Rows[index]["PlayerID"].ToString();
            try
            {
                if (LblAvailibility.Text == "Available")
                {
                    sqlConnect.Open();
                    sqlQuery = $"SELECT COUNT(player_id) FROM player WHERE player_id = '{TbPlayerID.Text}' AND player_id != '{prevID}';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    bool idNotAvailable = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                    sqlConnect.Close();

                    if (idNotAvailable)
                    {
                        MessageBox.Show("Error : ID Tidak Tersedia");
                        TbPlayerID.Text = prevID;
                        TbPlayerID.Focus();
                    }
                    else
                    {
                        sqlConnect.Open();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlQuery = $"UPDATE player SET player_id = '{TbPlayerID.Text}', player_name = '{TbPlayerName.Text}', birthdate = '{DtpBirthDate.Value.ToString("yyyy-MM-dd")}', nationality_id = '{CbNationality.SelectedValue}', team_id = '{CbTeam.SelectedValue}', team_number = '{NudTeamNumber.Value}' WHERE player_id = '{prevID}';";
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                    
                        updateTable();
                        MessageBox.Show("Data updated");
                    }
                }
                else MessageBox.Show("Error : Team Number Not Available !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void NudTeamNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"SELECT COUNT(team_number) FROM player WHERE team_id = '{CbTeam.SelectedValue.ToString()}' AND team_number = '{NudTeamNumber.Value.ToString()}' AND team_number != {NudTeamNumber.Value.ToString()} GROUP BY team_id;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                bool numberNotAvailable = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                sqlConnect.Close();

                if (!numberNotAvailable) LblAvailibility.Text = "Available";
                else LblAvailibility.Text = "Not Available";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
