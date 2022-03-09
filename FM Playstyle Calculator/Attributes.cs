using System;
using System.Collections.Generic;
using System.Text;

namespace FM_Playstyle_Calculator
{
    public class Attributes
    {
        #region Base Attributes

        public static string Acceleration = "Acceleration";
        public static string Aggression = "Aggression";
        public static string Agility = "Agility";
        public static string Anticipation = "Anticipation";
        public static string Balance = "Balance";
        public static string Bravery = "Bravery";
        public static string Composure = "Composure";
        public static string Concentration = "Concentration";
        public static string Corners = "Corners";
        public static string Crossing = "Crossing";
        public static string Decisions = "Decisions";
        public static string Dribbling = "Dribbling";
        public static string Finishing = "Finishing";
        public static string FirstTouch = "Fir";
        public static string Flair = "Fla";
        public static string FreeKick = "Fre";
        public static string Heading = "Hea";
        public static string JumpingReach = "Jmp";
        public static string Leadership = "Ldr";
        public static string LongShots = "Lon";
        public static string Marking = "Mar";
        public static string NaturalFitness = "Nat";
        public static string OffTheBall = "OtB";
        public static string Pace = "Pac";
        public static string Passing = "Pas";
        public static string Positioning = "Pos";
        public static string Stamina = "Sta";
        public static string Strength = "Str";
        public static string Tackling = "Tck";
        public static string Teamwork = "Tea";
        public static string Technique = "Tec";
        public static string Vision = "Vis";
        public static string WorkRate = "Wor";

        public static string AerialAbility = "Aer";
        public static string CommandOfArea = "Cmd";
        public static string Handling = "Han";
        public static string Kicking = "Kic";
        public static string LongThrow = "L Th";
        public static string OneOnOne = "1v1";
        public static string RushingOut = "TRO";
        public static string Throwing = "Thr";
        public static string GKRushingAbility = "GKRushingAbility";
        public static string GKDefAbility = "GKDefendingAbility";

        public static string Intelligence = "Intelligence";
        public static string Creativity = "Creativity";
        public static string Movement = "Movement";
        public static string Mobility = "Mobility";
        public static string PassingAbility = "PassingAbility";
        public static string DribblingAbility = "DribblingAbility";
        public static string CrossingAbility = "CrossingAbility";
        public static string Awareness = "Awareness";
        public static string DecisionMaking = "DecisionMaking";
        public static string Focus = "Focus";
        public static string PhysicalPresence = "PhysicalPresence";
        public static string Control = "Control";
        public static string ShootingAbility = "ShootingAbility";
        public static string Endeavour = "Endeavour";

        #endregion

        #region Composite Attributes

        public static List<string> IntelligenceMap = new List<string>
        {
            Anticipation,
            Decisions,
            Flair,
            Teamwork,
            Vision
        };

        public static List<string> CreativityMap = new List<string>
        {
            Anticipation,
            Decisions,
            Flair
        };

        public static List<string> MovementMap = new List<string>
        {
            Anticipation,
            Decisions,
            Teamwork
        };

        public static List<string> MobilityMap = new List<string>
        {
            Acceleration,
            Agility,
            Balance,
            Pace
        };

        public static List<string> PassingAbilityMap = new List<string>
        {
            Passing,
            Technique
        };

        public static List<string> DribblingAbilityMap = new List<string>
        {
            Dribbling,
            Technique
        };

        public static List<string> CrossingAbilityMap = new List<string>
        {
            Crossing,
            Passing,
            Technique
        };

        public static List<string> AwarenessMap = new List<string>
        {
            Anticipation,
            Teamwork
        };

        public static List<string> DecisionMakingMap = new List<string>
        {
            Decisions,
            Teamwork
        };

        public static List<string> FocusMap = new List<string>
        {
            Composure,
            Concentration
        };

        public static List<string> PhysicalPresenceMap = new List<string>
        {
            Balance,
            Strength
        };

        public static List<string> ControlMap = new List<string>
        {
            FirstTouch,
            Technique
        };

        public static List<string> ShootingAbilityMap = new List<string>
        {
            Finishing,
            LongShots,
            Technique
        };

        public static List<string> EndeavourMap = new List<string>
        {
            Aggression,
            Bravery,
            WorkRate
        };

        public static List<string> GKRushingAbilityMap = new List<string>
        {
            OneOnOne,
            RushingOut
        };

        public static List<string> GKDefendingAbilityMap = new List<string>
        {
            AerialAbility,
            CommandOfArea,
            Handling
        };

        #endregion
    }
}
