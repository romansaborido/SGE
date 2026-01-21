import { PersonaDTO } from "../dtos/PersonaDTO";
import { Persona } from "../entities/Persona";

export interface IPersonaUseCases {
    getPersonas(): Array<PersonaDTO>
    getPersona(id: number): PersonaDTO
    updatePersona(id: number, persona: Persona): number
	addPersona(persona: Persona): number
	deletePersona(id: number): number
}