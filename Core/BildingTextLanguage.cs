using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFSHOOL.Core
{
    class BildingTextLanguage : INotifyPropertyChanged
    {
        JsonController jsonController = new JsonController();
        Json ObjectJson;

        public BildingTextLanguage()
        {
            ObjectJson = jsonController.JsonStart();

            // Инициализация текстовых свойств после создания ObjectJson

            _settingsText = ObjectJson.Stettings_Text; // Проверьте правильность написания "Stettings_Text"
            _homeText = ObjectJson.Home_Text; // Проверьте правильность написания "Home_Text"
            _resizeModeText = ObjectJson.ResizeMode_Text; // Проверьте правильность написания "Home_Text"
        }





        // настройки

        public string _settingsText;

        public string Settings_Text { get => _settingsText; set { _settingsText = value; OnPropertyChanged(nameof(Settings_Text)); } }

        // Главная

        public string _homeText;

        public string Home_Text { get => _homeText; set { _homeText = value; OnPropertyChanged(nameof(Home_Text)); } }


        //ResizeMode

        public string _resizeModeText;

        public string ResizeMode_Text { get => _resizeModeText; set { _resizeModeText = value; OnPropertyChanged(nameof(ResizeMode_Text)); } }











        //PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


/*
public string Home_Text
        {
            get => _homeText;
            set
            {
                _homeText = value;
                OnPropertyChanged(nameof(Home_Text));
            }
        }
*/