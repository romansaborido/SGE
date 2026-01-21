import { Departamento } from "../entities/Departamento"

export interface IDepartamentoRepository {
    getDepartamentos(): Promise<Array<Departamento>>
	getDepartamento(id: number): Promise<Departamento>
	updateDepartamento(id: number, departamento: Departamento): Promise<number>
	addDepartamento(departamento: Departamento): Promise<number>
	deleteDepartamento(id: number): Promise<number>
}
