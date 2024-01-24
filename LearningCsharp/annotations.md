## DateTime

Representa um INSTANTE <br>
É um tipo valor (struct)

### Boas Práticas trabalhando com hora

    -> Armazaenar em formato UTC (em json/DB) (.ToUniversalTime())
    -> Instanciar e mostrar ao usuário em formatação local (.ToLocalTime())

## TimeSpan

Requesenta uma DURAÇÃO (um intervalo de tempo) <br>
É um tipo valor (struct)
