using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Avatars.AvatarComponents
{
    public class Tackle : BaseMove
    {
        
        #region Constructor region
        public Tackle()
        {
            this.Name = "Tackle";
            this.Target = Target.Enemy;
            this.MoveType = MoveType.Attack;
            this.MoveElement = MoveElement.None;
            this.Status = Status.Normal;
            this.Duration = 1;
            this.Unlocked = false;
            this.Attack = MoveManager.Random.Next(0, 0);
            this.Defense = MoveManager.Random.Next(0, 0);
            this.Speed = MoveManager.Random.Next(0, 0);
            this.Health = MoveManager.Random.Next(10, 15);
        }
        #endregion
        public override object Clone()
        {
            Tackle tackle = new Tackle();
            tackle.Unlocked = this.Unlocked;
            return tackle;
        }
    }
}
