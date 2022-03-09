using System;
using System.Collections.Generic;
using System.Text;

namespace FM_Playstyle_Calculator
{
    public class Player
    {
        #region Default Attributes
        private string position;
        private string role;
        private string name;
        private bool isWide;
        private int acceleration;
        private int aggression;
        private int agility;
        private int anticipation;
        private int balance;
        private int bravery;
        private int composure;
        private int concentration;
        private int corners;
        private int crossing;
        private int decisions;
        private int dribbling;
        private int finishing;
        private int firstTouch;
        private int flair;
        private int freeKick;
        private int heading;
        private int jumpingReach;
        private int leadership;
        private int longShots;
        private int longThrow;
        private int marking;
        private int naturalFitness;
        private int offTheBall;
        private int pace;
        private int passing;
        private int positioning;
        private int stamina;
        private int strength;
        private int tackling;
        private int teamwork;
        private int technique;
        private int throwing;
        private int vision;
        private int workRate;

        public string Position { get => position; set => position = value; }
        public string Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }
        public bool IsWide { get => isWide; set => isWide = value; }
        public int Acceleration { get => acceleration; set => acceleration = value; }
        public int Aggression { get => aggression; set => aggression = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Anticipation { get => anticipation; set => anticipation = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Bravery { get => bravery; set => bravery = value; }
        public int Composure { get => composure; set => composure = value; }
        public int Concentration { get => concentration; set => concentration = value; }
        public int Corners { get => corners; set => corners = value; }
        public int Crossing { get => crossing; set => crossing = value; }
        public int Decisions { get => decisions; set => decisions = value; }
        public int Dribbling { get => dribbling; set => dribbling = value; }
        public int Finishing { get => finishing; set => finishing = value; }
        public int FirstTouch { get => firstTouch; set => firstTouch = value; }
        public int Flair { get => flair; set => flair = value; }
        public int FreeKick { get => freeKick; set => freeKick = value; }
        public int Heading { get => heading; set => heading = value; }
        public int JumpingReach { get => jumpingReach; set => jumpingReach = value; }
        public int Leadership { get => leadership; set => leadership = value; }
        public int LongShots { get => longShots; set => longShots = value; }
        public int LongThrow { get => longThrow; set => longThrow = value; }
        public int Marking { get => marking; set => marking = value; }
        public int NaturalFitness { get => naturalFitness; set => naturalFitness = value; }
        public int OffTheBall { get => offTheBall; set => offTheBall = value; }
        public int Pace { get => pace; set => pace = value; }
        public int Passing { get => passing; set => passing = value; }
        public int Positioning { get => positioning; set => positioning = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Tackling { get => tackling; set => tackling = value; }
        public int Teamwork { get => teamwork; set => teamwork = value; }
        public int Technique { get => technique; set => technique = value; }
        public int Throwing { get => throwing; set => throwing = value; }
        public int Vision { get => vision; set => vision = value; }
        public int WorkRate { get => workRate; set => workRate = value; }
        #endregion

        #region GK Attributes
        private int aerialAbility;
        private int commandOfArea;
        private int handling;
        private int oneOnOne;
        private int rushingOut;

        public int AerialAbility { get => aerialAbility; set => aerialAbility = value; }
        public int CommandOfArea { get => commandOfArea; set => commandOfArea = value; }
        public int Handling { get => handling; set => handling = value; }
        public int OneOnOne { get => oneOnOne; set => oneOnOne = value; }
        public int RushingOut { get => rushingOut; set => rushingOut = value; }
        #endregion

        #region Composite Attributes
        private double intelligence;
        private double creativity;
        private double movement;
        private double mobility;
        private double passingAbility;
        private double dribblingAbility;
        private double crossingAbility;
        private double awareness;
        private double decisionMaking;
        private double focus;
        private double physicalPresence;
        private double control;
        private double shootingAbility;
        private double endeavour;
        private double gKRushingAbility;
        private double gKDefendingAbility;

        public double Intelligence
        {
            get => intelligence;

            set => intelligence = (Anticipation + Decisions + Flair + Teamwork + Vision) / 5;
        }
        public double Creativity
        {
            get => creativity;
            set => creativity = (Anticipation + Decisions + Flair) / 3;
        }
        public double Movement
        {
            get => movement;
            set => movement = (Anticipation + Decisions + Teamwork) / 3;
        }
        public double Mobility
        {
            get => mobility;
            set => mobility = (Acceleration + Agility + Balance + Pace) / 4;
        }
        public double PassingAbility
        {
            get => passingAbility;
            set => passingAbility = (Passing + Technique) / 2;
        }
        public double DribblingAbility
        {
            get => dribblingAbility;
            set => dribblingAbility = (Dribbling + Technique);
        }
        public double CrossingAbility
        {
            get => crossingAbility;
            set => crossingAbility = (Crossing + Passing + Technique) / 3;
        }
        public double Awareness
        {
            get => awareness;
            set => awareness = (Anticipation + Teamwork) / 2;
        }
        public double DecisionMaking
        {
            get => decisionMaking;
            set => decisionMaking = (Decisions + Teamwork) / 2;
        }
        public double Focus
        {
            get => focus;
            set => focus = (Composure + Concentration) / 2;
        }
        public double PhysicalPresence
        {
            get => physicalPresence;
            set => physicalPresence = (Balance + Strength) / 2;
        }
        public double Control
        {
            get => control;
            set => control = (FirstTouch + Technique) / 2;
        }
        public double ShootingAbility
        {
            get => shootingAbility;
            set => shootingAbility = (Finishing + LongShots + Technique);
        }
        public double Endeavour
        {
            get => endeavour;
            set => endeavour = (Aggression + Bravery + WorkRate) / 3;
        }
        public double GKRushingAbility
        {
            get => gKRushingAbility;
            set => gKRushingAbility = (OneOnOne + RushingOut) / 2;
        }
        public double GKDefendingAbility 
        { 
            get => gKDefendingAbility;
            set => gKDefendingAbility = (AerialAbility + CommandOfArea + Handling) / 3;
        }

        #endregion
    }
}
