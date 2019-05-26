import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DatePipe } from '@angular/common';
@Component({
  selector: 'app-listar-jugador',
  templateUrl: './listar-jugador.component.html',
  styleUrls: ['./listar-jugador.component.css']
})
export class ListarJugadorComponent {
  public jugadores: Jugador[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Jugador[]>(baseUrl + 'api/jugador').subscribe(result => {
      this.jugadores = result;
    }, error => console.error(error));
  }
}

interface Jugador {
  identificacion: string;
  nombre: string;
  apellidos: string;
  fechaNacimiento: DatePipe;
  idEquipo: number;

}

