# 🚗 Sistema de Estacionamento

# 🚗 Sistema de Estacionamento

Este projeto foi desenvolvido como parte de um **desafio de fundamentos em C#**, com o objetivo de criar um sistema simples para gerenciamento de veículos em um estacionamento.  

O **modelo inicial** do projeto foi fornecido pelo professor **Leonardo Buta (DIO)**, sendo importante destacar que **toda a lógica foi implementada por mim** durante o desenvolvimento.


---

## 📌 Funcionalidades

- **Adicionar veículo**: o usuário informa a placa, e o sistema registra no estacionamento.  
- **Remover veículo**: o sistema solicita a placa e a quantidade de horas estacionado, calculando o valor a ser pago.  
- **Listar veículos**: exibe todos os veículos atualmente estacionados.  

---

## 🛠️ Estrutura da Classe

A classe principal é `Estacionamento`, com os seguintes membros:

- **Atributos privados**  
  - `precoInicial`: valor fixo cobrado na entrada.  
  - `precoPorHora`: valor adicional por hora.  
  - `veiculos`: lista com as placas dos veículos estacionados.  

- **Construtor**  
  - `Estacionamento(decimal precoInicial, decimal precoPorHora)`: inicializa os preços do estacionamento.  

- **Métodos**  
  - `AdicionarVeiculo()`: adiciona a placa de um veículo, impedindo duplicações.  
  - `RemoverVeiculo()`: remove um veículo e calcula o valor total com base no tempo estacionado.  
  - `ListarVeiculos()`: exibe todos os veículos estacionados.  

---

