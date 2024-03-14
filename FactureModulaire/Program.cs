using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureModulaire
{
	class Program
	{
		public static void SaisieData(out string name, out int CV, out double d_Km) //procédure initialisation
		{
			Console.WriteLine("Donnez votre nom et votre prénom");
			name = Console.ReadLine();
			Console.WriteLine("donnez les chevaux fiscaux");
			CV = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Donnez la distance que vous avez parcouru en km");
			d_Km = double.Parse(Console.ReadLine());
		}
		public static double Calcul(double d_Km, int CV) //fonction if
		{
			double CalculMontant;
			if (CV <= 5)
			{//début du if
				if (d_Km <= 5000)
				{
					CalculMontant = d_Km * 0.543;
				}
				else
				{
					if (d_Km <= 20000)
					{
						CalculMontant = d_Km * 0.305 + 1188;
					}
					else
					{
						CalculMontant = d_Km * 0.364;
					} //fin premier CV
				}
			}
			else
			{
				if (CV == 6)
				{
					if (d_Km <= 5000)
					{
						CalculMontant = d_Km * 0.568;
					}
					else
					{
						if (d_Km <= 20000)
						{
							CalculMontant = d_Km * 0.32 + 1244;
						}
						else
						{
							CalculMontant = d_Km * 0.382;
						}
					}
				}//fin deuxième CV

				else
				{
					if (d_Km <= 5000)
					{
						CalculMontant = d_Km * 0.595;
					}
					else if (d_Km <= 20000)
					{
						CalculMontant = d_Km * 0.337 + 1288;
					}
					else
					{
						CalculMontant = d_Km * 0.401;
					}
				}//fin troisième CV
			}
			return CalculMontant;
		}
			//fin du if
		public static void AffichageResult(string name, int chevaux, double distance, double remboursement) //procédure affichage
		{
			Console.WriteLine("Monsieur ou Madame " + name + " a effectué " + distance + " kms en 2020 avec un véhicule de " + chevaux + " cv.");
			Console.WriteLine("Le montant des frais remboursés est de : " + remboursement + " euros.");
		}
		static void Main(string[] args) //Programme principal
		{
			string name;
			int chevaux;
			double distance, remboursement;
			SaisieData(out name, out chevaux, out distance);
			remboursement = Calcul(distance, chevaux);
			AffichageResult(name, chevaux, distance, remboursement);
			Console.ReadLine();
		}
	}
}