import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Http } from '@angular/http';
import { DatePipe } from '@angular/common';
@Component({
  selector: 'app-gestionar-juego',
  templateUrl: './gestionar-juego.component.html',
  styleUrls: ['./gestionar-juego.component.css']
})
export class GestionarJuegoComponent {
  public campeonatos: Campeonato[];
  public juegos: Juego[];



  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
    http.get<Campeonato[]>(baseUrl + 'api/Campeonato').subscribe(result => {
      this.campeonatos = result;
    }, error => console.error(error));

    /*    http.get<Juego[]>(baseUrl + 'api/Juego').subscribe(result => {
      this.juegos = result;
    }, error => console.error(error));*/
  }

  buscar(identificador: number): void {
    console.log("entra en buscar" + identificador)
    this.http.get<Juego[]>(this.baseUrl + 'api/Juego/'+ identificador).subscribe(result => {
      this.juegos = result;
    }, error => console.error(error));  
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
