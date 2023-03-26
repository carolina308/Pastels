namespace taller2;

public abstract class Monoplazaabs{
    public string nombreMono{get;set;}
    public bool onoff{get;set;}
    public bool move{get;set;}

     public string encender(){
        if(this.onoff == false & this.move == false){
        this.onoff = true;
        return "El vehiculo esta encendido";}
        return "Error";
    }
    public string apagar(){
        if(this.onoff == true & this.move == false){
            this.onoff = false;
            return "El vehiculo esta apagado";
        }
        return "Error";
        
    }
    public string detener(){
        if(this.onoff == true & this.move == true){
            this.onoff=false;
            this.move=false;
            return "El vehiculo se detuvo";
        }
        return "Error";
    }
    public string movimiento(){
        if(this.onoff == true & this.move == false){
            this.move = true;
            return "El vehiculo esta en movimiento";
        }
        return "Error";
    }

}