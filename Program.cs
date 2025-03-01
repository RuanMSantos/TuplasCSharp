// A tupla nos da a possibilidade de agrupar valores de forma que veremos a seguir

// Ela se torna muito útil quando não queremos ter o trabalho de criar uma classe, poupando tempo e trabalho

var cadastro = Tuple.Create(1, "Ruan"); // Cria-se uma variavel e em seu valor criamos o objeto do tipo Tupla

// Agora se olharmos a variavel cadastro, ela dinamicamente assumiu os dois valores passados.
// note que não é necessário passar o tipo de dado nos parâmetros.

Console.WriteLine(cadastro.Item1);
Console.WriteLine(cadastro.Item2);

// Item1 e Item2 tem os valores respectivos dos parâmetros.

// Existem dois pequenos problemas na Tupla: Dificuldade de visualização dos valores
// e provavelmente o pior, que só é possível utilizar no máximo 8 valores na tupla.

// Uma evolução é forma simplificada de criar uma tupla

var produto = (1, "Monitor gamer 244hz");

// Dessa forma fica muito bonito de simples de criar a tupla. Dessa forma, ja é entendido que estamos criando
// uma tupla.

Console.WriteLine($"{produto.Item1} {produto.Item2}");

// Uma das melhores evoluções é a possibilidade de nomear os valores.

// Isso acontece passando um nome seguido de dois pontos e um valor, semelhante a um objeto JavaScript

var hortifruti = (Fruta: "Banana", Quantidade: 265);

Console.WriteLine(hortifruti.Fruta);
Console.WriteLine(hortifruti.Quantidade);

// Agora é possível utilizar seus nomes.

// Também é possível desconstruir uma Tupla.

// Para isso na hora da declaração da variavel passamos variaveis separadas, onde cada uma recebe um valor,
// respectivamente

var (car, carBrand) = (Carro: "Palio", Marca: "Fiat");

Console.WriteLine(car);
Console.WriteLine(carBrand);

// Existem agora duas variáveis cada uma com um valor

// Porém neste caso faz mais sentido criar os valores da tupla sem nome.

var (filme, ator) = ("Homem Aranha", "Tobey Maguire");

Console.WriteLine(filme);
Console.WriteLine(ator);

// A forma de definição de uma tupla, caso não queira usar var e precise ser mais específico, é passando os
// tipos das variaveis da tupla entre parenteses antes do nome da sua variavel.

(int, string) animal = (10, "Coelho");

Console.WriteLine(animal.Item1);
Console.WriteLine(animal.Item2);

Console.WriteLine();

// Exemplo nerd e legal
var espada = (
    Nome: "Punição divina", Dano: 20, Resistencia: 10, Manuseio: "Extremamente difícil"
);

Console.WriteLine($"Espada: {espada.Nome}");
Console.WriteLine($"Dano: {espada.Dano}");
Console.WriteLine($"Resistencia: {espada.Resistencia}");
Console.WriteLine($"Manuseio: {espada.Manuseio}");

Console.WriteLine();