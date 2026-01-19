import { Routes } from '@angular/router';
import { FormularioPersonaComponent } from './components/formulario-persona/formulario-persona';
import { TablaPersonas } from './components/tabla-personas/tabla-personas';

export const routes: Routes = [
    {path: '', component: TablaPersonas},
    {path: 'formulario', component: FormularioPersonaComponent}
];
