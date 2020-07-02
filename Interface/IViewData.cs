using System.Collections.Generic;
using System;
namespace aspCore.WatchShop.Interface
{
    public interface IViewData
    {
        List<T> GetListViewData<T>();
        Object GetViewDetail();
    }
}