/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg2d;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Main {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int[][] arr2 = new int[6][6];
        int guardado = 0;
        for (int x = 0; x < 4; x++) {
            for (int y = 0; y < 4; y++) {
                arr2[x][y] = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] + arr[x + 1][y + 1] + arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
            }
        }
        guardado = arr2[0][0];
        for (int x = 0; x < 4; x++) {
            for (int y = 0; y < 4; y++) {
                System.out.println("este es mi guardado "+guardado+" este es mi matriz "+arr2[x][y]);
                if (guardado <arr2[x][y]) {
                    guardado= arr2[x][y];
                    System.out.println(guardado);
                }
            }
        }
        return guardado;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(("C:\\Users\\badop\\UNEDL2019B\\Console\\problemas\\problema\\respuesta.txt")));

        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            String[] arrRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowItems[j]);
                arr[i][j] = arrItem;
            }
        }

        int result = hourglassSum(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
