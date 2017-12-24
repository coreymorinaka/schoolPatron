app.controller("projectController", function ($scope, $state, $stateParams, $http, projectService) {

    if ($stateParams.id == null || $stateParams.id == "" || $stateParams.id == undefined) {
        $scope.project = {
            id: 0,
            Name: "",
            StartDate: "",
            EndDate: "",
            Subject: "",
            GradeLevel: "",
            Description: "",
            GoalReached: false,
            TeacherId: null,
            SchoolId: null
        }

        $scope.heading = "Create a Project";
        $scope.submitButton = true;
    }
    else {
        projectService.getProjectById($stateParams.id)
            .then(function (response) {
                console.log(response.data);
                $scope.project = response.data;
                $scope.heading = "Update your Project!";
                $scope.submitButton = false;
                console.log($scope.project);
            }, function (error) {
                console.log(error);
            })
    }

    projectService.getProjects()
        .then(function (response) {
            console.log(response);
            $scope.projects = response.data
        }, function (error) {
            console.log(error);
        })

    $scope.addProject = function () {
        projectService.addProject($scope.project)
            .then(function (response) {
                console.log(response);
                $state.go("project", { id: response.data.id });
            }, function (error) {
                console.log(error);
            })
    }

    $scope.updateProject = function () {
        console.log($stateParams.id);
        console.log($scope.project);
        projectService.updateProject($scope.project.id, $scope.project)
            .then(function (response) {
                console.log(response);
                $state.go("project", { id: $stateParams.id })
            }, function (error) {
                console.log(error);
            })
    }
    $scope.deleteProject = function () {
        console.log("test");
        projectService.deleteProject($scope.project.id)
            .then(function (response) {
                console.log(response);
                $state.go("projects");
            }, function (error) {
                console.log(error);
            })
    }
})