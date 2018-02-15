var productUrl = "/api/products/";

var getProducts = () => {
    sendRequest(productUrl, "GET", null)
        .done((data) => {
            model.products.removeAll();
            model.products.push.apply(model.products, data);
        })
        .fail((e) => {
            console.log(e);
        })
};

var deleteProduct = (id) => {
    sendRequest(productUrl + id, "DELETE", null)
    .done(() => {
        model.products.remove(function (item) {
            return item.Id == id;
            })
        })
        .fail((e) => {
            console.log(e);
        })
}

var saveProduct = (product, successCallback) => {
    sendRequest(productUrl, "POST", product)
    .done(() => {
        getProducts();
        if (successCallback) {
            successCallback();
        }
    })
    .fail((e) => {
        console.log(e);
    })
}