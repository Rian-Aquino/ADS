#include <iostream>
#include <locale.h> 

using namespace std;

struct No {
	int dado;
	No *prox;
};

struct Fila {
	No *ini;
	No *fim; 
};

Fila* init() {
	Fila *f = new Fila;
	f->ini = NULL;
	f->fim = NULL;
	return f;
}

int isEmpty(Fila *f) {
	return (f->ini == NULL);
}

int count(Fila *f) {
	int qtde = 0;
	No *no;
	no = f->ini;
	while (no != NULL) {
		qtde++;
		no = no->prox;
	}
	return qtde;
}

void print(Fila *f) {
	No *no;
	no = f->ini;
	cout << "-------------" << endl;
	while (no != NULL) {
		cout << no->dado << endl;
		no = no->prox;
	}
	cout << "-------------" << endl;
}

void enqueue(Fila *f, int v) {
	No *no = new No;
	no->dado = v;
	no->prox = NULL;
	if (isEmpty(f)) {
		f->ini = no;
	}
	else {
		f->fim->prox = no;
	}
	f->fim = no;
}

int dequeue(Fila *f) {
	int ret;
	if (isEmpty(f)) {
		ret = -1;
	}
	else {
		No *no = f->ini;
		ret = no->dado;
		f->ini = no->prox;
		if (f->ini == NULL) {
			f->fim = NULL;
		}
		//free(no);
	}
	return ret;
}

void freeFila(Fila *f) {
	No *no = f->ini;
	while (no != NULL) {
		No *temp = no->prox;
		//free(no);
		no = temp;
	}
	//free(f);
}

int main(int argc, char** argv)
{
	setlocale(LC_ALL, "Portuguese");
	char seletor;
	
	Fila *senhasGeradas;
	senhasGeradas = init();
	
	Fila *senhasAtendidas;
	senhasAtendidas = init();
	
	int senha = 1;
	
	do{
		cout << endl;
		cout << " +-------------------------+" << endl;
		cout << " | Escolha uma das opções: |" << endl;
		cout << " +-------------------------+" << endl;
		cout << " |                         |" << endl;
		cout << " | 0. Sair                 |" << endl;
		cout << " | 1. Gerar senha          |" << endl;
		cout << " | 2. Realizar atendimento |" << endl;
		cout << " |                         |" << endl;
		cout << " +-------------------------+" << endl;
		
		cout << endl << " - Senhas na fila: " << count(senhasGeradas) << endl;
		
		cout << " -> ";
		cin >> seletor;
		cout << endl;
					 
		switch(seletor) {
		case '0':
			if(isEmpty(senhasGeradas)) {
				cout << " - Fim do programa.";
			} else {
				cout << " X Ainda há senhas para serem atendidas";
				seletor = 5;
			}
			
		break;
		
		case '1':
			cout << " = Senha gerada: " << senha;
			
			enqueue(senhasGeradas, senha++);
		
		break;
		
		case '2':			
			if(isEmpty(senhasGeradas)) {
				cout << " X Não há senhas na fila para serem atendidas!";
			} else {
				cout << " = Senha atendida: " << senhasGeradas->ini->dado;
				
				enqueue(senhasAtendidas, senhasGeradas->ini->dado);
				dequeue(senhasGeradas);
			}
			
		break;
		
		default:
		cout << " - Digite um seletor válido! " << endl << endl;
		break;
	}
	cout << endl;
	} while(seletor != '0');
	
}