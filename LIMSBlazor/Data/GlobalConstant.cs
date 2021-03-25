using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class GlobalConstant
    {
        public const string DATE_FORMAT = "dd.MM.yyyy";
        public const string DATETIME_FORMAT = "dd.MM.yyyy HH:mm:ss";

        public enum SampleStatus : int
        {
            New = 1,
            Work = 2,
            Analize = 3,
            Wait = 4,
            Final = 5,
            Cancel = 6
        }

        //public static List<SelectListItem> SampleStatusModel = new List<SelectListItem> {
        //    new SelectListItem { Value = "1", Text = "Начало" },
        //    new SelectListItem { Value = "2", Text = "В работе" },
        //    new SelectListItem { Value = "3", Text = "Анализ" },
        //    new SelectListItem { Value = "4", Text = "Ожидание подтверждения" },
        //    new SelectListItem { Value = "5", Text = "Готов" },
        //    new SelectListItem { Value = "6", Text = "Отмена" }
        //};
        public static List<SelectListItem> SampleStatusModel = new List<SelectListItem> {
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.New).ToString(), Text = "Начало" },
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.Work).ToString(), Text = "В работе" },
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.Analize).ToString(), Text = "Анализ" },
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.Wait).ToString(), Text = "Ожидание подтверждения" },
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.Final).ToString(), Text = "Готов" },
            new SelectListItem { Value = Convert.ToInt32(SampleStatus.Cancel).ToString(), Text = "Отмена" }
        };

        public static List<SelectListItem> AttrTypeModel = new List<SelectListItem> {
            new SelectListItem { Value = "1", Text = "Число" },
            new SelectListItem { Value = "2", Text = "Строка" },
            new SelectListItem { Value = "3", Text = "Список" },
            new SelectListItem { Value = "4", Text = "Список SQL" },
            new SelectListItem { Value = "5", Text = "Логический" },
            new SelectListItem { Value = "6", Text = "Дата" },
            new SelectListItem { Value = "7", Text = "Дата и время" }
        };
    }
}
