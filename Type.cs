using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes_bancaires
{
		[System.Serializable]
	public class TypeMvt
	{
		private char sens;
		private string libelle;
		private string code;

		public TypeMvt(string code, string libelle, char sens)
		{
			this.code = code;
			this.libelle = libelle;
			this.sens = sens;
		}
		public string getCode()
		{
			return this.code;
		}
		public char getSens()
		{
			return this.sens;
		}
		public string getLibelle()
		{
			return this.libelle;
		}
	}
}
