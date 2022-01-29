﻿using System;
namespace Easter.Models.Bunnies
{
    public class HappyBunny : Bunny
    {
        public HappyBunny(string name)
            : base(name, 100)
        {
        }

        public override void Work()
        {
            this.Energy -= 15;
        }
    }
}