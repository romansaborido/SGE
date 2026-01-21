import { TYPES } from "../../core/Types";
import { Departamento } from "../../domain/entities/Departamento";
import { IDepartamentoRepository } from "../../domain/interfaces/IDepartamentoRepository";
import { BaseAPI } from "../connection/BaseAPI";

export class DepartamentoRepository implements IDepartamentoRepository {

    private _api: BaseAPI

    constructor(@inject(TYPES.BaseAPI) api: BaseAPI) {
        this._api = api
    }

    async getDepartamentos(): Promise<Array<Departamento>> {
        const url = this._api.getUrl("departamentos")
        try {
            // Realizamos la peticion a la API
            const response = await fetch(url, {method: "GET", headers: this._api.getDefaultHeaders()})

            // Manejo de errores
            if (!response.ok) { throw new Error("Fallo al conectar con la API") }

            // Extraccion de datos
            const data: Array<Departamento> = await response.json()

            // Devolvemos los datos
            return data
        }
        catch (error) {
            let errorMessage = "Fallo al conectar con la API"
            if (error instanceof Error) { throw new Error("Error al obtener los departamentos") }
            console.error("Error al obtener los departamentos")
            throw new Error(errorMessage)
        }
    }
    
    async getDepartamento(id: number): Promise<Departamento> {
        const url = this._api.getUrl("departamentos/" + id)
        try {
            const response = await fetch(url, {method: "GET", headers: this._api.getDefaultHeaders()})

            if (!response.ok) { throw new Error("Error al obtener el departamento") }

            const data: Departamento = await response.json()

            return data
        }
        catch (error) {
            let errorMessage = "Fallo al conectar con la API"
            if (error instanceof Error) { throw new Error("Error al obtener el departamento con ID " + id) }
            console.error("Error al obtener el departamento con ID" + id)
            throw new Error(errorMessage)
        }
    }

    async updateDepartamento(id: number, departamento: Departamento): Promise<number> {
        const url = this._api.getUrl("departamentos/" + id)
        try {
            const response = await 
        }
    }
    addDepartamento(departamento: Departamento): Promise<number> {
        throw new Error("Method not implemented.");
    }
    deleteDepartamento(id: number): Promise<number> {
        throw new Error("Method not implemented.");
    }
}