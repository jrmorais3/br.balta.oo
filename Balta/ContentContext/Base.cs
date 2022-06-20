using Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            var Id = new Guid();
        }

    }
}
