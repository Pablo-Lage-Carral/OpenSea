# Projeto Mar Aberto

## Introdução

O projeto "Mar Aberto" nasce da necessidade urgente de monitorar e controlar a qualidade da água dos oceanos de maneira eficiente e acessível. Em um mundo onde a preservação ambiental se torna cada vez mais crucial, a coleta e análise de dados precisos sobre a qualidade da água dos mares é essencial para a saúde dos ecossistemas marinhos e, consequentemente, para o bem-estar global.

## Ideia do Projeto

O "Mar Aberto" propõe uma abordagem inovadora para o monitoramento da qualidade da água dos oceanos, utilizando dados abertos e sensores distribuídos globalmente. A alusão ao nome do projeto reflete a transparência e a disponibilidade dos dados que pretendemos consumir e compartilhar. Todos os dados coletados serão provenientes do mar e estarão acessíveis a todos os interessados.

## Objetivos

Os principais objetivos do projeto "Mar Aberto" são:

- **Coleta de Dados**: Implementar uma rede de sensores em diversas regiões oceânicas para coletar dados em tempo real sobre a qualidade da água.
- **Centralização das Informações**: Criar uma plataforma centralizada que consolide e organize os dados coletados de maneira clara e acessível.
- **Análise e Visualização**: Desenvolver ferramentas de análise e visualização de dados que permitam a interpretação fácil e precisa das informações.
- **Projeções Futuras**: Utilizar modelos preditivos para projetar tendências futuras da qualidade da água, auxiliando na tomada de decisões e na formulação de políticas ambientais.
- **Acesso Público**: Garantir que todos os dados e análises sejam abertos e acessíveis ao público, promovendo a transparência e o engajamento comunitário.

## Proposta de Solução

A solução proposta pelo projeto "Mar Aberto" envolve várias etapas interconectadas:

## Requisitos para rodar o código

- **.NET SDK**
- **Banco de Dados: SQL Server**
- **Visual Studio Code: Com as extensões C# e .NET instaladas.**
  

## Dependências dentro do código

- **Microsoft.EntityFrameworkCore versão: (8.0.6)**
- **Microsoft.EntityFrameworkCore.SqlServer**
- **Microsoft.EntityFrameworkCore.Tools**
- **Swashbuckle.AspNetCore (para Swagger UI)**
- **Microsoft.AspNetCore.Mvc.NewtonsoftJson (para trabalhar com JSON de maneira mais avançada)**


## Rodando o código


**Baixando o arquivo pela URL**


1.Copie a URL (https://github.com/Pablo-Lage-Carral/OpenSea.git)



2.Depois clone a aplicação no PowerShell

2.1.git clone https://github.com/Pablo-Lage-Carral/OpenSea.git


3.Navegue até o arquivo "OpenSea"

  3.1.ls > cd .\OpenSea\.


4.Rode a aplicação com "dotnet run"


5.Após compilado, copie a URL "http://localhost:5237" e jogue no navegador


## Endpoints ##


**Foi utilizado um único endpoint chamado "OceanObservations" que foi usado para colher os dados retirados da nossa máquina de aprendizagem de previsão
Os campos criados foram:**

  **"id": 0,
  "temperature": 0,
  "salinity": 0,
  "oxygen": 0,
  "ph": 0**

