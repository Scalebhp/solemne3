using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Compilation;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{
	int Adiccion(Aritmetica x);

	int Sustraccion(Aritmetica x);

	int Producto(Aritmetica x);

	int Division(Aritmetica x);
	// TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class Aritmetica
{
	private int factorA, factorB;
	
	public Aritmetica(int factorA, int factorB)
	{
		this.factorA = factorA;
		this.factorB = factorB;
	}

	public int FactorA
	{
		get
		{
			return factorA;
		}

		set
		{
			factorA = value;
		}
	}

	public int FactorB
	{
		get
		{
			return factorB;
		}

		set
		{
			factorB = value;
		}
	}

	public int Privacidad
	{
		get { return 0; }
	}

}
