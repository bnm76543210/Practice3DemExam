//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice3Task
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdditionalImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int ServiceId { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
