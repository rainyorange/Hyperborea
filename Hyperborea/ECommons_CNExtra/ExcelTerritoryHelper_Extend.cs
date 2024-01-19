using Lumina.Excel.GeneratedSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperborea.ECommons_CNExtra
{
    public static class ExcelTerritoryHelper_Extend
    {
        public static bool NameExists(uint TerritoryType)
        {
            var data = Svc.Data.GetExcelSheet<TerritoryType>().GetRow(TerritoryType);
            if (data != null) return NameExists(data);
            return false;
        }

        public static bool NameExists(this TerritoryType t)
        {
            var nonExists = t.Name.ExtractText().IsNullOrEmpty() && t.ContentFinderCondition?.Value.Name.ExtractText().IsNullOrEmpty() != false;
            return !nonExists;
        }

        public static TerritoryType Get(uint ID) => Svc.Data.GetExcelSheet<TerritoryType>().GetRow(ID);
        public static string GetBG(this TerritoryType t) => t?.Bg?.ExtractText();
        public static string GetBG(uint ID) => Get(ID)?.Bg?.ExtractText();
    }
}
