import { Injectable, Inject } from '@angular/core';
import { Http, RequestOptions, Headers } from '@angular/http'
import {  Response } from '@angular/http';

import { Observable } from "rxjs/Observable";
import "rxjs/add/operator/map";
import { DatePipe } from '@angular/common';


@Injectable()
export class jugadorservice {
 
  constructor(private http: Http) {

  }

  private url = 'https://localhost:44396/';

  guardarJugador(jugador: Jugador): Observable<Jugador> {
    let body = jugador;
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    console.log("aquiiiiiiiiiiiiiiiiiiiiiiiiiiii")
    return this.http.post(this.url + 'api/jugador/', body, options).map(this.extractData);




  }




  validarExistencia(id: string): Observable<Jugador> {

    return this.http.get(this.url + "api/jugador/existe/" + id).map(response => response.json());

  }


  buscarJugador(nombre: string): Observable<Jugador[]> {

    return this.http.get(this.url + "api/jugador/nombre/" + nombre).map(response => response.json());

  }



  getAllJugadores(idEquipo: number): Observable<Jugador[]> {

    return this.http.get( "https://localhost:44396/api/jugador/", idEquipo+"").map(response => response.json());

  }

 

  actualizarJugador(jugador: Jugador): Observable<Jugador> {
    return this.http.put("https://localhost:44396/api/jugador/actualizar/", jugador).map(response => response.json());

  }

  eliminarJugador(identificacion: string): Observable<Jugador> {


    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });

    return this.http.delete(this.url + 'api/jugador/' + identificacion, options).map(response => response.json());
  }
    private extractData(res: Response) {
        let body = res.json();
        return body.fields || {};
    }

}
interface Jugador {
  identificacion: string;
  nombre: string;
  apellidos: string;
  fechaNacimiento: Date;
  idEquipo: number;

}
