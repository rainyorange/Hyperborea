using FFXIVClientStructs.FFXIV.Client.Game.Object;

namespace Hyperborea
{
    public static unsafe class GameObject_Extend
    {
        public static void SetObjectPos(GameObject* target, float x, float y, float z)
        {
            target->Position.X = x;
            target->Position.Y = y;
            target->Position.Z = z;
        }
    }
}
