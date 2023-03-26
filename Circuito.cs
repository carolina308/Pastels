namespace taller2;
public class circuito: Monoplazaabs{
    public bool libre = true;
    public int vueltas = 3;
    
        Random r = new Random(r.next(100000,999999));  
    public bool agregar(){
         if(libre==true){
            return libre = false;
         }else{
            return true;
         }
    }

     public void sacar(){
         if(libre==false){
             libre = true;
         }
    }

     public string prueba(List a, string Carro_evaluar){
        //if(libre = false){
        //    return "Monoplaza ocupada";
          //  break;}

          if(agregar() == false){
          }
            for(int i = 0; i < a.Count; i++){     
                int menorT = 999999;
                int Tiempo = 0;
                string carro = a[i];
                //if(Carro_evaluar == carro){
                    a[i].onoff = true;
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++                    
                 for(int j = 0; i < vueltas; j++){       
                    a[i].move = true;                            
                    Tiempo = r;
                    Console.WriteLine("El tiempo de la vuelta:" + Tiempo);
                    if (menorT < Tiempo){
                        menorT = Tiempo;                     
                    }                                         
                }
                Console.WriteLine("La monoplaza" + carro + " hizo su mejor tiempo en:" + menorT + " segundos");
                a[i].move = false;
                a[i].onoff = false;
                //} termina el ciclo
                sacar();
            }
        return " ";
    }

}