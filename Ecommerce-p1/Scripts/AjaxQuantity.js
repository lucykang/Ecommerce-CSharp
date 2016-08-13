
function increaseQuantity(id) {
    ajaxRequest("/Carts/IncreaseProductCount/" + id, function (res) {
        //$('#Quantity_' + id).text(res.Quantity);
        window.location.reload(false);
    });
}

function decreaseQuantity(id) {
    ajaxRequest("/Carts/DecreaseProductCount/" + id, function (res) {
        //$('#Quantity_' + id).text(res.Quantity);
        window.location.reload(false);
    });
}

function ajaxRequest(url, callback) {
    $.ajax({
        url: url,
        method: 'POST'
    }).done(callback);
}