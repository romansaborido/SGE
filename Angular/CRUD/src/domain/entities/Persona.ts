export class Persona {

    private _id: number
	private _nombre: string
	private _apellidos: string
	private _telefono: string
	private _direccion: string
	private _foto: string
	private _fechaNacimiento: Date
	private _idDepartamento: number

    constructor(id:number, nombre: string, apellidos: string, telefono: string, direccion: string, foto: string, fechaNacimiento: Date, idDepartamento: number) {
        this._id = id
        this._nombre = nombre
        this._apellidos = apellidos
        this._telefono = telefono
        this._direccion = direccion
        this._foto = foto
        this._fechaNacimiento = fechaNacimiento
        this._idDepartamento = idDepartamento
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

    public get apellidos(): string {
        return this._apellidos
    }

    public set apellidos(apellidos: string) {
        this._apellidos = apellidos
    }

    public get telefono(): string {
        return this._telefono
    }

    public set telefono(telefono: string) {
        this._telefono = telefono
    }

    public get direccion(): string {
        return this._direccion
    }

    public set direccion(direccion: string) {
        this._direccion = direccion
    }

    public get foto(): string {
        return this._foto
    }

    public set foto(foto: string) {
        this._foto = foto
    }

    public get fechaNacimiento(): Date {
        return this._fechaNacimiento
    }

    public set fechaNacimiento(fechaNacimiento: Date) {
        this._fechaNacimiento = fechaNacimiento
    }

    public get idDepartamento(): number {
        return this._idDepartamento
    }

    public set idDepartamento(idDepartamento: number) {
        this._idDepartamento = idDepartamento
    }
}