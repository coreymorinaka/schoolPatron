var app = angular.module("schoolPatronApp", ["ui.router", "jcs-autoValidate"])

app.config(function ($stateProvider, $urlRouterProvider) {
  $urlRouterProvider.otherwise("/");

  $stateProvider
    .state("home", {
      url: "/",
      templateUrl: "./views/homeView.html",
    })

    // PATRONS 
    .state("patrons", {
      url: "/patrons",
      templateUrl: "./views/patronsView.html",
      controller: "patronController"
    })
  
    .state("patronCreate", {
      url: "/patron/new",
      templateUrl: "./views/patronFormView.html",
      controller: "patronController"
    })
    .state("patron", {
      url: "/patron/:id",
      templateUrl: "./views/patronProfileView.html",
      controller: "patronController"
    })
    .state("patronUpdate", {
      url: "/patron/:id/edit",
      templateUrl: "./views/patronFormView.html",
      controller: "patronController"
    })

    // TEACHER 
    .state("teachers", {
      url: "/teachers",
      templateUrl: "./views/teachersView.html",
      controller: "teacherController"
    })
  
    .state("teacherCreate", {
      url: "/teacher/new",
      templateUrl: "./views/teacherFormView.html",
      controller: "teacherController"
    })
  
    .state("teacher", {
      url: "/teacher/:id",
      templateUrl: "./views/teacherProfileView.html",
      controller: "teacherController"
    })
  
    .state("teacherUpdate", {
      url: "/teacher/:id/edit",
      templateUrl: "./views/teacherFormView.html",
      controller: "teacherController"
    })

  //PROJECT
    .state("projects", {
      url: "/projects",
      templateUrl: "./views/projectListView.html",
      controller: "projectController"
    })
    .state("projectCreate", {
      url: "/project/new",
      templateUrl: "./views/projectFormView.html",
      controller: "projectController"
    })
    .state("project", {
      url: "/project/:id",
      templateUrl: "./views/projectView.html",
      controller: "projectController"
    })
    .state("projectUpdate", {
      url: "/project/:id/edit",
      templateUrl: "./views/projectFormView.html",
      controller: "projectController"
    })

  // .state("teacherProject", {
  //   url: "/teacher/:id/project/new", 
  //   templateUrl: "./views/projectFormView.html", 
  //   controller: "projectController", 
  // })

})