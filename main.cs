using System;
using System.Collections;


class Program {
  public static void Main (string[] args) {

    var utilisateur1 = new Utilisateur("PUISSANT", "Thomas", 435786135);
    var utilisateur2 = new Utilisateur("BESNARD", "Adrien", 4561237);
    var utilisateur3 = new Utilisateur("CHHIM", "Shenda", 1);

    var banque1 = new Banque("La-Poste", "Av. de la Libération, 77350 Le Mée-sur-Seine");

    var banque2 = new Banque("BNP-PAribas", "1 Rue Saint-Etienne, 77000 Melun");

    
    banque1.inscription(utilisateur1);
    banque1.inscription(utilisateur2);
    banque1.inscription(utilisateur3);

    

    
  }
}






