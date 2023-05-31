class Animal {
    constructor(tipo, nome, tamanho, cor, idade){
        this.tipo = tipo;
        this.nome = nome;
        this.tamanho = tamanho;
        this.cor = cor;
        this.idade = idade;
    }

    dormir(){
        console.log(`${this.nome} está dormindo.`)
    }

    comer(comida){
        console.log(`${this.nome} está comendo ${comida}.`)
    }

    static respirar(){
        console.log("O animal está respirando.")
    }
}

animal1 = new Animal("mamifero", "girafa", "gigante", "amarelo", 50)

animal1.dormir()
animal1.comer("uva")
Animal.respirar()
console.log(animal1.cor)
console.log(animal1.idade)