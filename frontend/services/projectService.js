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
    this.addWalmartProductToProject = function (item) {
        console.log(item);
        return $http.post("http://localhost:5000/project/", item)
    }
})