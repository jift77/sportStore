var sendRequest = function (url, verb, data, options) {
    return new Promise(function (resolve, reject) {
        var requestOptions = options || {};
        requestOptions.type = verb;
        requestOptions.success = resolve;
        requestOptions.error = reject;

        if (!url || !verb) {
            reject(401, "URL and HTTP verb required");
        }
        if (data) { requestOptions.data = data };
        $.ajax(url, requestOptions);
    });
}

var setDefaultCallbacks = new Promise((resolve, reject) => {
    $.ajaxSetup({
        complete: function (jqXHR, status) {
            if (jqXHR.status >= 200 && jqXHR.status < 300) {
                resolve(jqXHR.responseJSON);
            } else
                reject(jqXHR.status, jqXHR.statusText);
        }
    });
})

var setAjaxHeaders = function (requestHeaders) {
    $.ajaxSetup({ headers: requestHeaders });
}