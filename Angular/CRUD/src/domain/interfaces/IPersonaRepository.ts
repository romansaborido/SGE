import { Persona } from "../entities/Persona"
import { PersonaDTO } from "../dtos/PersonaDTO"

export interface IPersonaRepository {
    getPersonas(): Promise<Array<PersonaDTO>>
	getPersona(id: number): Promise<PersonaDTO>
	updatePersona(id: number, persona: Persona): Promise<number>
	addPersona(persona: Persona): Promise<number>
	deletePersona(id: number): Promise<number>
}