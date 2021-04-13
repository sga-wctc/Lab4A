using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void DotEntered(object sender, System.EventArgs e)
        {
            var str = entryLabel.Text;
            entryLabel.Text = str + '.';
        }
        void DashEntered(object sender, System.EventArgs e)
        {
            var str = entryLabel.Text;
            entryLabel.Text = str + '-';
        }
        void SpaceEntered(object sender, System.EventArgs e)
        {
            var str = entryLabel.Text;
            if (str.Length <=0)
            {
                str = messageLabel.Text;
                messageLabel.Text = str + " ";
            } else
            {
                char newChar = Morse.MorseCoder(str);
                str = messageLabel.Text;
                messageLabel.Text = str + newChar;
            }
            entryLabel.Text = "";

        }

    }

}

