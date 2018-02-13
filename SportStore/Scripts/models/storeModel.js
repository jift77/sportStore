var model = {
    products: ko.observableArray([]),
    orders: ko.observableArray([]),
    authenticated: ko.observable(false),
    username: ko.observable(null),
    password: ko.observable(null),
    error: ko.observable(""),
    gotError: ko.observable(false)
};

$(document).ready(function () {
    ko.applyBindings();
    setDefaultCallbacks((data) => {
            if (data) {
                console.log("---Begin success---");
                console.log(JSON.stringify(data));
                console.log("---End Success---");
            } else {
                console.log("Success (no data)");
            }
            model.gotError(false);
    }, (statusCode, statusText) => {
        console.log(`Error: ${statusCode} (${statusText})`);
        model.error(`${statusCode} (${statusText})`);
        model.gotError(true);
        })
});