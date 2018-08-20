using System;

namespace BattleSim
{
    public class Player
    {
        private static readonly Random _rng = new Random();


        public Player(string name, int hitpoints = 100)
        {
            Alive = true;
            Name = name;
            Hitpoints = hitpoints;
        }

        public string Name { get; }
        public int Hitpoints { get; private set; }
        public bool Alive { get; private set; }


        public void ReceiveDamage(int damage)
        {
            Hitpoints = Hitpoints - damage;

            if (Hitpoints <= 0)
            {
                Alive = false;
                Hitpoints = 0;
                throw new Exception(string.Format("{0} died", Name));
            }
        }

        public void Attack(Player player)
        {
            var damage = _rng.Next(0, 31);
            player.ReceiveDamage(damage);

            if (damage >= 25) throw new Exception("Critical Hit!");

            if (damage == 0) throw new Exception("Critical fail...");
        }
    }
}