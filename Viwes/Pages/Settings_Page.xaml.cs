using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFSHOOL.Core;
using System.Text.Json;

namespace WPFSHOOL.Viwes.Pages
{
    /// <summary>
    /// Логика взаимодействия для Settings_Page.xaml
    /// </summary>
    public partial class Settings_Page : Page
    {
        JsonController jsonController = new JsonController();
        Json ObjectJson;

        ChangingLanguage changingLanguage = new ChangingLanguage();

        public Settings_Page()
        {
            InitializeComponent();

            ObjectJson = jsonController.JsonStart();

            if (ObjectJson.ResizeMode == true)
            {
                ResizeMode_CheckBox.IsChecked = true;
            }
            else if(ObjectJson.ResizeMode == false)
            {
                ResizeMode_CheckBox.IsChecked = false;
            }
        }

        private void home_Button_Click(object sender, RoutedEventArgs e)
        {
            NavArcCore.ChageFrame(new Home_Page());
        }



        //Смена языка
        private void Flag_UE_Button_Click(object sender, RoutedEventArgs e)
        {
            changingLanguage.UE();
            NavArcCore.ChageFrame(new Settings_Page());
        }

        private void Flag_RU_Button_Click(object sender, RoutedEventArgs e)
        {
            changingLanguage.RU();
            NavArcCore.ChageFrame(new Settings_Page());
        }
        //



        // Настройка ресайс мода
        private void ResizeMode_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ObjectJson.ResizeMode = true;
            jsonController.JsonSave(ObjectJson);
            NavArcCore.MainWindow.ResizeMode = ResizeMode.CanResizeWithGrip;
        }

        private void ResizeMode_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ObjectJson.ResizeMode = false;
            jsonController.JsonSave(ObjectJson);
            NavArcCore.MainWindow.ResizeMode = ResizeMode.NoResize;
        }
        //
    }
}
