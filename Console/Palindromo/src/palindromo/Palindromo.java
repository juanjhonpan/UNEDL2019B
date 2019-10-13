/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package palindromo;

import java.util.Scanner;

/**
 *
 * @author badop
 */
public class Palindromo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        boolean sies=true;
        String frase1,frase2,frase1s="",frase2s="";
        Scanner tec = new Scanner(System.in);
        System.out.print("dame la primera frase  o palabra: ");
            frase1 = tec.nextLine();
            for(int i=0;i<frase1.length();i++){
                 if(frase1.charAt(i)==32){
                    }
                 else{
                frase1s+=frase1.charAt(i);
                    }
            }
                int a=frase1s.length();
                for(int i=0;i<frase1s.length();i++){
                    if(frase1s.charAt(i)==frase1s.charAt(a-1)){
                        a--;
                    }
                    else{
                        System.out.println("no es un palindromo");
                        sies=false;
                        break;
                    }
                }
                if(sies){
                    System.out.println("si es un palindromo");
                }
            }
    }
   
