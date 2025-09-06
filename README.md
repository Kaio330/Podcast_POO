# Podcast Manager

Este é um projeto simples de console em C# que demonstra os princípios básicos da Programação Orientada a Objetos (POO) através da criação e gerenciamento de podcasts e seus episódios.

## Visão Geral do Projeto

O projeto consiste em uma aplicação de console que:
- Cria instâncias de podcasts com um host e um nome.
- Cria instâncias de episódios com um título, duração e ordem.
- Adiciona convidados a cada episódio.
- Adiciona os episódios a um podcast.
- Exibe os detalhes do podcast, incluindo a lista de episódios e seus convidados.

## Estrutura do Projeto

O projeto está organizado nos seguintes arquivos principais:

- `Podcast.sln`: O arquivo de solução do Visual Studio que agrupa os projetos.
- `Podcast/`: O diretório que contém o projeto C#.
  - `Podcast.csproj`: O arquivo de projeto que contém as configurações de compilação e dependências.
  - `Program.cs`: A classe principal que contém o método `Main`, o ponto de entrada da aplicação. É aqui que os podcasts e episódios são instanciados e os resultados são exibidos no console.
  - `PodCast.cs`: Define a classe `Podcast`, que gerencia uma coleção de episódios.
  - `Episodio.cs`: Define a classe `Episodio`, que representa um único episódio de um podcast.

## Como Executar o Projeto

### Usando o Visual Studio
1. Abra o arquivo `Podcast.sln` com o Visual Studio.
2. Pressione `F5` ou clique no botão "Iniciar" para compilar e executar o projeto.
3. A saída será exibida em uma janela de console.

### Usando a Linha de Comando (com o .NET SDK)
1. Navegue até o diretório raiz do projeto no seu terminal.
2. Execute o seguinte comando para compilar e executar o projeto:
   ```sh
   dotnet run --project Podcast/Podcast.csproj
   ```
3. A saída será exibida no console.

## Exemplo de Saída

A execução do programa produzirá uma saída semelhante a esta:

```
Podcast >| Etec Itapevi |< Apresentado por [Hélio Silva]

1. aula de ds1. (50min) - Hélio Silva, Kaio
2. DS2. (35min) - Nica, Kaio
3. DS3. (55min) - Lazaro, Kaio


 Total de Episodios: 3.


Podcast >| Etec Itapevi |< Apresentado por [Hélio Silva]

1. aula de ds1. (50min) - Hélio Silva, Kaio
2. DS2. (35min) - Nica, Kaio
3. DS3. (55min) - Lazaro, Kaio


 Total de Episodios: 3.
```
