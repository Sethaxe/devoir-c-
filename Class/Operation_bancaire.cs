using System;
using System.Collections.Generic;

class Operation_bancaire{

  private string typeOperation;
  private string dateOperation;
  
  public string TypeOperation{
    get => typeOperation;
    set => typeOperation = value;
  }
  
  public string DateOperation{
    get => dateOperation;
    set => dateOperation = value;
  }

  public void Retrait(Utilisateur utilisateur, int montant){  
    if(utilisateur.Solde <= 0){
      throw new SoldeIsNegativeOrNullException("Vous ne pouvez pas faire de retrait car votre solde est negatif");
    }else{
      utilisateur.Solde -= montant;
    }
  
  }
  public void Crediter(Utilisateur utilisateur, int montant){
    utilisateur.Solde += montant;
  }

  public override string ToString(){
    return $"operation : {TypeOperation}, fait le {DateOperation}";
  }
}


public class SoldeIsNegativeOrNullException : Exception{
  public SoldeIsNegativeOrNullException(string message): base(message){
    
  }
}