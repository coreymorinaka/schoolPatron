app.controller("projectController", function ($scope, $state, $stateParams, projectService, walmartService) {

    if ($stateParams.id == null || $stateParams.id == "" || $stateParams.id == undefined) {
        $scope.project = {
            Id: 0,
            Name: "",
            StartDate: "",
            EndDate: "",
            Subject: "",
            GradeLevel: "",
            Description: "",
            GoalReached: false,
            TeacherId: null,
            SchoolId: null,
            // walmartProducts = null
        }

        $scope.heading = "Create a Project";
        $scope.submitButton = true;
        $scope.goal = false;
    }
    else {
        projectService.getProjectById($stateParams.id)
            .then(function (response) {
                console.log(response.data);
                $scope.project = response.data;
                $scope.walmartItems = response.data.walmartProducts;
                $scope.heading = "Update your Project!";
                $scope.submitButton = false;
                $scope.goal = true;
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
        projectService.updateProject($stateParams.id, $scope.project)
            .then(function (response) {
                console.log(response);
                $state.go("project", { id: $stateParams.id })
            }, function (error) {
                console.log(error);
            })
    }
    $scope.deleteProject = function () {
        console.log("test");
        projectService.deleteProject($stateParams.id)
            .then(function (response) {
                console.log(response);
                $state.go("projects");
            }, function (error) {
                console.log(error);
            })
    }
    //Search for Walmart Products
    $scope.getWalmartProducts = function () {
        walmartService.getWalmartProducts($scope.query)
            .then(function (response) {
                console.log(response);
                $scope.items = response.data.items;
                console.log($scope.items);
            }, function (error) {
                console.log(error);
            })
    }
    //Posting Walmart Products to db
    $scope.projectProducts = [];
    $scope.productsAdded = 0;
    $scope.addWalmartProductToProject = function (item) {
        item.projectId = $stateParams.id;
        projectService.addWalmartProductToProject(item)
            .then(function (response) {
                $scope.productsAdded++;
                $scope.projectProducts.push(response.data);
            },
            function (error) {
                console.log(error)
            })
    }
    //Getting Walmart Products from db
    $scope.getProductsFromProjects = function () {
        projectService.getProductsFromProjects()
            .then(function (response) {
                console.log(response);
            }, function (error) {
                console.log(error);
            })
    }
    $scope.deleteItem = function (id){
        console.log("test");
        projectService.deleteItem(id)
            .then(function (response) {
                $scope.productsAdded--;
                console.log(response);
                $state.go("project", { id: $stateParams.id })
            }, function (error) {
                console.log(error);
            })
    }
    $scope.patronBuy = function(url){
        window.open(url, "_blank");
    }
})