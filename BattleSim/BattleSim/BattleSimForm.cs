using System;
using System.Windows.Forms;

// TODO review code -- refactor, simplify etc.

namespace BattleSim
{
    public partial class BattleSimForm : Form
    {
        private readonly Player _playerOne = new Player("Player One");
        private readonly Player _playerTwo = new Player("Player Two");
        private readonly Random _rng = new Random();

        public BattleSimForm()
        {
            InitializeComponent();
            InitializeGame();
            playerOnePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playerTwoPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void InitializeGame()
        {
            var dice = _rng.Next(0, 2);
            // determine who may start
            if (dice == 1)
                playerTwoAttackBtn.Enabled = true;
            else
                playerOneAttackBtn.Enabled = true;

            // Set health
            healthLblPlayerOne.Text = _playerOne.Hitpoints.ToString();
            healthLblPlayerTwo.Text = _playerTwo.Hitpoints.ToString();

        }


        private void playerOneAttackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _playerOne.Attack(_playerTwo);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            playerOneAttackBtn.Enabled = false;
            playerTwoAttackBtn.Enabled = true;
            healthLblPlayerTwo.Text = _playerTwo.Hitpoints.ToString();
            SetHealthBar(healthBarPlayerTwo, _playerTwo.Hitpoints);
            CheckDead();
        }

        private void playerTwoAttackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _playerTwo.Attack(_playerOne);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            playerTwoAttackBtn.Enabled = false;
            playerOneAttackBtn.Enabled = true;
            healthLblPlayerOne.Text = _playerOne.Hitpoints.ToString();
            SetHealthBar(healthBarPlayerOne, _playerOne.Hitpoints);
            CheckDead();

        }

        private void CheckDead()
        {
            if (!(_playerOne.Alive && _playerTwo.Alive))
            {
                playerOneAttackBtn.Enabled = false;
                playerTwoAttackBtn.Enabled = false;
            }
        }

        private void SetHealthBar(ProgressBar healthBar, int hitpoints)
        {
            healthBar.Value = hitpoints;
        }


    }
}