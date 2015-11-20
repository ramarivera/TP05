﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ06
{
	/// <summary>
	/// Representa una cuenta, en pesos o dolares, la cual tiene un saldo
	/// </summary>
	public class Cuenta
	{
		/// <summary>
		/// Representa de qué moneda es la cuenta, si pesos o dolares
		/// </summary>
		private Moneda iMoneda;
		/// <summary>
		/// Reprenseta el saldo de la cuenta
		/// </summary>
		private double iSaldo;

		/// <summary>
		/// Propiedad Saldo, solo lectura
		/// </summary>
		public double Saldo
		{
			get { return this.iSaldo; }
			private set { this.iSaldo = value; }
		}

		/// <summary>
		/// Propiedad Moneda, solo lectura
		/// </summary>
		public Moneda Moneda
		{
			get { return this.iMoneda; }
			private set { this.iMoneda = value; }
		}

		/// <summary>
		/// Constructor de la clase
		/// </summary>
		/// <param name="pSaldoInicial">Saldo inicial de la cuenta</param>
		/// <param name="pMoneda">Tipo de moneda de la cuenta</param>
		public Cuenta(double pSaldoInicial, Moneda pMoneda)
		{
			this.Saldo = pSaldoInicial;
			this.Moneda = pMoneda;
		}

		/// <summary>
		/// Constructor de la clase. En este caso el saldo inicial es 0
		/// </summary>
		/// <param name="pMoneda">Tipo de moneda de la cuenta</param>
		public Cuenta(Moneda pMoneda) : this(0, pMoneda) { }

		/// <summary>
		/// Acredita en la cuenta el monto ingresado. 
		/// </summary>
		/// <param name="pSaldo">Monto a acreditar</param>
		public void AcreditarSaldo (double pSaldo )
		{
			if (pSaldo < 0)//Se agrega una excepcion en caso de que el monto a acreditar sea menor a $0
			{
				MontoNegativoException excepcion = new MontoNegativoException(pSaldo.ToString(),"El monto que se desea acreditar no es valido ya que es un valor negativo");
				throw excepcion;
			}
			unchecked
			{
				if (Saldo + pSaldo >= double.MaxValue) //Se agrega una excepcion en caso de que el nuevo saldo no sea soportado por la clase Double
				{
					DesbordamientoException lException = new DesbordamientoException("La suma del Monto actual y el monto a Acreditar es mayor que el valor maximo del tipo Double");
					throw lException;
				}
			}
			Saldo += pSaldo;
		}

		/// <summary>
		/// Debita de la cuenta el monto ingresado. 
		/// </summary>
		/// <param name="pSaldo">Monto de debitar</param>
		public void DebitarSaldo (double pSaldo )
		{
			if (pSaldo < 0) //Se agrega una excepcion en caso de que el monto a debitar sea menor a $0
			{
				MontoNegativoException excepcion = new MontoNegativoException(pSaldo.ToString(),"El monto que se desea debitar no es valido ya que es un valor negativo");
				throw excepcion;
			}
			if (Saldo < pSaldo) //Se agrega una excepcion en caso de que se desee debitar mas dinero que el disponible
			{
				SaldoInsuficienteException excepcion = new SaldoInsuficienteException("El monto que se desea debitar es mayor que el saldo disponible en la cuenta");
				throw excepcion;
			}
			Saldo -= pSaldo;
		}
	}
}
