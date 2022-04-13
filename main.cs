using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {


    Gestionnaire_banque gestion = new Gestionnaire_banque();
    

    BanquePhysique uneBanquePhy = new BanquePhysique("La Poste", "3 avenue Jean jaurès");
    BanqueEnLigne uneBanqueLigne = new BanqueEnLigne("Boursorama", "https://www.boursorama.com/");
    

    List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
  
    for(int i=0; i<=0; i++){
      Utilisateur utilisateur = new Utilisateur();
      
      Console.WriteLine("Votre Nom:");
      utilisateur.LastName = Console.ReadLine();
      Console.WriteLine("Votre Prenom:");
      utilisateur.FirstName = Console.ReadLine();
      Console.WriteLine("Votre solde:");
      utilisateur.Solde = int.Parse(Console.ReadLine());
      
      listeUtilisateurs.Add(utilisateur);
    }

    Console.WriteLine(listeUtilisateurs[0].ToString() +"\n");
    gestion.addUser(listeUtilisateurs[0], banquePhy: uneBanquePhy);
    

    List<Operation_bancaire> operations = new List<Operation_bancaire>();

    for(int i=0; i<=3; i++){
      Operation_bancaire operation = new Operation_bancaire();

      Console.WriteLine("type operation");
      string typeOpe = Console.ReadLine();
      operation.TypeOperation = typeOpe;
      Console.WriteLine("date operation");
      operation.DateOperation = Console.ReadLine();

      if(typeOpe == "retrait"){
        operation.Retrait(listeUtilisateurs[0], 50);
      }
      else if(typeOpe == "credit"){
        operation.Crediter(listeUtilisateurs[0], 150);
      }
      
      operations.Add(operation);
    }
      
    for(int i = 0; i < operations.Count; i++){
      Console.WriteLine(operations[i]);
    }
      
    gestion.addOparation(listeUtilisateurs[0], operations[0]);
    Console.WriteLine(listeUtilisateurs[0]+"\n");
  
  }
}