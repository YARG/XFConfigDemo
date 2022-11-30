using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppConfig.Interfaces;
using Xamarin.Forms;

namespace AppConfig
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Code behind .. it's only a demo
            IConfigurationService configService = DependencyService.Get<IConfigurationService>();
            lblEnvironment.Text = configService.GetEnvironment();

        }
    }
}

