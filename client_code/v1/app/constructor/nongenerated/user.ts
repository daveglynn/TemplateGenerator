export class Login {
    constructor(public email: string, public password: string) { }
}


import { DropDownItem } from "./../../master/items/item";

export class Search {
    constructor(public profile: DropDownItem, public language: DropDownItem, public q: string, public orderBy: DropDownItem, public orderDir: DropDownItem) { }
}

