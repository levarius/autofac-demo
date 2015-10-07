using autofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autofac.ViewModels
{
    public class SubViewModel
    {
        private readonly INavigationService m_navigationService;

        public DateTime Date { get; }

        public MyEnum Enum { get; }

        public SubViewModel(DateTime date, MyEnum myEnum, INavigationService navigationService)
        {
            Date = date;
            Enum = myEnum;
            m_navigationService = navigationService;
        }
    }
}
