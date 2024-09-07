# Sistema Financeiro

Este repositório contém o código-fonte de um sistema financeiro desenvolvido como parte de um projeto técnico de avaliação. O sistema inclui um dashboard com indicadores financeiros, gráficos de inadimplência e receita, além de uma lista de notas fiscais emitidas com filtros. O projeto foi construído utilizando Docker para facilitar o setup e a implantação.

## Desenvolvedor

- **Nome:** Gabriel Tarozzo
- **E-mail:** [gabriel.tarozzo@hotmail.com](mailto:gabriel.tarozzo@hotmail.com)
- **WhatsApp:** +55 17 98822-0881
- **Localização:** São José do Rio Preto, SP, Brasil

## Tecnologias Utilizadas

- **.NET Core:** Versão LTS 8.0
- **SQL Server:** Versão 2022
- **Entity Framework Core:** Versão 8.0
- **Docker:** Para criação e gerenciamento dos contêineres
- **HTML/CSS/JS:** Frontend com Bootstrap e jQuery
- **Chart.js:** Para visualização de gráficos no dashboard

## Setup do Projeto

### Pré-requisitos

- Docker Desktop instalado na máquina local
- Visual Studio 2022 ou superior
- SQL Server Management Studio (SSMS) para gerenciar o banco de dados

### Instruções de Instalação

1. **Clone o Repositório:**
    ```bash
    git clone https://github.com/gabrieltarozzo/TechNation
    ```

2. **Configuração do Docker:**
    - Certifique-se de que o Docker Desktop esteja rodando.

3. **Configuração do Banco de Dados:**
    - Conecte-se ao SQL Server através do SSMS e execute os scripts que estão em Dados-banco.txt na raiz para criar o banco de dados e as tabelas necessárias.

4. **Executando o Projeto:**
    - Abra o projeto no Visual Studio e execute o projeto.
    - A aplicação estará acessível conforme o link da imagem abaixo:

### Instruções de Uso

- **Dashboard:** O dashboard principal exibe gráficos de inadimplência e receita com base nos dados das notas fiscais.
- **Notas Fiscais:** Acesse a lista de notas fiscais emitidas e utilize os filtros para visualizar as notas por status, data, e pagador.

## Observações

- As instruções para configurar variáveis de ambiente e outras configurações estão detalhadas no arquivo `appsettings.json`, conforme imagem abaixo:

 ![ConnectionString](https://github.com/gabrieltarozzo/TechNation/raw/main/Imagens/connectionString.png)

  
- Este projeto foi desenvolvido para fins de avaliação técnica e contém simulações de dados.
  
##Imagens do sistema rodando:

## Licença

Este projeto está licenciado sob os termos da [MIT License](LICENSE).


