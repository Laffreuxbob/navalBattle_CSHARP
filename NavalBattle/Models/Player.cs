﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class Player
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String name;
        private PlayerType player; // AI human or other
        private Boolean winner = false;
        private Boolean lose = false;
        private List<Box> list;

        
        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public PlayerType Type
        {
            get { return player; }
            set { player = value; }
        }


        public Boolean Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public Boolean Lose
        {
            get { return lose; }
            set { lose = value; }
        }

        public List<Box> List
        {
            get { return list; }
            set { list = value; }
        }



        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player()
        {

        }

        public Player(String name, PlayerType type)
        {
            this.Name = name != "" ? name : "default_name"; // in case of user dont send name
            this.Type = type;
        }
        #endregion

        #region StaticFunctions

        public static Player CreatePlayer(String name, PlayerType type)
        {
            return new Player(name, type);
        }
        #endregion

        #region Functions

        // Show Player in console
        public virtual void Show()
        {
            System.Console.WriteLine(this.Name + " - " + this.Type + " - " + this.Winner);
        }
        #endregion

        // Check if this player got at least one ship alive in his boat list
        public Boolean CheckWin(List<Box> list)
        {
            foreach(Box box in list)
            {
                if (box.State.Equals(StateBox.ship))
                {
                    this.Lose = false;
                    
                    break;
                }

                this.Lose = true;
            }
            if (this.Lose) {
                System.Console.WriteLine(this.name + "Win ?  Yes, ggwp bro !");
            }
            else
            {
                System.Console.WriteLine(this.name + "Win ? Nope, try harder !");
            }
            return this.Lose;

        }

        public Box SelectBox(List<Box> list, int x, int y, int step)
        {
            return list[x + y * step];
        }

        #region Events
        #endregion


    }
}
