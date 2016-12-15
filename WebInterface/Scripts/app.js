

var API_SERVICE_ENDPOINT = 'http://localhost:23543';
var INTERVAL_TIME = 5000;

// On Document Ready
$(document).ready(function () {
    getAllNews();

    setInterval(function () {
        getAllNews();
    }, INTERVAL_TIME);
});

// Get All News
var getAllNews = function () {
    var url = API_SERVICE_ENDPOINT + '/api/news';

    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'json',
        success: function (response, status) {
            if (status == 'success') {
                $('#news-list').empty();

                // $('#id-footer').text(response);

                response.forEach(function (item, index) {
                    $('#news-tmpl').tmpl(item).appendTo('#news-list');
                });
            }
        },
        error: function (response, status) {

        }
    });
}