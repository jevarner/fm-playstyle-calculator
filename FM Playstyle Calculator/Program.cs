using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FM_Playstyle_Calculator
{
    class Program
    {
        #region Instruction Maps

        #region Mentality

        private static readonly List<string> DefenceMentalityAttributes = new List<string>
        {
            Attributes.Movement,
            Attributes.Positioning,
            Attributes.Tackling,
            Attributes.Strength
        };

        private static readonly List<string> AttackingMentalityAttributes = new List<string>
        {
            Attributes.Intelligence,
            Attributes.PassingAbility,
            Attributes.Mobility
        };

        #endregion

        #region In Possession

        #region Attacking Width
        private static readonly List<string> AttackWidthDefAttr = new List<string>
        {
            Attributes.Movement,
            Attributes.Positioning,
            Attributes.Marking
        };

        private static readonly List<string> AttackWidthAttackAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.OffTheBall,
            Attributes.PassingAbility
        };
        #endregion

        #region Pass Into Space
        private static readonly List<string> PassIntoSpaceCreatorAtt = new List<string>
        {
            Attributes.Intelligence,
            Attributes.PassingAbility
        };

        private static readonly List<string> PassIntoSpaceFinisherAtt = new List<string>
        {
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall
        };
        #endregion

        #region Overlaps and Underlaps

        private static readonly List<string> FullbackLapAttr = new List<string>
        {
            Attributes.WorkRate,
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall
        };

        private static readonly List<string> WingerLapAttr = new List<string>
        {
            Attributes.Creativity,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.DribblingAbility
        };

        #endregion

        #region Focus Play Down Lane

        private static readonly List<string> FocusPlayDownWingFlanksAttr = new List<string>
        {
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.CrossingAbility,
            Attributes.DribblingAbility,
            Attributes.Positioning,
            Attributes.Marking
        };

        private static readonly List<string> FocusPlayDownMidCenterAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.PassingAbility,
            Attributes.Mobility,
            Attributes.OffTheBall
        };

        private static readonly List<string> FocusPlayDownMidFlankAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.Awareness,
            Attributes.DecisionMaking,
            Attributes.Positioning,
            Attributes.Marking,
            Attributes.Mobility,
            Attributes.OffTheBall
        };

        #endregion

        #region Play Out of Defence

        private static readonly List<string> PlayOutOfDefAttr = new List<string>
        {
            Attributes.Focus,
            Attributes.Awareness,
            Attributes.DecisionMaking
        };

        #endregion

        #region Passing Directness

        private static readonly List<string> DirectPassing = new List<string>
        {
            Attributes.WorkRate,
            Attributes.PhysicalPresence,
            Attributes.JumpingReach,
            Attributes.Mobility,
            Attributes.Intelligence,
            Attributes.OffTheBall,
            Attributes.Control,
            Attributes.PassingAbility
        };

        private static readonly List<string> ShortPassing = new List<string>
        {
            Attributes.Intelligence,
            Attributes.OffTheBall,
            Attributes.Control,
            Attributes.PassingAbility,
            Attributes.WorkRate,
            Attributes.PhysicalPresence,
            Attributes.JumpingReach,
            Attributes.Mobility
        };

        #endregion

        #region Tempo

        private static readonly List<string> TempoAttr = new List<string>
        {
            Attributes.WorkRate,
            Attributes.Intelligence,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.Control
        };

        #endregion

        #region Crossing Types

        private static readonly List<string> FloatedCrossFlankAttr = new List<string>
        {
            Attributes.Awareness,
            Attributes.DecisionMaking,
            Attributes.Flair,
            Attributes.CrossingAbility
        };

        private static readonly List<string> FloatedCrossCenterAttr = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Heading,
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall
        };

        private static readonly List<string> WhippedCrossFlankAttr = new List<string>
        {
            Attributes.Awareness,
            Attributes.DecisionMaking,
            Attributes.CrossingAbility
        };

        private static readonly List<string> WhippedCrossCenterAttr = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.Heading,
            Attributes.Technique
        };

        private static readonly List<string> LowCrossFlankAttr = new List<string>
        {
            Attributes.Awareness,
            Attributes.DecisionMaking,
            Attributes.CrossingAbility
        };

        private static readonly List<string> LowCrossCenterAttr = new List<string>
        {
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.Control,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Heading,
            Attributes.Technique
        };
        #endregion

        #region Work Ball Into Box

        private static readonly List<string> WorkBallCenterAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.ShootingAbility
        };

        private static readonly List<string> WorkBallFlankAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.Crossing,
            Attributes.Technique
        };

        #endregion

        #region Hit Early Crosses

        private static readonly List<string> HitEarlyCrossesFlankAttr = new List<string>
        {
            Attributes.CrossingAbility,
            Attributes.Intelligence,
            Attributes.WorkRate,
            Attributes.Mobility,
            Attributes.DribblingAbility
        };

        #endregion

        #region Shoot on Sight

        private static readonly List<string> ShootOnSightAttr = new List<string>
        {
            Attributes.ShootingAbility,
            Attributes.Intelligence
        };

        #endregion

        #region Play for Set Pieces

        private static readonly List<string> PlayForSetPiecesTakerAttr = new List<string>
        {
            Attributes.Corners,
            Attributes.FreeKick,
            Attributes.LongThrow,
            Attributes.Crossing,
            Attributes.LongShots,
            Attributes.Passing
        };

        private static readonly List<string> PlayForSetPiecesAttackAttr = new List<string>
        {
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Heading
        };

        #endregion

        #region Dribble Mentality

        private static readonly List<string> DribbleLessAttr = new List<string>
        {
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Flair,
            Attributes.Mobility,
            Attributes.DribblingAbility
        };

        private static readonly List<string> RunAtDefenceAttr = new List<string>
        {
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Flair,
            Attributes.Mobility,
            Attributes.Awareness,
            Attributes.Passing
        };

        #endregion

        #region Creativity Mentality 

        private static readonly List<string> CreativeMentalityAttr = new List<string>
        {
            Attributes.Intelligence,
            Attributes.OffTheBall,
            Attributes.Control,
            Attributes.PassingAbility,
            Attributes.DribblingAbility,
            Attributes.ShootingAbility
        };

        #endregion


        #endregion

        #region In Transition

        private static readonly List<string> PossessionLostAttr = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Mobility,
            Attributes.Positioning,
            Attributes.Tackling,
            Attributes.Focus,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Marking,
            Attributes.Heading
        };

        private static readonly List<string> CounterAttackAttr = new List<string>
        {
            Attributes.WorkRate,
            Attributes.Mobility,
            Attributes.OffTheBall,
            Attributes.DribblingAbility,
            Attributes.Intelligence,
            Attributes.Passing
        };

        #region Distribute Speed

        private static readonly List<string> DistributeSpeedGKAttr = new List<string>
        {
            Attributes.Awareness,
            Attributes.Decisions
        };

        private static readonly List<string> DistributeSpeedReceivingAttr = new List<string>
        {
            Attributes.Focus
        };

        #endregion

        #region GK Distribution Style

        private static readonly List<string> GKDistributionAttr = new List<string>
        {
            Attributes.Kicking,
            Attributes.Throwing
        };

        private static readonly List<string> DisOverDefenceAttackAttr = new List<string>
        {
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Control,
            Attributes.Heading,
            Attributes.Technique
        };

        private static readonly List<string> DisOverDefenceGKAttr = new List<string>
        {
            Attributes.Kicking,
            Attributes.Throwing
        };

        #endregion

        #region GK Distribution Receiver Attributes

        private static readonly List<string> RollItOutRecAttr = new List<string>
        {
            Attributes.Focus,
            Attributes.Creativity,
            Attributes.Passing
        };

        private static readonly List<string> ThrowItLongRecAttr = new List<string>
        {
            Attributes.Focus,
            Attributes.Creativity,
            Attributes.Control,
            Attributes.Passing
        };

        private static readonly List<string> TakeShortKickGKAttr = new List<string>
        {
            Attributes.Kicking,
            Attributes.Throwing,
            Attributes.Passing
        };

        private static readonly List<string> TakeShortKickRecAttr = new List<string>
        {
            Attributes.Focus,
            Attributes.Creativity,
            Attributes.Control,
            Attributes.Passing
        };

        private static readonly List<string> TakeLongKicksRecAttr = new List<string>
        {
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Control,
            Attributes.Heading,
            Attributes.Technique
        };

        #endregion

        #endregion

        #region Out of Possession

        private static readonly List<string> UseOffsideTrapAttr = new List<string>
        {
            Attributes.Movement,
            Attributes.Mobility,
            Attributes.Positioning
        };

        private static readonly List<string> LineOfEngagementAttr = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Mobility,
            Attributes.Positioning,
            Attributes.Tackling,
            Attributes.Focus,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Marking,
            Attributes.Heading
        };

        private static readonly List<string> DefensiveStyleAttr = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Mobility,
            Attributes.Positioning,
            Attributes.Tackling,
            Attributes.Focus,
            Attributes.Strength,
            Attributes.JumpingReach,
            Attributes.Marking,
            Attributes.Heading
        };

        private static readonly List<string> DefensiveStyleGKAttr = new List<string>
        {
            Attributes.GKDefAbility,
            Attributes.GKRushingAbility,
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.Acceleration,
            Attributes.Agility,
            Attributes.Pace
        };

        private static readonly List<string> UseTighterMarking = new List<string>
        {
            Attributes.Focus,
            Attributes.Endeavour,
            Attributes.Movement,
            Attributes.PhysicalPresence,
            Attributes.AerialAbility,
            Attributes.Mobility,
            Attributes.Positioning,
            Attributes.Marking,
            Attributes.Tackling
        };

        private static readonly List<string> TacklingStyle = new List<string>
        {
            Attributes.Endeavour,
            Attributes.Anticipation,
            Attributes.Decisions,
            Attributes.PhysicalPresence,
            Attributes.Tackling
        };

        #endregion

        #endregion

        private static Dictionary<string, int> ColumnMap = new Dictionary<string, int>
        {
            { "Position", 0 },
            { "Name", 1 },
            { Attributes.Acceleration, 2 },
            { Attributes.AerialAbility, 3 },
            { Attributes.Aggression, 4 },
            { Attributes.Agility, 5 },
            { Attributes.Anticipation, 6 },
            { Attributes.Balance, 7 },
            { Attributes.Bravery, 8 },
            { Attributes.CommandOfArea, 9 },
            { Attributes.Composure, 10 },
            { Attributes.Concentration, 11 },
            { Attributes.Corners, 12 },
            { Attributes.Decisions, 13 },
            { Attributes.Dribbling, 15 },
            { Attributes.Finishing, 16 },
            { Attributes.FirstTouch, 17 },
            { Attributes.Flair, 18 },
            { Attributes.FreeKick, 19 },
            { Attributes.Handling, 20 },
            { Attributes.Heading, 21 },
            { Attributes.JumpingReach, 22 },
            { Attributes.Kicking, 23 },
            { Attributes.Leadership, 24 },
            { Attributes.LongShots, 25 },
            { Attributes.LongThrow, 26 },
            { Attributes.Marking, 27 },
            { Attributes.NaturalFitness, 28 },
            { Attributes.OffTheBall, 29 },
            { Attributes.OneOnOne, 30 },
            { Attributes.Pace, 31 },
            { Attributes.Passing, 32 },
            { Attributes.Positioning, 33 },
            { Attributes.RushingOut, 34 },
            { Attributes.Stamina, 35 },
            { Attributes.Strength, 36 },
            { Attributes.Tackling, 37 },
            { Attributes.Teamwork, 38 },
            { Attributes.Technique, 39 },
            { Attributes.Throwing, 40 },
            { Attributes.Vision, 41 },
            { Attributes.WorkRate, 42 }
        };

        private static readonly string InputFilePath = @"C:\Users\jacob\Documents\Projects\FM stat sheet\Input File.csv";
        static void Main()
        {
            var lines = File.ReadAllLines(InputFilePath)
                            .Skip(1)
                            .ToList();


        }

        public static List<Player> CreatePlayerList(List<string> lines)
        {
            foreach (var line in lines)
            {
                var input = line.Split(',');
            }

            throw new NotImplementedException();
        }

        public static Player CreatePlayer(string[] line)
        {
            var player = new Player
            {
                Position = line[ColumnMap["Position"]]
            };

            return new Player();
        }
    }
}
