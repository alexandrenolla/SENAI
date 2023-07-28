import { Component, EventEmitter, Input, Output } from '@angular/core';
import { EventEmitterService } from 'src/app/services/event-emitter.service';

@Component({
  selector: 'app-lista-episodios',
  templateUrl: './lista-episodios.component.html',
  styleUrls: ['./lista-episodios.component.css']
})
export class ListaEpisodiosComponent {

  @Input() listaEpisodiosFilho: any;
  @Output() meuEvento = new EventEmitter<any>();

  // @Output() cliqueSinopse = new EventEmitter<string>();
  // @Output() cliqueTrailer = new EventEmitter<string>();

  constructor(private eeService: EventEmitterService) {
    setTimeout(() => {
      // Emite o evento
      this.meuEvento.emit('bom dia!');
      console.log('evento emitido!');
    }, 5000)
  }

  emiteEventoSinopse(nomeEpisodio: string) {
    EventEmitterService.get('verSinopse').emit(nomeEpisodio);
  }

  emiteEventoTrailer(nomeEpisodio: string) {
    EventEmitterService.get('verTrailer').emit(nomeEpisodio);
  }

}
