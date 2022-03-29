using System;
using System.Collections;

public class Utilisateur {
  private string nom { get; set; }
  private string prenom { get; set; }
  private int solde { get; set; }
  private List<Operation_bancaire> desOperations = new List<Operation_bancaire>();

  public Utilisateur(string n, string p, int s){
    nom = n;
    prenom = p;
    solde = s;
  }
  
  public Utilisateur(string n, string p, int s, ArrayList desOp){
    nom = n; { get; set; }
    prenom = p; { get; set; }
    solde = s; { get; set; }
    desOperations = desOp;
  }

  public override string ToString(){
    var chaine = "Utilisateur /n";
      chaine += "nom : " + nom + " /n";
      chaine += "prenom : " + prenom + " /n";
      chaine += "solde : " + solde + " /n";

    return chaine;
  }
}