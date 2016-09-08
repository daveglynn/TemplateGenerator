/******************************************************************************************************
 Get Item records by Object 
******************************************************************************************************/
    getItemsByObjectId = function (object, filter?) {

        var parms = {};
        if (filter && filter.view) {
            parms['view'] = filter.view;
        }

        const headers = new Headers({ 'Content-Type': 'application/json' });
            return this._http.get(this._url + "/" + object + "/all", { search: this._commonService.setParms(parms) })
                .map(res => res.json())
                .catch(error => Observable.throw(error.json()))
    }