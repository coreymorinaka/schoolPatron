var app = angular.module("schoolPatronApp", ["ui.router"])

app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/");

    $stateProvider
    .state("home", {
      url: "/",
      templateUrl: "./views/productsView.html",
      controller: "productController"
    })
})