import { Component } from '@angular/core';
import { EventEmitterService } from 'src/app/services/event-emitter.service';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.css']
})
export class SerieComponent {
  listaEpisodiosPai = [
    {
      nome: 'nome1',
      duracao: '20min'
    },
    {
      nome: 'nome2',
      duracao: '23min'
    },
    {
      nome: 'nome3',
      duracao: '21min'
    }
  ];

  ngOnInit(): void {
    EventEmitterService.get('verTrailer')
      .subscribe((value: any) => {
        alert('Um evento ver trailer foi chamado')
        console.log(value)
      })
  }


  recebeEventoPai(evento: any) {
    console.log('evento recebido!!');
    console.log(evento);
  }

  recebeCliqueSinopse(nomeEpisodio: string) {
    alert(`Ver Sinopse foi executada no ${nomeEpisodio}`);
  }

  recebeCliqueTrailer(nomeEpisodio: string) {
    alert(`Assitir Trailer foi executada no ${nomeEpisodio}`);
  }

  ngOnDestroy() {
    EventEmitterService.get('verTrailer')
      .unsubscribe()
  }

}
