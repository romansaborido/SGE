import { Persona } from "../entities/Persona"

export class PersonaDTO {

    private _persona: Persona
    private _nombreDepartamento: string

    constructor(persona: Persona, nombreDepartamento: string) {
        this._persona = persona
        this._nombreDepartamento = nombreDepartamento
    }

    public get persona(): Persona {
        return this._persona
    }

    public set persona(persona: Persona) {
        this._persona = persona
    }

    public get nombreDepartamento(): string {
        return this._nombreDepartamento
    }

    public set nombreDepartamento(nombreDepartamento: string) {
        this._nombreDepartamento = nombreDepartamento
    }
}