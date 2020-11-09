using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes_bancaires
{
		[System.Serializable]
	public class Banque
	{
		private List<Compte> mesComptes;
		private List<TypeMvt> mesTypes;
		public Banque()
		{
			this.mesComptes = new List<Compte>();
			this.mesTypes = new List<TypeMvt>();
		}
		public List<Compte> getMesComptes()
		{
			return this.mesComptes;
		}
		public void ajouterType(string code, string libelle, char sens)
		{
			TypeMvt t;
			t = new TypeMvt(code, libelle, sens);
			this.mesTypes.Add(t);
		}
		public void ajouterType(TypeMvt t)
		{
			this.mesTypes.Add(t);
		}
		public void ajouterCompte(string num, string nom, double solde, double decouvert)
		{
			Compte c;
			c = new Compte(num, nom, solde, decouvert);
			this.mesComptes.Add(c);
		}
		public void ajouterCompte(Compte t)
		{
			this.mesComptes.Add(t);
		}
		//retourne un Compte en fonction de son numéro. La Fonction retourne null si le compte n'est pas trouvé.
		public Compte RendCompte(string numero)
		{
			foreach(Compte c in this.mesComptes)
			{
				if (c.getNumero() == numero)
					return c;
			}
			return null;
		}
		public TypeMvt getType(string codeType)
		{
			TypeMvt type = null;
			foreach (TypeMvt t in this.mesTypes)
				if (t.getCode() == codeType)
					return t;
			return type;

		}
	}
}
