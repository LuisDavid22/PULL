//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PULL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nomina_Detalle
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Nullable<double> SalarioCotizable { get; set; }
        public Nullable<double> AporteVoluntario { get; set; }
        public Nullable<double> ISR { get; set; }
        public Nullable<double> RemOtrosAgentes { get; set; }
        public Nullable<double> SaldoAFavor { get; set; }
        public Nullable<double> OtrasRemuneraciones { get; set; }
        public Nullable<double> SalarioINFOTEP { get; set; }
        public int IdNomina { get; set; }
    
        public virtual Nomina Nomina { get; set; }
    }
}
