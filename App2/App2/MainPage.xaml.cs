using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Button[] bt = new Button[64];
        public bool invis_vis = true;
        public int king, rook2, rook, deter, pos_your_king = -1;

        public void placesNoForDarkKing(Button b1, Button b2, Button b3)
        {
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
        }

        public void placesYesForDarkKing(Button b1, Button b2, Button b3)
        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
        }

        public MainPage()
        {
            this.InitializeComponent();
            massButton();
            my_king.Visibility = Windows.UI.Xaml.Visibility.Visible;
            my_rook2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            my_rook.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt1);
        }

        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt15);
        }

        public void createDarkKing(Button bt)
        {
            your_king.Visibility = Windows.UI.Xaml.Visibility.Visible;
            your_king.Margin = bt.Margin;
            pos_your_king = Convert.ToInt32(bt.Name.Remove(0, 2)) - 1;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt2);
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt3);
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt4);
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt5);
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt6);
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt7);
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt8);
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt9);
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt10);
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt11);
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt12);
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt13);
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt14);
        }

        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt16);
        }

        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt17);
        }

        private void bt18_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt18);
        }

        private void bt19_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt19);
        }

        private void bt20_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt20);
        }

        private void bt21_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt21);
        }

        private void bt22_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt22);
        }

        private void bt23_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt23);
        }

        private void bt24_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt24);
        }

        private void bt25_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt25);
        }

        private void bt26_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt26);
        }

        private void bt27_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt27);
        }

        private void bt28_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt28);
        }

        private void bt29_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt29);
        }

        private void bt30_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt30);
        }

        private void bt31_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt31);
        }

        private void bt32_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt32);
        }

        private void bt33_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt33);
        }

        private void bt34_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt34);
        }

        private void bt35_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt35);
        }

        private void bt36_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt36);
        }

        private void bt37_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt37);
        }

        private void bt38_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt38);
        }

        private void bt39_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt39);
        }

        private void bt40_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt40);
        }

        private void bt41_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt41);
        }

        private void bt42_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt42);
        }

        private void bt43_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt43);
        }

        private void bt44_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt44);
        }

        private void bt45_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt45);
        }

        private void bt46_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt46);
        }

        private void bt47_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt47);
        }

        private void bt48_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt48);
        }

        private void bt49_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt49);
        }

        private void bt50_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt50);
        }

        private void bt51_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt51);
        }

        private void bt52_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt52);
        }

        private void bt53_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt53);
        }

        private void bt54_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt54);
        }

        private void bt55_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt55);
        }

        private void bt56_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt56);
        }

        private void bt57_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt57);
        }

        private void bt58_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt58);
        }

        private void bt59_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt59);
        }

        private void bt60_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt60);
        }

        private void bt61_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt61);
        }

        private void bt62_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt62);
        }

        private void bt63_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt63);
        }

        private void bt64_Click(object sender, RoutedEventArgs e)
        {
            createDarkKing(bt64);
        }

        private void generate_Click(object sender, RoutedEventArgs e)
        {
            randomPositionFigure(bt);
        }

        public void massButton()
        {
            bt[0] = bt1;
            bt[1] = bt2;
            bt[2] = bt3;
            bt[3] = bt4;
            bt[4] = bt5;
            bt[5] = bt6;
            bt[6] = bt7;
            bt[7] = bt8;
            bt[8] = bt9;
            bt[9] = bt10;
            bt[10] = bt11;
            bt[11] = bt12;
            bt[12] = bt13;
            bt[13] = bt14;
            bt[14] = bt15;
            bt[15] = bt16;
            bt[16] = bt17;
            bt[17] = bt18;
            bt[18] = bt19;
            bt[19] = bt20;
            bt[20] = bt21;
            bt[21] = bt22;
            bt[22] = bt23;
            bt[23] = bt24;
            bt[24] = bt25;
            bt[25] = bt26;
            bt[26] = bt27;
            bt[27] = bt28;
            bt[28] = bt29;
            bt[29] = bt30;
            bt[30] = bt31;
            bt[31] = bt32;
            bt[32] = bt33;
            bt[33] = bt34;
            bt[34] = bt35;
            bt[35] = bt36;
            bt[36] = bt37;
            bt[37] = bt38;
            bt[38] = bt39;
            bt[39] = bt40;
            bt[40] = bt41;
            bt[41] = bt42;
            bt[42] = bt43;
            bt[43] = bt44;
            bt[44] = bt45;
            bt[45] = bt46;
            bt[46] = bt47;
            bt[47] = bt48;
            bt[48] = bt49;
            bt[49] = bt50;
            bt[50] = bt51;
            bt[51] = bt52;
            bt[52] = bt53;
            bt[53] = bt54;
            bt[54] = bt55;
            bt[55] = bt56;
            bt[56] = bt57;
            bt[57] = bt58;
            bt[58] = bt59;
            bt[59] = bt60;
            bt[60] = bt61;
            bt[61] = bt62;
            bt[62] = bt63;
            bt[63] = bt64;
            randomPositionFigure(bt);

            //my_rook.Margin = bt[29].Margin;
            //my_rook2.Margin = bt[44].Margin;
            //my_king.Margin = bt[7].Margin;
            //rook = 30;
            //rook2 = 45;
            //king = 8;
        }

        public void randomPositionFigure(Button[] bt)
        {
            placesYesForDarkKing(bt[king], bt[rook2], bt[rook]);
            if (invis_vis == false)
            {
                invis_vis = true;
                if (deter == 1) //left_top
                {
                    bt[king + 1].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                    bt[king + 9].IsEnabled = true;
                }
                if (deter == 2) //center_top
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king + 1].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                    bt[king + 9].IsEnabled = true;
                    bt[king + 7].IsEnabled = true;
                }
                if (deter == 3) //right_top
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king + 7].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                }
                if (deter == 4) //left_middle
                {
                    bt[king + 1].IsEnabled = true;
                    bt[king - 7].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                    bt[king + 9].IsEnabled = true;
                }
                if (deter == 5) //center_middle
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king + 1].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                    bt[king + 9].IsEnabled = true;
                    bt[king - 9].IsEnabled = true;
                    bt[king + 7].IsEnabled = true;
                    bt[king - 7].IsEnabled = true;
                }
                if (deter == 6) //right_middle
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king + 7].IsEnabled = true;
                    bt[king + 8].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                    bt[king - 9].IsEnabled = true;
                }
                if (deter == 7) //left_bottom
                {
                    bt[king + 1].IsEnabled = true;
                    bt[king - 7].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                }
                if (deter == 8) //center_bottom
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king + 1].IsEnabled = true;
                    bt[king - 7].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                    bt[king - 9].IsEnabled = true;
                }
                if (deter == 9) //right_bottom
                {
                    bt[king - 1].IsEnabled = true;
                    bt[king - 9].IsEnabled = true;
                    bt[king - 8].IsEnabled = true;
                }
            }
            Random rnd = new Random();
            king = rnd.Next(0, 4);
            if (king == 0 || king == 1)
                king = 0;
            else
                king = 7;
            rook2 = rnd.Next(0, 64);
            rook = rnd.Next(0, 64);
            while (king == rook2 || king == rook || rook2 == rook)
            {
                king = rnd.Next(0, 4);
                if (king == 0 || king == 1)
                    king = 0;
                else
                    king = 7;
                rook2 = rnd.Next(0, 64);
                rook = rnd.Next(0, 64);
            }
            my_king.Margin = bt[king].Margin;
            my_rook2.Margin = bt[rook2].Margin;
            my_rook.Margin = bt[rook].Margin;
            invis_vis = false;
            if (king == 0) //left_top
            {
                deter = 1;
                bt[king + 1].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
                bt[king + 9].IsEnabled = false;
            }
            if (king > 0 && king < 7) //center_top
            {
                deter = 2;
                bt[king - 1].IsEnabled = false;
                bt[king + 1].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
                bt[king + 9].IsEnabled = false;
                bt[king + 7].IsEnabled = false;
            }
            if (king == 7) //right_top
            {
                deter = 3;
                bt[king - 1].IsEnabled = false;
                bt[king + 7].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
            }
            if (king == 8 || king == 16 || king == 24 || king == 32 || king == 40 || king == 48) //left_middle
            {
                deter = 4;
                bt[king + 1].IsEnabled = false;
                bt[king - 7].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
                bt[king + 9].IsEnabled = false;
            }
            if ((king > 8 && king < 15) || (king > 16 && king < 23) || (king > 24 && king < 31) || (king > 32 && king < 39) || (king > 40 && king < 47) || (king > 48 && king < 55)) //center_middle
            {
                deter = 5;
                bt[king - 1].IsEnabled = false;
                bt[king + 1].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
                bt[king + 9].IsEnabled = false;
                bt[king - 9].IsEnabled = false;
                bt[king + 7].IsEnabled = false;
                bt[king - 7].IsEnabled = false;
            }
            if (king == 15 || king == 23 || king == 31 || king == 39 || king == 47 || king == 55) //right_middle
            {
                deter = 6;
                bt[king - 1].IsEnabled = false;
                bt[king + 7].IsEnabled = false;
                bt[king + 8].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
                bt[king - 9].IsEnabled = false;
            }
            if (king == 56) //left_bottom
            {
                deter = 7;
                bt[king + 1].IsEnabled = false;
                bt[king - 7].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
            }
            if (king > 56 && king < 63) //center_bottom
            {
                deter = 8;
                bt[king - 1].IsEnabled = false;
                bt[king + 1].IsEnabled = false;
                bt[king - 7].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
                bt[king - 9].IsEnabled = false;
            }
            if (king == 63) //right_bottom
            {
                deter = 9;
                bt[king - 1].IsEnabled = false;
                bt[king - 9].IsEnabled = false;
                bt[king - 8].IsEnabled = false;
            }
            while (my_king.Margin == your_king.Margin || my_rook2.Margin == your_king.Margin || my_rook.Margin == your_king.Margin)
                randomPositionFigure(bt);
            if (pos_your_king > -1 && pos_your_king < 64)
            {
                if (pos_your_king == 0)
                    while (bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin || bt[pos_your_king + 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king > 0 && pos_your_king < 7)
                    while (bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin || bt[pos_your_king + 7].Margin == my_king.Margin || bt[pos_your_king + 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king == 7)
                    while (bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king + 7].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king == 8 || pos_your_king == 16 || pos_your_king == 24 || pos_your_king == 32 || pos_your_king == 40 || pos_your_king == 48)
                    while (bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king - 7].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin || bt[pos_your_king + 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if ((pos_your_king > 8 && pos_your_king < 15) || (pos_your_king > 16 && pos_your_king < 23) || (pos_your_king > 24 && pos_your_king < 31) || (pos_your_king > 32 && pos_your_king < 39) || (pos_your_king > 40 && pos_your_king < 47) || (pos_your_king > 48 && pos_your_king < 55))
                    while (bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king - 7].Margin == my_king.Margin || bt[pos_your_king + 7].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin || bt[pos_your_king - 9].Margin == my_king.Margin || bt[pos_your_king + 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king == 15 || pos_your_king == 23 || pos_your_king == 31 || pos_your_king == 39 || pos_your_king == 47 || pos_your_king == 55)
                    while (bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king + 7].Margin == my_king.Margin || bt[pos_your_king + 8].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin || bt[pos_your_king - 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king == 56)
                    while (bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king - 7].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king > 56 && pos_your_king < 63)
                    while (bt[pos_your_king + 1].Margin == my_king.Margin || bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king - 7].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin || bt[pos_your_king - 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);

                if (pos_your_king == 63)
                    while (bt[pos_your_king - 1].Margin == my_king.Margin || bt[pos_your_king - 8].Margin == my_king.Margin || bt[pos_your_king - 9].Margin == my_king.Margin)
                        randomPositionFigure(bt);
            }
            placesNoForDarkKing(bt[king], bt[rook2], bt[rook]);
        }

        private async void searching_Click(object sender, RoutedEventArgs e)
        {
            double p_x_rook1 = 0, p_y_rook1 = 0, p_x_rook2 = 0, p_y_rook2 = 0, p_x_king = 0, p_y_king = 0, p_x_your_king = 0, p_y_your_king = 0;
            MessageDialog message;
            if (your_king.Visibility == Windows.UI.Xaml.Visibility.Visible)
            {
                message = new MessageDialog("All right.", "Ok");
                await message.ShowAsync();
                if ((double)rook / 8 == 1 || (double)rook / 8 == 2 || (double)rook / 8 == 3 || (double)rook / 8 == 4 || (double)rook / 8 == 5 || (double)rook / 8 == 6 || (double)rook / 8 == 7 || (double)rook / 8 == 8)
                {
                    p_y_rook1 = 8;
                    p_x_rook1 = rook / p_y_rook1;
                }
                else
                {
                    p_x_rook1 = Math.Floor((double)rook / 8 + 1);
                    p_y_rook1 = rook - (p_x_rook1 - 1) * 8;
                }

                if ((double)rook2 / 8 == 1 || (double)rook2 / 8 == 2 || (double)rook2 / 8 == 3 || (double)rook2 / 8 == 4 || (double)rook2 / 8 == 5 || (double)rook2 / 8 == 6 || (double)rook2 / 8 == 7 || (double)rook2 / 8 == 8)
                {
                    p_y_rook2 = 8;
                    p_x_rook2 = rook2 / p_y_rook2;
                }
                else
                {
                    p_x_rook2 = Math.Floor((double)rook2 / 8 + 1);
                    p_y_rook2 = rook2 - (p_x_rook2 - 1) * 8;
                }

                if ((double)king / 8 == 1 || (double)king / 8 == 2 || (double)king / 8 == 3 || (double)king / 8 == 4 || (double)king / 8 == 5 || (double)king / 8 == 6 || (double)king / 8 == 7 || (double)king / 8 == 8)
                {
                    p_y_king = 8;
                    p_x_king = king / p_y_king;
                }
                else
                {
                    p_x_king = Math.Floor((double)king / 8 + 1);
                    p_y_king = king - (p_x_king - 1) * 8;
                }

                if ((double)(pos_your_king + 1) / 8 == 1 || (double)(pos_your_king + 1) / 8 == 2 || (double)(pos_your_king + 1) / 8 == 3 || (double)(pos_your_king + 1) / 8 == 4 || (double)(pos_your_king + 1) / 8 == 5 || (double)(pos_your_king + 1) / 8 == 6 || (double)(pos_your_king + 1) / 8 == 7 || (double)(pos_your_king + 1) / 8 == 8)
                {
                    p_y_your_king = 8;
                    p_x_your_king = (pos_your_king + 1) / p_y_your_king;
                }
                else
                {
                    p_x_your_king = Math.Floor((double)(pos_your_king + 1) / 8 + 1);
                    p_y_your_king = (pos_your_king + 1) - (p_x_your_king - 1) * 8;
                }
                var value = Mat.matMethod(Convert.ToInt32(p_x_rook1), Convert.ToInt32(p_y_rook1+1), Convert.ToInt32(p_x_rook2), Convert.ToInt32(p_y_rook2+1), Convert.ToInt32(p_x_king), Convert.ToInt32(p_y_king+1), Convert.ToInt32(p_x_your_king), Convert.ToInt32(p_y_your_king));
                //  var value = Mat.matMethod(3, 8, 3, 3, 1, 8, 4, 6);
                foreach (var item in value.Item1)
                {
                    my_rook.Margin = bt[(item.Y + (item.X - 1) * 8) - 1].Margin;
                }
                foreach (var item in value.Item2)
                {
                    my_rook2.Margin = bt[(item.Y + (item.X - 1) * 8) - 1].Margin;
                }

                foreach (var item in value.Item3)
                {
                    your_king.Margin = bt[(item.Y + (item.X - 1) * 8) - 1].Margin;
                }
            }
            else
            {
                message = new MessageDialog("You didn't choose your enemy.", "Error");
                await message.ShowAsync();
            }
        }

        public static class Mat
        {
            static int switcher;
            static position rook1;
            static position rook2;
            static position my_king;
            static position your_king;
            static List<position> l_rook1;
            static List<position> l_rook2;
            static List<position> l_your_king;
            static bool rook1Flag = false, rook2Flag = false;
            static int[,] board;

            public async static void mesDialog()
            {
                var mes = new MessageDialog("Мат", "Уведомление");
                await mes.ShowAsync();
            }

            public static Tuple<List<position>, List<position>, List<position>> matMethod(int x_rook1, int y_rook1, int x_rook2, int y_rook2, int x_my_king, int y_my_king, int x_your_king, int y_your_king)
            {
                rook1 = new position();
                rook2 = new position();
                my_king = new position();
                your_king = new position();
                l_rook1 = new List<position>();
                l_rook2 = new List<position>();
                l_your_king = new List<position>();
                rook1.X = x_rook1;
                rook1.Y = y_rook1;
                rook2.X = x_rook2;
                rook2.Y = y_rook2;
                my_king.X = x_my_king;
                my_king.Y = y_my_king;
                your_king.X = x_your_king;
                your_king.Y = y_your_king;
                board = new int[8, 8];
                for (int i = 0; i < board.Length / 8; i++)
                {
                    for (int j = 0; j < board.Length / 8; j++)
                    {
                        board[i, j] = 0;
                    }
                }
                board[rook1.X - 1, rook1.Y - 1] = 1;
                board[rook2.X - 1, rook2.Y - 1] = 2;
                board[my_king.X - 1, my_king.Y - 1] = 3;
                board[your_king.X - 1, your_king.Y - 1] = -3;
                bool priority = true;
                while (true)
                {
                    if (priority)
                    {
                        if (rook1.X + 1 == your_king.X)
                        {
                            rook2_Mot();
                        }
                        if (rook2.X + 1 == your_king.X)
                        {
                            rook1_Mot();
                        }
                        if (rook1.X - 1 != your_king.X && rook2.X - 1 != your_king.X)
                        {
                            Random step = new Random();
                            int k = step.Next(0, 1);
                            if (k == 0)
                            {
                                rook1_Mot();
                            }
                            else
                            {
                                rook2_Mot();
                            }
                        }
                        priority = false;
                    }
                    else
                    {
                        your_king_Mot();
                        priority = true;
                    }
                    if (rook1.X == your_king.X && your_king.X == 8 && rook2.X == 7 || rook2.X == your_king.X && your_king.X == 8 && rook1.X == 7)
                    {
                        mesDialog();
                        break;
                    }
                }
                return Tuple.Create<List<position>, List<position>, List<position>>(l_rook1, l_rook2, l_your_king);
            }

            public static void rook1_Mot()
            {
                if (rook1.Y == your_king.Y - 1 && rook1.X + 1 != your_king.X || rook1.Y == your_king.Y + 1 && rook1.X + 1 != your_king.X)
                {
                    if (rook2.X != rook1.X || my_king.X != rook1.X)
                    {
                        if (Math.Abs(rook1.Y - rook2.Y) == rook2.Y - (Math.Abs(rook1.Y - rook2.Y)))
                        {
                            if (rook1.X == my_king.X)
                            {
                                if (rook1.Y >= 1 && rook1.Y < 5)
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = my_king.Y - 1;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                    if (rook1.Y > 4 && rook1.Y <= 8)
                                    {
                                        board[rook1.X - 1, rook1.Y - 1] = 0;
                                        rook1.Y = my_king.Y + 1;
                                        board[rook1.X - 1, rook1.Y - 1] = 1;
                                        l_rook1.Add(rook1);
                                    }
                            }
                            else
                            {
                                if (rook2.Y == 1)
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 8;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 1;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                            }
                        }
                        else
                        {
                            if (rook1.X == my_king.X)
                            {
                                if (rook1.Y >= 1 && rook1.Y < 5)
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = my_king.Y - 1;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                    if (rook1.Y > 4 && rook1.Y <= 8)
                                    {
                                        board[rook1.X - 1, rook1.Y - 1] = 0;
                                        rook1.Y = my_king.Y + 1;
                                        board[rook1.X - 1, rook1.Y - 1] = 1;
                                        l_rook1.Add(rook1);
                                    }
                            }
                            else
                            {
                                if (rook2.Y == 1)
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 8;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 1;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                if (rook2.Y > 4 && rook2.Y <= 8 && Math.Abs(rook1.Y - rook2.Y) == 1)
                                {
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 8;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                    if (rook2.Y >= 1 && rook2.Y < 5 && Math.Abs(rook1.Y - rook2.Y) == 1)
                                    {
                                        board[rook1.X - 1, rook1.Y - 1] = 0;
                                        rook1.Y = 1;
                                        board[rook1.X - 1, rook1.Y - 1] = 1;
                                        l_rook1.Add(rook1);
                                    }
                            }
                        }
                    }
                    else
                    {
                        if (rook2.X == my_king.X)
                        {
                            if (rook2.Y < rook1.Y && rook2.Y < my_king.Y)
                            {
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.Y = my_king.Y - 1;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                            }
                            else
                                if (rook1.Y == 1 && rook1.Y == rook2.Y - 1 || rook1.Y == 1 && rook1.Y == my_king.Y - 1)
                                {
                                    if (your_king.X > rook1.X + 1)
                                    {
                                        board[rook1.X - 1, rook1.Y - 1] = 0;
                                        rook1.X = rook1.X + 1;
                                        board[rook1.X - 1, rook1.Y - 1] = 1;
                                        l_rook1.Add(rook1);
                                    }
                                }
                                else
                                    if (rook1.Y == 8 && rook1.Y == rook2.Y + 1 || rook1.Y == 8 && rook1.Y == my_king.Y + 1)
                                    {
                                        if (your_king.X > rook1.X + 1)
                                        {
                                            board[rook1.X - 1, rook1.Y - 1] = 0;
                                            rook1.X = rook1.X + 1;
                                            board[rook1.X - 1, rook1.Y - 1] = 1;
                                            l_rook1.Add(rook1);
                                        }
                                    }
                        }
                    }
                }
                else
                    if (rook1.X + 1 == your_king.X && rook1.Y + 1 == your_king.Y || rook1.X - 1 == your_king.X && rook1.Y - 1 == your_king.Y || rook1.X + 1 == your_king.X && rook1.Y - 1 == your_king.Y || rook1.X - 1 == your_king.X && rook1.Y + 1 == your_king.Y)
                    {
                        rook1Flag = true;
                        if (rook1.Y == 1)
                        {
                            if (rook2.Y == 8)
                            {
                                switcher = 2;
                                rook1Flag = false;
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.Y = 7;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                            }
                            else
                            {
                                switcher = 2;
                                rook1Flag = false;
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.Y = 8;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                            }
                        }
                        else
                            if (rook1.Y == 8)
                            {
                                if (rook2.Y == 1)
                                {
                                    switcher = 2;
                                    rook1Flag = false;
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 2;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                                else
                                {
                                    switcher = 2;
                                    rook1Flag = false;
                                    board[rook1.X - 1, rook1.Y - 1] = 0;
                                    rook1.Y = 1;
                                    board[rook1.X - 1, rook1.Y - 1] = 1;
                                    l_rook1.Add(rook1);
                                }
                            }
                        if (rook1Flag)
                        {
                            if (rook1.Y >= 1 && rook1.Y < 5)
                                switcher = 0;
                            else
                                if (rook1.Y > 4 && rook1.Y <= 8)
                                    switcher = 1;
                        }
                        switch (switcher)
                        {
                            case 0:
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.Y = 8;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                                break;
                            case 1:
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.Y = 1;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (rook1.X == your_king.X)
                            return;
                        else
                        {
                            if (rook2.X == your_king.X - 1)
                            {
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.X = your_king.X;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                            }
                            else
                            {
                                board[rook1.X - 1, rook1.Y - 1] = 0;
                                rook1.X = your_king.X - 1;
                                board[rook1.X - 1, rook1.Y - 1] = 1;
                                l_rook1.Add(rook1);
                            }
                        }
                    }
            }

            public static void rook2_Mot()
            {
                if (rook2.Y == your_king.Y - 1 && rook2.X + 1 != your_king.X || rook2.Y == your_king.Y + 1 && rook2.X + 1 != your_king.X)
                {
                    if (rook1.X != rook2.X || my_king.X != rook2.X)
                    {
                        if (Math.Abs(rook2.Y - rook1.Y) == rook1.Y - (Math.Abs(rook2.Y - rook1.Y)))
                        {
                            if (rook2.X == my_king.X)
                            {
                                if (rook2.Y >= 1 && rook2.Y < 5)
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = my_king.Y - 1;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                    if (rook2.Y > 4 && rook2.Y <= 8)
                                    {
                                        board[rook2.X - 1, rook2.Y - 1] = 0;
                                        rook2.Y = my_king.Y + 1;
                                        board[rook2.X - 1, rook2.Y - 1] = 2;
                                        l_rook2.Add(rook2);
                                    }
                            }
                            else
                            {
                                if (rook1.Y == 1)
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 8;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 1;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                            }
                        }
                        else
                        {
                            if (rook2.X == my_king.X)
                            {
                                if (rook2.Y >= 1 && rook2.Y < 5)
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = my_king.Y - 1;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                    if (rook2.Y > 4 && rook2.Y <= 8)
                                    {
                                        board[rook2.X - 1, rook2.Y - 1] = 0;
                                        rook2.Y = my_king.Y + 1;
                                        board[rook2.X - 1, rook2.Y - 1] = 2;
                                        l_rook2.Add(rook2);
                                    }
                            }
                            else
                            {
                                if (rook1.Y == 1)
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 8;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 1;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                if (rook1.Y > 4 && rook1.Y <= 8 && Math.Abs(rook1.Y - rook2.Y) == 1)
                                {
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 8;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                    if (rook1.Y >= 1 && rook1.Y < 5 && Math.Abs(rook1.Y - rook2.Y) == 1)
                                    {
                                        board[rook2.X - 1, rook2.Y - 1] = 0;
                                        rook2.Y = 1;
                                        board[rook2.X - 1, rook2.Y - 1] = 2;
                                        l_rook2.Add(rook2);
                                    }
                            }
                        }
                    }
                    else
                    {
                        if (rook1.X == my_king.X)
                        {
                            if (rook1.Y < rook2.Y && rook1.Y < my_king.Y)
                            {
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.Y = my_king.Y - 1;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                            }
                            else
                                if (rook2.Y == 1 && rook2.Y == rook1.Y - 1 || rook2.Y == 1 && rook2.Y == my_king.Y - 1)
                                {
                                    if (your_king.X > rook2.X + 1)
                                    {
                                        board[rook2.X - 1, rook2.Y - 1] = 0;
                                        rook2.X = rook2.X + 1;
                                        board[rook2.X - 1, rook2.Y - 1] = 2;
                                        l_rook2.Add(rook2);
                                    }
                                }
                                else
                                    if (rook2.Y == 8 && rook2.Y == rook1.Y + 1 || rook2.Y == 8 && rook2.Y == my_king.Y + 1)
                                    {
                                        if (your_king.X > rook2.X + 1)
                                        {
                                            board[rook2.X - 1, rook2.Y - 1] = 0;
                                            rook2.X = rook2.X + 1;
                                            board[rook2.X - 1, rook2.Y - 1] = 2;
                                            l_rook2.Add(rook2);
                                        }
                                    }
                        }
                    }
                }
                else
                    if (rook2.X + 1 == your_king.X && rook2.Y + 1 == your_king.Y || rook2.X - 1 == your_king.X && rook2.Y - 1 == your_king.Y || rook2.X + 1 == your_king.X && rook2.Y - 1 == your_king.Y || rook2.X - 1 == your_king.X && rook2.Y + 1 == your_king.Y)
                    {
                        rook2Flag = true;
                        if (rook2.Y == 1)
                        {
                            if (rook1.Y == 8)
                            {
                                switcher = 2;
                                rook2Flag = false;
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.Y = 7;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                            }
                            else
                            {
                                switcher = 2;
                                rook2Flag = false;
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.Y = 8;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                            }
                        }
                        else
                            if (rook2.Y == 8)
                            {
                                if (rook1.Y == 1)
                                {
                                    switcher = 2;
                                    rook2Flag = false;
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 2;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                                else
                                {
                                    switcher = 2;
                                    rook2Flag = false;
                                    board[rook2.X - 1, rook2.Y - 1] = 0;
                                    rook2.Y = 1;
                                    board[rook2.X - 1, rook2.Y - 1] = 2;
                                    l_rook2.Add(rook2);
                                }
                            }
                        if (rook2Flag)
                        {
                            if (rook2.Y >= 1 && rook2.Y < 5)
                                switcher = 0;
                            else
                                if (rook2.Y > 4 && rook2.Y <= 8)
                                    switcher = 1;
                        }
                        switch (switcher)
                        {
                            case 0:
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.Y = 8;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                                break;
                            case 1:
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.Y = 1;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (rook2.X == your_king.X)
                            return;
                        else
                        {
                            if (rook1.X == your_king.X - 1)
                            {
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.X = your_king.X;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                            }
                            else
                            {
                                board[rook2.X - 1, rook2.Y - 1] = 0;
                                rook2.X = your_king.X - 1;
                                board[rook2.X - 1, rook2.Y - 1] = 2;
                                l_rook2.Add(rook2);
                            }
                        }
                    }
            }

            public static void your_king_Mot()
            {
                if (your_king.X == rook1.X && rook1.X - 1 == rook2.X)
                {
                    board[your_king.X - 1, your_king.Y - 1] = 0;
                    your_king.X = rook1.X + 1;
                    if (rook1.Y >= 1 && rook1.Y < 5)
                    {
                        your_king.Y--;
                        board[your_king.X - 1, your_king.Y - 1] = 4;
                        l_your_king.Add(your_king);
                    }
                    else
                        if (rook1.Y > 4 && rook1.Y <= 8)
                        {
                            your_king.Y++;
                            board[your_king.X - 1, your_king.Y - 1] = 4;
                            l_your_king.Add(your_king);
                        }
                }
                else
                    if (your_king.X == rook2.X && rook2.X - 1 == rook1.X)
                    {
                        board[your_king.X - 1, your_king.Y - 1] = 0;
                        your_king.X = rook2.X + 1;
                        if (rook2.Y >= 1 && rook2.Y < 5)
                        {
                            your_king.Y--;
                            board[your_king.X - 1, your_king.Y - 1] = 4;
                            l_your_king.Add(your_king);
                        }
                        else
                            if (rook2.Y > 4 && rook2.Y <= 8)
                            {
                                your_king.Y++;
                                board[your_king.X - 1, your_king.Y - 1] = 4;
                                l_your_king.Add(your_king);
                            }
                    }
                    else
                    {
                        if (rook1.Y >= 1 && rook1.Y < 5 && rook2.Y >= 1 && rook2.Y < 5)
                        {
                            board[your_king.X - 1, your_king.Y - 1] = 0;
                            your_king.Y--;
                            board[your_king.X - 1, your_king.Y - 1] = 4;
                            l_your_king.Add(your_king);
                        }
                        if (rook1.Y > 4 && rook1.Y <= 8 && rook2.Y > 4 && rook2.Y <= 8)
                        {
                            board[your_king.X - 1, your_king.Y - 1] = 0;
                            your_king.Y++;
                            board[your_king.X - 1, your_king.Y - 1] = 4;
                            l_your_king.Add(your_king);
                        }
                        if (rook1.Y >= 1 && rook1.Y < 5 && rook2.Y > 4 && rook2.Y <= 8)
                        {
                            if (rook1.X + 1 == your_king.X)
                            {
                                board[your_king.X - 1, your_king.Y - 1] = 0;
                                your_king.Y++;
                                board[your_king.X - 1, your_king.Y - 1] = 4;
                                l_your_king.Add(your_king);
                            }
                            else
                            {
                                board[your_king.X - 1, your_king.Y - 1] = 0;
                                your_king.Y--;
                                board[your_king.X - 1, your_king.Y - 1] = 4;
                                l_your_king.Add(your_king);
                            }
                        }
                        if (rook2.Y >= 1 && rook2.Y < 5 && rook1.Y > 4 && rook1.Y <= 8)
                        {
                            if (rook1.X + 1 == your_king.X)
                            {
                                board[your_king.X - 1, your_king.Y - 1] = 0;
                                your_king.Y++;
                                board[your_king.X - 1, your_king.Y - 1] = 4;
                                l_your_king.Add(your_king);
                            }
                            else
                            {
                                board[your_king.X - 1, your_king.Y - 1] = 0;
                                your_king.Y--;
                                board[your_king.X - 1, your_king.Y - 1] = 4;
                                l_your_king.Add(your_king);
                            }
                        }
                    }
            }

            public struct position
            {
                public int X;
                public int Y;
            }
        }
    }
}