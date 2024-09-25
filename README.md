# **ProjetoEmEquipe**
# **Automatizando a Localização e Cópia de Arquivos em C#**
Identificar arquivos que seguem o mesmo padrão dentro da pasta de origem e copiá-los para pasta de destino.

## **O que foi utilizado**
### **Cronometro**
Console.Write(): Para exibir uma mensagem solicitando a entrada do usuário.
Console.ReadLine(): Para ler a entrada do usuário.
int.TryParse(): Valida e converte a entrada do usuário em um número inteiro, garantindo que seja um valor válido.
for loop: Usado para criar a contagem regressiva, decrementando o valor de segundos.
Console.WriteLine(): Para exibir o tempo restante a cada segundo.
Thread.Sleep(1000): Pausa a execução por 1000 milissegundos (1 segundo).
if: Para verificar se a entrada do usuário é um número válido e maior que zero.

### **Dados de seis lados**
Entrada do Usuário: O programa solicita ao usuário que insira o número de jogadas (rolagens de dado).
Validação: Usa int.TryParse para verificar se a entrada é um número inteiro válido.
Loop de Rolagens: Um loop for itera o número de jogadas, gerando um número aleatório entre 1 e 6 em cada iteração, simulando a rolagem de um dado.
Saída: Os resultados das rolagens são impressos no console.
Gerador de Números Aleatórios: Um objeto Random é criado para gerar os números aleatórios.

### **Senha Aleatoria**
Entrada do Usuário: Solicita ao usuário o tamanho da senha desejada.
Validação: Usa int.TryParse para verificar se a entrada é um número inteiro válido.
Conjunto de Caracteres: Define uma string (possivel) contendo letras maiúsculas, minúsculas e dígitos numéricos, que serão usados para criar a senha.
Gerador de Números Aleatórios: Um objeto Random é criado para gerar números aleatórios.
Array de Caracteres: Cria um array (senha) do tamanho especificado para armazenar os caracteres da senha.
Loop de Geração: Um loop for itera até o número de caracteres desejado, preenchendo o array com caracteres aleatórios selecionados da string possivel.
Saída: A senha gerada é impressa no console.

### **Calculadora IMC**
### **Decisão de Almoço**
### **Calculadora**
### **Conversor de temperatura**
### **Adivinhação de numeros**

## **Parâmetros**

1. Local onde os arquivos estão armazenados ```string path_origin = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);```

2. Qual informação tem no nome do arquivo que será possível diferenciá-lo dos demais? ```identify_file = ".TXT"```
> Não necessariamente precisa ser a extensão do arquivo. No meu caso, eu precisei pesquisar por uma informação que tinha no meio do nome.
Só substituir o ".TXT". 

3. Para qual pasta deseja copiar os arquivos? Se quiser copiar para uma outra pasta dentro de Documents só alterar para: ```os.path.expanduser(r"~\Documents/NOVA-PASTA")```

## **Bibliotecas utilizadas**
```os.path```
```shutil```

## **Etapas implementadas**
- [x] Identificar a pasta de origem
- [x] Identificar a pasta de destino 
- [x] Como identificar o(s) arquivo(s)
- [x] Criar função para obter a lista de arquivo(s)
- [x] Criar função para copiar o(s) arquivo(s)
- [x] Criar diretório de destino
- [x] Validar se o diretório de destino existe
- [x] Permitir excluir ou não o diretório de destino antes de copiar os arquivos
- [x] Imprimir no console os arquivos que foram copiados com sucesso


## **Backlog**
- [ ] Mover arquivo(s)
- [ ] Manipular arquivo(s)

# **Conclusão**
