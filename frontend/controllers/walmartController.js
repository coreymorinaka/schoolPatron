app.controller("walmartController", function ($scope, $http, $state, $stateParams, walmartService) {
    
    $scope.getWalmartProducts = function () {
        console.log("test");
        walmartService.getWalmartProducts($scope.query)
            .then(function (response) {
                console.log(response);
                $scope.items=response.data.items;
            }, function(error){
                console.log(error);
            })
    }
});