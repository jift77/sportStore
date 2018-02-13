var ordersUrl = "/nonrest/orders";
var ordersListUrl = ordersUrl + "/list";
var ordersCreateUrl = ordersUrl + "/createorder/";
var ordersDeleteUrl = ordersUrl + "/deleteorder/";

var getOrders = function () {
    sendRequest(ordersListUrl, "GET", null).done((data) => {
        model.orders.removeAll();
        model.orders.push.apply(model.orders, data);
    });
}

var saveOrder = function (order, successCallback) {
    sendRequest(ordersCreateUrl, "POST", order).done(() => {
        if (successCallback) {
            successCallback();
        }
    });
}
var deleteOrder = function (id) {
    sendRequest(ordersDeleteUrl + id, "DELETE", null).done(() => {
        model.orders.remove(function (item) {
            return item.Id == id;
        })
    });
}