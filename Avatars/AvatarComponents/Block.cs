using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Avatars.AvatarComponents
{
    public class Block : BaseMove
    {
        
        #region Constructor Region
        public Block()
        {
            this.Name = "Block";
            this.Target = Target.Self;
            this.MoveType = MoveType.Buff;
            this.MoveElement = MoveElement.None;
            this.Status = Status.Normal;
            this.Unlocked = false;
            this.Duration = 5;
            this.Attack = MoveManager.Random.Next(0, 0);
            this.Defense = MoveManager.Random.Next(2, 6);
            this.Speed = MoveManager.Random.Next(0, 0);
            this.Health = MoveManager.Random.Next(0, 0);
        }
        #endregion

        public override object Clone()
        {
            Block block = new Block();
            block.Unlocked = this.Unlocked;
            return block;
        }
    }
}
