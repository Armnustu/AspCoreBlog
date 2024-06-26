﻿using DataEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INotificationService
    {

        void NoticationAdd(Notification  notification);
        void NotificationDelete(Notification notification);
        void NotificationUpdate(Notification notification);
        List<Notification> GetList();
    }
}
