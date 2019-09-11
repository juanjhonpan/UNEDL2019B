/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recorridomatriz;

/**
 *
 * @author badop
 */
public class RecorridoMatriz {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int[][] Matriznew ={{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
        // TODO code application logic here
        for(int i=0;i< Matriznew.length ;i++){
           for(int j=0;j< Matriznew.length ;j++){
            if((i%2)==0){
                System.out.print("dw"+Matriznew[j][i]);
            }
            else{
                System.out.print(
                "up" + Matriznew[Matriznew.length-j-1][i]);
            }
        }  
        }
    }
    
}
