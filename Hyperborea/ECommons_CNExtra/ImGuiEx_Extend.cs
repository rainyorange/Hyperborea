using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperborea.ECommons_CNExtra
{
    internal static class ImGuiEx_Extend
    {
        public static bool Ctrl => ImGui.GetIO().KeyCtrl;

        public static void HelpMarker(string helpText, Vector4? color = null, string symbolOverride = null) => InfoMarker(helpText, color, symbolOverride);

        public static void InfoMarker(string helpText, Vector4? color = null, string symbolOverride = null)
        {
            ImGui.SameLine();
            ImGui.PushFont(UiBuilder.IconFont);
            ImGuiEx.Text(color ?? ImGuiColors.DalamudGrey3, symbolOverride ?? FontAwesomeIcon.InfoCircle.ToIconString());
            ImGui.PopFont();
            if (ImGui.IsItemHovered())
            {
                ImGui.BeginTooltip();
                ImGui.PushTextWrapPos(ImGui.GetFontSize() * 35f);
                ImGui.TextUnformatted(helpText);
                ImGui.PopTextWrapPos();
                ImGui.EndTooltip();
            }
        }

        public static void SetNextItemWidthScaled(float width)
        {
            ImGui.SetNextItemWidth(width.Scale());
        }

        public static Vector2 CalcIconSize(FontAwesomeIcon icon, bool isButton = false)
        {
            return CalcIconSize(icon.ToIconString(), isButton);
        }

        public static Vector2 CalcIconSize(string icon, bool isButton = false)
        {
            ImGui.PushFont(UiBuilder.IconFont);
            var result = ImGui.CalcTextSize($"{icon}");
            ImGui.PopFont();
            return result + (isButton ? ImGui.GetStyle().FramePadding * 2f : Vector2.Zero);
        }
    }
}
