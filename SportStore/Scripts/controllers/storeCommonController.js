const authenticateUrl = "/authenticate"

var authenticate = (successCallback) => {
    sendRequest(authenticateUrl, "POST", {
        grant_type: "password",
        username: model.username(),
        password: model.password()
    }, null)
    .done((data) => {
        model.authenticated(true);
        setAjaxHeaders({ Authorization: `bearer ${data.access_token}` });
        if (successCallback) successCallback();
        })
    .fail((e) => {
        console.log(e);
    })
} 