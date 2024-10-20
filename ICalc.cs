﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5
{
	public interface ICalc
	{
		event EventHandler<EventArgs> GotResult;
		// int Sum(int value);
		void Sum(int value);
		// int Subtract(int value);
		void Subtract(int value);
		// int Multiply(int value);
		void Multiply(int value);
		// int Divide(int value);
		void Divide(int value);
		void CancelLast();
	}
}
