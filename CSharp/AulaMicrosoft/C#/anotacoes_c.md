# C#

- Na linguagem C# as funções built-in são diferenciadas por M e m (Maiúsculo e minúsculo); 
    Console =! console
- A linguagem também não aceita as pasas simples (''). Apenas as duplas ("");

- Erros comuns cometidos por programadores não experientes:
    - Inserir letras minúsculas em vez de colocar C em maiúsculas em Console ou as letras W ou L em WitreLinte --------- Console.WriteLine("Heelo World!");
    - Inserir uma vírgula em vez de um ponto entre Console e WriteLine.
    - Esquecer de usar aspas duplas ou colocar a frase Hello World! entre aspas simples.
    - Esquecer de usar o ponto e vírgula no final do comando.
(Cada um desses erros impede que o código seja compilado com êxito)

- // Para comentar com C#

- As classes agrupam métodos que realizam funções semelhantes. Ex: Console(é a classe). WriteLine(é o método - todos os métodos que operam no painel de Saída são definidos na classe Console).
    - O método sempre será seguido de parênteses.
    - A classe e o método são separados por um ponto (.). O ponto é a forma como você "navega da classe para um dos métodos dela.
    - O ; informa ao compilador que terminamos de inserir o comando. 

# Valor Literal
    - É um valor embutido em código que nunca é alterado.
    - Apenas um único caractere alfanumérico impresso na tela, poderíamoso criar um literal char circundando um caractere alfanumérico com aspas simples.
    - Assim como o tipo de dados String, você usa char sempre que tem um único caractere alfanumérico para apresentação (não para cálculo).
        O termo char é a abreviaão de caractere em inglês.
    - Número inteiro = int
    - Sufixo Literal - A letra m = informa ao compilador que você deseja trabalhar com um valor do tipo decimal. Ex: "Console.WriteLine(12.3m);". O m pode ser maiúsculo ou minúsculo;
    - Literal bool - bool - true ou false
    - string e char são usados para "apresentação, não cálculo". Se precisar executar uma operação matemática em valores numéricos, você deverá usar um int ou decimal.

# Variável
- Para usar uma variável, você precisa primeiro declará-la;
- Para criar uma variável primeiro deve-se declarar o tipo de dados da variável e, em seguida, dar um nome a ela. Ex: "string firstName;"
    - Os nomes das variáveis diferenciam maiúsculas de minúsculas, ou seja, string Value; =! string value;
    - Os nomes das varipaveis devem usar minúsculas concatenadas. Ex: string thisIsCamelCase;
    - O nome da variável deve ser uma ou mais palavras inteiras unidas. Não use contrações!
    - O nome da variável não deve ncluir o tipo de dados da variável.
- O C# foi projetado para impor tipos, o que significa que você não pode atribuir um valor de um tipo de dados a uma variável declarada com a finalidade de conter um tipo de dados diferente.
    - Recuperar um valor de uma variável = obter a variável = operação "get".
    - É possível reutilizar e reatribuir a variável quants vezes desejar. 
    - É preciso definir uma variável como um valor antes de poder obter o valor da variável.
    - Variáveis locais do tipo implícito - é criado usando a palavr-chave var - faz com que o C# infira o tipo de dados daquela variável. Ex: var message = "Hello world!";
# Sequência de Escape
    - \n adicionará uma nova linha;
    - \t adicionará uma guia;
    - \" para colocar entre aspas. Ex: \"World\"  
    - Se quiser digitar um caminho dá erro porque o C# resenva a barra invertida para sequências de escape. Ex de erro: Console.WriteLine("c:\source\repos");. \s e \r é uma sequência de escape. Ex dsem erro: Console.WriteLine("c:\\source\\repos");
    - A diretiva @ antes da cadeia de caracteres literal faz com que não seja necessário usar as \\
        Ex: Console.WriteLine(@"c:\source\repos");
    - \u converte um código de quatro caracteres representando algum caractere em unicode (UTF-16), por exemplo.
--------------------
### Recapitulando:
- Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
- Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
- Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
- Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
- Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.
-----------------------
# Concatenação
- Combinar dois ou mais valores em um novo valor.
- Operador de concatenação de cadeia de caracteres = +.
- Evitar usar variáveis intermediárias (uma variável que resulte da soma de outras 2 ou maisvariáveis).

# Interpolação
- Combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação.
    Para se tornar um modelo, a cadeia de caracteres literal quando é prefixado pelo caractere $.

- Sobrecarregar os operadores = o operador de adição, que é o símbolo de mais, é utilizado tanto para somar quanto para concatenar as cadeias de caracteres.
    Considerando os tipos de dados das variáveis (ambos são ints), ele conclui que você deseja adicionar os dois valores.
- Operadores de atribuição composta =+, -=, *=, ++, --;
    O operador += é chamado especificamente de operador de atribuição de adição;
    
# Métodos com estado (Método de Instância) vs Métodos Sem Estado (Método Estático)

- O estado descreve a condição do ambiente de execução em um momento específico no tempo. Conforme seu código executa linha por linha, os valores são armazenados em variáveis. A qualquer momento durante a execução, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.
    Os métodos com estados ou métodos de instância são criados de uma forma que dependem de valores armazenados na memória pelas linhas de código anteriores que já foram executadas. Ou eles modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória.
    Os métodos com estado (instância) controlam seu estado em campos, que são variáveis definidas na classe.

