/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package problema;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<Integer>> arr) {
     // float matriz [][];
        int suma=0;
        int resta=0;
        int total=0;
        int m=arr.size();
        //int tamaño=0;
    //Scanner tec = new Scanner(System.in);
      //  System.out.println("dame el tamaño de la matriz");
        //tamaño = tec.nextInt();
        //matriz=new float[tamaño][tamaño];
        for(int x=0;x<arr.size();x++){
            for(int z=0;z<arr.size();z++){
                if(x==z){
                    suma = suma + arr.get(x).get(z);
                }
                 if(z==(m-1)){
                    resta= resta+arr.get(x).get(z);
                    m=m-1;
                }
            }
        }
         total=(suma-resta);  
        if(total<0){
          total=total*-1;  
        }
return total;
    }

}

public class Problema {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(("C:\\Users\\badop\\UNEDL2019B\\Console\\problemas\\problema\\respuesta.txt")));

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<List<Integer>> arr = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

            List<Integer> arrRowItems = new ArrayList<>();

            for (int j = 0; j < n; j++) {
                int arrItem = Integer.parseInt(arrRowTempItems[j]);
                arrRowItems.add(arrItem);
            }

            arr.add(arrRowItems);
        }

        int result = Result.diagonalDifference(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
