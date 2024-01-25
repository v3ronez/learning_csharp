## DateTime

Representa um INSTANTE <br>
É um tipo valor (struct)

### Boas Práticas trabalhando com hora

    -> Armazaenar em formato UTC (em json/DB) (.ToUniversalTime())
        ->formato ISO 8601 "yyyy-MM-ddTHH:mm:ssZ"
    -> antes de formatar para ISO 8601, garantir que está no padrão universal
    -> Instanciar e mostrar ao usuário em formatação local (.ToLocalTime())

## TimeSpan

Requesenta uma DURAÇÃO (um intervalo de tempo) <br>
É um tipo valor (struct)
