/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primer_parcial;

import java.math.BigDecimal;
import java.math.RoundingMode;

/**
 *
 * @author badop
 */
public class Calculadora {
    public double Calcular=0;
    public static double calculo(double area, double costo){
        double total;
        total =area*costo;
        BigDecimal bd = new BigDecimal(area);
          bd =bd.setScale(2, RoundingMode.HALF_UP);
         
        return total;
    }
    public double getTotalCost(){
        return Calcular;
    }

    public void setCalcular(double Calcular) {
        this.Calcular = Calcular;
    }
    public Calculadora() {
    }
    
}
