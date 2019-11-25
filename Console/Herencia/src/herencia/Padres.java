
package herencia;
public class Padres{

    protected float estatura;
    protected String Nariz;
    protected String Manos;
    protected String colorPiel;
    protected String colorOjos;
    protected String colorCabello;

    public Padres() {//Estado inicial de los atributos
        estatura = 1.70f;
        Nariz = "griega";
        colorPiel = "clara";
        colorOjos = "cafe";
        colorCabello = "Lacio";
        Manos ="Pequeñas";
    }
    
    protected String inseguridad(){
        return "la inseguridad";
    }
    
    protected String puntualidad(){
        return "Obsesion por la puntualidad";
    }
    
    protected String ahorrador(){
        return "ser muy cuidadoso con el dinero";
    }
    
    protected String getManos(){
        return Manos;
    }
    public float getEstatura() {
        return estatura;
    }

    public String getNariz() {
        return Nariz;
    }

    public String getColorPiel() {
        return colorPiel;
    }

    public String getColorOjos() {
        return colorOjos;
    }

    public String getColorCabello() {
        return colorCabello;
    }

}
