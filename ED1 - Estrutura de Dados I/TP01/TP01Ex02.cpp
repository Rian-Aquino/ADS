#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <iomanip>

using namespace std;

int getElement(int number) {
	return number + 1;
}

string getNaipe(int number) {
	switch(number)	{
	case 1:
		return "Copas";
		break;
	case 2:
		return "Paus";
		break;
	case 3:
		return "Ouro";
		break;
	case 4:
		return "Espada";
		break;
	}
}

int main()
{
    cout << "Projeto Buraco" << endl;
    cout << " - embaralhamento automático" << endl << endl;
    
    bool ***baralhos;
    int i, j, k;
    
    baralhos = new bool**[2];
    for(i = 0; i < 2; i++) {
		baralhos[i] = new bool*[4];
		
		for(j = 0; j < 4; j++) {
			baralhos[i][j] = new bool[13];
			
			for(k = 0; k < 13; k++) {
				baralhos[i][j][k] = false;
				
				//cout << naipe << "-" << setfill('0') << setw(2) << carta << "-" << baralho << endl;
			}
		}
	}
	
	
	
	int jogador, carta;
	for (jogador = 0; jogador < 4; jogador++) {
		cout << " - Jogador N" << jogador + 1 << endl;
		
		for(carta = 0; carta < 11;  carta++) {
			int x, y, z;
			
			do { 
				x = rand() % ( 1 + 1 - 0) + 0;
				y = rand() % ( 3 + 1 - 0) + 0;
				z = rand() % ( 12 + 1 - 0) + 0;
			} while(baralhos[x][y][z]);
			
			baralhos[x][y][z] = true;
			
			int baralho = getElement(x);
			int naipe = getElement(y);
			int carta = getElement(z);
			
			cout << "    > (" << naipe << "-" << setfill('0') << setw(2) << carta << "-" << baralho << ")";
			cout << " " << setw(2) << carta << " de " << getNaipe(naipe) << ", baralho " << baralho << endl;
		}
		
		cout << endl;
	}
	
    
    return 0;       
}