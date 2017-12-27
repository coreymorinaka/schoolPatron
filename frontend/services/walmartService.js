app.service("walmartService", function ($http) {

    this.getWalmartProducts = function (query) {
        
        if (query == "undefined") {
            return "Search undefined"
        } else {
            return $http.get("http://localhost:5000/walmart?query=" + query);
        }
        }
       
})