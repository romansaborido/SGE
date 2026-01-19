import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators, ReactiveFormsModule } from '@angular/forms';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-formulario-persona',
  standalone: true,
  imports: [NgIf, ReactiveFormsModule],
  templateUrl: './formulario-persona.html',
  styleUrls: ['./formulario-persona.css']
})
export class FormularioPersonaComponent {
  personaForm = new FormGroup({
    nombre: new FormControl('', [Validators.required, Validators.minLength(2)]),
    apellidos: new FormControl('', [Validators.required, Validators.minLength(2)]),
  });

  saludar() {
    if (this.personaForm.valid) {
      alert(`Hola ${this.personaForm.value.nombre}`);
    } else {
      alert('Por favor completa todos los campos correctamente');
      this.personaForm.markAllAsTouched();
    }
  }
}
