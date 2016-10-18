using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatars.AvatarComponents
{
    public class BaseMove : IMove
    {
        #region Field Region
        private string name;
        private Target target;
        private MoveType moveType;
        private MoveElement moveElement;
        private Status status;
        private bool unlocked;
        private int unlockedAt;
        private int duration;
        private int attack;
        private int defense;
        private int speed;
        private int health;
        #endregion
        #region Property Region
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Target Target
        {
            get { return target; }
            set { target = value; }
        }
        public MoveType MoveType
        {
            get { return moveType; }
            set { moveType = value; }
        }
        public MoveElement MoveElement
        {
            get { return moveElement; }
            set { moveElement = value; }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
        public int UnlockedAt
        {
            get { return unlockedAt; }
            set { unlockedAt = value; }
        }
        public bool Unlocked
        {
            get { return unlocked; }
            set { unlocked = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        #endregion

        public BaseMove() { }
        #region Method Region
        public void Unlock()
        {
            unlocked = true;
        }

        public virtual object Clone()
        {
            return null;
        }
        #endregion

    }
}
