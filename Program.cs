//Váriavel para controle de Loop
int continuar;

do
{

//Declarando Variaveis e Colhendo Dados


Console.WriteLine("Olá! Qual o seu nome?");
string? nome = Console.ReadLine();

Console.WriteLine("Qual sua idade?");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual a sua altura?");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual seria o seu peso?");
double peso = Convert.ToDouble(Console.ReadLine());


//Calculando o IMC
double IMC = peso / (altura * altura);  
string? categoriaIMC;


//Definindo a Classificação do IMC da pessoa
if(IMC <= 18.5)
{
    categoriaIMC = "Abaixo do Peso";
}
else if(IMC >= 18.5 && IMC <= 24.99)
{
    categoriaIMC = "Normal"; 
}
else if(IMC >= 25 && IMC <= 29.99)
{
    categoriaIMC = "Sobrepeso";
}
else if(IMC >= 30 && IMC <= 35)
{
    categoriaIMC = "Obeso";
}
else
{
    categoriaIMC = "Inválido";
}


//Definindo a Faixa Etária 
string? faixa;

if(idade <= 12)
{
    faixa = "Criança";
}
else if(idade > 12 && idade <= 18)
{
    faixa = "Adolescente";
}
else if(idade > 18 && idade <= 63)
{
    faixa = "Adulto";
}
else if(idade >= 64)
{
    faixa = "Idoso";
}
else
{
    faixa = "Inválido";
}

// Montando Relatório Final
Console.WriteLine("-------------RELATÓRIO FINAL--------------");
Console.WriteLine("Nome: " + nome );
Console.WriteLine("Idade: " + idade);
Console.WriteLine($"IMC: {IMC}");
Console.WriteLine($"Categoria do IMC: {categoriaIMC}");
Console.WriteLine("Faixa Etária: " + faixa);

//Perguntando se gostaria de gerar um novo relatório
   Console.WriteLine("Deseja gerar um novo relatótio? \n Digite '1' para CONTINUAR. \n Digite '2' para ENCERRAR");
    continuar = Convert.ToInt32(Console.ReadLine());


}while(continuar != 2); //Condição de Loop