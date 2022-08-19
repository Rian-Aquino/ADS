/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex16;
import java.util.Scanner;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * Entrar via teclado com o valor de um ângulo em graus, calcular e exibir as
seguintes funções trigonométricas: seno, cosseno, tangente e secante deste ângulo.
Lembre-se que uma função trigonométrica trabalha em radianos.
 */
public class TP01Ex16 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Insira a ângulo em graus: ");
        Scanner scan= new Scanner(System.in);
        double angulo = scan.nextDouble();
        double radiano = Math.toRadians(angulo);
        double secante = 1/Math.cos(radiano);


        System.out.println("\n O seno do ângulo é: " + Math.sin(radiano)); 
        System.out.println("\n O cosseno do ângulo é: " + Math.cos(radiano)); 
        System.out.println("\n O tangente do ângulo é: " + Math.tan(radiano)); 
        System.out.println("\n O secante do ângulo é: " + secante);
    }
}
