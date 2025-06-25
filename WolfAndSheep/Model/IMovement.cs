using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public interface IMovement
    {

        public abstract BoardPosition FromPos { get; }
        public abstract BoardPosition ToPos { get; }

        public abstract void Move(Board board);

    }
}