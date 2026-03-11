using Puniemu.Src.Server.GameServer.DataClasses;
using System;

namespace Puniemu.Src.Server.GameServer.Logic
{
    public class MoneyExpManager
    {
        public static int ScoreToMoney(int score)
        {
            double money1 = 1.9 * Math.Pow(score, 0.5);
            double money2 = 26 * Math.Pow(score, 0.33);
            double money3 = 39 * Math.Pow(score, 0.25);
            double money4 = 0.04 * Math.Pow(score, 0.6);
            double money5 = 0.004 * Math.Pow(score, 0.7);
            double money = money1 - money2 + money3 - money4 - money5;
            if ((int)money < 0)
            {
                return 1;
            }
            /*
                Or a simpler but less precise formula:
                0.7 * √score
            */
            return (int)money;
        }
    
        public static int ScoreToExp(int score)
        {
            double exp1 = 149.5 * Math.Pow(score, 0.5);
            double exp2 = 1100 * Math.Pow(score, 0.3333);
            double exp3 = 522 * Math.Pow(score, 0.25);
            double exp4 = 18 * Math.Pow(score, 0.6);
            double exp5 = 1.25 * Math.Pow(score, 0.7);
            double exp6 = 0.04 * Math.Pow(score, 0.8);
            double exp7 = 741 * Math.Pow(score, 0.4);
            double exp = exp1 + exp2 - exp3 - exp4 + exp5 - exp6 - exp7;
            if ((int)exp < 0)
            {
                return 1;
            }
            /*
                Or a simpler but less precise formula:
                3.6 * √score
            */

            return (int)exp;
        }
    }
}
