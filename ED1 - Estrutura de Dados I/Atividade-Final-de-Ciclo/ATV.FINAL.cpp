#include <iostream>
#include <string.h>
#include <sstream>
using namespace std;

#define NUMERO_CONTATOS 10

/*
    Alunos: Diogo Santos Teixeira e Rian Gustavo Quintanilha de Aquino
*/


class Data
{
private:
	int dia;
	int mes;
	int ano;

public:
	Data(int dia, int mes, int ano)
	{
		this->dia = dia;
		this->mes = mes;
		this->ano = ano;
	}

	Data()
	{
		this->dia = 28;
		this->mes = 9;
		this->ano = 1962;
	}

	void setDia(int dia)
	{
		this->dia = dia;
	}

	void setMes(int mes)
	{
		this->mes = mes;
	}

	void setAno(int ano)
	{
		this->ano = ano;
	}

	int getDia()
	{
		return this->dia;
	}

	int getMes()
	{
		return this->mes;
	}

	int getAno()
	{
		return this->ano;
	}

	string getData()
	{
		stringstream stream;
		stringstream stream2;
		stringstream stream3;
		
		stream << this->dia;
		string saidaDia;
		stream >> saidaDia;
		
		string saidaMes;
		stream2 << this->mes;
		stream2 >> saidaMes;
		
		stream3 << this->ano;
		string saidaAno;
		stream3 >> saidaAno;
		
		return saidaDia.append("/").append(saidaMes).append("/").append(saidaAno);
	}

	Data* dia_seguinte()
	{
		Data *ds;
		int diasNoMes[12] = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		ds = new Data(this->dia, this->mes, this->ano);

		if (ds->ano % 4 == 0)
		{
			diasNoMes[1]++;
		}

		ds->dia++;
		if (ds->dia > diasNoMes[ds->mes - 1])
		{
			ds->dia = 1;
			ds->mes++;
			if(ds->mes > 12)
			{
				ds->mes = 1;
				ds->ano++;
			}
		}

		return ds;
	}

};


class Contato {
    public:
        string email;
        string nome;
        string telefone;
        Data *dtNasc;
        
        Contato(string email, string nome, string telefone, Data *dtNasc) {
            this->email = email;
            this->nome = nome;
            this->telefone = telefone;
            this->dtNasc = dtNasc;
        }
        
        int idade() {
            return 2022 - this->dtNasc->getAno();
        }
        
};

int main(int argc, char** argv)
{
    int i;
    Contato *contatos[NUMERO_CONTATOS];
    
    cout << "Cadastro de Contatos:" << endl;
    
    for(i = 0; i < NUMERO_CONTATOS; i++) {
        string nome, email, telefone, dtNasc;
        
        cout << endl << "Contato Nº" << (i + 1) << ":" << endl;
        
        cout << "   - Nome: ";
        cin >> nome;
        
        cout << "   - E-mail: ";
        cin >> email;
        
        cout << "   - Telefone: ";
        cin >> telefone;
        
        cout << "   - Data de Nascimento (DD/MM/AAAA): ";
        cin >> dtNasc;
        
        int dataArray[3];
        dataArray[0] = stoi(dtNasc.substr(0, 2));
        dataArray[1] = stoi(dtNasc.substr(3, 2));
        dataArray[2] = stoi(dtNasc.substr(6, 4));
        
        contatos[i] = new Contato(email, nome, telefone, new Data(dataArray[0], dataArray[1], dataArray[2]));
    }
	
	cout << "--------------------" << endl << endl;
	
	double mediaIdade = 0;
	
	for(int k = 0; k < NUMERO_CONTATOS; k++) {
	    mediaIdade = mediaIdade + contatos[k]->idade();
	}
	
	mediaIdade = mediaIdade / NUMERO_CONTATOS;
	
	cout << "> Média da idade dos contatos: " << mediaIdade << endl;
	
	
	string contatosIdadeAcimaMedia;
	int qtdContatosMaioresIdade = 0;
	
	for(int l = 0; l < NUMERO_CONTATOS; l++) {
	    if(contatos[l]->idade() > mediaIdade) {
	        contatosIdadeAcimaMedia = contatosIdadeAcimaMedia + contatos[l]->nome + (l < NUMERO_CONTATOS - 1 ? ", " : ".");
	    }
	    
	    if(contatos[l]->idade() >= 18) {
	        qtdContatosMaioresIdade++;
	    }
	}
	
	cout << "> Contatos com a idade acima da média: " << contatosIdadeAcimaMedia << endl;
	cout << "> Número de contatos maiores de idade: " << qtdContatosMaioresIdade << endl;
	
	cout << "> Contato(s) mais velho(s): " << endl;
	
	
	int idadeMaisVelha = -1;
	
	for(int m = 0; m < NUMERO_CONTATOS; m++) {
	    if(contatos[m]->idade() > idadeMaisVelha) {
	        idadeMaisVelha = contatos[m]->idade();
	    }
	}
	
	for(int n = 0; n < NUMERO_CONTATOS; n++) {
	    if(contatos[n]->idade() == idadeMaisVelha) {
	        cout << endl << " | Contato Nº" << (n + 1) << ":" << endl;
	        
	        cout << " | Nome: " << contatos[n]->nome << endl;
            cout << " | E-mail: " << contatos[n]->email << endl;
            cout << " | Telefone: " << contatos[n]->telefone << endl;
	    }
	}
	
	return 0;
}
