//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hospital
    {
        public Hospital()
        {
            this.Admins = new HashSet<Admin>();
            this.DOCTORS_1 = new HashSet<DOCTORS_1>();
            this.Engineer_1 = new HashSet<Engineer_1>();
            this.Laboratories = new HashSet<Laboratory>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Nullable<int> C__of_workers { get; set; }
    
        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<DOCTORS_1> DOCTORS_1 { get; set; }
        public virtual ICollection<Engineer_1> Engineer_1 { get; set; }
        public virtual ICollection<Laboratory> Laboratories { get; set; }
    }
}
