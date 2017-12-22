app.service("schoolService", function ($state, $http) {
    
    this.getSchools= function () {
        return $http.get("http://localhost:5000/school")
    }
    this.getSchoolById= function (id) {
        return $http.get("http://localhost:5000/school/" + id)
    }
    this.addSchool= function (school) {
        console.log(school);
        return $http.post("http://localhost:5000/school/", school)
    }
    this.updateSchool= function (id, school) {
        return $http.put("http://localhost:5000/school/" + id, school)
    }
    this.deleteSchool= function (id) {
        return $http.delete("http://localhost:5000/school/" + id)
    }
})