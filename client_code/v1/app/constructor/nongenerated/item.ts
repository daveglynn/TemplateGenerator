export class DropDownParent {
    constructor(public parentId: number, public name: string) { }
}
export class DropDownChild {
    constructor(public childId: number, public parentId: number, public name: string) { }
}