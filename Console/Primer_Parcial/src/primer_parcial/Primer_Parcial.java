/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primer_parcial;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.Scanner;

/**
 *
 * @author badop
 */
public class Primer_Parcial {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Tapiz tapiz1 = new Tapiz();
        double area=0;
        Habitacion habitacion1 = new Habitacion(area);
        Calculadora calculadora1 = new Calculadora();
        double ancho=0,largo=0,costo=0;
        double r2=0;
        double rt=0;
        double pe=0;
        int decimal=0;
        String veri;
        Scanner tec = new Scanner(System.in);
        //Pedimos el valor del cual obtendremos la raiz
        String comprobacionRaiz;
        boolean a=false;
        int quitarDecimales = 0;
        do{
            System.out.print("dame el ancho de la base ");
            comprobacionRaiz = tec.next();
            
            for(int i=0;i<comprobacionRaiz.length();i++){
                if(comprobacionRaiz.charAt(i)<45 || comprobacionRaiz.charAt(i)>57 || comprobacionRaiz.charAt(i)==47){
                    a=true;
                    //System.out.println(comprobacionRaiz.charAt(i));
                    //if(comprobacionRaiz.charAt(i)==46){
                      //  quitarDecimales = comprobacionRaiz.length()-(i+1);
                    //}
                    break;
                    
                }
                 if(comprobacionRaiz.charAt(i)==46){
                        quitarDecimales = comprobacionRaiz.length()-(i+1);
                    }
            
                else{
                    a=false;
                    //System.out.println(comprobacionRaiz.charAt(i)); 
                }
            }
            //System.out.println(a);
        }while(a==true);
        ancho = Double.parseDouble(comprobacionRaiz);
        BigDecimal b1 = new BigDecimal(ancho);
        b1 = b1.setScale(quitarDecimales, RoundingMode.HALF_UP);
       
        do{
            System.out.print("dame el largo de la base ");
            comprobacionRaiz = tec.next();
            
            for(int i=0;i<comprobacionRaiz.length();i++){
                if(comprobacionRaiz.charAt(i)<45 || comprobacionRaiz.charAt(i)>57 || comprobacionRaiz.charAt(i)==47){
                    a=true;
                    //System.out.println(comprobacionRaiz.charAt(i));
                    //if(comprobacionRaiz.charAt(i)==46){
                      //  quitarDecimales = comprobacionRaiz.length()-(i+1);
                    //}
                    break;
                    
                }
                 if(comprobacionRaiz.charAt(i)==46){
                        quitarDecimales = comprobacionRaiz.length()-(i+1);
                    }
            
                else{
                    a=false;
                    //System.out.println(comprobacionRaiz.charAt(i)); 
                }
            }
            //System.out.println(a);
        }while(a==true);
        largo = Double.parseDouble(comprobacionRaiz);
        BigDecimal b2 = new BigDecimal(largo);
        b2 = b2.setScale(quitarDecimales, RoundingMode.HALF_UP);
        do{
            System.out.print("dame el costo ");
            comprobacionRaiz = tec.next();
            
            for(int i=0;i<comprobacionRaiz.length();i++){
                if(comprobacionRaiz.charAt(i)<45 || comprobacionRaiz.charAt(i)>57 || comprobacionRaiz.charAt(i)==47){
                    a=true;
                    //System.out.println(comprobacionRaiz.charAt(i));
                    //if(comprobacionRaiz.charAt(i)==46){
                      //  quitarDecimales = comprobacionRaiz.length()-(i+1);
                    //}
                    break;
                    
                }
                 if(comprobacionRaiz.charAt(i)==46){
                        quitarDecimales = comprobacionRaiz.length()-(i+1);
                    }
            
                else{
                    a=false;
                    //System.out.println(comprobacionRaiz.charAt(i)); 
                }
            }
            //System.out.println(a);
        }while(a==true);
        costo = Double.parseDouble(comprobacionRaiz);
        BigDecimal b3 = new BigDecimal(costo);
        b3 = b3.setScale(quitarDecimales, RoundingMode.HALF_UP);
        area=  habitacion1.getArea();
        habitacion1.setArea(habitacion1.area(ancho,largo));
        System.out.println("area total: "+habitacion1.getArea());
        tapiz1.setCost(costo);
        calculadora1.setCalcular(calculadora1.calculo(tapiz1.getCost(),habitacion1.getArea()));
        System.out.println("costo "+tapiz1.Cost);
        System.out.println("costo total "+calculadora1.getTotalCost());
        //habitacion1.Area=habitacion1.are;
    }

    
}
