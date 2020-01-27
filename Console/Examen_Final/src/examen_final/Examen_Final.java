/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package examen_final;

import java.util.Scanner;

/**
 *
 * @author badop
 */
public class Examen_Final {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner tec = new Scanner(System.in);
        int Dinero=0,resultado=0;
        // TODO code application logic here
        System.out.println("dame la cantidad de dinero");
        Dinero = tec.nextInt();
        int matriz[] = {1,12,5,111,200,1000,10};
            for(int z=0;z<matriz.length;z++){
                if(Dinero>matriz[z]){
                    resultado++;
                }
            }
             System.out.println("este es la cantidad maxima de elementos que puede comprar: "+resultado);
    }
    }
