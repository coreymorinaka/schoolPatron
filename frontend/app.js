var app = angular.module("schoolPatronApp", ["ui.router"])

app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/");

})