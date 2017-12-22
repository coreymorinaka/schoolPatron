angular.module("schoolPatronApp").controller("walmartController", function ($scope, $http, $state, $stateParams, productService) {
    $scope.getProducts = function () {
        productService.getProducts($scope.query)
            .then(function (response) {
                console.log(response);
            }, function(error){
                console.log(error);
            })
    }
});