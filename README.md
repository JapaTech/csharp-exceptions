# Estudos sobre tratamento de exceções
Este repositório documenta meu estudo de como lançar e tratar de execessões no C#.

## Linguagens, Ferramentas e Tecnologias
> C#,
> Visual Studio 2022,
> .Net 8,
> Postman

## O que aprendi
### Pilha de Execução
Através de testes compreendi como a pilha de execução organiza o funcionamento de um programa e que caso aconteça algum erro em algum lugar da pilha, o fluxo será interrompido e toda aplicação irá travar. Para solucionar esse problema é utilizado o bloco try-catch, que trata essas excessões e faz a aplicação continuar normalmente

### Bloco Try-Catch

    public void Divisao(double x, double y)
    {
      try
      {
        //Tenta dividir x por y e apresenta os valores na tela
        double resultado = x/y;
        Console.WriteLine(resultado);
      }
      catch (DivideByZeroException ex)
      {
        // Log a exceção interna para ver detalhes
        Console.WriteLine($"***********Erro divisão por 0***********");  
      }
    }

O bloco try é responsável por tentar executar o código em que é esperado uma exceção, em quanto o catch é usado para manipular a exceção esperada, no código acima eu uso o try para tentar executar uma divisão, e trato o erro caso é ocorra uma divisão por 0.

### Throw
    public double Divisao(double x, double y)
    {https://docs.github.com/github/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
      if(y = 0)
      {
        throw new DivideByZeroException("Não pode dividir por zero");
      }
      return x/y;
    }

A instrução throw é usada para lançar uma execeção (System.Exception) quando necessário, além de preservar o rastreamento original da pilha de exceção.

## Tratamento de exceção com API
    public IActionResult BuscarPet(string nome)
    {
      try
      {
        var pet = petService.BuscarPorTitulo(nome);
        return Ok(pet);
      }
      catch (PetNaoEncontradoException)
      {
        return NotFound();
      }
    }

Nesse projeto também aprendi usar try-catch fora do ambiente de console, nesse caso usei um projeto da Alura que é uma API para um sistema de adoção chamado Adopet

## Criando Exceções Personalizadas
Também fiz minhas exceções personalizads, através da herança da classe 'Exception' no caso do console, assim tem os benefícios do polimorfismo. Já para a API usei a interface IExceptionHandler, que permitiu o tratamento das exceções globalmente de forma mais consistente, através de uma middlewere, seguindo as boas práticas recomendadas da Microsoft.
