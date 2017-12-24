var app = angular.module("schoolPatronApp", ["ui.router"])

app.config(function ($stateProvider, $urlRouterProvider) {
  $urlRouterProvider.otherwise("/");

  $stateProvider
    .state("home", {
      url: "/",
      templateUrl: "./views/homeView.html",
    })

    // PATRONS 

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

    // TEACHER 

  $stateProvider
    .state("teachers", {
      url: "/teachers",
      templateUrl: "./views/teachersView.html",
      controller: "teacherController"
    })
  $stateProvider
    .state("teacherCreate", {
      url: "/teacher/new",
      templateUrl: "./views/teacherFormView.html",
      controller: "teacherController"
    })
  $stateProvider
    .state("teacher", {
      url: "/teacher/:id",
      templateUrl: "./views/teacherProfileView.html",
      controller: "teacherController"
    })
  $stateProvider
    .state("teacherUpdate", {
      url: "/teacher/:id/edit",
      templateUrl: "./views/teacherFormView.html",
      controller: "teacherController"
    })

  //PROJECT

  $stateProvider
    .state("projects", {
      url: "/projects",
      templateUrl: "./views/projectListView.html",
      controller: "projectController"
    })
  $stateProvider
    .state("projectCreate", {
      url: "/project/new",
      templateUrl: "./views/projectFormView.html",
      controller: "projectController"
    })
  $stateProvider
    .state("project", {
      url: "/project/:id",
      templateUrl: "./views/projectView.html",
      controller: "projectController"
    })
  $stateProvider
    .state("projectUpdate", {
      url: "/project/:id/edit",
      templateUrl: "./views/projectFormView.html",
      controller: "projectController"
    })
    
  $stateProvider
  .state("teacherProject", {
    url: "/teacher/:id/project/new", 
    templateUrl: "./views/projectFormView.html", 
    controller: "projectController", 
  })

})