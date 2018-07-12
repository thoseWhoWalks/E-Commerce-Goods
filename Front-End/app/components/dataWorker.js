function sendGetRequest(data, target, callback) {
    $.ajax({
        type: "GET",
        url: target,
        headers: {
            'Content-Type': 'application/x-www-form-urlencoded'
        },
        xhrFields: {
            withCredentials: true
        },
        data: data,
        success: callback,
        error: function(e) {
            alert(`Error: status:${e.status}`);
        }
    });
}

function sendPostRequest(formData, target, callback) {
    $.ajax({
        type: "POST",
        url: target,
        headers: {
            'Content-Type': 'application/x-www-form-urlencoded'
        },
        xhrFields: {
            withCredentials: true
        },
        data: formData,
        success: callback,
        error: function(e) {
            alert(`Error: status:${e.status}`);
        },
        dataType: "json"
    });
}