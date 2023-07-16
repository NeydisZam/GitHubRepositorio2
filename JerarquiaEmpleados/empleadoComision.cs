namespace JerarquiaEmpleados
{
    public class empleadoComision:Empleado
    {
        private float ventas;
        private float comision;
        public empleadoComision(long id, string nomb, string ape, float ventas, float comision)
        :base(id, nomb,ape)
        {
            this.ventas=ventas;
            this.comision=comision;
        }
        public float Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        
        public float Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }
        public override float calcularSalario()
        {
            Salario=ventas*comision;
            return Salario;
        }
    }
}