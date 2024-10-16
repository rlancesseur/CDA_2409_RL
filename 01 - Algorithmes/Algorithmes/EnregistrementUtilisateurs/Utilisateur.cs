using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnregistrementUtilisateurs
{
    public class Utilisateur
    {
        // private Guid id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string? metier;
        private string? couleurPreferee;

        public Utilisateur(string _nomPrenom, string _dateDeNaissance)
        {
            string[] nomPrenomSepare = _nomPrenom.Split(" ");
            this.nom = nomPrenomSepare[0];
            this.prenom = nomPrenomSepare[1];

            if(!DateTime.TryParse(_dateDeNaissance, out dateDeNaissance))
            {
                throw new ArgumentException("Date invalide");
            }

            if(dateDeNaissance > DateTime.Now)
            {
                throw new ArgumentException("La date doit être dans le passé");
            }

        }

        public void SetMetier(string _valeur)
        {
            this.metier = _valeur;
        }

        public void SetCouleurPreferee(string _valeur)
        {
            this.couleurPreferee = _valeur;
        }

        public string GetNomComplet()
        {
            return prenom + " " + nom;
        }

        public string GetDateDeNaissance()
        {
            return dateDeNaissance.ToShortDateString();
        }

        public int GetAge()
        {
            TimeSpan intervalle;
            intervalle = DateTime.Now - dateDeNaissance;
            return (int)(intervalle.Days / 365.25);
        }

        public bool IsMajeur()
        {
            return this.GetAge() > 18;
        }

        public string? GetCouleurOuMetier()
        {
            if (this.IsMajeur())
            {
                return this.metier;
            }
            else
            {
                return this.couleurPreferee;
            }
        }

    }
}