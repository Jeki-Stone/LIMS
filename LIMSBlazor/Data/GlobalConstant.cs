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

        public static List<SelectListItem> SampleStatusModel = new List<SelectListItem> {
            new SelectListItem { Value = "1", Text = "Начало" },
            new SelectListItem { Value = "2", Text = "В работе" },
            new SelectListItem { Value = "3", Text = "Анализ" },
            new SelectListItem { Value = "4", Text = "Ожидание подтверждения" },
            new SelectListItem { Value = "5", Text = "Готов" },
            new SelectListItem { Value = "6", Text = "Отмена" }
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
