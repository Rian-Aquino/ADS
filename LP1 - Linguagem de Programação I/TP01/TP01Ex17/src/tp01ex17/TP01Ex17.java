/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex17;
import java.util.Scanner;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * 
 * Entrar via teclado com dois valores quaisquer “X” e “Y”. Calcular e exibir o
cálculo XY (“X” elevado a “Y”). Pesquisar as funções Exp e Ln.
 */
public class TP01Ex17 {
    public static void main(String[] args) {
        Scanner scan = new Scanner (System.in);
        
        System.out.println("Digite o valor de x:");
        double x = scan.nextDouble();
        System.out.println("Digite o valor de y:");
        double y = scan.nextDouble();
        
        //calculo
        int i;
        double res = x;
        for(i = 1; i < y; i++) {
            res = res * x;
        }
        System.out.println("O Valor de X elevado a Y é: " + res);
    }
    
}
