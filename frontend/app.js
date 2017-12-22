var app = angular.module("schoolPatronApp", ["ui.router"])

app.config(function ($stateProvider, $urlRouterProvider) {
  $urlRouterProvider.otherwise("/");

  $stateProvider
    .state("home", {
      url: "/",
      templateUrl: "./views/homeView.html",
    })
  $stateProvider
    .state("patrons", {
      url: "/patrons",
      templateUrl: "./views/patronsView.html",
      controller: "patronController"
    })
  $stateProvider
    .state("patronCreate", {
      url: "/patron/new",
      templateUrl: "./views/patronFormView.html",
      controller: "patronController"
    })
  $stateProvider
    .state("patron", {
      url: "/patron/:id",
      templateUrl: "./views/patronProfileView.html",
      controller: "patronController"
    })
  $stateProvider
    .state("patronUpdate", {
      url: "/patron/:id/edit",
      templateUrl: "./views/patronFormView.html",
      controller: "patronController"
    })
})