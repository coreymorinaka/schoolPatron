app.service("projectService", function ($state, $http) {
    
    this.getProjects= function () {
        return $http.get("http://localhost:5000/project")
    }
    this.getProjectById= function (id) {
        return $http.get("http://localhost:5000/project/" + id)
    }
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

    //Post and Get Walmart Products to/from Projects
    this.addWalmartProductToProject = function (item) {
        console.log("success");
        return $http.post("http://localhost:5000/project/walmart", item)
    }
    this.getProductsFromProjects= function () {
        return $http.get("http://localhost:5000/project/walmart")
    }
    this.getProductFromProjectById= function (id) {
        return $http.get("http://localhost:5000/project/walmart" + id)
    }
})