app.service("walmartService", function($http) {

    this.getProducts = function(query){
        return $http.get("http://localhost:5000/walmart?query=" + query);
    }
})