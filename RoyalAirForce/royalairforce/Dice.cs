using System;

namespace royalairforce
{
    public class Dice {
        private static Dice _dice = new Dice();

        private Dice() {
            
        }
        public static Dice GetInstance() {
            return _dice;
        }

        private Random _random = new Random();

        public int RollDice() {
            return _random.Next(1, 7);
        }
    }
}