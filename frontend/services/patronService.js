app.service("patronService", function ($http) {
    
    this.getPatrons= function () {
        return $http.get("http://localhost:5000/patron")
    }
    this.getPatronById= function (id) {
        return $http.get("http://localhost:5000/patron/" + id)
    }
    this.addPatron= function (patron) {
        console.log(patron);
        return $http.post("http://localhost:5000/patron/", patron)
    }
    this.updatePatron= function (id, patron) {
        return $http.put("http://localhost:5000/patron/" + id, patron)
    }
    this.deletePatron= function (id) {
        return $http.delete("http://localhost:5000/patron/" + id)
    }
})