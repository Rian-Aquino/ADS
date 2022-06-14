#include <iostream>

using namespace std;

#define MAX 30

//PilhaArray
struct PilhaArray {
	int qtde;
	float elementos[MAX];
};

PilhaArray* initArray() {
	PilhaArray *p = new PilhaArray;
	p->qtde = 0;
	return p;
};

int pushArray(PilhaArray *p, float v) {
	int podeEmpilhar = (p->qtde < MAX);
	if (podeEmpilhar) {
		p->elementos[p->qtde++] = v;
	}
	return podeEmpilhar;
}

void printArray(PilhaArray *p) {
	cout << endl << "Números Pares" << endl << endl;
	for(int i = p->qtde-1; i>=0; --i) {
		cout << p->elementos[i] << endl;
	}
	cout << "------" << endl;
}

//PilhaPonteiro
#include <iostream>
using namespace std;

struct No {
	float dado;
	No *prox;
};

struct PilhaPonteiro
{
	No *topo;
};

PilhaPonteiro* initPonteiro() {
	PilhaPonteiro *p = new PilhaPonteiro;
	p->topo = NULL;
	return p;
}

void pushPonteiro(PilhaPonteiro *p, float v) {
	No *no = new No;
	no->dado = v;
	no->prox = p->topo;
	p->topo = no;
}

void printPonteiro(PilhaPonteiro *p) {
	No *no;
	no = p->topo;
	cout << endl << "Números Ímpares" << endl << endl;
	while (no != NULL) {
		cout << no->dado << endl;
		no = no->prox;
	}
	cout << "------" << endl;
}

int main()
{
    setlocale(LC_ALL, "Portuguese");
    
    PilhaArray *par;
    par = initArray();
    
    PilhaPonteiro *impar;
    impar = initPonteiro();
    
    cout << "Digite uma sequência de 30 números, em ordem crescente:" << endl << endl;
    
    int i, aux;
    for(i = 0; i < MAX; i++) {
    	int num;
    	
		cout << i + 1 << "º Número: ";
		cin >> num;
		
		if (i > 0) {
			while(num <= aux) {
				cout << "X - O número precisa ser maior que o anterior, digite novamente: ";
				cin >> num;
			}
		}
		
		aux = num;
		
		if (num % 2 == 0) {
			pushArray(par, num);
		} else {
			pushPonteiro(impar, num);
		}
	}
	
    printArray(par);
    printPonteiro(impar);
    return 0;       
}