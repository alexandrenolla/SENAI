# ambiente de build
# imagem linux, que tem o dotnet 7.0 pré instalado
# essa imagem está apelidada de build-env
# build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env  

# dentro da imagem será criar uma pasta chamada /app_container e vou colocar os arquivos do programa nela
WORKDIR /app_container                              

# vai copiar qualquer csproj para dentro do /src da imagem
# esse arquivo copiado vai ser colocado dentro do /app_container
COPY src/*.csproj .                                 
# COPY FichaCadastroSln/FichaCadastroAPI/*.csproj .     

# restaura o projeto do senai-estreito.csproj
RUN dotnet restore "senai-estreito.csproj" --use-current-runtime

# copia todo o src para dentro do /app_container
COPY src .

RUN dotnet publish senai-estreito.sln -c Release -o /publish


# crio uma nova imagem chamada runtime
# essa imagem será responsável pela execução do programa
FROM mcr.microsoft.com/dotnet/sdk:7.0 as runtime   

WORKDIR /publish

# copiando o app_container e o /publish anterior para dentro do /publish criado na linha 28
COPY --from=build-env /publish .

# a porta do container que correponde a porta do programa é a 5000
EXPOSE 5000
ENTRYPOINT [ "dotnet", "senai-estreito.dll" ]

