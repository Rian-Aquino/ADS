/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex04;
import java.util.Scanner;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * 
 * A partir dos valores da base e altura de um triângulo, calcular e exibir sua área.
 */
public class TP01Ex04 {

    public static void main(String args[]){
        
        System.out.println("Insira o valor da base de um triangulo:");
        Scanner scan= new Scanner(System.in); // Pode ser reutilizado
        //Quando inteiro
        float base = scan.nextInt();
        System.out.println("Insira o valor da altura de um triangulo:");
        float altura = scan.nextInt();
        float area = base * altura / 2;
        System.out.println("A area do triangulo é: " + area);
    
    }
}
