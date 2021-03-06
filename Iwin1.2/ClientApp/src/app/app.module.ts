import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { RegistrarJugadorComponent } from './registrar-jugador/registrar-jugador.component';
import { EliminarJugadorComponent } from './eliminar-jugador/eliminar-jugador.component';
import { ListarJugadorComponent } from './listar-jugador/listar-jugador.component';
import { ModificarJugadorComponent } from './modificar-jugador/modificar-jugador.component';
import { GestionarJugadorComponent } from './gestionar-jugador/gestionar-jugador.component';
import { GestionarJuegoComponent } from './gestionar-juego/gestionar-juego.component';
import { ActualizarJuegoComponent } from './actualizar-juego/actualizar-juego.component';
import { jugadorservice } from './Service/jugadorservice';
import { HttpModule } from '@angular/http';
import { GestionarEquipoComponent } from './gestionar-equipo/gestionar-equipo.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    RegistrarJugadorComponent,
    EliminarJugadorComponent,
    ListarJugadorComponent,
    ModificarJugadorComponent,
    GestionarJugadorComponent,
    GestionarJuegoComponent,
    ActualizarJuegoComponent,
    RegistrarJugadorComponent,
    EliminarJugadorComponent,
    ListarJugadorComponent,
    GestionarJugadorComponent,
    GestionarEquipoComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule, HttpModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },

      { path: 'gestionarJuego', component: GestionarJuegoComponent },

      { path: 'actualizarJuego', component: ActualizarJuegoComponent },
      { path: 'registrarJugador', component: RegistrarJugadorComponent },

      { path: 'eliminarJugador', component: EliminarJugadorComponent },


      { path: 'listarJugador', component: ListarJugadorComponent },


      { path: 'gestionarJugador', component: GestionarJugadorComponent },


      { path: 'listarJugador/:idEquipo', component: ListarJugadorComponent },

      { path: 'modificarJugador/:idEquipo', component: ModificarJugadorComponent },

      { path: 'gestionarEquipo', component: GestionarEquipoComponent },






      { path: 'eliminarJugador/:idEquipo', component: EliminarJugadorComponent },



      { path: 'registrarJugador/:idEquipo', component: RegistrarJugadorComponent },



      { path: 'gestionarJugador/:idEquipo', component: GestionarJugadorComponent },






    ])
  ],
  providers: [jugadorservice],
  bootstrap: [AppComponent],
})
export class AppModule { }
