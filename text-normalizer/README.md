# Normalizador de Texto

Um aplicativo de console em C# que normaliza pontuações duplicadas em textos, reduzindo múltiplas exclamações e interrogações consecutivas.

## O que é a Normalização de Pontuações?

A normalização de pontuações é o processo de reduzir múltiplas pontuações consecutivas (`!` e `?`) a uma forma simplificada e padronizada, mantendo a intenção original do texto.

### Exemplos de Normalização:
- "Olá!!!" ? "Olá!"
- "Como vai???" ? "Como vai?"
- "Que legal!?!?!?" ? "Que legal!?"
- "Incrível!!!???" ? "Incrível!?"
- "Nossa???!!!" ? "Nossa?!"

## Funcionalidades

- Remove pontuações duplicadas consecutivas (`!` e `?`)
- Combina múltiplas pontuações em uma forma normalizada
- Preserva a ordem da primeira pontuação encontrada (ex: `!?!?` ? `!?`, `?!?!` ? `?!`)
- Quando há apenas um tipo de pontuação, retorna apenas um caractere
- Valida entrada do usuário (não aceita texto vazio ou apenas espaços)
- Interface interativa de linha de comando

## Requisitos

- .NET 8.0 SDK ou superior

## Como Executar

1. Clone o repositório ou navegue até o diretório do projeto

2. Execute a aplicação:
```bash
dotnet run
```

## Como Usar

1. Após executar a aplicação, digite um texto com pontuações
2. O programa exibirá o texto normalizado
3. Digite outro texto para continuar testando
4. Digite `sair` para encerrar o programa
