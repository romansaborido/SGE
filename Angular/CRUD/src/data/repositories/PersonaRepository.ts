import { TYPES } from "../../core/Types";
import { PersonaDTO } from "../../domain/dtos/PersonaDTO";
import { Persona } from "../../domain/entities/Persona";
import { IPersonaRepository } from "../../domain/interfaces/IPersonaRepository";
import { BaseAPI } from "../connection/BaseAPI";

export class PersonaRepository implements IPersonaRepository {

    private _api: BaseAPI

    constructor(@inject(TYPES.BaseAPI) api: BaseAPI) {
        this._api = api
    }

    async getPersonas(): Promise<Array<PersonaDTO>> {
        const url = this._api.getUrl("personas")
        try {

            // Realizamos la peticion
            const response = await fetch(url, {method: "GET", headers: this._api.getDefaultHeaders()})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: Array<PersonaDTO> = await response.json()

            // Devolvemos los datos
            return data

        } catch (error) {
            let errorMessage = "Fallo al conectar con la API"
            if (error instanceof Error) {
                errorMessage = error.message
            }
            console.error("Error al obtener las peronas:" + error)
            throw new Error(errorMessage)
        }
    }

    async getPersona(id: number): Promise<PersonaDTO> {
        const url = this._api.getUrl("personas/" + id)
        try {
            // Realizamos la peticion
            const response = await fetch(url, {method: "GET", headers: this._api.getDefaultHeaders()})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: PersonaDTO = await response.json()

            // Devolvemos los datos
            return data

        } catch (error) {
            let errorMessage = "Error al conectar con la API"
            if (error instanceof Error) {
                errorMessage = error.message
            }
            console.error("Error al obtener la persona:" + error)
            throw new Error(errorMessage)
        }
    }

    async updatePersona(id: number, persona: Persona): Promise<number> {
        const url = this._api.getUrl("personas/" + id)
        try {
            const response = await fetch(url, {method: "PUT", headers: this._api.getDefaultHeaders(), body: JSON.stringify(persona)})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: number = await response.json()

            // Devolvemos los datos
            return data
        
        } catch (error) {
            let errorMessage = "Error al conectar con la API"
            if (error instanceof Error) {
                errorMessage = error.message
            }
            console.error("Error al actualizar la persona:" + error)
            throw new Error(errorMessage)
        }
    }

    async addPersona(persona: Persona): Promise<number> {
        const url = this._api.getUrl("personas")
        try {
            // Hacemos la peticion a la API
            const response = await fetch(url, {method: "POST", headers: this._api.getDefaultHeaders(), body: JSON.stringify(persona)})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: number = await response.json()

            // Devolvemos los datos
            return data
        } 
        catch (error) {
            let errorMessage = "Error al conectar con la API"
            if (error instanceof Error) { errorMessage = error.message }
            console.error("Error al añadir la persona")
            throw new Error(errorMessage)
        }
    }

    async deletePersona(id: number): Promise<number> {
        const url = this._api.getUrl("personas/" + id)
        try {
            // Hacemos la peticion a la API
            const response = await fetch(url, {method: "DELETE", headers: this._api.getDefaultHeaders()})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: number = await response.json()

            // Devolvemos los datos
            return data
        } 
        catch (error) {
            let errorMessage = "Error al eliminar la persona"
            if (error instanceof Error) { errorMessage = error.message }
            console.error("Error al eliminar la persona")
            throw new Error(errorMessage)
        }
    }
}