app.service("projectService", function ($state, $http) {
    
    this.getProjects= function () {
        return $http.get("http://localhost:5000/project")
    }
    this.getWalmartProducts= function () {
        return $http.get("http://localhost:5000/project/walmart")
    }
    //Add functions in controller
    this.getProjectById= function (id) {
        return $http.get("http://localhost:5000/project/" + id)
    }
    this.getWalmartProductsById= function (id) {
        return $http.get("http://localhost:5000/project/" + id)
    }
    //Add functions in controller
    this.addProject= function (project) {
        console.log(project);
        return $http.post("http://localhost:5000/project/", project)
    }
    this.updateProject= function (id, project) {
        return $http.put("http://localhost:5000/project/" + id, project)
    }
    this.deleteProject= function (id) {
        return $http.delete("http://localhost:5000/project/" + id)
    }
    this.addWalmartProductToProject = function (item) {
        console.log("success");
        return $http.post("http://localhost:5000/project/walmart", item)
    }
})