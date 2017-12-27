app.controller("patronController", function ($scope, $state, $stateParams, $http, patronService) {

    if ($stateParams.id == null || $stateParams.id == "" || $stateParams.id == undefined) {
        $scope.patron = {
            id: 0,
            FirstName: "",
            LastName: "",
            Email: "",
            Password: ""
        }
        
        $scope.heading = "Create your Patron Profile";
        $scope.submitButton = true;
    }
    else {
        patronService.getPatronById($stateParams.id)
            .then(function (response) {
                console.log(response.data);
                $scope.patron = response.data;
                $scope.heading = "Update your Profile!";
                $scope.submitButton = false;
                
                console.log($scope.patron);
            }, function (error) {
                console.log(error);
            })
    }
        patronService.getPatrons()
            .then(function (response) {
                console.log(response);
                $scope.patrons = response.data
            }, function (error) {
                console.log(error);
            })

    $scope.addPatron = function () {
        patronService.addPatron($scope.patron)
            .then(function (response) {
                console.log(response);
                $state.go("patron", {id: response.data.id});
            }, function (error) {
                console.log(error);
            })
    }

    $scope.updatePatron = function () {
        console.log($stateParams.id);
        console.log($scope.patron);
        patronService.updatePatron($scope.patron.id, $scope.patron)
            .then(function (response) {
                console.log(response);
                $state.go("patron", {id: $stateParams.id});
            }, function (error) {
                console.log(error);
            })
    }
    $scope.deletePatron = function () {
        patronService.deletePatron($scope.patron.id)
            .then(function (response) {
                console.log(response);
                $state.go("patrons");
            }, function (error) {
                console.log(error);
            })
    }
})