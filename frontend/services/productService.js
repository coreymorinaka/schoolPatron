app.service("productService", function ($state, $http) {
    
    this.getProducts= function () {
        return $http.get("http://localhost:5000/product")
    }
    this.getProductById= function (id) {
        return $http.get("http://localhost:5000/product/" + id)
    }
    this.addProduct= function (product) {
        console.log(product);
        return $http.post("http://localhost:5000/product/", product)
    }
    this.updateProduct= function (id, product) {
        return $http.put("http://localhost:5000/product/" + id, product)
    }
    this.deleteProduct= function (id) {
        return $http.delete("http://localhost:5000/product/" + id)
    }
})