import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Http } from '@angular/http';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-actualizar-juego',
  templateUrl: './actualizar-juego.component.html',
  styleUrls: ['./actualizar-juego.component.css']
})
export class ActualizarJuegoComponent {
  public juegos: Juego[];
  public juego: Juego;
  public campeonatos: Campeonato[];

  identificadorJ: number;
  identificadorCampeonatoJ: number;
  equipoAJ: number;
  equipoBJ: number;
  fechaJuegoJ: Date;
  estadoJuegoJ: boolean;
  lugarJ: String;
  arbitroAsignadoJ: String;

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
    http.get<Campeonato[]>(baseUrl + 'api/Campeonato').subscribe(result => {
      this.campeonatos = result;
    }, error => console.error(error));

  
  }

  buscar(identificador: number): void {
    console.log("entra en buscar" + identificador)
    this.http.get<Juego[]>(this.baseUrl + 'api/Juego/' + identificador).subscribe(result => {
      this.juegos = result;
    }, error => console.error(error));
  }
  
  buscarJuego(identificador: number): void {
    console.log("entra en busca segunnnndo")
    this.http.get<Juego>(this.baseUrl + 'api/Juego/' + identificador).subscribe(result => {
      this.juego = result;
    }, error => console.error(error));
    /*
    this.identificadorJ = this.juego.identificador;
    this.identificadorCampeonatoJ = this.juego.identificadorCampeonato;
    this.equipoAJ = this.juego.equipoA;
    this.equipoBJ = this.juego.equipoB;
    this.fechaJuegoJ = this.juego.fechaJuego;
    this.estadoJuegoJ = this.juego.estadoJuego;
    this.arbitroAsignadoJ = this.juego.arbitroAsignado;*/

  }

}


interface Campeonato {
  identificador: number;
  nombreCampeonato: String;
  imagenCampeonato: ByteString;
  cantidadGrupos: number;
  fechaInicio: Date;

}

interface Juego {
  identificador: number;
  identificadorCampeonato: number;
  equipoA: number;
  equipoB: number;
  fechaJuego: Date;
  estadoJuego: boolean;
  lugar: String;
  arbitroAsignado: String;

} 
