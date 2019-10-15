/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package matrizcuadrada;

import java.util.Scanner;

/**
 *
 * @author badop
 */
public class Matrizcuadrada {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner tec = new Scanner(System.in);
        int mat=0;
        // TODO code application logic here
        System.out.println("dame el tamaño de tu matriz");
        mat = tec.nextInt();
        int matriz[][];
         matriz = new int[mat][mat];
         int suma=0;
        int resta=0;
        int total=0;
        int m=mat;
        for(int x=0;x<mat;x++){
            for(int z=0;z<mat;z++){
                System.out.println("dame el valor de la posicion ["+x+"] ["+z+"]");
                matriz[x][z] = tec.nextInt();
            }
        }
        //int tamaño=0;
    //Scanner tec = new Scanner(System.in);
      //  System.out.println("dame el tamaño de la matriz");
        //tamaño = tec.nextInt();
        //matriz=new float[tamaño][tamaño];
        for(int x=0;x<mat;x++){
            for(int z=0;z<mat;z++){
                if(x==z){
                    suma = suma + matriz[x][z];
                }
                 if(z==(m-1)){
                    resta= resta+matriz[x][z];
                    m=m-1;
                }
            }
        }
         total=(suma-resta);  
        if(total<0){
          total=total*-1;  
        }
        System.out.println("es el total: "+total);
    }
    
}
