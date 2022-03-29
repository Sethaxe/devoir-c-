using System;
using System.Collections;

public class Operation_bancaire {
  private string type_operation { get; set; }
  private string date_operation { get; set; }

  public Operation_bancaire(string t_o, string d_o){
    type_opration = t_o ;
    date_operation = d_o;

  }

  public string Type_operation
  {
      get { return type_operation; }
      set { type_operation = value; }
  }
  
   public void Crediter()
  {  

  }
  public void Retrait()
  { 
      
  }
  //public Afficher(){}

  //public HistoriqueOpe(){}

  public override string ToString(){
    var chaine = "Operation Bancaire /n";
      chaine += "Type : " + type_operation + " /n";
      chaine += "Date : " + date_operation + " /n";

    return chaine;
  }
    
}