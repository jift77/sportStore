var sendRequest = function (url, verb, data, options) {
    var requestOptions = options || {};
    requestOptions.type = verb;
    if (data) { requestOptions.data = data };

    return $.ajax(url, requestOptions);
}

var setDefaultCallbacks = (successCallback, errorCallback) => {
    $.ajaxSetup({
        complete: function (jqXHR, status) {
            if (jqXHR.status >= 200 && jqXHR.status < 300) {
                successCallback(jqXHR.responseJSON);
            } else
                errorCallback(jqXHR.status, jqXHR.statusText );    
        }
    });
}

var setAjaxHeaders = function (requestHeaders) {
    $.ajaxSetup({ headers: requestHeaders });
}