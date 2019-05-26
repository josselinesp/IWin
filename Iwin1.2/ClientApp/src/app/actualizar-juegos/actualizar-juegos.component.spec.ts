import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarJuegosComponent } from './actualizar-juegos.component';

describe('ActualizarJuegosComponent', () => {
  let component: ActualizarJuegosComponent;
  let fixture: ComponentFixture<ActualizarJuegosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActualizarJuegosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActualizarJuegosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
