using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    public class Ship
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id; // id of the ship
        private String name; // name of the ship
        private int widthNbBox; // size of the ship
        private int heightNbBox; // size of the ship
        private Boolean state; // the ship is still alive ?
        private int[][] positionShip; // position X,Y of each case of the ship
        private String picturePath; // path for the picture of the ship
        #endregion

        #region Properties
        [Key]
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int WidthNbBox
        {
            get { return widthNbBox; }
            set { widthNbBox = value; }
        }

        public int HeightNbBox
        {
            get { return heightNbBox; }
            set { heightNbBox = value; }
        }

        public Boolean State
        {
            get { return state; }
            set { state = value; }
        }

        public int[][] PositionShip
        {
            get { return positionShip; }
            set { positionShip = value; }
        }

        public String PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
        }



        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Ship()
        {

        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public static List<Ship> ShipCreation()
        {
            // first ship
            Ship shipA = new Ship();
            shipA.Name = "Submarine";
            shipA.heightNbBox = 2;
            shipA.widthNbBox = 1;
            shipA.State = true;
            shipA.PicturePath = "";
            Ship shipB = new Ship();
            shipB.Name = "Corvette";
            shipB.heightNbBox = 3;
            shipB.widthNbBox = 1;
            shipB.State = true;
            shipB.PicturePath = "";
            Ship shipC = new Ship();
            shipC.Name = "Cruiser";
            shipC.heightNbBox = 4;
            shipC.widthNbBox = 1;
            shipC.State = true;
            shipC.PicturePath = "";
            Ship shipD = new Ship();
            shipD.Name = "Aircraft carrier";
            shipD.heightNbBox = 4;
            shipD.widthNbBox = 2;
            shipD.State = true;
            shipD.PicturePath = "";

            return [shipA, shipB, shipC, shipD];
        }
        #endregion

        #region Events
        #endregion


    }
}
