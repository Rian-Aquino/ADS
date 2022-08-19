/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp01ex14;
import java.util.Scanner;
import java.text.DecimalFormat;

/**
 *
 * @author
 * Diogo Santos Teixeira
 * Rian Gustavo Quintanilha de Aquino
 * 
 * Calcular e exibir o volume livre de um ambiente que contém uma esfera de raio
“r” inscrita em um cubo perfeito de aresta “a”. Os valores de “r “ e “a” serão
digitados.
 */
public class TP01Ex14 {

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]){
    //Texto
    System.out.println("Insira a aresta de um cubo perfeito");
    Scanner scan= new Scanner(System.in);
    DecimalFormat deci = new DecimalFormat();
    deci.setMaximumFractionDigits(2);
    int marc = 0;
    double a = scan.nextInt();

    System.out.println("Insira o raio de uma esfera");
    double r = scan.nextInt();
    
    
    double vcubo = a * a * a;
        

    //calculo volume
    double vesfera = (4 * Math.PI * Math.pow(r, 3))/3;

    //define formato decimal
    DecimalFormat frmt = new DecimalFormat();
    frmt.setMaximumFractionDigits(2);
            
   
    
    double vlivre = vcubo - vesfera;
 
 
    System.out.println("O volume livre é: " + deci.format(vlivre));
    }
}
