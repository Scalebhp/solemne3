using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public int Adiccion(Aritmetica x)
	{
		return x.FactorA + x.FactorB;
	}

	public int Sustraccion (Aritmetica x)
	{
		return x.FactorA - x.FactorB;
	}

	public int Producto(Aritmetica x)
	{
		return x.FactorA * x.FactorB;
	}
	
	public int Division(Aritmetica x)
	{
		if (x.FactorB == 0) return 0;
		return x.FactorA / x.FactorB;
	}
}
