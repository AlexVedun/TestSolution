using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_SPA_App.Models
{
    // Модели, возвращенные действиями MeController.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}