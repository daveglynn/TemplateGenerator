/******************************************************************************************************
 Get Item records by List 
******************************************************************************************************/
getListByIdItems(listId) {
    return this._http.get(this._url + "/list/" + listId +"/Items", { search: this._commonService.getTokenAsParm() })
        .map(res => res.json())
        .catch(error => Observable.throw(error.json()))
}	

/******************************************************************************************************
 Get Item records by Object 
******************************************************************************************************/
getListByObject = function (object, filter?) {

    var parms = {};
    if (filter && filter.view) {
        parms['view'] = filter.view;
    }

    const headers = new Headers({ 'Content-Type': 'application/json' });
    return this._http.get(this._url + "/" + object + "/dropdown", { search: this._commonService.setParms(parms) })
        .map(res => res.json())
        .catch(error => Observable.throw(error.json()))
}