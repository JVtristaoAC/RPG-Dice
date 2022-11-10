﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace RPG.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dices : ContentPage
    {

        Random random = new Random();
        public Dices()
        {
            
            InitializeComponent();
             
        }

        private void d4_Clicked(object sender, EventArgs e)
        {
           
            DisplayAlert(random.Next(1, 5).ToString(), "", "OK");
        }

        private void d6_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 7).ToString(), "", "OK");
        }

        private void d8_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 9).ToString(), "", "OK");
        }

        private void d10_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 11).ToString(), "", "OK");
        }

        private void d12_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 13).ToString(), "", "OK");
        }

        private void d20_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 21).ToString(), "", "OK");
        }

        private void d100_Clicked(object sender, EventArgs e)
        {
            
            DisplayAlert(random.Next(1, 101).ToString(), "", "OK");
        }

         private void d_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ent_custom.Text))
            {
                try
                {
                    int i = Convert.ToInt32(ent_custom.Text);                  
                    DisplayAlert(random.Next(1, i++).ToString(), "", "OK");
                    
                }
                catch
                {
                    DisplayAlert("ERRO", "Numero inválido", "OK");
                }
                
                               
               
            }
            
            
        }

        private void btn_Refresh_Clicked(object sender, EventArgs e)
        {
            lbl_d.Text = "d" + ent_custom.Text;
        }
    }
}