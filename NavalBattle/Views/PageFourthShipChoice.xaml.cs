﻿using NavalBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavalBattle.Views
{
    /// <summary>
    /// Logique d'interaction pour PageFirstShipChoice.xaml
    /// </summary>
    public partial class PageFourthShipChoice : Page
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PageFourthShipChoice()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void fourthShipChoice_Click(object sender, RoutedEventArgs e)
        {
            ListShip listReturn = new ListShip();
            List<Ship> aircraftCarrierList = new List<Ship>();
            Ship aircraftCarrier = new Ship();
            aircraftCarrier.Name = "Aircraft carrier";
            aircraftCarrier.State = true;

            // dimensions of the ship
            if (this.fourthShipWidthTxt.Text == "" || this.fourthShipWidthTxt.Text == "0")
            {
                aircraftCarrier.WidthNbBox = 4;
            }
            else
            {
                int widthChoice = int.Parse(this.fourthShipWidthTxt.Text);
                if (widthChoice < 0)
                {
                    widthChoice = -widthChoice;
                }
                aircraftCarrier.WidthNbBox = widthChoice;
            }
            if (this.fourthShipHeightTxt.Text == "" || this.fourthShipHeightTxt.Text == "0")
            {
                aircraftCarrier.HeightNbBox = 2;
            }
            else
            {
                int heightChoice = int.Parse(this.fourthShipHeightTxt.Text);
                if (heightChoice < 0)
                {
                    heightChoice = -heightChoice;
                }
                aircraftCarrier.HeightNbBox = heightChoice;
            }
            aircraftCarrier.PositionShip = new int[aircraftCarrier.WidthNbBox, aircraftCarrier.HeightNbBox];

            // number of ship
            int quantity = 0;
            if (this.fourthShipQuantityTxt.Text == "" || this.fourthShipQuantityTxt.Text == "0")
            {
                quantity = 1;
            }
            else
            {
                quantity = int.Parse(this.fourthShipQuantityTxt.Text);
                if (quantity < 0)
                {
                    quantity = -quantity;
                }
            }

            // quantity test
            Boolean quantityTestReturn = false;
            while (quantityTestReturn != true && quantity != 0)
            {
                quantityTestReturn = ListShip.quantityTest(quantity, aircraftCarrier.WidthNbBox, aircraftCarrier.HeightNbBox);

                if (quantityTestReturn == false)
                {
                    quantity--;
                }
            }

            listReturn.Quantity = quantity;
            listReturn.QuantityAlive = quantity;
            listReturn.DisplayString = listReturn.QuantityAlive + " " + aircraftCarrier.Name + " alive";
            listReturn.ImageSource = new BitmapImage(new Uri("pack://application:,,,/NavalBattle;component/Resources/aircraft_carrier.jpg"));
            for (int i = 0; i < quantity; i++)
            {
                aircraftCarrierList.Add(aircraftCarrier);
            }
            listReturn.ShipsList = aircraftCarrierList;

            (this.Parent as MainWindow).PlacementPlayer.Add(listReturn);
            (this.Parent as MainWindow).PlacementVersus.Add(listReturn);

            PageGridGame game = new PageGridGame();
            game.PlacementShipsPlayer = (this.Parent as MainWindow).PlacementPlayer;
            game.BindListviews();

            // generate random configuration of ships
            game.placementAleatoire((this.Parent as MainWindow).PlacementPlayer);
            game.placementAleatoire((this.Parent as MainWindow).PlacementVersus);

            (this.Parent as Window).Content = game;
        }
        #endregion

    }
}
