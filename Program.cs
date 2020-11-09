using System;
using System.Collections.Generic;
using System.IO;//pour creer un fiche
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;//pour serialisation un fiche
using System.Text;
using System.Threading.Tasks;

namespace Comptes_bancaires
{
	class Program
	{
		static void Main(string[] args)
		{
			Banque b = new Banque();
			//b.ajouterType("ch", "chèque débité ", '-');
			//b.ajouterType("pre", "prélèvement ", '-');
			//b.ajouterType("dab", "retrait en distributeur ", '-');
			//b.ajouterType("ret", "retrait guichet ", '-');
			//b.ajouterType("vir", "virement sur compte ", '+');
			//b.ajouterType("dch", "chèque déposé ", '+');
			//b.ajouterType("des", "dépôt d’espèce ", '+');

			//b.ajouterCompte("12345", "toto", 1000, -500);
			//b.ajouterCompte("45657", "titi", 2000, -1000);
			//b.ajouterCompte("12654", "tintin", 5000, -500);

			//Compte c;
			//c = b.RendCompte("45657");
			//c.ajouterMouvement(200, new DateTime(2018, 11, 23), b.getType("vir"));
			//c.ajouterMouvement(100, new DateTime(2018, 11, 24), b.getType("ret"));
			//c.ajouterMouvement(3500, new DateTime(2018, 11, 24), b.getType("ch"));
			//c.ajouterMouvement(500, new DateTime(2018, 11, 24), b.getType("vir"));

			//Console.WriteLine(c.ToString());

			//FileStream f = new FileStream("banque.rs", FileMode.Create); //il faut donne un nom et comment l'ouvrir. 
			//BinaryFormatter bi = new BinaryFormatter();//sterilizer un objec permettre de faire circuler un application entre utlisateur
			//bi.Serialize(f, b);//il a besion de un stream et un object.
			//f.Close();
			FileStream f = new FileStream("banque.rs", FileMode.Open);//Création d’un fichier
			BinaryFormatter bi = new BinaryFormatter();//Création d’un Formatter
			b = (Banque) bi.Deserialize(f);//Demande de sérialisation. Oberateur de case = (Banque), Il faut avoir, le deserialize a besoin de type de object Banque.
			Console.WriteLine(b.RendCompte("45657").ToString());
		}
	}
}
