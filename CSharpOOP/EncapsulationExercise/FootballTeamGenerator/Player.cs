﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private double skillLevel;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (value == null || value == string.Empty || value == " ")
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }
        public int Endurance
        {
            get => endurance;

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }

                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }

                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }

                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting; 
            
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }

                shooting = value;
            }
        }

        public double CalculateSkillLevel()
        {
            this.skillLevel = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0d;

            return this.skillLevel;
        }

    }
}
