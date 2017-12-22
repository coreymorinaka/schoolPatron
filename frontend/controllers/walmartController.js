app.controller("walmartController", function ($scope, $http, $state, $stateParams, walmartService) {
    
    $scope.getWalmartProducts = function () {
        walmartService.getWalmartProducts($scope.query)
            .then(function (response) {
                console.log(response);
            }, function(error){
                console.log(error);
            })
    }
});