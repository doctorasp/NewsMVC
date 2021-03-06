﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsBlog.Models
{
    public class Article
    {
        public int ID { get; set; }
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Display(Name = "Короткий огляд")]
        public string Description { get; set; }

        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        [Display(Name = "Контент")]
        public string Content { get; set; }

        public DateTime DateCreate { get; set; }

        public string CoverType { get; set; }

        [Display(Name = "Зображення")]
        public byte[] Cover { get; set; }

        public int ViewCount { get; set; }

        public virtual int CategoriesID { get; set; }

        [Display(Name = "Категорія")]
        public virtual Categories Categories { get; set; }

        public virtual string UserID { get; set; }
    }
}