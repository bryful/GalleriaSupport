using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleriaVita
{
	public enum IN_MODE
	{
		NONE = -1,
		n0 = 0,
		n1,
		n2,
		n3,
		n4,
		n5,
		n6,
		n7,
		n8,
		n9,
		nA,
		nB,
		nC,
		nD,
		nE,
		nF,
		nP1,
		nP10,
		nM1,
		nM10,
		nCL,
		nBS,
		COUNT
	}
	public class Hex_input_def
	{
		public static string[] Cap = new string[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"A",
			"B",
			"C",
			"D",
			"E",
			"F",
			"+1",
			"+10",
			"-1",
			"-10",
			"CL",
			"BS"
		};
	}
}
