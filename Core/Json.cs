using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace WPFSHOOL.Core
{
    class Json
    {
        public bool ResizeMode { get; set; } = false;
        public short Width { get; set; } = 800;
        public short Height { get; set; } = 450;

        // Языковые параметры

        public string Home_Text { get; set; } = "Главная";
        public string Stettings_Text { get; set; } = "Настройки";
        public string ResizeMode_Text { get; set; } = "Масштабирование окна";
    }
}