using System;
using System.Collections.Generic;
namespace PhoneService
{
    public interface IRingable
    {
        string Ring();
        string Unlock();
    }
}