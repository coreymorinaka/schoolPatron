app.controller("patronController", function ($scope, $state, $stateParams, patronService) {

    if ($stateParams.id == null || $stateParams.id == "" || $stateParams.id == undefined) {
        $scope.patron = {
            Id: 0,
            FirstName: "",
            LastName: "",
            Email: "",
            Password: ""
        }
    }
    else {
        patronService.getPatronById($stateParams.id)
            .then(function (response) {
                console.log(response);
            }, function (error) {
                console.log(error);
            })
    }

    // $scope.patrons = [];
    // console.log($scope.patrons);

    $scope.getPatrons = function () {
        patronService.getPatrons()
            .then(function (response) {
                console.log(response);
                // for (var i = 0; i < response.data.length; i++) {
                //     $scope.patrons.push(response.data[i]);
                // }
            }, function (error) {
                console.log(error);
            })
    }
    $scope.getPatrons();

    $scope.addPatron = function () {
        patronService.addPatron($scope.patron)
            .then(function (response) {
                console.log(response);
            }, function (error) {
                console.log(error);
            })
    }

    $scope.updatePatron = function () {
        patronService.updatePatron($scope.patron.id, $scope.patron)
            .then(function (response) {
                console.log(response);
            }, function (error) {
                console.log(error);
            })
    }
    $scope.deletePatron = function () {
        patronService.deletePatron($scope.patron.id)
            .then(function (response) {
                console.log(response);
            }, function (error) {
                console.log(error);
            })
    }
})