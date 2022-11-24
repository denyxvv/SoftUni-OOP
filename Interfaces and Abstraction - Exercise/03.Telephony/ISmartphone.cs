using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        void BrowseURL(string url);
    }
}
