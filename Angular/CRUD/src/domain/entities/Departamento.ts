export class Departamento {
    
    private _id: number
    private _nombre: string
    
    constructor(id: number, nombre: string) {
        this._id = id
        this._nombre = nombre
    }

    public get id(): number {
        return this._id
    }

    public set id(id: number) {
        this._id = id
    }

    public get nombre(): string {
        return this._nombre
    }

    public set nombre(nombre: string) {
        this._nombre = nombre
    }
}