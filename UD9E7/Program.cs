using System;

namespace UD9E7
{
	using System;

	public class Persona
	{
		private const char sexoDefecto = 'H';

		private string nombre;
		private int edad;
		private string DNI;
		private char sexo;
		private double peso;
		private double altura;

		public Persona() : this("", 0, sexoDefecto, 0, 0)
		{

		}

		public Persona(string nombre, int edad, char sexo) : this(nombre, edad, sexo, 0, 0)
		{
		}

		public Persona(string nombre, int edad, char sexo, double peso, double altura)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.peso = peso;
			this.altura = altura;
			this.sexo = sexo;
		}


		public virtual string Nombre
		{
			set
			{
				this.nombre = value;
			}
		}

		public virtual int Edad
		{
			set
			{
				this.edad = value;
			}
		}

		public virtual char Sexo
		{
			set
			{
				this.sexo = value;
			}
		}

		public virtual double Peso
		{
			set
			{
				this.peso = value;
			}
		}


		public virtual double Altura
		{
			set
			{
				this.altura = value;
			}
		}

		public void Mostrar()
		{
			Console.WriteLine("Nombre:" + nombre);
			Console.WriteLine("Sexo: " + sexo);
			Console.WriteLine("Edad: " + edad);
			Console.WriteLine("DNI: " + DNI);
			Console.WriteLine("Peso: " + peso + " kg");
			Console.WriteLine("Altura: " + altura + " metros");
		}
		static void Main(string[] args)
		{
			Persona persona1 = new Persona();
			persona1.Mostrar();
			Console.ReadKey();
		}
	}

}

	

