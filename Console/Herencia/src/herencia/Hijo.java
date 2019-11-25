
package herencia;

public class Hijo extends Padres implements Habilidades{
public Hijo() {
        
    }
    

    public static void main(String[] args) {
        Hijo her = new Hijo();
        System.out.println("\n los Atributos que herede");
        System.out.println("yo herede de mi Padre el tipo de cabello: " + her.getColorCabello());
        System.out.println("yo herede de mi Madre el color de mis ojos: " + her.getColorOjos());
        System.out.println("yo herede de ambos la estatura: " + her.getEstatura() + " cm");
        System.out.println("yo herede de mi Padre el tipo de nariz: " + her.getNariz());
        System.out.println("yo herede de mi Madre el tipo de mano: " + her.getManos());
        System.out.println("\nlos Comportamientos que herede");
        System.out.println("Herede de mi padre: " + her.inseguridad());
        System.out.println("Herede de mi madre: " + her.ahorrador());
        System.out.println("Herede de ambos: " + her.puntualidad());
        System.out.println("\nlas Habilidades que aprendi por terceros");
        System.out.println(her.Programar());
        System.out.println(her.EntenderLasMatematicas());
    }

    public String Programar() {
        return "Aprendi a programar por un amigo en la prepa";
    }

    public String EntenderLasMatematicas() {
        return "Aprendi a enteder las matematicas por una maestra en el ceti";
    }
}
