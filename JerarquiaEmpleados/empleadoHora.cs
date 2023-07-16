namespace JerarquiaEmpleados
{
    public class empleadoHora:Empleado
    {
        private int horas;
	    private float pagoHora;
        public int Horas { 
            get {return horas;} 
            set {horas=value;} 
        }
        public float PagoHoras { 
            get
            {return pagoHora;} 
            set{
                pagoHora=value;
            }
        }
        public empleadoHora(long id, string nomb, string ape, int horas, float pgh)
        :base(id, nomb,ape)
        {
            this.horas=horas;
            this.pagoHora=pgh; 
        }
        public override float calcularSalario()
        {
            Salario=horas*pagoHora;
            return Salario;
        }
    }
}