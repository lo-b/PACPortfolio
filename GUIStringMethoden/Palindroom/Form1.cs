using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Palindroom
{
    public partial class Form1 : Form
    {
        private readonly StringBuilder _stringBuilderLeft;
        private readonly StringBuilder _stringBuilderRight;
        private readonly List<char> charList;
        private int inputLength;

        public Form1()
        {
            InitializeComponent();
            _stringBuilderLeft = new StringBuilder();
            _stringBuilderRight = new StringBuilder();
            charList = new List<char>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckPalindrome(textBoxUserInput.Text))
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }

        private bool CheckPalindrome(string input)
        {
            inputLength = input.Length;
            _stringBuilderLeft.Clear();
            _stringBuilderRight.Clear();

            if (input.Length % 2 == 0)
            {
                _stringBuilderLeft.Append(input.Substring(0, inputLength / 2));
                _stringBuilderRight.Append(input.Substring(inputLength / 2));


                return _stringBuilderLeft.ToString().Equals(RevertString(_stringBuilderRight.ToString()));
            }

            _stringBuilderLeft.Append(input.Substring(0, inputLength / 2));
            _stringBuilderRight.Append(input.Substring(inputLength / 2 + 1));

            return _stringBuilderLeft.ToString().Equals(RevertString(_stringBuilderRight.ToString()));
        }

        private string RevertString(string input)
        {
            charList.Clear();

            foreach (var character in input) charList.Add(character);

            charList.Reverse();

            return new string(charList.ToArray());
        }
    }
}