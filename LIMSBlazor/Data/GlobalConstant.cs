using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class GlobalConstant
    {
        public static List<SelectListItem> SampleStatusModel = new List<SelectListItem> {
            new SelectListItem { Value = "1", Text = "Начало" },
            new SelectListItem { Value = "2", Text = "В работе" },
            new SelectListItem { Value = "3", Text = "Ожидание подтверждения" },
            new SelectListItem { Value = "4", Text = "Готов" },
            new SelectListItem { Value = "5", Text = "Отмена" }
        };

        public static List<SelectListItem> AttrTypeModel = new List<SelectListItem> {
            new SelectListItem { Value = "1", Text = "Число" },
            new SelectListItem { Value = "2", Text = "Строка" },
            new SelectListItem { Value = "3", Text = "Список" },
            new SelectListItem { Value = "4", Text = "Логический" },
            new SelectListItem { Value = "5", Text = "Дата" },
            new SelectListItem { Value = "6", Text = "Дата и время" }
        };
    }
}
