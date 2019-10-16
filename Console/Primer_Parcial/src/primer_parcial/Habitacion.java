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
public class Habitacion {
     public double Area=0;
    public static double area(double ancho, double largo){
        double area;
        area =ancho*largo;
        BigDecimal bd = new BigDecimal(area);
          bd =bd.setScale(2, RoundingMode.HALF_UP);
         
        return area;
    }
    public double getArea(){
        return Area;
    }

    public void setArea(double Area) {
        this.Area = Area;
    }

    public Habitacion(double Area) {
        this.Area = Area;
    }
    
}
