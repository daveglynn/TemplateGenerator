/******************************************************************************************************
 Get Item records by List 
******************************************************************************************************/
getListByIdItems(listId,parms?) {

    return this._http.get(this._url + "/item/list/" + listId +"/dropdown",  { search: this._commonService.setParms(parms) })
        .map(res => res.json())
        .catch(error => Observable.throw(error.json()))
}	

/******************************************************************************************************
 Get Item records by Object 
******************************************************************************************************/
getListByObject = function (object, parms?) {

    const headers = new Headers({ 'Content-Type': 'application/json' });
    return this._http.get(this._url + "/" + object + "/dropdown", { search: this._commonService.setParms(parms) })
        .map(res => res.json())
        .catch(error => Observable.throw(error.json()))
}