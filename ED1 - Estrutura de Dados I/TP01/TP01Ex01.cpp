#include <iostream>
#include <stdlib.h>
#include <iomanip>
using namespace std;

#define TOTAL_LIN 15
#define TOTAL_COL 40

int menu() {
	int opt;
	
	cout << endl;
	
	cout << " +-------- Menu --------+" << endl;
	cout << " |                      |" << endl;
	cout << " | 1. Reservar Poltrona |" << endl;
	cout << " | 2. Mapa de ocupação  |" << endl;
	cout << " | 3. Faturamento       |" << endl;
	cout << " | 0. Finalizar         |" << endl;
	cout << " |                      |" << endl;
	cout << " +----------------------+" << endl;
	
	cout << endl << " - Selecione: ";
	
	cin >> opt;
	return opt;
}

bool validarCord(int x, int y) {
		bool isXValid = x >= 0 && x < 15;
		bool isYValid = y >= 0 && y < 40;
		
		if(!isXValid) {
			cout << endl << "A fileira deve estar entre 1 e 15" << endl << endl;
			return false;
		}
		
		if(!isYValid) {
			cout << endl << "A poltrona deve estar entre 1 e 40" << endl << endl;
			return false;
		}
		
		return true;
	}

void reservarPoltrona(bool **map) {
	cout << " > Reservar Poltrona" << endl << endl;
	
	int lin, col;
	
	do {	
		cout << " ^ Fileira (Entre 1 e 15): ";
		cin >> lin;
		
		cout << " ^ Poltrona (Entre 1 e 40: ";
		cin >> col;
		
		lin--;
		col--;
	} while(!validarCord(lin, col));
	
	if(!map[lin][col]) {
		map[lin][col] = true;
		cout << endl << " = Poltrona Nº " << col + 1 << " da fileira " << lin + 1 << " reservada com sucesso!";
	} else {
		cout << endl << " = Esta poltrona ja está reservada! Tente com uma vazia.";
	}
	
	
}

void mapaOcupacao(bool **map) {
	cout << endl << " > Mapa de Ocupação" << endl << endl;
	
	int i, j;
	
	for(i = 0; i < TOTAL_LIN; ++i) {
		for(j = 0; j < TOTAL_COL; ++j) {
			if(map[i][j]) {
				cout << " #";
			} else {
				cout << " .";
			}
			
		}
		
		cout << endl;
	}
}

void faturamento(bool **map) {
	cout << " > Faturamento" << endl << endl;
	
	
	int i, j;
	int poltronasOcupadas = 0;
	float totalBilheteria = 0.0;
	
	for(i = 0; i < TOTAL_LIN; ++i) {
		for(j = 0; j < TOTAL_COL; ++j) {
			if(map[i][j]) {
				poltronasOcupadas++;
				if(i < 5) {
					totalBilheteria += 50.0;
				} else if(i < 10) {
					totalBilheteria += 30.0;
				} else {
					totalBilheteria += 15.0;
				}
			} 
			
		}
	}
	
	cout << " = Poltronas ocupadas: " << poltronasOcupadas << endl;
	cout << " = Valor da bilheteria: R$" << totalBilheteria << ",00";
}

void finalizar(bool **map) {
	cout << " > Finalizar" << endl;
}



int main(int argc, char** argv) {
	setlocale(LC_ALL, "");
	
	int i;
	int j;
	
	bool **map;
	map = new bool*[15];
	
	for(i = 0; i < TOTAL_LIN; ++i) {
		map[i] = new bool[TOTAL_COL];
		
		for(j = 0; j < TOTAL_COL; ++j) {
			map[i][j] = false;
		}
	}
	
	int opt;
	
	do {
		opt = menu();
		cout << endl;
		
		switch(opt) {
			case 1:
				reservarPoltrona(map);
				break;
			case 2:
				mapaOcupacao(map);
				break;
			case 3:
				faturamento(map);
				break;
			case 0:
				finalizar(map);
				break;
			default:
				cout << "Esse comando não existe!";
		}
		
		cout << endl;
		cout << "_____________________________________________________" << endl << endl;
		
		//system("PAUSE");
		
	} while(opt != 0);
	
	return 0;
}