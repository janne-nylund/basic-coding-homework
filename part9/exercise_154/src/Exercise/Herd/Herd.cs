using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Herd : IMovable
    {
        private List<IMovable> movableList;
        public Herd()
        {
            this.movableList = new List<IMovable>();
        }

        public void AddToHerd(IMovable mov)
        {
            this.movableList.Add(mov);
        }

        public void Move(int dx, int dy)
        {
            foreach (IMovable item in movableList)
            {
                item.Move(dx, dy);
            }
        }

        public override string ToString()
        {
            List<string> list = new List<string>();
            foreach (IMovable item in this.movableList)
            {
                list.Add((item.ToString() + "\n"));
            }
            return String.Join(String.Empty, list);
        }
    }
}