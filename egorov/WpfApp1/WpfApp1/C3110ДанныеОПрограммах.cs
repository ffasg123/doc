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
    
    public partial class C3110ДанныеОПрограммах
    {
        public int id { get; set; }
        public string Наименование { get; set; }
        public int Количество { get; set; }
        public System.DateTime ДатаВыпуска { get; set; }
        public System.DateTime ДатаПоступленияНаФирму { get; set; }
        public int ФирмаПроизводитель { get; set; }
        public int Цена { get; set; }
        public int Клиентid { get; set; }
    
        public virtual C3110Клиенты C3110Клиенты { get; set; }
        public virtual C3110Поставщики C3110Поставщики { get; set; }
    }
}
