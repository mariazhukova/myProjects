using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class LessonItemViewModel
    {
        [HiddenInput()]
        public int ID { get; set; }
        [Description("Название Группы")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Указание группы обязательно")]
        public string Group { get; set; }

        [Description("Номер комнаты")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Указание комнаты обязательно")]
        public string Room { get; set; }

        [Description("Преподаватель")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Указание имени преаодавателя обязательно")]
        public string Trainer { get; set; }

        [Description("Домашнее задание")]
        [Required(AllowEmptyStrings = true)]
        [StringLength(250,ErrorMessage ="Превышено максимальое колличество символов")]
        public string HomeWork { get; set; }

        [Description("Дата занятия")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Указание даты обязательно")]
        public DateTime DateTime { get; set; }
    }
}