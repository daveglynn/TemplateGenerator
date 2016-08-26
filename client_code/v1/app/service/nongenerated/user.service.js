    getUserEmail(email) {
        return this._http.get("/user/email/" + email)
           .map(res => res.json())
           .catch(error => Observable.throw(error.json()))
    }