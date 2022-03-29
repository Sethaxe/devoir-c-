using System;
using System.Collections;

public class Banque {
  private string nom_banque { get; set; }
  private string adresse { get; set; }
  private List<Utilisateur> listeUtilisateur = new List<Utilisateur>();

  public Banque(string n_b, string ad){
    nom_banque = n_b;
    adresse = ad;
  }
  
  public Banque(string n_b, string ad, ArrayList liste){
    nom_banque = n_b;
    adresse = ad;
    liste = listeUtilisateur;
  }
    
}
