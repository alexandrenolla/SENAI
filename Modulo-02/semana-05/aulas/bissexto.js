function isBissexto(year) {
    if (year % 400 === 0 || year % 4 === 0 && year % 100 !== 0) {
        return true;
    }
    else {
        return false;
    }
}


console.log(isBissexto(1996));

// Com operador ternário
let year = 1996

var msg = (year % 400 === 0 || year % 4 === 0 && year % 100 !== 0) ? 'Ano bissexto' : 'Ano não bissexto'

console.log(msg);