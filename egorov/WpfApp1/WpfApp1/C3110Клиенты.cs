//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class C3110Клиенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C3110Клиенты()
        {
            this.C3110ДанныеОПрограммах = new HashSet<C3110ДанныеОПрограммах>();
        }
    
        public int id { get; set; }
        public string НазваниеФирмы { get; set; }
        public string ЮридическийАдрес { get; set; }
        public int Телефон { get; set; }
        public int НомерСчета { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C3110ДанныеОПрограммах> C3110ДанныеОПрограммах { get; set; }
        public virtual C3110Сотрудники C3110Сотрудники { get; set; }
    }
}
