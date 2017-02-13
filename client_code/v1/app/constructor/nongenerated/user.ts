export class Login {
    constructor(public email: string, public password: string) { }
}


import { DropDownItem } from "./../../master/items/item";

export class Search {
    constructor(public profileId: string, public languageId: string, public roleId: string, public q: string, public orderBy: string, public orderDir: string) { }
}

