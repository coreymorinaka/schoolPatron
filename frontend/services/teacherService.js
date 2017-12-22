app.service("teacherService", function ($state, $http) {
    
    this.getTeachers= function () {
        return $http.get("http://localhost:5000/teacher")
    }
    this.getTeacherById= function (id) {
        return $http.get("http://localhost:5000/teacher/" + id)
    }
    this.addTeacher= function (teacher) {
        console.log(teacher);
        return $http.post("http://localhost:5000/teacher/", teacher)
    }
    this.updateTeacher= function (id, teacher) {
        return $http.put("http://localhost:5000/teacher/" + id, teacher)
    }
    this.deleteTeacher= function (id) {
        return $http.delete("http://localhost:5000/teacher/" + id)
    }
})