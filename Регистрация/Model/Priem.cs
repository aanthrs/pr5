//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Регистрация.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Priem
    {
        public int ID_talona { get; set; }
        public Nullable<int> ID_pacienta { get; set; }
        public string FIO_pacienta { get; set; }
        public Nullable<System.DateTime> Data_priema { get; set; }
        public string FIO_sotrudnika { get; set; }
        public Nullable<int> ID_uslugi { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Uslugi Uslugi { get; set; }
    }
}
