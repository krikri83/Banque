using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes_bancaires
{
		[System.Serializable]
	public class Mouvement
	{
		private DateTime dateMvt;
		private Double montant;
		private TypeMvt leType;

		public Mouvement(DateTime dateMvt, Double montant, TypeMvt leType)
		{
			this.dateMvt = dateMvt;
			this.montant = montant;
			this.leType = leType;
		}
		public DateTime getDateMvt()
		{
			return this.dateMvt;
		}
		public Double getMontant()
		{
			return this.montant;
		}
		public TypeMvt getLeType()
		{
			return this.leType;
		}
		public override string ToString()
		{
			string s = "";
			s = "\n" + this.dateMvt.ToShortDateString() + ", " + this.montant + ", " + this.leType.getLibelle();
			return s;
		}
	}
}
