using autofac.Managers;
using autofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace autofac.ViewModels
{
    public enum MyEnum
    {
        Default,
        Other
    }

    public class MyViewModel
    {
        public MyViewModel(INavigationService service, ResourceLoader loader, HttpMessageHandler handler,
            AccountManager accountManager, ISettingsManager settingsManager, IConverter converter,
            Func<DateTime, MyEnum, SubViewModel> itemFactory, MyEnum value = MyEnum.Default)
        {

        }
    }
}
