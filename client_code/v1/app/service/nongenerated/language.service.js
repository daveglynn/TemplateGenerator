﻿/******************************************************************************************************
 Get Languages for Dropdown 
******************************************************************************************************/
getListByObject() {
    return this._http.get(this._url + "/language" +"/dropdown", { search: this._commonService.getTokenAsParm() })
        .map(res => res.json())
        .catch(error => Observable.throw(error.json()))
}	