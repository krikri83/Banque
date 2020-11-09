using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptes_bancaires
{
		[System.Serializable]
	public class Compte
	{
		private string numero;
		private string nom;
		private double solde;
		private double decouvertAutorise;
		private List<Mouvement> mesMouvements;

		public Compte()
		{
			this.numero = ""; this.nom = ""; this.solde = 0; ; this.decouvertAutorise = 0;
			this.mesMouvements = new List<Mouvement>();
		}
		public Compte(string numero, string nom, double solde, double decouvert)
		{
			this.numero = numero ; this.nom = nom; this.solde = solde; this.decouvertAutorise = decouvert;
			this.mesMouvements = new List<Mouvement>();
		}
		public string getNumero()
		{
			return this.numero;
		}
		public string getNom()
		{
			return this.nom;
		}
		public double getSolde()
		{
			return this.solde;
		}
		public double getDecouvertAutorise()
		{
			return this.decouvertAutorise;
		}
		public void crediter(double montant)
		{
			this.solde = this.solde + montant;
		}
		public bool debiter(double montant)
		{
			bool ok = true;
			double soldePossible = this.solde - montant;
			if (soldePossible > this.decouvertAutorise)
			{
				this.solde = this.solde - montant;
			}
			else
								ok = false;
			return ok;
		}
		//transférer un montant, du compte courant vers un autre compte; même remarque que pour le paragraphe précédent
		public bool transfer(double montant, Compte c)
		{
			bool ok = true;
			ok = this.debiter(montant);//je recupait le bool de debiter
			if (ok == true)
			{
				c.crediter(montant);
			
			}
			
			return ok;
		}
		//indiquer si le solde de l'objet courant est supérieur au solde d'un autre compte fourni, le résultat sera un booléen
		public bool soldSuperieur(Compte c)
		{
			bool ok = false;
			if(this.solde > c.solde)
			{
				ok = true;
			}
			return ok;
		}
		public override string ToString()
		{			
			string s = "Numéro : " + this.numero + " Nom : " + this.nom + " Solde est : " + this.solde +
				" Déouvert Autorise : " + this.decouvertAutorise;
			s = s + " \nMouvement : ";
			foreach (Mouvement  m in this.mesMouvements)
			{
				s = "\n" + s + m.ToString();
			}
			return s;
		}
		public bool ajouterMouvement(double montant, DateTime d, TypeMvt t)
		{
			bool ok = false;
			Mouvement m;
			if (t.getSens() == '-') // c'est un débit
				ok = this.debiter(montant);// ok reçoit true ou false selon si l'on peut débiter
			else
			{
				this.crediter(montant); //  on crédite dans tous les cas
				ok = true;
			}
			if (ok == true) // cas favorable, soit c'est un crédit soit un débit possible
			{
				m = new Mouvement(d, montant,t); // alors on crée un mvt
				this.mesMouvements.Add(m); // et on l'ajoute à liste des mvts
			}
			return ok;// dans tous les cas on retourne le bool indiquant si l'opération s'est bien passée
		}
	}
}
