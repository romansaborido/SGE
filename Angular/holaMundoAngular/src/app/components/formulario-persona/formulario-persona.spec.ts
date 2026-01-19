import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormularioPersonaComponent } from './formulario-persona';


describe('FormularioPersona', () => {
  let component: FormularioPersonaComponent;
  let fixture: ComponentFixture<FormularioPersonaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormularioPersonaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormularioPersonaComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
