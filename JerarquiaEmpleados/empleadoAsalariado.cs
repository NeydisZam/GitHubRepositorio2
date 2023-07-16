namespace JerarquiaEmpleados
{
    public class empleadoAsalariado:Empleado
    {
        public empleadoAsalariado(long id, string nomb, string ape, float salario)
        :base(id,nomb,ape)
        {
            this.Salario=salario;
        }
        public override float calcularSalario()
        {
           return Salario;
        }
    }
    
}