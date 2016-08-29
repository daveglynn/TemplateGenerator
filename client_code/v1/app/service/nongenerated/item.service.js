    getItemsByListId(listId,filter?) {
        var parms = {};
        if (filter && filter.view) {
            parms['view'] = filter.view;
        }
    
        const headers = new Headers({ 'Content-Type': 'application/json' });
        return this._http.get(this._url + "/item/list/" + listId, { search: this._commonService.setParms(parms) })

            .map(res => res.json())
            .catch(error => Observable.throw(error.json()))
    }