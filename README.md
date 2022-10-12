# WebApi.DotNet

++ Desafio 02 Internal Talent - CINEMA++



(OK) Pode utilizar a linguagem de sua escolha, porem na versão LTS mais atual
(OK) Pode utlizar qualquer banco de dados (NoSQL ou SQL), rodando em Docker no WSL2



(OK) - Criar uma API para fazer um CRUD (CRUD mais lindo da vida)
Deve haver os seguintes pre requisitos:
(OK) - Ter mais de 1 projeto na solution (ou mais de um package)
(OK) - Utilizar os seguintes tipos primitivos (int, bool, datetime, string, arrays (Lista ou Coleções))
- Ter 1 exemplo de cada pilar de OOP

- Utilizar principios SOLID
- Ter 1 exemplo de Design Pattern (Criação, Comportamento ou estrutura)
(OK) - Ter um relacionamento entre os objetos (1:1 ou 1:n ou n:n)
- Utilizar um ORM
- Ter um teste de unidade
(OK) - Utilizar o Swagger para documentar a API
(OK) - Criar um README.md



 
(OK)  * Código precisa estar versionado no Github
(OK)  * Precisa estar fazendo o build através do Github Actions (Continuos Integration)
(OK)  * Utilizar Conventional Commits

Instalar o WSL em 
	https://docs.microsoft.com/pt-br/windows/wsl/wsl2-kernel 


Mudar a versão para o 2 no powershell
	wsl --set-default-version 2

Microsof Store instale o Ubuntu

*Dica Usar o Windows Terminal, vai ter o Ubuntu lá

Depois rode:
	sudo apt update && sudo apt upgrade
	sudo apt remove docker docker-engine docker.io containerd runc
	sudo apt-get install \
    		apt-transport-https \
    		ca-certificates \
    		curl \
    		gnupg \
    		lsb-release

E depois:
	curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /usr/share/keyrings/docker-archive-keyring.gpg
	echo "deb [arch=amd64 signed-by=/usr/share/keyrings/docker-archive-keyring.gpg] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list > /dev/null

Depois: 
	sudo apt-get update

Depois:
	sudo apt-get install docker-ce docker-ce-cli containerd.io docker-compose-plugin

Depois:
	sudo usermod -aG docker $USER

E sempre rodar : sudo service docker start


----------------------------------------------------------------------------------------

docker pull mongo ou docker pull mongo:versão

https://docs.docker.com/engine/reference/commandline/rm/


parar todos os container: docker stop $(docker ps -a -q)

excluir container parados: docker rm $(docker ps -a -q)

remover todas as imagens: docker rmi $(docker images -q)

incluir uma imagem mongo no docker: docker pull mongo:4.4

incluir um container na imagem mongo: docker run -d -p 27017:27017 --name cinema-mongo mongo:4:4

para abrir a conexão com o mongo: ~$ docker exec -it cinema-mongo mongosh

startar um container docker start [OPTIONS] CONTAINER [CONTAINER...]

dotnet build
dotnet run


https://jasonwatmore.com/post/2021/06/24/vs-code-net-debug-a-net-web-app-in-visual-studio-code


Projeto em camada
https://www.macoratti.net/20/10/aspnc_impclean2.htm

******************************************************************************************
https://www.digitalocean.com/community/tutorials/ufw-essentials-common-firewall-rules-and-commands

Firewall no WLS2 - Ubuntu

sudo ufw status

sudo ufw enable

https://learn.microsoft.com/pt-br/windows/wsl/networking

Para saber o IP do WSL2 ubuntu
cat /etc/resolv.conf

netsh interface portproxy add v4tov4 listenport=4000 listenaddress=0.0.0.0 connectport=4000 connectaddress=192.168.101.100


habilitar o Linux no PowerShell como adm
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux

Habilitar máquina virtual
Enable-WindowsOptionalFeature -Online -FeatureName VirtualMachinePlatform

Instatal docker compose
sudo apt install docker-compose


https://github.com/PatriciaKG/WebApi.DotNet/blob/master/images/imagem01.png


listar ip - linux - ubuntu

Para Achar o IP no Ubuntu - Scope Eth0
ip address | grep inet


mongodb://172.31.174.108:8081/DbTeste


Adicionar o mongo
dotnet add package MongoDB.Driver --version 2.17.1


automapper
https://www.youtube.com/watch?v=_ekvCMGuywg


https://blog.revelo.com.br/orm/
dotnet add package Microsoft.AspNetCore --version 2.2.0
dotnet add package Microsoft.AspNetCore.Mvc --version 2.2.0
dotnet add package Microsoft.Extensions.Logging --version 7.0.0-rc.1.22426.10



