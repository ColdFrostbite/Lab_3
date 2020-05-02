using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic1;

namespace Solution
{
    public partial class ScrambleGame15 : Form
    {
        const int size = 4;
        Game game;
        
       
        public ScrambleGame15()
        {
            InitializeComponent();
            game = new Game(size);
            HideButtons();
        }

        private void bt_00_Click(object sender, EventArgs e)
        {
            if (game.Solved())
                return;
            Button button = (Button)sender;
            int x = int.Parse(button.Name.Substring(1,1));
            int y = int.Parse(button.Name.Substring(2, 1));
            game.PressButton(x, y);
            ShowButtons();
            if (game.Solved())
                labelMoves.Text = "Game finished in" + game.moves + "Moves";
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            game.StartGame(10);  //(1000 + DateTime.Now.DayOfYear);
            ShowButtons();
        }

        void HideButtons()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    ShowDigitAt(0, x, y);
            labelMoves.Text = "Welcome to Scramble!";
        }
        void ShowButtons()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    ShowDigitAt(game.GetDigitAt(x, y),x, y);
            labelMoves.Text = game.moves + "Moves";
        }

        void ShowDigitAt (int digit, int x, int y)
        {
            Button button = (Button)Controls["b" + x + y];
            button.Text = DecToHex(digit);
            button.Visible = digit > 0;
        }

        string DecToHex (int digit)
        {
            if (digit == 0) return "";
            if (digit < 10) return digit.ToString();
            return ((char)('A' + digit - 10)).ToString();
        }
    }
}
