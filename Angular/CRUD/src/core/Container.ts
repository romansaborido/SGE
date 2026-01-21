import { IPersonaRepository } from "../domain/interfaces/IPersonaRepository";
import { PersonaRepository } from "../data/repositories/PersonaRepository";
import { TYPES } from "./Types";

export const container = new Container()

container.bind<IPersonaRepository>(TYPES.IPersonaRepository).to(PersonaRepository)