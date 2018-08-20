using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Rekenmachine
{
    public partial class Rekenmachine : Form
    {
        /// <summary>
        /// Het volgende moet er gebeuren:
        ///     Na het opstarten, bij elke button press moet dit naar het scherm gestuurd worden zodat men kan zien wat je berekend. Meerdere operatorsachter elkaar mag niet!
        ///         Er moet een stringbuilder bijgehouden worden voor de input.
        ///         Bij elke press moet er één methode gerunned worden die checkt WAT voor button het is
        ///     Bij cijfer -> operator -> cijfer -> operator moet er een tussentijdse berekening plaatsvinden. Bij "=" indrukken verdwijnt het scherm en komt het resultaat op het
        ///     tweede scherm te zien.
        /// </summary>



        private StringBuilder _input;
        private long _leftNum = 0;
        private long _rightNum = 0;
        private long _previousResult = 0;
        private List<char> operatorList = new List<char>() {'x', '/', '+', '-'};


        private int _indexPointer = 0;
        public Rekenmachine()
        {
            InitializeComponent();
            _input = new StringBuilder();
        }


        private void buttonOne_Click(object sender, EventArgs e)
        {
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {

        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
        }

        private void buttonNil_Click(object sender, EventArgs e)
        {
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            _input.Clear();
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            // not sure what this does on android calculator ? .~. TODO find out how to implement or remove this.
        }

        private long CalculateResult()
        {
            var input = _input.ToString();
/*            ;
            var @operator = new StringBuilder();*/

            


             
            // I want to use the operator on the left and right hand side and calculate it, then display the result on the second box
            // Then I have to make sure the left and right hand side 

        }

        private long CalculatePerOperator(char sign, long leftNum, long rightNum)
        {
            switch (sign)
            {
                case '+':
                    return leftNum + rightNum;
                case '-':
                    return leftNum - rightNum;
                case 'x':
                    return leftNum * rightNum;
                case '/':
                    return leftNum / rightNum;
                default:
                    return 0;
            }

        }

        private void buttonParaetheses_Click(object sender, EventArgs e)
        {
            /*if (!_input.ToString().Contains("("))
            {
                _input.Append("(");
            }
            else if (_input.ToString().Contains("("))
            {
                _input
            }*/

            // probably have to fix this with % counting the amount of '(' or ')' occurences
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignChange_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPressController(Button button)
        {
            foreach (var character in operatorList)
            {
                if (button.Text.Equals(character))
                {
                    // calculate intermediate result
                    // call new method, make this method have as arguement this button,
                    // calculate the result and display it.
                }
                else
                {
                    _indexPointer++;
                }
            }

            
            _input.Append(button.Text);
            textBoxInput.Text = _input.ToString();


        }
    }
}
