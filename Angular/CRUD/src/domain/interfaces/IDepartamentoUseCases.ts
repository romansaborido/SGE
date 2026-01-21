import { Departamento } from "../entities/Departamento"

export interface IDepartamentoUseCases {
    getDepartamentos(): Array<Departamento>
	getDepartamento(id: number): Departamento
	updateDepartamento(id: number, departamento: Departamento): number
	addDepartamento(departamento: Departamento): number
	deleteDepartamento(id: number): number
}
