using FFXIVClientStructs.FFXIV.Client.Game.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperborea.ECommons_CNExtra
{
    public unsafe static class GameObject_Extend
    {
        public static void SetObjectPos(GameObject* target, float x, float y, float z)
        {
            target->Position.X = x;
            target->Position.Y = y;
            target->Position.Z = z;
        }
    }
}
