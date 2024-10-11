using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSHOOL.Core
{
    class ChangingLanguage
    {
        private BildingTextLanguage bildingTextLanguage = new BildingTextLanguage();
        private JsonController jsonController = new JsonController();
        private Json ObjectJson;

        public ChangingLanguage() 
        {
            ObjectJson = jsonController.JsonStart();
        }

        public void Language(int i) 
        {
            switch (i)
            {
                case 1:
                    RU();
                    break;
                case 2:
                    UE();
                    break;
            }
        }

        public void RU()
        {
            ObjectJson.Home_Text = "Главная";
            ObjectJson.Stettings_Text = "Настройки";
            ObjectJson.ResizeMode_Text = "Масштабирование окна";
            jsonController.JsonSave(ObjectJson);


            bildingTextLanguage._homeText = ObjectJson.Home_Text;
            bildingTextLanguage._settingsText = ObjectJson.Stettings_Text;
            bildingTextLanguage.ResizeMode_Text = ObjectJson.ResizeMode_Text;
        }

        public void UE() 
        {
            ObjectJson.Home_Text = "Home";
            ObjectJson.Stettings_Text = "Settings";
            ObjectJson.ResizeMode_Text = "Scaling the window";
            jsonController.JsonSave(ObjectJson);

            bildingTextLanguage._homeText = ObjectJson.Home_Text;
            bildingTextLanguage._settingsText = ObjectJson.Stettings_Text;
            bildingTextLanguage.ResizeMode_Text = ObjectJson.ResizeMode_Text;
        }
    }
}
