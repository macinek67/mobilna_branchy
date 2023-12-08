using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna_branchy
{
    public partial class MainPage : ContentPage
    {
        public int likes = 0;
        public MainPage()
        {
            InitializeComponent();
            lbl_Likes.Text = likes + " likes";
        }

        private void Btn_Like_Clicked(object sender, EventArgs e)
        {
            likes++;
            lbl_Likes.Text = likes + " likes";
        }

        private void Btn_Dislike_Clicked(object sender, EventArgs e)
        {
            likes--;
            lbl_Likes.Text = likes + " likes";
        }
    }
}
