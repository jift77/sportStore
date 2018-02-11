var productUrl = "/api/products/";
var getProducts = () => {
    sendRequest(productUrl, "GET", null)
    .then((data) => {
        model.products.removeAll();
        model.products.push.apply(model.products, data);
    })
};

var deleteProduct = (id) => {
    sendRequest(productUrl + id, "DELETE", null)
    .then(() => {
        model.products.remove(function (item) {
            return item.Id == id;
        })
    });
}

var saveProduct = (product, successCallback) => {
    sendRequest(productUrl, "POST", product)
    .then(() => {
        getProducts();
        if (successCallback) {
            successCallback();
        }
    });
}