/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex06;
import java.util.Scanner;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * 
 * Calcular e exibir a média aritmética de quatro valores quaisquer que serão
digitados.
 */
public class TP01Ex06 {

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]){
        System.out.println("Insira 4 valores da sua escolha:");
        Scanner scan= new Scanner(System.in);
        float val1 = scan.nextInt();
        float val2 = scan.nextInt();
        float val3 = scan.nextInt();
        float val4 = scan.nextInt();
        float media = (val1 + val2 + val3 + val4) / 4;
        System.out.println("A media aritmética: " + media);
    }  
    
}
