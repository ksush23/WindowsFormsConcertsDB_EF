//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConcertsDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets
    {
        public int Ticket_ID { get; set; }
        public int Ticket_State_ID { get; set; }
        public Nullable<int> Ticket_Concert_ID { get; set; }
        public Nullable<int> Ticket_Seat_ID { get; set; }
        public Nullable<decimal> Ticket_Price { get; set; }
    
        public virtual Concerts Concerts { get; set; }
        public virtual Seats Seats { get; set; }
        public virtual Ticket_States Ticket_States { get; set; }
    }
}
