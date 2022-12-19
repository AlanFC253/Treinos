#include <iostream> //Biblioteca pra usa o std::cout
#include <string> //Biblioteca para String


int Sla(int y) { //colocar & depois do tipo passa a variavel por referecia . Por exemplo voce ja tem uma variavel y no codigo, se coloca int& y ele linka as variaveis
	int x = y + 1;
	return x;
}

int main(int argc, char** argv) {

	std::cout << "Ola, mundo!\n"; //output

	system("pause");


	int myInt = 0; //Inteiro,pode ser numero negativo
	myInt = 10;
	myInt = 20;
	myInt = 10 + 20;
	myInt += 10;
	myInt -= 5;
	myInt *= 10;
	myInt /= 10;

	std::cout << myInt << "\n";

	system("pause");

	unsigned int myUint = 0; //int sem negativo

	float myFloat = 0.0f; // Usa o F para ele sabe que tem numero flutuante , se não acha que é um double
	double myDouble = 0.0; //Mais precisão  
	bool myBool = true; // 1 ou 0
	char myChar = 't'; // 1 caracter

	size_t mySizeT = 0; // Tamanhos de coisas, não tem valores negativos

	char myArray[11] = "0123456789"; // array tem q ter +1 de tamanho do array, pq o ultimo caracter vai se um \0

	std::string myStrig = "Ola";

	myStrig = "Teste";

	std::cout << myStrig << "\n";

	system("pause");

	while (true)
	{
		int x;
		std::cout << "Digite um numero (1337 Break) \n";
		std::cin >> x;

		if (x == 1337) {
			std::cout << "Fim do While \n";
			break;
		}
		if (x > 0)
		{
			std::cout << "MyInt maior que 0 \n";
		}
		else if (x < 0) {
			std::cout << "MyInt e negativo \n";
		}
		else
		{
			std::cout << "MyInt e 0 \n";
		}
	}

	system("pause");



	for (int i = 0; i < 10; i++)
	{
		std::cout << i << "\n";
	}


	system("pause");

	std::cout << Sla(5)<<"\n";

	system("pause");

	return 0;


}

