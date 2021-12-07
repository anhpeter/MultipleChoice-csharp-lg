using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Interfaces
{
    public interface IPagination
    {
        int count();
        void onPage();
    }
}
