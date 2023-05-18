/* Console.WriteLine("Primeiro programa");

int idade = 33;
Console.WriteLine(idade);
string nome = "Rafael Almeida";
Console.WriteLine(nome);
decimal valor = 200.99m;
double valorDouble = 200.99;
float valorFloat = 200.99f;
Console.WriteLine(valor);
var idadeNova = 34;
char flag = 'y';
Console.WriteLine(flag);
bool ativo = true;
Console.WriteLine(ativo);




const string descricao = "curso CSHARP";
//descricao = "Curso";
Console.WriteLine(descricao);
*/
/*
int numero1 = 1;
int numero2 = 2;

var soma = numero1 + numero2;
Console.WriteLine(soma);

var subtracao = numero1 - numero2;
Console.WriteLine(subtracao);

int multiplicacao = numero1 * numero2;
Console.WriteLine(multiplicacao);

var divisao = numero1 / numero2;
Console.WriteLine(divisao);

bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero1 > numero2;
Console.WriteLine(maior);

bool menor = numero1 < numero2;
Console.WriteLine(menor);

bool maiorOuIgual = numero1 >= numero2;
Console.WriteLine(maiorOuIgual);

bool menorOuIgual = numero1 <= numero2;
Console.WriteLine(menorOuIgual);

bool diferente = numero1 != numero2;
Console.WriteLine(diferente);*/
/*
int numero1 = 1;
int numero2 = 2;

bool valido = numero1 < numero2 && 8> 7;
Console.WriteLine(valido);

bool valido2 = numero1 > numero2 || 8> 7;
Console.WriteLine(valido);

bool valido3 = !(numero2 > 10);
Console.WriteLine(valido3);

bool ativo = true;
string status = !ativo ? "Cadastro Ativo" : "Cadastro Inativo";
Console.WriteLine(status);*/
/*
EscreverNome();

void EscreverNome()
{
    var nome = NomeCompleto();
    var soma = SomaValores();

    Console.WriteLine(nome);
    Console.WriteLine(soma);
}

string NomeCompleto()
{
    string primeiroNome = "Rafael";
    string segundoNome = "Almeida";
    return primeiroNome + " " + segundoNome;
}

int SomaValores()
{
    return 8 + 2;
}
*/
/*
var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Rafael", 33);
Console.WriteLine(nome);

int SomaValores(int a, int b)
{
    return a + b;
}

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
} */
/*
using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1); //0
arrayList.Add("Rafael"); //1
arrayList.Add(true); //2

//Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);

arrayList.Clear();
foreach(var item in arrayList)
{
    Console.WriteLine(item);
}
*/
/*
//var arrayTipadoNumero = new int[3] {1, 2, 3};
var arrayTipadoNumero = new int[3];

arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

//Array.Resize(ref arrayTipadoNumero, 100);

//arrayTipadoNumero[10] = 100;

foreach(var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}
var arrayTipadoString = new string[2] {"Gustavo", "Luiz"};
foreach(var item in arrayTipadoString)
{
    Console.WriteLine(item);
}*/
/*
var lista = new List<string>(10);
lista.Add("Gustavo");
lista.Add("Luiz");
lista.Add("Curso");

var nome = lista[0];
Console.WriteLine(nome);
*/
/*
var dicionario = new Dictionary<int, string>()
{
    {5, "Teste"},
    {6, "Teste 6"},
};
dicionario.Add(100, "Gustavo");
dicionario[50] = "Curso";

var nome = dicionario[100];
Console.WriteLine(nome);

foreach(var item in dicionario)
{
    Console.WriteLine(item);
}
*/
/*
var queue = new Queue<string>();
queue.Enqueue("Gustavo");
queue.Enqueue("Luiz");

// var nome = queue.Peek();
// var nome1 = queue.Peek();

var nome = queue.Dequeue();
var nome1 = queue.Dequeue();

Console.WriteLine(nome);
Console.WriteLine(nome1);
*/
/*
foreach(var item in queue)
{
    Console.WriteLine(item);
}
*/
/*
var stack = new Stack<string>();
stack.Push("Gustavo");
stack.Push("Luiz");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);

foreach(var item in stack)
{
    Console.WriteLine(item);
}
*/
/*
var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho)
{
    Console.WriteLine("Hoje é domingo");
} else if (diaDaSemana == 0 && diaDeTrabalho == false)
{
    Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
} else {
    Console.WriteLine("Hoje não é domingo");
}
*/
/*
var diaDaSemana = 8;

if(diaDaSemana == 0)
{
    Console.WriteLine("hoje é domingo");
} else if (diaDaSemana == 1)
{
    Console.WriteLine("hoje é segunda");
} else if (diaDaSemana == 2)
{
    Console.WriteLine("hoje é terça");
} else if (diaDaSemana == 3)
{
    Console.WriteLine("hoje é quarta");
} else if (diaDaSemana == 4)
{
    Console.WriteLine("hoje é quinta");
} else if (diaDaSemana == 5)
{
    Console.WriteLine("hoje é sexta");
} else if (diaDaSemana == 6)
{
    Console.WriteLine("hoje é sábado");
} else
{
    Console.WriteLine("dia da semana inválido");
}
*/
/*
var diaDaSemana = 0;

switch(diaDaSemana)
{
    case 0:
        Console.WriteLine("hoje é domingo");
        break;
    case 1:
        Console.WriteLine("hoje é segunda");
        break;
    case 2:
        Console.WriteLine("hoje é terça");
        break;
    case 3:
        Console.WriteLine("hoje é quarta");
        break;
    case 4:
        Console.WriteLine("quinta");
        break;
    case 5:
        Console.WriteLine("hoje é sexta");
        break;
    case 6:
        Console.WriteLine("hoje é sábado");
        break;
}
*/
/*
var lista = new List<string>() {"Gustavo", "Luiz", "Curso"};
var count = lista.Count;
for(var i=0; i < count; i++)
{
    var nome = lista[i];
    Console.WriteLine(nome);
}
*/
/*
var lista = new List<string>() {"Gustavo", "Luiz", "Curso"};

foreach(string item in lista)
{
    Console.WriteLine(item);
}

foreach(var letra in "lista")
{
    Console.WriteLine(letra);
}
*/
/*
var i = 3;
while(i < 2)
{
    Console.WriteLine("var i = " + i);
    i++;
}

var j = 3;
 do
 {
    Console.WriteLine("var j = " + j);
    j++;
 } while (j < 2);
 */
/*
var i = 0;
while(i < 5)
{
    Console.WriteLine("var i = " + i);
    i++;
    if (i < 2)
    {
        Console.WriteLine("Continuando...");
        continue;
    }
    if(i == 2)
    {
        Console.WriteLine("Valor de i é igual a 2 (dois)");
        break;
    }
}
*/