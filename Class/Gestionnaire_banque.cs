using System;
using System.Collections.Generic;


class Gestionnaire_banque{

  public string chaine_user;
  public string chaine_operation;

  public void addUser(Utilisateur utilisateur, BanqueEnLigne banqueLigne = null, BanquePhysique banquePhy = null){
    if(banqueLigne != null){
      banqueLigne.listeUtilisateurs.Add(utilisateur);
    }
    if(banquePhy != null){
      banquePhy.listeUtilisateurs.Add(utilisateur);
    }
    
  }

  public void addOparation(Utilisateur utilisateur, Operation_bancaire operationBancaire){
    utilisateur.operations.Add(operationBancaire);
    
  }

 
  public string affichageOperation(Utilisateur utilisateur){
    
    for (int i = 0; i <= utilisateur.operations.Count-1; i++)
    {
      chaine_operation += utilisateur.operations[i]; 
    }
    return chaine_operation;
  }
  
  public string affichageUtilisateur(BanqueEnLigne bankOnline = null, BanquePhysique bankPhysic = null){
    if(bankOnline != null){
      for (int i = 0; i <= bankOnline.listeUtilisateurs.Count-1; i++)
      {
        chaine_user += bankOnline.listeUtilisateurs[i]; 
      }
    return chaine_user;
    }
    
    if(bankPhysic != null){
      for (int i = 0; i <= bankPhysic.listeUtilisateurs.Count-1; i++)
      {
        chaine_user += bankPhysic.listeUtilisateurs[i]; 
      }
    return chaine_user; 
    }

  return "User not found";
  }
 
}