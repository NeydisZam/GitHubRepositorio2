namespace JerarquiaEmpleados
{
    /// <summary>
    /// Clase abstracta<c>Empleado<c>es la super clase
    /// para todos los tipos de empleados existentes
    /// </summary>
    public abstract class Empleado
    {
        private long inss;
        private string nombre;
        private string apellido;
        private float salario;
        /// <summary>
        /// El constructor de la superclase abstracta empleado
        /// </summary>
        /// <param name="id">Es número INNS</param>
        /// <param name="nomb">Nombre del empleado</param>
        /// <param name="ape">Apellido del empleado</param>
       public Empleado(long id, string nomb, string ape)
       {
           this.inss=id;
           this.nombre=nomb;
           this.apellido=ape;
           this.salario=0;
       }
       /// <summary>
       /// Propiedad pública que<c>establece el salario del <c>empleado
       /// </summary>
       /// <value>Salario del empleado</value>
       
        public float Salario
        {
           get { return salario; }
            set { salario = value; }
        }
        
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
        }
        
        public long Inss
        {
            get { return inss; }
            set { inss = value; }
        }
        public string MostrarInformacion( )
        {
            string Salida="";
		    Salida+=$"Inss   : {Inss}\n"
				+ $"Nombre :  {Nombre}\n"
				+ $"Salario:  {salario}\n";
		return  Salida;
        }
       
        public abstract  float calcularSalario();
    }
    
}