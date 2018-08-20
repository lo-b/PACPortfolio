using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Galgje.Properties;

namespace Galgje
{
    public partial class Galgje : Form
    {
        /// <summary>
        ///     The game will play out as follows:
        ///     1. User inputs word to be guessed into textbox, then clicks 'start playing!' and the game will start.
        ///     2.  Game will be initialized: new texbox, button and labels together with a PictureBox will be placed with the
        ///     starting image.
        ///     3. The user will now we able to guess a letter, when the button "Guess!" is pressed the following will happen:
        ///     4.  If it's a correct guess
        ///     5.      MessageBox will appear telling the user the guess was correct.
        ///     6.      Changed the labels from _ to the letter at the places this should occur
        ///     7.    If the guess was wrong
        ///     8.      New Image of gallows will be displayed into PictureBox,
        ///     9.      Add the guessed letter to list of already guessed letters
        ///     10.     Update the displayed guesses
        ///     11.     Increment guessed amount
        ///     12. Check state of the game: did the player lose, win or is he still eligible to play
        /// </summary
        ///
        ///

        private const int _maxGuesses = 10;
        private int _numOfFalseGuesses;

        private readonly List<string> _guessedLetters = new List<string>();
        private readonly StringBuilder _hiddenWord = new StringBuilder();
        private readonly StringBuilder _hiddenWordCopy = new StringBuilder();
        private readonly List<Label> _labels = new List<Label>();
        private readonly StringBuilder _guessedLettersBuilder = new StringBuilder("Already guessed: ");


        private Button _button;
        private PictureBox _pictureBox;
        private TextBox _textBoxGuess;
        private Label _wrongGuessesLabel;

        public Galgje()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            string hiddenWord = textBoxWord.Text.Trim().ToLower();
            // Sets the hidden word
            _hiddenWord.Append(hiddenWord);
            _hiddenWordCopy.Append(hiddenWord);
            // Disposes of old button and textBox
            textBoxWord.Dispose();
            buttonStartGame.Dispose();
            InitializeGame();
        }



        private void InitializeGame()
        {
            
            
            // Variables for positioning labels and other tools
            var counterX = 0;
            var counterY = Height - Height / 5;

            // Loop that creates a label for each letter in the word to be guessed
            for (var i = 0; i < _hiddenWord.Length; i++)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Location = new Point(counterX, counterY),
                    Name = "label",
                    Size = new Size(35, 13),
                    Text = "_"
                };
                Controls.Add(label);
                counterX += 20;
                _labels.Add(label);
            }

            // Adding textbox where the other user is able to put in his or her guess
            _textBoxGuess = new TextBox
            {
                Location = new Point(counterX, counterY),
                MaxLength = 1
            };
            Controls.Add(_textBoxGuess);

            // Adding button to confirm 
            _button = new Button
            {
                Location = new Point(_textBoxGuess.Location.X + _textBoxGuess.Width + 1, counterY),
                Text = "Guess!"
            };
            _button.Click += _button_Click;
            Controls.Add(_button);

            // Adding PictureBox to display the correct image of the gallows
            _pictureBox = new PictureBox
            {
                Height = 249,
                Width = 340
            };
            _pictureBox.Location = new Point(Width / 2 - _pictureBox.Width, Height / 2 - _pictureBox.Height);
            _pictureBox.BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(_pictureBox);

            // Label to keep track of already guessed letters
            _wrongGuessesLabel = new Label
            {
                AutoSize = true,
                Location = new Point(_pictureBox.Width + 80, _pictureBox.Height)
            };
            Controls.Add(_wrongGuessesLabel);
            // Setting up the initial white image
            _pictureBox.Image = Resources.galgjeStart;
        }

        private void _button_Click(object sender, EventArgs e)
        {
            var word = _hiddenWord.ToString();
            var guess = _textBoxGuess.Text.ToLower();

            // Check if the guess is new, if so then...
            if (!AlreadyGuessedCheck(guess))
            {
                // Check if the letter is in the word to be guessed
                if (word.Contains(guess))
                {
                    MessageBox.Show("Correct guess!");
                    LabelController(guess);
                }
                else
                {
                    // If not then increment the number of false guesses and update the image
                    _numOfFalseGuesses++;
                    _pictureBox.Image = LoadBitmap(_numOfFalseGuesses);

                }

                // Check the state of the game
                if (_numOfFalseGuesses == _maxGuesses)
                {
                    MessageBox.Show(String.Format("You've lost!\nThe Correct word was '{0}'", _hiddenWordCopy));
                }

                if (_hiddenWord.ToString().Equals(string.Concat(Enumerable.Repeat("_", _hiddenWord.Length))))
                {
                    MessageBox.Show("You've won!");
                }
                    


                _guessedLetters.Add(_textBoxGuess.Text);
                _guessedLettersBuilder.Append(guess + " ");
                _wrongGuessesLabel.Text = _guessedLettersBuilder.ToString().Trim();
            }
        }

        /// <summary>
        /// Sets correct labels to the correctly guessed letter
        /// </summary>
        /// <param name="letter">A string of the correctly guessed letter</param>
        private void LabelController(string letter)
        {
            // While the remaining to be guessed word contains the guessed letter...
            while (_hiddenWord.ToString().Contains(letter))
            {
                // Get index of the letter
                var indexOfLetter = _hiddenWord.ToString().IndexOf(letter);
                // Sets the corresponding label to the letter
                _labels[indexOfLetter].Text = letter;
                // Change the remaining to be guessed word replacing the letter with an '_'
                _hiddenWord.Replace(letter, "_", indexOfLetter, 1);
            }
        }


        /// <summary>
        /// Checks if the letter guessed was already guessed or not.
        /// </summary>
        /// <param name="guess">A string of the current guess</param>
        /// <returns>A bool wether the the letter was already guessed (true) or not (false)</returns>
        private bool AlreadyGuessedCheck(string guess)
        {
            foreach (var letter in _guessedLetters)
                if (guess.Equals(letter))
                {
                    MessageBox.Show("Already guessed that letter!");
                    return true;
                }

            return false;
        }

        /// <summary>
        /// Method of selecting the correct image.
        /// </summary>
        /// <param name="i">The number of false guesses</param>
        /// <returns>The image that corresponds to the number of false guesses at that time</returns>
        private Bitmap LoadBitmap(int i)
        {
            switch (i)
            {
                case 1:
                    return Resources.galgje1;
                case 2:
                    return Resources.galgje2;
                case 3:
                    return Resources.galgje3;
                case 4:
                    return Resources.galgje4;
                case 5:
                    return Resources.galgje5;
                case 6:
                    return Resources.galgje6;
                case 7:
                    return Resources.galgje7;
                case 8:
                    return Resources.galgje8;
                case 9:
                    return Resources.galgje9;
                case 10:
                    return Resources.galgje10;
                default:
                    return null;
            }
        }
    }
}