- O método sem estado ou método estático, não depende do estado atual do aplicativo para funcionar corretamente. Assim, os métodos sem estado são implementados para que possam funcionar sem referenciar ou alterar os valores já armazenados na memória. 
    Ex: O Console.WriteLine() não depende de nenhum valor armazenado na memória. Ele executa sua função e termina sem afetar o estado do aplicativo de qualquer forma.

- Uma única classe pode dar suporte a métodos com e sem estado. No entanto, quando você precisa chamar métodos com estado, deve primeiro criar uma intância da classe para que o método possa acessar o estado.
    Uma instância de uma classe é chamada de um objeto.
    Operador new = criar uma instância de um classe.

- Um maneira de aprender a chamar o método é consultar a documentação. Você encontrará exemplos que mostram se o método deve ser chamado da instânci do objeto ou diretamente da classe.

## Recapitulando

- Para chamar métodos de uma classee na Biblioteca de Classe do .NET = use o formato "ClassName.MethodName()".

- Ao chamar um método sem estado, não é necessário criar uma instância de sua classe primeiro.

- Ao chamar um método com estado, é necessário criar uma instância da classe e acessar o método no objeto.
    Use o operador new para criar uma instância de uma classe.
    Uma instância de uma classe é chamada de objeto

- Métodos nulos = não retornam valores quando são concluídos.

- Operação = métodos criados para retornar um valor após a conclusão

- O paarâmetros de entrada podem configurar como o método executa seu trabalho. Ou os parâmetros de entrada podem ser operados diretamente. 
    Ao chamar métodos, você separa cada parâmetro de entrada com um símbolo ",".

- Uma assinatura de método é o número de parâmetros de entrada definidos para cada tipo de dados e parâmetro de entrada.

- Um método sobrecarregado é definido com várias assinaturas de método.
    Oferecen diferentes maneiras de chamar o método ou diferentes tipos de dados.

- IntelliSense - fornece dicas e informações de referência breves em uma janela pop-up sob seu cursor enqunto você insere o código. (autopreenchimento);

# IF, ELSE IF AND ELSE

- A expressão booliana é entre parênteses () --- True or False
- Um bloco de código é definido por chaves { }
    Ex: 
        if (total > 14)
        {
            Console.WriteLine("You Win!");
        }

# MATRIZ

- Uma matriz é uma sequência de elementos de dados individuais que pode ser acessada por meio de um único nome de variável
    Os elementos de uma matriz são como qualquer outro valor de variável, de modo que você pode atribuir, recuperar e reatribuir um valor a cada elemento da matriz.
    A propriedade Length é uma maneira programática de determinar o número de elementos em uma matriz.
        Ex: Console.WriteLine($"There are {fraudulentOrderIDDs.Length} fraudulent orders to process.");

# Foreach

- Realiza um loop em cada elemento da matriz.
    Itera em cada elemento de uma matriz, executando o bloco de código associado uma vez para cada elemento da matriz.

# Melhores Práticas

"A parte mais difícil do desenvolvimento de software é nomear as coisas". 
    O nome de uma variável precisa não apenas seguir certas regras de sintaxe, mas também deve ser usado para tornar o código mais legível e compreensível.
- Escolher nome descritivo para variáveis que descrevem sua finalidade e intençãoo;
- Usar comentários de código para instruir temporariamente o compilador a ignorar linhas de código;
- Usar comentários de código para descrever uma finalidade ou requisitos de nível superior para uma passagem de código;
- Escrever código que use espaço em branco de modo eficaz para transmitir a relação de linhas de código.

    - Convenção = camel case - letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Ex: string thisIsCamelCase;
    - Escolher um nome para a variável que represente o tipo de dados que ela manterá;
    - O nome da variável deve ser uma ou mais palavras inteira unidas. Não usar contrações (nem todo mundo pode entender);
    - Nomes de variável não devem incluir o tipo de dados da variável. Ex: string strMyValue;

    O exemplo string firstName; segue todas essas regras e convenções, supondo que seja uma variável para armazenar dados que representem o nome de uma pessoa.
    
    Exemplos de nome variáveis:
        char userOption;
        int gameScore;
        float particlesPerMillion;
        bool processedCustomer;

    # Variáveis Locais

    O escopo está dentro do corpo de um método. 
    Embora esteja trabalhando no VS Code, está na verdade escrevendo código dentro de um método.
    Classe, métodos têm as mesmas convenções de nomenclatura. 
        O camel case faz parte de uma convenção faz parte de uma estrutura de nomenclatura maior.

    Comentários
    Para que serve?

    - Usar o TODO para lembrar de examinar uma determinada passagem;
    - As vezes os desenvolvedores atualizam o código mas esquecem de atualizar os comentários. 
    - Então, é melhor usar comentários para ideias de nível superior e não adicionar comentários sobre como uma linha de código individual funciona.
    - Comentários de várias linhas = /* Oioioi */
    - Os comentários precisam fornecer um conexto para o problema que está sendo resolvido pelo código. Deixar claro a finalizadade do código, qual o problema ele está resolvendo, como ele se relaciona com o sistema maior.

    # Espaço em Branco ou espaços negativos
        espaços individuais produzidos pelo space bar, tab ou enter;
        - O espaço em branco, quando usado corretamente, pode aumentar sua capacidade de ler e compreender o código.
        - Concentrar na legibilidade do código que escreve
        - Se uma única linha de código se tornar longa, você poderá dividi-la.
            No entanto, deve evitar dividir uma única instrução arbitrariamente em vára linhas até ter um bom motivo para fazer isso.

