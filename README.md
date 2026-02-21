![CO-10](https://github.com/user-attachments/assets/eea2ce0f-6542-432a-8319-6c6dd2d9cdb8)

## 🥁 CarnaCode 2026 - Desafio 22 - Template Method

Oi, eu sou o Leonardo Malavolti Monteiro e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

### Sobre este desafio
No desafio **Template Method** eu tive que resolver um problema real implementando o **Design Pattern Template Method**.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Um sistema precisa processar diferentes tipos de pedidos (Online, Atacado, Marketplace) onde cada um segue os mesmos passos gerais mas com implementações específicas. 
O código atual duplica a estrutura do algoritmo em cada classe, tornando difícil manter consistência.

## Solução com Template Method
- Definição do fluxo de processamento em uma classe abstrata `OrderProcessor`
- Subclasses implementam apenas passos específicos
- Passos comuns (estoque, separação) reutilizados
- Sequência do algoritmo garantida
- Facilita adicionar novos tipos de pedido sem duplicação de código

## Benefícios
- Código limpo, modular e consistente
- Cumpre Open/Closed Principle
- Fluxo de processamento padronizado
- Facilidade de manutenção e extensão

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
