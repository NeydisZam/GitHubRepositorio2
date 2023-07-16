namespace JerarquiaEmpleados
{
    public class empleadoBaseComision:empleadoComision
    {
        private float salarioBase;
        public float Base
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public empleadoBaseComision(long id, string nomb, string ape, float ventas, float comision, float salbase)
        :base(id,nomb,ape,ventas,comision)
        {
            salarioBase=salbase;
        }
        public override float calcularSalario()
        {
            Salario=salarioBase+base.calcularSalario();
            return Salario;
        }
    }
}