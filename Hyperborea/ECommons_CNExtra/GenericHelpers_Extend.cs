using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperborea.ECommons_CNExtra
{
    public static class GenericHelpers_Extend
    {
        public static string GetCallStackID(int maxFrames = 3)
        {
            try
            {
                if (maxFrames == 0)
                {
                    maxFrames = int.MaxValue;
                }
                else
                {
                    maxFrames--;
                }
                var stack = new StackTrace().GetFrames();
                if (stack.Length > 1)
                {
                    return stack[1..Math.Min(stack.Length, maxFrames)].Select(x => x.GetMethod() == null ? "<unknown>" : $"{x.GetMethod().DeclaringType?.FullName}.{x.GetMethod().Name}").Join(" <- ");
                }
            }
            catch (Exception e)
            {
                e.Log();
            }
            return "";
        }
    }
}
