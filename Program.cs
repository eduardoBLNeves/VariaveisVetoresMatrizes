//Textos();
//Inteiros();
//Decimais();
//Booleanos();
//Vetores();
//Matrizes();




void Textos(){

    string texto = "Este é um texto";
    Console.WriteLine(texto);



    string outroTexto = "Este é outro texto";
    Console.WriteLine(texto + outroTexto);



    char exemploChar = 'a';
    Console.WriteLine("Char: "+ exemploChar);
}

void Inteiros()
{
    int numero = 3;
    Console.WriteLine(numero);

    Console.WriteLine("Texto e numero: " + numero);

    int outroNumero = -1;
    Console.WriteLine(numero + outroNumero); 
    Console.WriteLine(numero - outroNumero);

}

void Decimais()
{
    float numeroFloat = 99.99F;     //Ponto flutuante
    double numeroDouble = 99.99D;   //Mais casas decimais
    decimal numeroDecimal = 99.99M; //Maior precisão custando desempenho 

    Console.WriteLine(numeroFloat);
    Console.WriteLine(numeroDouble);
    Console.WriteLine(numeroDecimal);

    var variavelSemTipo = 23.33;    //Para tipagem especifica, usar sufíxo
}

void Booleanos()
{

    bool verdadeiro = true;
    Console.WriteLine(verdadeiro);

    bool falso = false;
    Console.WriteLine(falso);

    
    Console.WriteLine(!true);
    Console.WriteLine(!false);


}

void Vetores()
{
    //Vetor = Array

    var vetorString = new string[5]
    {
        "a",
        "b",
        "c",
        "d",
        "e" 
    };

    //Console.WriteLine(vetorString); Não funciona 
    Console.WriteLine(string.Join(",", vetorString));


    var vetorInt = new int[2];
    vetorInt[0] = 3;
    vetorInt[1] = 2;

    var vetorBool = new bool[2];
    vetorBool[0] = vetorBool[1] = true;
}

void Matrizes()
{
    //Matriz = Array multidimensional

    var matriz = new string[2, 5]
    { 
        {
            "a",
            "b",
            "c",
            "d",
            "e"
        },  
        {
            "a",
            "b",
            "c",
            "d",
            "e" 
        }
    };

    foreach (var item in matriz)
    {
        Console.WriteLine(string.Join(",", item));
    }

}