using System;
using System.Collections.Generic;

class BanquePhysique{

  public List<Utilisateur> listeUtilisateurs = new List<Utilisateur>(); 

  private string nom_banque;
  private string adresse;

    public string Nom_banque{
    get => nom_banque;
    set => nom_banque = value;
  }
  public string Adresse{
    get => adresse; 
    set => adresse = value;
  }

  public BanquePhysique(String name, string adresse){
    this.nom_banque = name;
    this.adresse = adresse;
  }


  
  public override string ToString(){
    var chaine = "Banque Physique : /n";
      chaine += "nom : " + nom_banque + " /n";
      chaine += "adresse : " + adresse + " /n";

    return chaine;
  }
}