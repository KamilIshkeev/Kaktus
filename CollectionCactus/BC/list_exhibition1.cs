//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollectionCactus.BC
{
    using System;
    using System.Collections.Generic;
    
    public partial class list_exhibition1
    {
        public int id_list_exhibition { get; set; }
        public Nullable<int> id_cactus { get; set; }
        public Nullable<int> id_exhibition { get; set; }
    
        public virtual Cactus Cactus { get; set; }
        public virtual Exhibition1 Exhibition1 { get; set; }
    }
}
