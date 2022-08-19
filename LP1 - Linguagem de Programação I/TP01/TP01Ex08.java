/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex08;
import java.util.Scanner;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * 
 * Sabendo que uma milha marítima equivale a um mil, oitocentos e cinquenta e
dois metros e que um quilômetro possui mil metros, fazer um programa para
converter milhas marítimas em quilômetros.
 */
public class TP01Ex08 {

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]){
        System.out.println("Insira a quantidade de milhas marítmas que deseja converter quilômetros:");
        Scanner scan= new Scanner(System.in); // Pode ser reutilizado
        //Quando inteiro
        double milha = scan.nextInt();
        double km = milha * 1.852;

        System.out.println("A distancia em quilômetros é: " + km);
    }  
    
}
