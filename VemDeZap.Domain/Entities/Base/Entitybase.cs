using prmToolkit.NotificationPattern;
using System;

namespace VemDeZap.Domain.Entities.Base
{
    public abstract class Entitybase : Notifiable
    {
        public Guid Id { get; set; }
        protected Entitybase()
        {
            Id = Guid.NewGuid();
        }
    }
}
