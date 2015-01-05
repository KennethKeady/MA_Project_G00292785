using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MA_Project_G00292785
{
    /// <summary>
    /// Premier League Guess The Crest Game
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int score;
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PremierLeague_Tapped(object sender, TappedRoutedEventArgs e)
        {
            HomeCanvas.Visibility = Visibility.Collapsed;
            PremierLeagueCanvas.Visibility = Visibility.Visible;
            Chelsea.Visibility = Visibility.Visible;
            btnChelsea1.Visibility = Visibility.Visible;
            btnChelsea2.Visibility = Visibility.Visible;
            btnChelsea3.Visibility = Visibility.Visible;
            btnChelsea4.Visibility = Visibility.Visible;
            ManCity.Visibility = Visibility.Collapsed;
            btnCity1.Visibility = Visibility.Collapsed;
            btnCity2.Visibility = Visibility.Collapsed;
            btnCity3.Visibility = Visibility.Collapsed;
            btnCity4.Visibility = Visibility.Collapsed;
            ManUtd.Visibility = Visibility.Collapsed;
            btnUtd1.Visibility = Visibility.Collapsed;
            btnUtd2.Visibility = Visibility.Collapsed;
            btnUtd3.Visibility = Visibility.Collapsed;
            btnUtd4.Visibility = Visibility.Collapsed;
            WestHam.Visibility = Visibility.Collapsed;
            btnWham1.Visibility = Visibility.Collapsed;
            btnWham2.Visibility = Visibility.Collapsed;
            btnWham3.Visibility = Visibility.Collapsed;
            btnWham4.Visibility = Visibility.Collapsed;
            Southampton.Visibility = Visibility.Collapsed;
            btnSoton1.Visibility = Visibility.Collapsed;
            btnSoton2.Visibility = Visibility.Collapsed;
            btnSoton3.Visibility = Visibility.Collapsed;
            btnSoton4.Visibility = Visibility.Collapsed;
            Arsenal.Visibility = Visibility.Collapsed;
            btnArsenal1.Visibility = Visibility.Collapsed;
            btnArsenal2.Visibility = Visibility.Collapsed;
            btnArsenal3.Visibility = Visibility.Collapsed;
            btnArsenal4.Visibility = Visibility.Collapsed;
            Spurs.Visibility = Visibility.Collapsed;
            btnSpurs1.Visibility = Visibility.Collapsed;
            btnSpurs2.Visibility = Visibility.Collapsed;
            btnSpurs3.Visibility = Visibility.Collapsed;
            btnSpurs4.Visibility = Visibility.Collapsed;
            Swansea.Visibility = Visibility.Collapsed;
            btnSwan1.Visibility = Visibility.Collapsed;
            btnSwan2.Visibility = Visibility.Collapsed;
            btnSwan3.Visibility = Visibility.Collapsed;
            btnSwan4.Visibility = Visibility.Collapsed;
            Newcastle.Visibility = Visibility.Collapsed;
            btnNewc1.Visibility = Visibility.Collapsed;
            btnNewc2.Visibility = Visibility.Collapsed;
            btnNewc3.Visibility = Visibility.Collapsed;
            btnNewc4.Visibility = Visibility.Collapsed;
            Liverpool.Visibility = Visibility.Collapsed;
            btnPool1.Visibility = Visibility.Collapsed;
            btnPool2.Visibility = Visibility.Collapsed;
            btnPool3.Visibility = Visibility.Collapsed;
            btnPool4.Visibility = Visibility.Collapsed;
            Everton.Visibility = Visibility.Collapsed;
            btnEverton1.Visibility = Visibility.Collapsed;
            btnEverton2.Visibility = Visibility.Collapsed;
            btnEverton3.Visibility = Visibility.Collapsed;
            btnEverton4.Visibility = Visibility.Collapsed;
            AstonVilla.Visibility = Visibility.Collapsed;
            btnVilla1.Visibility = Visibility.Collapsed;
            btnVilla2.Visibility = Visibility.Collapsed;
            btnVilla3.Visibility = Visibility.Collapsed;
            btnVilla4.Visibility = Visibility.Collapsed;
            Stoke.Visibility = Visibility.Collapsed;
            btnStoke1.Visibility = Visibility.Collapsed;
            btnStoke2.Visibility = Visibility.Collapsed;
            btnStoke3.Visibility = Visibility.Collapsed;
            btnStoke4.Visibility = Visibility.Collapsed;
            Sunderland.Visibility = Visibility.Collapsed;
            btnSunderland1.Visibility = Visibility.Collapsed;
            btnSunderland2.Visibility = Visibility.Collapsed;
            btnSunderland3.Visibility = Visibility.Collapsed;
            btnSunderland4.Visibility = Visibility.Collapsed;
            WestBrom.Visibility = Visibility.Collapsed;
            btnWestBrom1.Visibility = Visibility.Collapsed;
            btnWestBrom2.Visibility = Visibility.Collapsed;
            btnWestBrom3.Visibility = Visibility.Collapsed;
            btnWestBrom4.Visibility = Visibility.Collapsed;
            QPR.Visibility = Visibility.Collapsed;
            btnQPR1.Visibility = Visibility.Collapsed;
            btnQPR2.Visibility = Visibility.Collapsed;
            btnQPR3.Visibility = Visibility.Collapsed;
            btnQPR4.Visibility = Visibility.Collapsed;
            Palace.Visibility = Visibility.Collapsed;
            btnPalace1.Visibility = Visibility.Collapsed;
            btnPalace2.Visibility = Visibility.Collapsed;
            btnPalace3.Visibility = Visibility.Collapsed;
            btnPalace4.Visibility = Visibility.Collapsed;
            Burnley.Visibility = Visibility.Collapsed;
            btnBurnley1.Visibility = Visibility.Collapsed;
            btnBurnley2.Visibility = Visibility.Collapsed;
            btnBurnley3.Visibility = Visibility.Collapsed;
            btnBurnley4.Visibility = Visibility.Collapsed;
            Hull.Visibility = Visibility.Collapsed;
            btnHull1.Visibility = Visibility.Collapsed;
            btnHull2.Visibility = Visibility.Collapsed;
            btnHull3.Visibility = Visibility.Collapsed;
            btnHull4.Visibility = Visibility.Collapsed;
            Leicester.Visibility = Visibility.Collapsed;
            btnLeicester1.Visibility = Visibility.Collapsed;
            btnLeicester2.Visibility = Visibility.Collapsed;
            btnLeicester3.Visibility = Visibility.Collapsed;
            btnLeicester4.Visibility = Visibility.Collapsed;           
            score = 0;
            Score.Text = "Score: " + score.ToString();
        }

        private void AppBarButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            HomeCanvas.Visibility = Visibility.Visible;
            PremierLeagueCanvas.Visibility = Visibility.Collapsed;
            ResultCanvas.Visibility = Visibility.Collapsed;
        }

        private void btnChelsea1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Chelsea.Visibility = Visibility.Collapsed;
            btnChelsea1.Visibility = Visibility.Collapsed;
            btnChelsea2.Visibility = Visibility.Collapsed;
            btnChelsea3.Visibility = Visibility.Collapsed;
            btnChelsea4.Visibility = Visibility.Collapsed;
            ManCity.Visibility = Visibility.Visible;
            btnCity1.Visibility = Visibility.Visible;
            btnCity2.Visibility = Visibility.Visible;
            btnCity3.Visibility = Visibility.Visible;
            btnCity4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnChelsea2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Chelsea.Visibility = Visibility.Collapsed;
            btnChelsea1.Visibility = Visibility.Collapsed;
            btnChelsea2.Visibility = Visibility.Collapsed;
            btnChelsea3.Visibility = Visibility.Collapsed;
            btnChelsea4.Visibility = Visibility.Collapsed;
            ManCity.Visibility = Visibility.Visible;
            btnCity1.Visibility = Visibility.Visible;
            btnCity2.Visibility = Visibility.Visible;
            btnCity3.Visibility = Visibility.Visible;
            btnCity4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnChelsea3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Chelsea.Visibility = Visibility.Collapsed;
            btnChelsea1.Visibility = Visibility.Collapsed;
            btnChelsea2.Visibility = Visibility.Collapsed;
            btnChelsea3.Visibility = Visibility.Collapsed;
            btnChelsea4.Visibility = Visibility.Collapsed;
            ManCity.Visibility = Visibility.Visible;
            btnCity1.Visibility = Visibility.Visible;
            btnCity2.Visibility = Visibility.Visible;
            btnCity3.Visibility = Visibility.Visible;
            btnCity4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnChelsea4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Chelsea.Visibility = Visibility.Collapsed;
            btnChelsea1.Visibility = Visibility.Collapsed;
            btnChelsea2.Visibility = Visibility.Collapsed;
            btnChelsea3.Visibility = Visibility.Collapsed;
            btnChelsea4.Visibility = Visibility.Collapsed;
            ManCity.Visibility = Visibility.Visible;
            btnCity1.Visibility = Visibility.Visible;
            btnCity2.Visibility = Visibility.Visible;
            btnCity3.Visibility = Visibility.Visible;
            btnCity4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnCity1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManCity.Visibility = Visibility.Collapsed;
            btnCity1.Visibility = Visibility.Collapsed;
            btnCity2.Visibility = Visibility.Collapsed;
            btnCity3.Visibility = Visibility.Collapsed;
            btnCity4.Visibility = Visibility.Collapsed;
            ManUtd.Visibility = Visibility.Visible;
            btnUtd1.Visibility = Visibility.Visible;
            btnUtd2.Visibility = Visibility.Visible;
            btnUtd3.Visibility = Visibility.Visible;
            btnUtd4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnCity2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManCity.Visibility = Visibility.Collapsed;
            btnCity1.Visibility = Visibility.Collapsed;
            btnCity2.Visibility = Visibility.Collapsed;
            btnCity3.Visibility = Visibility.Collapsed;
            btnCity4.Visibility = Visibility.Collapsed;
            ManUtd.Visibility = Visibility.Visible;
            btnUtd1.Visibility = Visibility.Visible;
            btnUtd2.Visibility = Visibility.Visible;
            btnUtd3.Visibility = Visibility.Visible;
            btnUtd4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnCity3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManCity.Visibility = Visibility.Collapsed;
            btnCity1.Visibility = Visibility.Collapsed;
            btnCity2.Visibility = Visibility.Collapsed;
            btnCity3.Visibility = Visibility.Collapsed;
            btnCity4.Visibility = Visibility.Collapsed;
            ManUtd.Visibility = Visibility.Visible;
            btnUtd1.Visibility = Visibility.Visible;
            btnUtd2.Visibility = Visibility.Visible;
            btnUtd3.Visibility = Visibility.Visible;
            btnUtd4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnCity4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManCity.Visibility = Visibility.Collapsed;
            btnCity1.Visibility = Visibility.Collapsed;
            btnCity2.Visibility = Visibility.Collapsed;
            btnCity3.Visibility = Visibility.Collapsed;
            btnCity4.Visibility = Visibility.Collapsed;
            ManUtd.Visibility = Visibility.Visible;
            btnUtd1.Visibility = Visibility.Visible;
            btnUtd2.Visibility = Visibility.Visible;
            btnUtd3.Visibility = Visibility.Visible;
            btnUtd4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }
        
        private void btnUtd1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManUtd.Visibility = Visibility.Collapsed;
            btnUtd1.Visibility = Visibility.Collapsed;
            btnUtd2.Visibility = Visibility.Collapsed;
            btnUtd3.Visibility = Visibility.Collapsed;
            btnUtd4.Visibility = Visibility.Collapsed;
            WestHam.Visibility = Visibility.Visible;
            btnWham1.Visibility = Visibility.Visible;
            btnWham2.Visibility = Visibility.Visible;
            btnWham3.Visibility = Visibility.Visible;
            btnWham4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnUtd2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManUtd.Visibility = Visibility.Collapsed;
            btnUtd1.Visibility = Visibility.Collapsed;
            btnUtd2.Visibility = Visibility.Collapsed;
            btnUtd3.Visibility = Visibility.Collapsed;
            btnUtd4.Visibility = Visibility.Collapsed;
            WestHam.Visibility = Visibility.Visible;
            btnWham1.Visibility = Visibility.Visible;
            btnWham2.Visibility = Visibility.Visible;
            btnWham3.Visibility = Visibility.Visible;
            btnWham4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnUtd3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManUtd.Visibility = Visibility.Collapsed;
            btnUtd1.Visibility = Visibility.Collapsed;
            btnUtd2.Visibility = Visibility.Collapsed;
            btnUtd3.Visibility = Visibility.Collapsed;
            btnUtd4.Visibility = Visibility.Collapsed;
            WestHam.Visibility = Visibility.Visible;
            btnWham1.Visibility = Visibility.Visible;
            btnWham2.Visibility = Visibility.Visible;
            btnWham3.Visibility = Visibility.Visible;
            btnWham4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnUtd4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ManUtd.Visibility = Visibility.Collapsed;
            btnUtd1.Visibility = Visibility.Collapsed;
            btnUtd2.Visibility = Visibility.Collapsed;
            btnUtd3.Visibility = Visibility.Collapsed;
            btnUtd4.Visibility = Visibility.Collapsed;
            WestHam.Visibility = Visibility.Visible;
            btnWham1.Visibility = Visibility.Visible;
            btnWham2.Visibility = Visibility.Visible;
            btnWham3.Visibility = Visibility.Visible;
            btnWham4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWham1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestHam.Visibility = Visibility.Collapsed;
            btnWham1.Visibility = Visibility.Collapsed;
            btnWham2.Visibility = Visibility.Collapsed;
            btnWham3.Visibility = Visibility.Collapsed;
            btnWham4.Visibility = Visibility.Collapsed;
            Southampton.Visibility = Visibility.Visible;
            btnSoton1.Visibility = Visibility.Visible;
            btnSoton2.Visibility = Visibility.Visible;
            btnSoton3.Visibility = Visibility.Visible;
            btnSoton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWham2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestHam.Visibility = Visibility.Collapsed;
            btnWham1.Visibility = Visibility.Collapsed;
            btnWham2.Visibility = Visibility.Collapsed;
            btnWham3.Visibility = Visibility.Collapsed;
            btnWham4.Visibility = Visibility.Collapsed;
            Southampton.Visibility = Visibility.Visible;
            btnSoton1.Visibility = Visibility.Visible;
            btnSoton2.Visibility = Visibility.Visible;
            btnSoton3.Visibility = Visibility.Visible;
            btnSoton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWham3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestHam.Visibility = Visibility.Collapsed;
            btnWham1.Visibility = Visibility.Collapsed;
            btnWham2.Visibility = Visibility.Collapsed;
            btnWham3.Visibility = Visibility.Collapsed;
            btnWham4.Visibility = Visibility.Collapsed;
            Southampton.Visibility = Visibility.Visible;
            btnSoton1.Visibility = Visibility.Visible;
            btnSoton2.Visibility = Visibility.Visible;
            btnSoton3.Visibility = Visibility.Visible;
            btnSoton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWham4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestHam.Visibility = Visibility.Collapsed;
            btnWham1.Visibility = Visibility.Collapsed;
            btnWham2.Visibility = Visibility.Collapsed;
            btnWham3.Visibility = Visibility.Collapsed;
            btnWham4.Visibility = Visibility.Collapsed;
            Southampton.Visibility = Visibility.Visible;
            btnSoton1.Visibility = Visibility.Visible;
            btnSoton2.Visibility = Visibility.Visible;
            btnSoton3.Visibility = Visibility.Visible;
            btnSoton4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSoton1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Southampton.Visibility = Visibility.Collapsed;
            btnSoton1.Visibility = Visibility.Collapsed;
            btnSoton2.Visibility = Visibility.Collapsed;
            btnSoton3.Visibility = Visibility.Collapsed;
            btnSoton4.Visibility = Visibility.Collapsed;
            Arsenal.Visibility = Visibility.Visible;
            btnArsenal1.Visibility = Visibility.Visible;
            btnArsenal2.Visibility = Visibility.Visible;
            btnArsenal3.Visibility = Visibility.Visible;
            btnArsenal4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSoton2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Southampton.Visibility = Visibility.Collapsed;
            btnSoton1.Visibility = Visibility.Collapsed;
            btnSoton2.Visibility = Visibility.Collapsed;
            btnSoton3.Visibility = Visibility.Collapsed;
            btnSoton4.Visibility = Visibility.Collapsed;
            Arsenal.Visibility = Visibility.Visible;
            btnArsenal1.Visibility = Visibility.Visible;
            btnArsenal2.Visibility = Visibility.Visible;
            btnArsenal3.Visibility = Visibility.Visible;
            btnArsenal4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSoton3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Southampton.Visibility = Visibility.Collapsed;
            btnSoton1.Visibility = Visibility.Collapsed;
            btnSoton2.Visibility = Visibility.Collapsed;
            btnSoton3.Visibility = Visibility.Collapsed;
            btnSoton4.Visibility = Visibility.Collapsed;
            Arsenal.Visibility = Visibility.Visible;
            btnArsenal1.Visibility = Visibility.Visible;
            btnArsenal2.Visibility = Visibility.Visible;
            btnArsenal3.Visibility = Visibility.Visible;
            btnArsenal4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSoton4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Southampton.Visibility = Visibility.Collapsed;
            btnSoton1.Visibility = Visibility.Collapsed;
            btnSoton2.Visibility = Visibility.Collapsed;
            btnSoton3.Visibility = Visibility.Collapsed;
            btnSoton4.Visibility = Visibility.Collapsed;
            Arsenal.Visibility = Visibility.Visible;
            btnArsenal1.Visibility = Visibility.Visible;
            btnArsenal2.Visibility = Visibility.Visible;
            btnArsenal3.Visibility = Visibility.Visible;
            btnArsenal4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnArsenal1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Arsenal.Visibility = Visibility.Collapsed;
            btnArsenal1.Visibility = Visibility.Collapsed;
            btnArsenal2.Visibility = Visibility.Collapsed;
            btnArsenal3.Visibility = Visibility.Collapsed;
            btnArsenal4.Visibility = Visibility.Collapsed;
            Spurs.Visibility = Visibility.Visible;
            btnSpurs1.Visibility = Visibility.Visible;
            btnSpurs2.Visibility = Visibility.Visible;
            btnSpurs3.Visibility = Visibility.Visible;
            btnSpurs4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnArsenal2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Arsenal.Visibility = Visibility.Collapsed;
            btnArsenal1.Visibility = Visibility.Collapsed;
            btnArsenal2.Visibility = Visibility.Collapsed;
            btnArsenal3.Visibility = Visibility.Collapsed;
            btnArsenal4.Visibility = Visibility.Collapsed;
            Spurs.Visibility = Visibility.Visible;
            btnSpurs1.Visibility = Visibility.Visible;
            btnSpurs2.Visibility = Visibility.Visible;
            btnSpurs3.Visibility = Visibility.Visible;
            btnSpurs4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnArsenal3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Arsenal.Visibility = Visibility.Collapsed;
            btnArsenal1.Visibility = Visibility.Collapsed;
            btnArsenal2.Visibility = Visibility.Collapsed;
            btnArsenal3.Visibility = Visibility.Collapsed;
            btnArsenal4.Visibility = Visibility.Collapsed;
            Spurs.Visibility = Visibility.Visible;
            btnSpurs1.Visibility = Visibility.Visible;
            btnSpurs2.Visibility = Visibility.Visible;
            btnSpurs3.Visibility = Visibility.Visible;
            btnSpurs4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnArsenal4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Arsenal.Visibility = Visibility.Collapsed;
            btnArsenal1.Visibility = Visibility.Collapsed;
            btnArsenal2.Visibility = Visibility.Collapsed;
            btnArsenal3.Visibility = Visibility.Collapsed;
            btnArsenal4.Visibility = Visibility.Collapsed;
            Spurs.Visibility = Visibility.Visible;
            btnSpurs1.Visibility = Visibility.Visible;
            btnSpurs2.Visibility = Visibility.Visible;
            btnSpurs3.Visibility = Visibility.Visible;
            btnSpurs4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSpurs1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spurs.Visibility = Visibility.Collapsed;
            btnSpurs1.Visibility = Visibility.Collapsed;
            btnSpurs2.Visibility = Visibility.Collapsed;
            btnSpurs3.Visibility = Visibility.Collapsed;
            btnSpurs4.Visibility = Visibility.Collapsed;
            Swansea.Visibility = Visibility.Visible;
            btnSwan1.Visibility = Visibility.Visible;
            btnSwan2.Visibility = Visibility.Visible;
            btnSwan3.Visibility = Visibility.Visible;
            btnSwan4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSpurs2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spurs.Visibility = Visibility.Collapsed;
            btnSpurs1.Visibility = Visibility.Collapsed;
            btnSpurs2.Visibility = Visibility.Collapsed;
            btnSpurs3.Visibility = Visibility.Collapsed;
            btnSpurs4.Visibility = Visibility.Collapsed;
            Swansea.Visibility = Visibility.Visible;
            btnSwan1.Visibility = Visibility.Visible;
            btnSwan2.Visibility = Visibility.Visible;
            btnSwan3.Visibility = Visibility.Visible;
            btnSwan4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSpurs3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spurs.Visibility = Visibility.Collapsed;
            btnSpurs1.Visibility = Visibility.Collapsed;
            btnSpurs2.Visibility = Visibility.Collapsed;
            btnSpurs3.Visibility = Visibility.Collapsed;
            btnSpurs4.Visibility = Visibility.Collapsed;
            Swansea.Visibility = Visibility.Visible;
            btnSwan1.Visibility = Visibility.Visible;
            btnSwan2.Visibility = Visibility.Visible;
            btnSwan3.Visibility = Visibility.Visible;
            btnSwan4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSpurs4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spurs.Visibility = Visibility.Collapsed;
            btnSpurs1.Visibility = Visibility.Collapsed;
            btnSpurs2.Visibility = Visibility.Collapsed;
            btnSpurs3.Visibility = Visibility.Collapsed;
            btnSpurs4.Visibility = Visibility.Collapsed;
            Swansea.Visibility = Visibility.Visible;
            btnSwan1.Visibility = Visibility.Visible;
            btnSwan2.Visibility = Visibility.Visible;
            btnSwan3.Visibility = Visibility.Visible;
            btnSwan4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSwan1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Swansea.Visibility = Visibility.Collapsed;
            btnSwan1.Visibility = Visibility.Collapsed;
            btnSwan2.Visibility = Visibility.Collapsed;
            btnSwan3.Visibility = Visibility.Collapsed;
            btnSwan4.Visibility = Visibility.Collapsed;
            Newcastle.Visibility = Visibility.Visible;
            btnNewc1.Visibility = Visibility.Visible;
            btnNewc2.Visibility = Visibility.Visible;
            btnNewc3.Visibility = Visibility.Visible;
            btnNewc4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSwan2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Swansea.Visibility = Visibility.Collapsed;
            btnSwan1.Visibility = Visibility.Collapsed;
            btnSwan2.Visibility = Visibility.Collapsed;
            btnSwan3.Visibility = Visibility.Collapsed;
            btnSwan4.Visibility = Visibility.Collapsed;
            Newcastle.Visibility = Visibility.Visible;
            btnNewc1.Visibility = Visibility.Visible;
            btnNewc2.Visibility = Visibility.Visible;
            btnNewc3.Visibility = Visibility.Visible;
            btnNewc4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSwan3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Swansea.Visibility = Visibility.Collapsed;
            btnSwan1.Visibility = Visibility.Collapsed;
            btnSwan2.Visibility = Visibility.Collapsed;
            btnSwan3.Visibility = Visibility.Collapsed;
            btnSwan4.Visibility = Visibility.Collapsed;
            Newcastle.Visibility = Visibility.Visible;
            btnNewc1.Visibility = Visibility.Visible;
            btnNewc2.Visibility = Visibility.Visible;
            btnNewc3.Visibility = Visibility.Visible;
            btnNewc4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSwan4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Swansea.Visibility = Visibility.Collapsed;
            btnSwan1.Visibility = Visibility.Collapsed;
            btnSwan2.Visibility = Visibility.Collapsed;
            btnSwan3.Visibility = Visibility.Collapsed;
            btnSwan4.Visibility = Visibility.Collapsed;
            Newcastle.Visibility = Visibility.Visible;
            btnNewc1.Visibility = Visibility.Visible;
            btnNewc2.Visibility = Visibility.Visible;
            btnNewc3.Visibility = Visibility.Visible;
            btnNewc4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnNewc1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Newcastle.Visibility = Visibility.Collapsed;
            btnNewc1.Visibility = Visibility.Collapsed;
            btnNewc2.Visibility = Visibility.Collapsed;
            btnNewc3.Visibility = Visibility.Collapsed;
            btnNewc4.Visibility = Visibility.Collapsed;
            Liverpool.Visibility = Visibility.Visible;
            btnPool1.Visibility = Visibility.Visible;
            btnPool2.Visibility = Visibility.Visible;
            btnPool3.Visibility = Visibility.Visible;
            btnPool4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnNewc2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Newcastle.Visibility = Visibility.Collapsed;
            btnNewc1.Visibility = Visibility.Collapsed;
            btnNewc2.Visibility = Visibility.Collapsed;
            btnNewc3.Visibility = Visibility.Collapsed;
            btnNewc4.Visibility = Visibility.Collapsed;
            Liverpool.Visibility = Visibility.Visible;
            btnPool1.Visibility = Visibility.Visible;
            btnPool2.Visibility = Visibility.Visible;
            btnPool3.Visibility = Visibility.Visible;
            btnPool4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnNewc3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Newcastle.Visibility = Visibility.Collapsed;
            btnNewc1.Visibility = Visibility.Collapsed;
            btnNewc2.Visibility = Visibility.Collapsed;
            btnNewc3.Visibility = Visibility.Collapsed;
            btnNewc4.Visibility = Visibility.Collapsed;
            Liverpool.Visibility = Visibility.Visible;
            btnPool1.Visibility = Visibility.Visible;
            btnPool2.Visibility = Visibility.Visible;
            btnPool3.Visibility = Visibility.Visible;
            btnPool4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnNewc4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Newcastle.Visibility = Visibility.Collapsed;
            btnNewc1.Visibility = Visibility.Collapsed;
            btnNewc2.Visibility = Visibility.Collapsed;
            btnNewc3.Visibility = Visibility.Collapsed;
            btnNewc4.Visibility = Visibility.Collapsed;
            Liverpool.Visibility = Visibility.Visible;
            btnPool1.Visibility = Visibility.Visible;
            btnPool2.Visibility = Visibility.Visible;
            btnPool3.Visibility = Visibility.Visible;
            btnPool4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPool1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Liverpool.Visibility = Visibility.Collapsed;
            btnPool1.Visibility = Visibility.Collapsed;
            btnPool2.Visibility = Visibility.Collapsed;
            btnPool3.Visibility = Visibility.Collapsed;
            btnPool4.Visibility = Visibility.Collapsed;
            Everton.Visibility = Visibility.Visible;
            btnEverton1.Visibility = Visibility.Visible;
            btnEverton2.Visibility = Visibility.Visible;
            btnEverton3.Visibility = Visibility.Visible;
            btnEverton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPool2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Liverpool.Visibility = Visibility.Collapsed;
            btnPool1.Visibility = Visibility.Collapsed;
            btnPool2.Visibility = Visibility.Collapsed;
            btnPool3.Visibility = Visibility.Collapsed;
            btnPool4.Visibility = Visibility.Collapsed;
            Everton.Visibility = Visibility.Visible;
            btnEverton1.Visibility = Visibility.Visible;
            btnEverton2.Visibility = Visibility.Visible;
            btnEverton3.Visibility = Visibility.Visible;
            btnEverton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPool3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Liverpool.Visibility = Visibility.Collapsed;
            btnPool1.Visibility = Visibility.Collapsed;
            btnPool2.Visibility = Visibility.Collapsed;
            btnPool3.Visibility = Visibility.Collapsed;
            btnPool4.Visibility = Visibility.Collapsed;
            Everton.Visibility = Visibility.Visible;
            btnEverton1.Visibility = Visibility.Visible;
            btnEverton2.Visibility = Visibility.Visible;
            btnEverton3.Visibility = Visibility.Visible;
            btnEverton4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPool4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Liverpool.Visibility = Visibility.Collapsed;
            btnPool1.Visibility = Visibility.Collapsed;
            btnPool2.Visibility = Visibility.Collapsed;
            btnPool3.Visibility = Visibility.Collapsed;
            btnPool4.Visibility = Visibility.Collapsed;
            Everton.Visibility = Visibility.Visible;
            btnEverton1.Visibility = Visibility.Visible;
            btnEverton2.Visibility = Visibility.Visible;
            btnEverton3.Visibility = Visibility.Visible;
            btnEverton4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnEverton1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Everton.Visibility = Visibility.Collapsed;
            btnEverton1.Visibility = Visibility.Collapsed;
            btnEverton2.Visibility = Visibility.Collapsed;
            btnEverton3.Visibility = Visibility.Collapsed;
            btnEverton4.Visibility = Visibility.Collapsed;
            AstonVilla.Visibility = Visibility.Visible;
            btnVilla1.Visibility = Visibility.Visible;
            btnVilla2.Visibility = Visibility.Visible;
            btnVilla3.Visibility = Visibility.Visible;
            btnVilla4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnEverton2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Everton.Visibility = Visibility.Collapsed;
            btnEverton1.Visibility = Visibility.Collapsed;
            btnEverton2.Visibility = Visibility.Collapsed;
            btnEverton3.Visibility = Visibility.Collapsed;
            btnEverton4.Visibility = Visibility.Collapsed;
            AstonVilla.Visibility = Visibility.Visible;
            btnVilla1.Visibility = Visibility.Visible;
            btnVilla2.Visibility = Visibility.Visible;
            btnVilla3.Visibility = Visibility.Visible;
            btnVilla4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnEverton3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Everton.Visibility = Visibility.Collapsed;
            btnEverton1.Visibility = Visibility.Collapsed;
            btnEverton2.Visibility = Visibility.Collapsed;
            btnEverton3.Visibility = Visibility.Collapsed;
            btnEverton4.Visibility = Visibility.Collapsed;
            AstonVilla.Visibility = Visibility.Visible;
            btnVilla1.Visibility = Visibility.Visible;
            btnVilla2.Visibility = Visibility.Visible;
            btnVilla3.Visibility = Visibility.Visible;
            btnVilla4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnEverton4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Everton.Visibility = Visibility.Collapsed;
            btnEverton1.Visibility = Visibility.Collapsed;
            btnEverton2.Visibility = Visibility.Collapsed;
            btnEverton3.Visibility = Visibility.Collapsed;
            btnEverton4.Visibility = Visibility.Collapsed;
            AstonVilla.Visibility = Visibility.Visible;
            btnVilla1.Visibility = Visibility.Visible;
            btnVilla2.Visibility = Visibility.Visible;
            btnVilla3.Visibility = Visibility.Visible;
            btnVilla4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnVilla1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            AstonVilla.Visibility = Visibility.Collapsed;
            btnVilla1.Visibility = Visibility.Collapsed;
            btnVilla2.Visibility = Visibility.Collapsed;
            btnVilla3.Visibility = Visibility.Collapsed;
            btnVilla4.Visibility = Visibility.Collapsed;
            Stoke.Visibility = Visibility.Visible;
            btnStoke1.Visibility = Visibility.Visible;
            btnStoke2.Visibility = Visibility.Visible;
            btnStoke3.Visibility = Visibility.Visible;
            btnStoke4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnVilla2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            AstonVilla.Visibility = Visibility.Collapsed;
            btnVilla1.Visibility = Visibility.Collapsed;
            btnVilla2.Visibility = Visibility.Collapsed;
            btnVilla3.Visibility = Visibility.Collapsed;
            btnVilla4.Visibility = Visibility.Collapsed;
            Stoke.Visibility = Visibility.Visible;
            btnStoke1.Visibility = Visibility.Visible;
            btnStoke2.Visibility = Visibility.Visible;
            btnStoke3.Visibility = Visibility.Visible;
            btnStoke4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnVilla3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            AstonVilla.Visibility = Visibility.Collapsed;
            btnVilla1.Visibility = Visibility.Collapsed;
            btnVilla2.Visibility = Visibility.Collapsed;
            btnVilla3.Visibility = Visibility.Collapsed;
            btnVilla4.Visibility = Visibility.Collapsed;
            Stoke.Visibility = Visibility.Visible;
            btnStoke1.Visibility = Visibility.Visible;
            btnStoke2.Visibility = Visibility.Visible;
            btnStoke3.Visibility = Visibility.Visible;
            btnStoke4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnVilla4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            AstonVilla.Visibility = Visibility.Collapsed;
            btnVilla1.Visibility = Visibility.Collapsed;
            btnVilla2.Visibility = Visibility.Collapsed;
            btnVilla3.Visibility = Visibility.Collapsed;
            btnVilla4.Visibility = Visibility.Collapsed;
            Stoke.Visibility = Visibility.Visible;
            btnStoke1.Visibility = Visibility.Visible;
            btnStoke2.Visibility = Visibility.Visible;
            btnStoke3.Visibility = Visibility.Visible;
            btnStoke4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnStoke1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Stoke.Visibility = Visibility.Collapsed;
            btnStoke1.Visibility = Visibility.Collapsed;
            btnStoke2.Visibility = Visibility.Collapsed;
            btnStoke3.Visibility = Visibility.Collapsed;
            btnStoke4.Visibility = Visibility.Collapsed;
            Sunderland.Visibility = Visibility.Visible;
            btnSunderland1.Visibility = Visibility.Visible;
            btnSunderland2.Visibility = Visibility.Visible;
            btnSunderland3.Visibility = Visibility.Visible;
            btnSunderland4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnStoke2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Stoke.Visibility = Visibility.Collapsed;
            btnStoke1.Visibility = Visibility.Collapsed;
            btnStoke2.Visibility = Visibility.Collapsed;
            btnStoke3.Visibility = Visibility.Collapsed;
            btnStoke4.Visibility = Visibility.Collapsed;
            Sunderland.Visibility = Visibility.Visible;
            btnSunderland1.Visibility = Visibility.Visible;
            btnSunderland2.Visibility = Visibility.Visible;
            btnSunderland3.Visibility = Visibility.Visible;
            btnSunderland4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnStoke3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Stoke.Visibility = Visibility.Collapsed;
            btnStoke1.Visibility = Visibility.Collapsed;
            btnStoke2.Visibility = Visibility.Collapsed;
            btnStoke3.Visibility = Visibility.Collapsed;
            btnStoke4.Visibility = Visibility.Collapsed;
            Sunderland.Visibility = Visibility.Visible;
            btnSunderland1.Visibility = Visibility.Visible;
            btnSunderland2.Visibility = Visibility.Visible;
            btnSunderland3.Visibility = Visibility.Visible;
            btnSunderland4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnStoke4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Stoke.Visibility = Visibility.Collapsed;
            btnStoke1.Visibility = Visibility.Collapsed;
            btnStoke2.Visibility = Visibility.Collapsed;
            btnStoke3.Visibility = Visibility.Collapsed;
            btnStoke4.Visibility = Visibility.Collapsed;
            Sunderland.Visibility = Visibility.Visible;
            btnSunderland1.Visibility = Visibility.Visible;
            btnSunderland2.Visibility = Visibility.Visible;
            btnSunderland3.Visibility = Visibility.Visible;
            btnSunderland4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSunderland1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Sunderland.Visibility = Visibility.Collapsed;
            btnSunderland1.Visibility = Visibility.Collapsed;
            btnSunderland2.Visibility = Visibility.Collapsed;
            btnSunderland3.Visibility = Visibility.Collapsed;
            btnSunderland4.Visibility = Visibility.Collapsed;
            WestBrom.Visibility = Visibility.Visible;
            btnWestBrom1.Visibility = Visibility.Visible;
            btnWestBrom2.Visibility = Visibility.Visible;
            btnWestBrom3.Visibility = Visibility.Visible;
            btnWestBrom4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSunderland2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Sunderland.Visibility = Visibility.Collapsed;
            btnSunderland1.Visibility = Visibility.Collapsed;
            btnSunderland2.Visibility = Visibility.Collapsed;
            btnSunderland3.Visibility = Visibility.Collapsed;
            btnSunderland4.Visibility = Visibility.Collapsed;
            WestBrom.Visibility = Visibility.Visible;
            btnWestBrom1.Visibility = Visibility.Visible;
            btnWestBrom2.Visibility = Visibility.Visible;
            btnWestBrom3.Visibility = Visibility.Visible;
            btnWestBrom4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSunderland3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Sunderland.Visibility = Visibility.Collapsed;
            btnSunderland1.Visibility = Visibility.Collapsed;
            btnSunderland2.Visibility = Visibility.Collapsed;
            btnSunderland3.Visibility = Visibility.Collapsed;
            btnSunderland4.Visibility = Visibility.Collapsed;
            WestBrom.Visibility = Visibility.Visible;
            btnWestBrom1.Visibility = Visibility.Visible;
            btnWestBrom2.Visibility = Visibility.Visible;
            btnWestBrom3.Visibility = Visibility.Visible;
            btnWestBrom4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnSunderland4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Sunderland.Visibility = Visibility.Collapsed;
            btnSunderland1.Visibility = Visibility.Collapsed;
            btnSunderland2.Visibility = Visibility.Collapsed;
            btnSunderland3.Visibility = Visibility.Collapsed;
            btnSunderland4.Visibility = Visibility.Collapsed;
            WestBrom.Visibility = Visibility.Visible;
            btnWestBrom1.Visibility = Visibility.Visible;
            btnWestBrom2.Visibility = Visibility.Visible;
            btnWestBrom3.Visibility = Visibility.Visible;
            btnWestBrom4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWestBrom1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestBrom.Visibility = Visibility.Collapsed;
            btnWestBrom1.Visibility = Visibility.Collapsed;
            btnWestBrom2.Visibility = Visibility.Collapsed;
            btnWestBrom3.Visibility = Visibility.Collapsed;
            btnWestBrom4.Visibility = Visibility.Collapsed;
            QPR.Visibility = Visibility.Visible;
            btnQPR1.Visibility = Visibility.Visible;
            btnQPR2.Visibility = Visibility.Visible;
            btnQPR3.Visibility = Visibility.Visible;
            btnQPR4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWestBrom2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestBrom.Visibility = Visibility.Collapsed;
            btnWestBrom1.Visibility = Visibility.Collapsed;
            btnWestBrom2.Visibility = Visibility.Collapsed;
            btnWestBrom3.Visibility = Visibility.Collapsed;
            btnWestBrom4.Visibility = Visibility.Collapsed;
            QPR.Visibility = Visibility.Visible;
            btnQPR1.Visibility = Visibility.Visible;
            btnQPR2.Visibility = Visibility.Visible;
            btnQPR3.Visibility = Visibility.Visible;
            btnQPR4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWestBrom3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestBrom.Visibility = Visibility.Collapsed;
            btnWestBrom1.Visibility = Visibility.Collapsed;
            btnWestBrom2.Visibility = Visibility.Collapsed;
            btnWestBrom3.Visibility = Visibility.Collapsed;
            btnWestBrom4.Visibility = Visibility.Collapsed;
            QPR.Visibility = Visibility.Visible;
            btnQPR1.Visibility = Visibility.Visible;
            btnQPR2.Visibility = Visibility.Visible;
            btnQPR3.Visibility = Visibility.Visible;
            btnQPR4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnWestBrom4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            WestBrom.Visibility = Visibility.Collapsed;
            btnWestBrom1.Visibility = Visibility.Collapsed;
            btnWestBrom2.Visibility = Visibility.Collapsed;
            btnWestBrom3.Visibility = Visibility.Collapsed;
            btnWestBrom4.Visibility = Visibility.Collapsed;
            QPR.Visibility = Visibility.Visible;
            btnQPR1.Visibility = Visibility.Visible;
            btnQPR2.Visibility = Visibility.Visible;
            btnQPR3.Visibility = Visibility.Visible;
            btnQPR4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnQPR1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            QPR.Visibility = Visibility.Collapsed;
            btnQPR1.Visibility = Visibility.Collapsed;
            btnQPR2.Visibility = Visibility.Collapsed;
            btnQPR3.Visibility = Visibility.Collapsed;
            btnQPR4.Visibility = Visibility.Collapsed;
            Palace.Visibility = Visibility.Visible;
            btnPalace1.Visibility = Visibility.Visible;
            btnPalace2.Visibility = Visibility.Visible;
            btnPalace3.Visibility = Visibility.Visible;
            btnPalace4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnQPR2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            QPR.Visibility = Visibility.Collapsed;
            btnQPR1.Visibility = Visibility.Collapsed;
            btnQPR2.Visibility = Visibility.Collapsed;
            btnQPR3.Visibility = Visibility.Collapsed;
            btnQPR4.Visibility = Visibility.Collapsed;
            Palace.Visibility = Visibility.Visible;
            btnPalace1.Visibility = Visibility.Visible;
            btnPalace2.Visibility = Visibility.Visible;
            btnPalace3.Visibility = Visibility.Visible;
            btnPalace4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnQPR3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            QPR.Visibility = Visibility.Collapsed;
            btnQPR1.Visibility = Visibility.Collapsed;
            btnQPR2.Visibility = Visibility.Collapsed;
            btnQPR3.Visibility = Visibility.Collapsed;
            btnQPR4.Visibility = Visibility.Collapsed;
            Palace.Visibility = Visibility.Visible;
            btnPalace1.Visibility = Visibility.Visible;
            btnPalace2.Visibility = Visibility.Visible;
            btnPalace3.Visibility = Visibility.Visible;
            btnPalace4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnQPR4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            QPR.Visibility = Visibility.Collapsed;
            btnQPR1.Visibility = Visibility.Collapsed;
            btnQPR2.Visibility = Visibility.Collapsed;
            btnQPR3.Visibility = Visibility.Collapsed;
            btnQPR4.Visibility = Visibility.Collapsed;
            Palace.Visibility = Visibility.Visible;
            btnPalace1.Visibility = Visibility.Visible;
            btnPalace2.Visibility = Visibility.Visible;
            btnPalace3.Visibility = Visibility.Visible;
            btnPalace4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPalace1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Palace.Visibility = Visibility.Collapsed;
            btnPalace1.Visibility = Visibility.Collapsed;
            btnPalace2.Visibility = Visibility.Collapsed;
            btnPalace3.Visibility = Visibility.Collapsed;
            btnPalace4.Visibility = Visibility.Collapsed;
            Burnley.Visibility = Visibility.Visible;
            btnBurnley1.Visibility = Visibility.Visible;
            btnBurnley2.Visibility = Visibility.Visible;
            btnBurnley3.Visibility = Visibility.Visible;
            btnBurnley4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPalace2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Palace.Visibility = Visibility.Collapsed;
            btnPalace1.Visibility = Visibility.Collapsed;
            btnPalace2.Visibility = Visibility.Collapsed;
            btnPalace3.Visibility = Visibility.Collapsed;
            btnPalace4.Visibility = Visibility.Collapsed;
            Burnley.Visibility = Visibility.Visible;
            btnBurnley1.Visibility = Visibility.Visible;
            btnBurnley2.Visibility = Visibility.Visible;
            btnBurnley3.Visibility = Visibility.Visible;
            btnBurnley4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPalace3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Palace.Visibility = Visibility.Collapsed;
            btnPalace1.Visibility = Visibility.Collapsed;
            btnPalace2.Visibility = Visibility.Collapsed;
            btnPalace3.Visibility = Visibility.Collapsed;
            btnPalace4.Visibility = Visibility.Collapsed;
            Burnley.Visibility = Visibility.Visible;
            btnBurnley1.Visibility = Visibility.Visible;
            btnBurnley2.Visibility = Visibility.Visible;
            btnBurnley3.Visibility = Visibility.Visible;
            btnBurnley4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnPalace4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Palace.Visibility = Visibility.Collapsed;
            btnPalace1.Visibility = Visibility.Collapsed;
            btnPalace2.Visibility = Visibility.Collapsed;
            btnPalace3.Visibility = Visibility.Collapsed;
            btnPalace4.Visibility = Visibility.Collapsed;
            Burnley.Visibility = Visibility.Visible;
            btnBurnley1.Visibility = Visibility.Visible;
            btnBurnley2.Visibility = Visibility.Visible;
            btnBurnley3.Visibility = Visibility.Visible;
            btnBurnley4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnBurnley1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Burnley.Visibility = Visibility.Collapsed;
            btnBurnley1.Visibility = Visibility.Collapsed;
            btnBurnley2.Visibility = Visibility.Collapsed;
            btnBurnley3.Visibility = Visibility.Collapsed;
            btnBurnley4.Visibility = Visibility.Collapsed;
            Hull.Visibility = Visibility.Visible;
            btnHull1.Visibility = Visibility.Visible;
            btnHull2.Visibility = Visibility.Visible;
            btnHull3.Visibility = Visibility.Visible;
            btnHull4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnBurnley2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Burnley.Visibility = Visibility.Collapsed;
            btnBurnley1.Visibility = Visibility.Collapsed;
            btnBurnley2.Visibility = Visibility.Collapsed;
            btnBurnley3.Visibility = Visibility.Collapsed;
            btnBurnley4.Visibility = Visibility.Collapsed;
            Hull.Visibility = Visibility.Visible;
            btnHull1.Visibility = Visibility.Visible;
            btnHull2.Visibility = Visibility.Visible;
            btnHull3.Visibility = Visibility.Visible;
            btnHull4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnBurnley3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Burnley.Visibility = Visibility.Collapsed;
            btnBurnley1.Visibility = Visibility.Collapsed;
            btnBurnley2.Visibility = Visibility.Collapsed;
            btnBurnley3.Visibility = Visibility.Collapsed;
            btnBurnley4.Visibility = Visibility.Collapsed;
            Hull.Visibility = Visibility.Visible;
            btnHull1.Visibility = Visibility.Visible;
            btnHull2.Visibility = Visibility.Visible;
            btnHull3.Visibility = Visibility.Visible;
            btnHull4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnBurnley4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Burnley.Visibility = Visibility.Collapsed;
            btnBurnley1.Visibility = Visibility.Collapsed;
            btnBurnley2.Visibility = Visibility.Collapsed;
            btnBurnley3.Visibility = Visibility.Collapsed;
            btnBurnley4.Visibility = Visibility.Collapsed;
            Hull.Visibility = Visibility.Visible;
            btnHull1.Visibility = Visibility.Visible;
            btnHull2.Visibility = Visibility.Visible;
            btnHull3.Visibility = Visibility.Visible;
            btnHull4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnHull1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Hull.Visibility = Visibility.Collapsed;
            btnHull1.Visibility = Visibility.Collapsed;
            btnHull2.Visibility = Visibility.Collapsed;
            btnHull3.Visibility = Visibility.Collapsed;
            btnHull4.Visibility = Visibility.Collapsed;
            Leicester.Visibility = Visibility.Visible;
            btnLeicester1.Visibility = Visibility.Visible;
            btnLeicester2.Visibility = Visibility.Visible;
            btnLeicester3.Visibility = Visibility.Visible;
            btnLeicester4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnHull2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Hull.Visibility = Visibility.Collapsed;
            btnHull1.Visibility = Visibility.Collapsed;
            btnHull2.Visibility = Visibility.Collapsed;
            btnHull3.Visibility = Visibility.Collapsed;
            btnHull4.Visibility = Visibility.Collapsed;
            Leicester.Visibility = Visibility.Visible;
            btnLeicester1.Visibility = Visibility.Visible;
            btnLeicester2.Visibility = Visibility.Visible;
            btnLeicester3.Visibility = Visibility.Visible;
            btnLeicester4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnHull3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Hull.Visibility = Visibility.Collapsed;
            btnHull1.Visibility = Visibility.Collapsed;
            btnHull2.Visibility = Visibility.Collapsed;
            btnHull3.Visibility = Visibility.Collapsed;
            btnHull4.Visibility = Visibility.Collapsed;
            Leicester.Visibility = Visibility.Visible;
            btnLeicester1.Visibility = Visibility.Visible;
            btnLeicester2.Visibility = Visibility.Visible;
            btnLeicester3.Visibility = Visibility.Visible;
            btnLeicester4.Visibility = Visibility.Visible;
            score++;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnHull4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Hull.Visibility = Visibility.Collapsed;
            btnHull1.Visibility = Visibility.Collapsed;
            btnHull2.Visibility = Visibility.Collapsed;
            btnHull3.Visibility = Visibility.Collapsed;
            btnHull4.Visibility = Visibility.Collapsed;
            Leicester.Visibility = Visibility.Visible;
            btnLeicester1.Visibility = Visibility.Visible;
            btnLeicester2.Visibility = Visibility.Visible;
            btnLeicester3.Visibility = Visibility.Visible;
            btnLeicester4.Visibility = Visibility.Visible;
            Score.Text = "Score: " + score.ToString();
        }

        private void btnLeicester1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Leicester.Visibility = Visibility.Collapsed;
            btnLeicester1.Visibility = Visibility.Collapsed;
            btnLeicester2.Visibility = Visibility.Collapsed;
            btnLeicester3.Visibility = Visibility.Collapsed;
            btnLeicester4.Visibility = Visibility.Collapsed;
            PremierLeagueCanvas.Visibility = Visibility.Collapsed;
            
            if (score == 20)
            {
                Result.Text = "Congratulations, you have scored 20 out of 20";
            }

            else if (score > 15)
            {
                Result.Text = "Well done, you have scored " + score.ToString() + " out of 20";
            }

            else if (score > 10)
            {
                Result.Text = "Not bad, you have scored " + score.ToString() + " out of 20";
            }

            else
            {
                Result.Text = "Hard luck, you have scored " + score.ToString() + " out of 20. Try Again";
            }

            ResultCanvas.Visibility = Visibility.Visible;
        }

        private void btnLeicester2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Leicester.Visibility = Visibility.Collapsed;
            btnLeicester1.Visibility = Visibility.Collapsed;
            btnLeicester2.Visibility = Visibility.Collapsed;
            btnLeicester3.Visibility = Visibility.Collapsed;
            btnLeicester4.Visibility = Visibility.Collapsed;
            PremierLeagueCanvas.Visibility = Visibility.Collapsed;
            score++;
            
            if (score == 20)
            {
                Result.Text = "Congratulations, you have scored 20 out of 20";
            }

            else if (score > 15)
            {
                Result.Text = "Well done, you have scored " + score.ToString() + " out of 20";
            }

            else if (score > 10)
            {
                Result.Text = "Not bad, you have scored " + score.ToString() + " out of 20";
            }

            else
            {
                Result.Text = "Hard luck, you have scored " + score.ToString() + " out of 20. Try Again";
            }

            ResultCanvas.Visibility = Visibility.Visible;           
        }

        private void btnLeicester3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Leicester.Visibility = Visibility.Collapsed;
            btnLeicester1.Visibility = Visibility.Collapsed;
            btnLeicester2.Visibility = Visibility.Collapsed;
            btnLeicester3.Visibility = Visibility.Collapsed;
            btnLeicester4.Visibility = Visibility.Collapsed;
            PremierLeagueCanvas.Visibility = Visibility.Collapsed;

            if (score == 20)
            {
                Result.Text = "Congratulations, you have scored 20 out of 20";
            }

            else if (score > 15)
            {
                Result.Text = "Well done, you have scored " + score.ToString() + " out of 20";
            }

            else if (score > 10)
            {
                Result.Text = "Not bad, you have scored " + score.ToString() + " out of 20";
            }

            else
            {
                Result.Text = "Hard luck, you have scored " + score.ToString() + " out of 20. Try Again";
            }

            ResultCanvas.Visibility = Visibility.Visible;
        }

        private void btnLeicester4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Leicester.Visibility = Visibility.Collapsed;
            btnLeicester1.Visibility = Visibility.Collapsed;
            btnLeicester2.Visibility = Visibility.Collapsed;
            btnLeicester3.Visibility = Visibility.Collapsed;
            btnLeicester4.Visibility = Visibility.Collapsed;
            PremierLeagueCanvas.Visibility = Visibility.Collapsed;
                        
            if (score == 20)
            {
                Result.Text = "Congratulations, you have scored 20 out of 20";
            }

            else if (score > 15)
            {
                Result.Text = "Well done, you have scored " +score.ToString() + " out of 20";
            }

            else if (score > 10)
            {
                Result.Text = "Not bad, you have scored " + score.ToString() + " out of 20";
            }

            else
            {
                Result.Text = "Hard luck, you have scored " + score.ToString() + " out of 20. Keep Practising";
            }

            ResultCanvas.Visibility = Visibility.Visible;
        }

        private void TryAgain_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ResultCanvas.Visibility = Visibility.Collapsed;
            HomeCanvas.Visibility = Visibility.Visible;
        }
    }    
}
