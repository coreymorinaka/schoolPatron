app.controller("teacherController", function ($scope, $state, $stateParams, $http, teacherService) {

    if ($stateParams.id == null || $stateParams.id == "" || $stateParams.id == undefined) {
        $scope.teacher = {
            id: 0,
            FirstName: "",
            LastName: "",
            Bio: "",
            Email: "",
            GradeLevel: "",
            Password: "",
            SchoolId: null
        }

        $scope.heading = "Create your Teacher Profile";
        $scope.submitButton = true;
    } else {
        teacherService.getTeacherById($stateParams.id)
            .then(function (response) {
                console.log(response.data);
                $scope.teacher = response.data;
                $scope.teacherProjects = response.data.projects;
                $scope.heading = "Update your Profile!";
                $scope.submitButton = false;
                console.log($scope.teacher);
            }, function (error) {
                console.log(error);
            })
    }

    teacherService.getTeachers()
        .then(function (response) {
            console.log(response);
            $scope.teachers = response.data;
        }, function (error) {
            console.log(error);
        })

    $scope.addTeacher = function () {
        teacherService.addTeacher($scope.teacher)
            .then(function (response) {
                console.log(response);
                $state.go("teacher", { id: response.data.id });
            }, function (error) {
                console.log(error);
            })
    }

    $scope.updateTeacher = function () {
        console.log($stateParams.id);
        console.log($scope.teacher);
        teacherService.updateTeacher($scope.teacher.id, $scope.teacher)
            .then(function (response) {
                console.log(response);
                $state.go("teacher", { id: $stateParams.id })
            }, function (error) {
                console.log(error);
            })
    }

    $scope.deleteTeacher = function () {
        teacherService.deleteTeacher($scope.teacher.id)
            .then(function (response) {
                console.log(response);
                $state.go("teachers");
            }, function (error) {
                console.log(error);
            })
    }
})