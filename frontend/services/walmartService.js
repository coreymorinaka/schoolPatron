app.service("walmartService", function($http) {

    this.getWalmartProducts = function(query){
        return $http.get("http://localhost:5000/walmart?query=" + query);
    }
})