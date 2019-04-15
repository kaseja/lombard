﻿using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Services
{
    public interface IItemService
    {
        void DeleteItem(Item item);
        Item GetItemById(int id);
        List<Item> GetItems();
    }
}